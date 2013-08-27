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
    public partial class Torneos : Form
    {
        public Torneos()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect(Properties.Settings.Default.ruta);
        bool modi = false;
        int row = -1;

        public void consultar()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = db.consultarGrid("select nombre,fecha_inicio,fecha_final from campeonato").DataSource;

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Editar";
            col.Name = "Edición";
            dataGridView1.Columns.Add(col);

            col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Eliminar";
            col.Name = "Eliminación";
            dataGridView1.Columns.Add(col);

            col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Ver equpipos";
            col.Name = "Equipos";
            dataGridView1.Columns.Add(col);

            panel1.Visible = false;
        }

        private void Torneos_Load(object sender, EventArgs e)
        {
            consultar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tabla;
            Dictionary<string, string> dict;
            datos(out tabla, out dict);
            if (!modi)
            {               
                db.insertar(tabla, dict);                
            }
            else
            {
                db.actualizar(tabla, dict, "nombre='" + dataGridView1[0, dataGridView1.CurrentRow.Index].Value+"'");
            }
            modi = false;
            textBox1.Text = "";
            consultar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex + 1;
            if (e.ColumnIndex==3)
            {
                string query = "select nombre,fecha_inicio,fecha_final from campeonato where nombre = '" + dataGridView1[0, dataGridView1.CurrentRow.Index].Value+"'";
                ArrayList array = db.consultar(query);
                foreach (Dictionary<string,string> v in array)
                {
                    textBox1.Text = v["nombre"];
                    //dateTimePicker1.Value = DateTime.Parse(v["fecha_inicio"], "'dd'|'MM'|'yyyy'",System.Globalization.DateTimeStyles styles);
                    //dateTimePicker2.Value = v["fecha_final"];
                    modi = true;
                }
                panel1.Visible = true;
               
            }
            else if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("¿Estás seguro de eliminar este registro?", "Eliminar registro",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = 0;
                    String ob = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                    string query = "select * from campeonato where nombre='" + ob+"'";
                    ArrayList array = db.consultar(query);
                    foreach (Dictionary<string, string> dict in array)
                    {
                        id= Convert.ToInt32(dict["idcampeonato"]);
                    }
                    db.eliminar("campeonato", "idcampeonato=" + id);
  
                    MessageBox.Show("Registro eliminado","Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    consultar();
                }
            }
            else if (e.ColumnIndex == 5)
            {
                
                new Asignacion_torneo(row).ShowDialog();
            }
        }

        private void datos(out string tabla, out Dictionary<string,string> dict)
        {
            tabla = "campeonato";
            dict = new Dictionary<string, string>();
            dict.Add("nombre", textBox1.Text);
            dict.Add("fecha_inicio", dateTimePicker1.Value.ToString());
            dict.Add("fecha_final", dateTimePicker2.Value.ToString());
        }
    }
}
