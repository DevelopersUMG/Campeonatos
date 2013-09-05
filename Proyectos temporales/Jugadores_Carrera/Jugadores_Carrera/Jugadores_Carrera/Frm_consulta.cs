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


namespace WindowsFormsApplication1
{
    public partial class Frm_consulta : Form
    {
        public Frm_consulta()
        {
            InitializeComponent();
        }


        DBConnect db = new DBConnect("campeonato.sqlite");
        private void Frm_consulta_Load(object sender, EventArgs e)
        {
            //string query = "select * from jugador";
            grid1.DataSource = db.consultarGrid("select nombre as 'Nombre del Jugador',telefono as 'Telefono del jugador',direccion as 'Direccion del jugador' from jugador").DataSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //string query = "select * from jugador";
            grid1.DataSource = db.consultarGrid("select nombre as 'Nombre del Jugador',telefono as 'Telefono del jugador',direccion as 'Direccion del jugador' from jugador").DataSource;
        }

       // private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
           
        //}

        //private void checkBox2_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void checkBox3_CheckedChanged(object sender, EventArgs e)
        //{
            
        //}

        private void rdb_nombre_CheckedChanged(object sender, EventArgs e)
        {
             grid1.DataSource = db.consultarGrid("select nombre as 'Nombre del Jugador',telefono as 'Telefono del jugador',direccion as 'Direccion del jugador' from jugador order by nombre").DataSource;
        }

        private void rdb_telefono_CheckedChanged(object sender, EventArgs e)
        {
        grid1.DataSource = db.consultarGrid("select nombre as 'Nombre del Jugador',telefono as 'Telefono del jugador',direccion as 'Direccion del jugador' from jugador order by direccion").DataSource;
        }

        private void rdb_direccion_CheckedChanged(object sender, EventArgs e)
        {
            grid1.DataSource = db.consultarGrid("select nombre as 'Nombre del Jugador',telefono as 'Telefono del jugador',direccion as 'Direccion del jugador' from jugador order by telefono").DataSource;
        }

       

      

        

        
    }
}
