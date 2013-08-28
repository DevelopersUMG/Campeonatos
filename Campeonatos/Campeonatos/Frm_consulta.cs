//Desarrollado por Edgar Carrera -0901-09-5333-
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
    public partial class Frm_consulta : Form
    {
        public Frm_consulta()
        {
            InitializeComponent();
        }


        DBConnect db = new DBConnect(Properties.Settings.Default.ruta);
        private void Frm_consulta_Load(object sender, EventArgs e)
        {
            //string query = "select * from jugador";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //string query = "select * from jugador";
            grid1.DataSource = db.consultarGrid("select nombre,telefono,direccion from jugador").DataSource;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            grid1.DataSource = db.consultarGrid("select * from jugador order by nombre").DataSource;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            grid1.DataSource = db.consultarGrid("select * from jugador order by direccion").DataSource;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            grid1.DataSource = db.consultarGrid("select * from jugador order by telefono").DataSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grid1.DataSource = db.consultarGrid("select * from jugador").DataSource;
        }

        
    }
}
