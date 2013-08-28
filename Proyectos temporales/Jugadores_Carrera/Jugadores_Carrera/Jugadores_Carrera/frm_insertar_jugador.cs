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

namespace WindowsFormsApplication1
{
    public partial class frm_insertar_jugador : Form
    {
        public frm_insertar_jugador()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect("campeonato.sqlite");
        private void btn_consulta_Click(object sender, EventArgs e)
        {
            string tabla = "jugador";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("nombre", textBox1.Text);
            dict.Add("direccion", textBox3.Text);
            dict.Add("telefono", textBox2.Text);

//realizar insercion
            db.insertar(tabla, dict);
//actualizar el datagrid
            string query = "select * from jugador";
            dataGridView1.DataSource = db.consultarGrid(query).DataSource;
        }

       
    }
}
