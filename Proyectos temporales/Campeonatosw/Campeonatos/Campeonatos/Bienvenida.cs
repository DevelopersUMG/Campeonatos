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
    public partial class form_bienvenida : Form
    {
        DBConnect db = new DBConnect("campeonato.sqlite");

        public form_bienvenida()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
        }

        

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string query = "select nombre,pass from usuario where nombre='" + txt_usuario.Text + "' and pass='" + txt_pass.Text + "';";
            ArrayList array = db.consultar(query);
            if (array.Count == 1)
            {
                //MessageBox.Show("Bienvenido");
                this.Close();
            }
            else
            {
                MessageBox.Show("¡Usuario o password incorrecto!");
            }
            
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter){
                e.Handled = true;
                btn_login_Click(sender,e);
            }
           
        }
    }
}
