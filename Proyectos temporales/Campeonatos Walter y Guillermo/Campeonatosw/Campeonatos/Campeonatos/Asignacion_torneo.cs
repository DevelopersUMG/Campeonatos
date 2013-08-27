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
        public Asignacion_torneo(String po)
        {

        }

        int torneo;
        DBConnect db = new DBConnect(Properties.Settings.Default.ruta);

        private void consultar_todos()
        {
            ArrayList array = db.consultar("select idequipo,nombre from equipo where idcampeonato = 0");            
            tblequiposizq.RowCount = array.Count;
            tblequiposizq.ColumnCount = 2;
            int r = 0;
            foreach (Dictionary<string, string> d in array)
            {
                tblequiposizq.Rows[r].Cells[0].Value = d["idequipo"];
                tblequiposizq.Rows[r].Cells[1].Value = d["nombre"];
                r++;
            }
            tblequiposizq.Columns[0].Visible = false;

            tblequiposizq.CurrentCell = tblequiposizq[1, 0];
           
        }

        private void consultar_campeonato()
        {
            System.Collections.ArrayList array = db.consultar("select idequipo,nombre from equipo where idcampeonato = " + torneo);
            tblequiposder.RowCount = array.Count;
            tblequiposder.ColumnCount = 2;
            int r = 0;
            foreach (Dictionary<string, string> d in array)
            {
                tblequiposder.Rows[r].Cells[0].Value = d["idequipo"];
                tblequiposder.Rows[r].Cells[1].Value = d["nombre"];
                r++;
            }
            tblequiposder.Columns[0].Visible = false;

            lbltotal.Text += " " + tblequiposder.RowCount;
        }

        private void Asignacion_torneo_Load(object sender, EventArgs e)
        {
            System.Collections.ArrayList array = db.consultar("select nombre from campeonato where idcampeonato = "+torneo);
            foreach(Dictionary<string,string> dict in array){
                lbltorneo.Text += " "+ dict["nombre"];
            }
            consultar_todos();
            consultar_campeonato();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tblequiposizq.RowCount > 0)
            {
                if (tblequiposizq.CurrentCell.RowIndex >= 0)
                {
                    int row = tblequiposizq.CurrentCell.RowIndex;
                    int r = tblequiposder.RowCount;
                    tblequiposder.RowCount += 1;
                    tblequiposder.Rows[r].Cells[0].Value = tblequiposizq.Rows[row].Cells[0].Value;
                    tblequiposder.Rows[r].Cells[1].Value = tblequiposizq.Rows[row].Cells[1].Value;
                    tblequiposizq.Rows.Remove(tblequiposizq.Rows[row]);
                }
            }
            lbltotal.Text = "Total: " + tblequiposder.RowCount;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tblequiposder.RowCount > 0)
            {
                if (tblequiposder.CurrentCell.RowIndex >= 0)
                {
                    int row = tblequiposder.CurrentCell.RowIndex;
                    int r = tblequiposizq.RowCount;
                    tblequiposizq.RowCount += 1;
                    tblequiposizq.Rows[r].Cells[0].Value = tblequiposder.Rows[row].Cells[0].Value;
                    tblequiposizq.Rows[r].Cells[1].Value = tblequiposder.Rows[row].Cells[1].Value;
                    tblequiposder.Rows.Remove(tblequiposder.Rows[row]);
                }
            }
            lbltotal.Text = "Total: " + tblequiposder.RowCount;
            
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
            for (int i = 0; i < tblequiposder.RowCount; i++)
            {
                string condicion = "idequipo="+tblequiposder.Rows[i].Cells[0].Value;
                db.actualizar(tabla, d, condicion);
                
            }

           
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
