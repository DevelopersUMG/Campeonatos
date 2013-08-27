using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SQLiteConnect;

namespace Campeonatos
{
    public partial class Equipos : Form
    {
        public Equipos()
        {
            InitializeComponent();
        }

        bool modi = false;
        DBConnect db = new DBConnect(Properties.Settings.Default.ruta);
        int row = -1;

        public void consultar()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = db.consultarGrid("select idequipo,nombre,encargado,telefono,idcampeonato from equipo").DataSource;

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

            dataGridView1.Columns[0].Visible = false;

            panel1.Visible = false;
            limpiar();
        }

        public void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Equipos_Load(object sender, EventArgs e)
        {
            consultar();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBox1.Focus();
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
                db.actualizar(tabla, dict, "idequipo="+row);
            }
            consultar();
        }

        private void datos(out string tabla, out Dictionary<string, string> dict)
        {
            tabla = "equipo";
            dict = new Dictionary<string, string>();
            dict.Add("nombre", textBox1.Text);
            dict.Add("encargado", textBox2.Text);
            dict.Add("telefono", textBox3.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex + 1;
            if (e.ColumnIndex == dataGridView1.Columns.Count - 2)
            {
                string query = "select nombre,encargado,telefono from equipo where idequipo = " + row;
                System.Collections.ArrayList array = db.consultar(query);
                foreach (Dictionary<string, string> v in array)
                {
                    textBox1.Text = v["nombre"];
                    textBox2.Text = v["encargado"];
                    textBox3.Text = v["telefono"];
                    modi = true;
                }
                panel1.Visible = true;
            }
            else if (e.ColumnIndex == dataGridView1.Columns.Count - 1)
            {
                if (MessageBox.Show("Estas seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.eliminar("equipo", "idequipo=" + row);
                    MessageBox.Show("Registro eliminado");
                    consultar();
                }               
            }
        }
    }
}
