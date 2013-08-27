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

namespace equipos
{
    public partial class jugadorescs : Form
    {
        DBConnect db = new DBConnect("campeonato.sqlite");

        public jugadorescs()
        {
            InitializeComponent();
        }

        private void jugadorescs_Load(object sender, EventArgs e)
        {
            string query = "select * from jugador ";
            dataGridView1.DataSource = db.consultarGrid(query).DataSource;
        }

        private void button_agregar_jugador_Click(object sender, EventArgs e)
        {
            
            string tabla = "jugador";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("nombre", jugador_text.Text);
            dict.Add("telefono", textBox2.Text);
            dict.Add("direccion", textBox3.Text);

            //insert into tabla(nombre,direcion)values*jfdlkfdkajfkdfja;

            db.insertar(tabla, dict);

            string query = "select * from jugador";
            dataGridView1.DataSource = db.consultarGrid(query).DataSource;

        }
    }
}
