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
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Frm_edicion : Form
    {
        public Frm_edicion()
        {
            InitializeComponent();
        }
        DBConnect db= new DBConnect ("campeonato.sqlite");
        private void Form1_Load(object sender, EventArgs e)
        {
          //String query =  "select * from syscolumns where id = object_id('jugador')";
          //comboBox1.DataSource = db.consultarGrid(query).DataSource; 
        }

      public void llenacombobox()
        {
            //código para llenar el comboBox
            // DataSet ds = new DataSet();
             //indicamos la consulta en SQL
            //SqlDataAdapter da = new SqlDataAdapter("select * from syscolumns where id = objet_id('jugador')", db);
            //se indica el nombre de la tabla
            // da.Fill(ds, "Anime");
            //comboBox1.DataSource = ds.Tables[0].DefaultView;
             //se especifica el campo de la tabla
            //comboBox1.ValueMember = "Nombre_Anime";
      }

        
    }
}
