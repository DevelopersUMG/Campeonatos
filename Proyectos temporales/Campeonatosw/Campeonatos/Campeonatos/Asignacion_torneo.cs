using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SQLiteConnect;
using System.Collections;
namespace Campeonatos
{
    public partial class Asignacion_torneo : Form
    {
        public Asignacion_torneo(int t)
        {
            InitializeComponent();
            torneo = t;
        }

        int torneo;
        DBConnect db = new DBConnect(Properties.Settings.Default.ruta);

        private void consultar_todos()
        {
            ArrayList array = db.consultar("select idequipo,nombre from equipo where idcampeonato = 0");
            
            dataGridView1.RowCount = array.Count;
            dataGridView1.ColumnCount = 2;
            int r = 0;
            foreach (Dictionary<string, string> d in array)
            {
                dataGridView1.Rows[r].Cells[0].Value = d["idequipo"];
                dataGridView1.Rows[r].Cells[1].Value = d["nombre"];
                r++;
            }
            dataGridView1.Columns[0].Visible = false;

            dataGridView1.CurrentCell = dataGridView1[1, 0];
           
        }

        private void consultar_campeonato()
        {
            System.Collections.ArrayList array = db.consultar("select idequipo,nombre from equipo where idcampeonato = " + torneo);
            dataGridView2.RowCount = array.Count;
            dataGridView2.ColumnCount = 2;
            int r = 0;
            foreach (Dictionary<string, string> d in array)
            {
                dataGridView2.Rows[r].Cells[0].Value = d["idequipo"];
                dataGridView2.Rows[r].Cells[1].Value = d["nombre"];
                r++;
            }
            dataGridView2.Columns[0].Visible = false;

            label4.Text += " " + dataGridView2.RowCount;
        }

        private void Asignacion_torneo_Load(object sender, EventArgs e)
        {
            System.Collections.ArrayList array = db.consultar("select nombre from campeonato where idcampeonato = "+torneo);
            foreach(Dictionary<string,string> dict in array){
                label1.Text += " "+ dict["nombre"];
            }
            consultar_todos();
            consultar_campeonato();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                if (dataGridView1.CurrentCell.RowIndex >= 0)
                {
                    int row = dataGridView1.CurrentCell.RowIndex;
                    int r = dataGridView2.RowCount;
                    dataGridView2.RowCount += 1;
                    dataGridView2.Rows[r].Cells[0].Value = dataGridView1.Rows[row].Cells[0].Value;
                    dataGridView2.Rows[r].Cells[1].Value = dataGridView1.Rows[row].Cells[1].Value;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[row]);
                }
            }
            label4.Text = "Total: " + dataGridView2.RowCount;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
            {
                if (dataGridView2.CurrentCell.RowIndex >= 0)
                {
                    int row = dataGridView2.CurrentCell.RowIndex;
                    int r = dataGridView1.RowCount;
                    dataGridView1.RowCount += 1;
                    dataGridView1.Rows[r].Cells[0].Value = dataGridView2.Rows[row].Cells[0].Value;
                    dataGridView1.Rows[r].Cells[1].Value = dataGridView2.Rows[row].Cells[1].Value;
                    dataGridView2.Rows.Remove(dataGridView2.Rows[row]);
                }
            }
            label4.Text = "Total: " + dataGridView2.RowCount;
            
            //se agregará el codigo para cambiar el dataGridView1

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Equipos().ShowDialog();
            consultar_todos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tabla = "equipo";
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("idcampeonato", torneo.ToString());
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                string condicion = "idequipo="+dataGridView2.Rows[i].Cells[0].Value;
                db.actualizar(tabla, d, condicion);
                
            }

           
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
