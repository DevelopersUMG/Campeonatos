using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDI
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {             
            InitializeComponent();
        }


        
        public void llamada_formulario( )
        {
             
             frmprueba prueba = new frmprueba();
             prueba.MdiParent = this;
             prueba.WindowState = FormWindowState.Maximized;
             prueba.MinimizeBox = false;
             prueba.MaximizeBox = false;
            // prueba.FormBorderStyle = FormBorderStyle.None; //para quitar cinta de opciones             
             prueba.ControlBox = true;
             contenedor.Panel2.Controls.Add(prueba);
             
             prueba.Show();
        }

        private void mprueba_Click(object sender, EventArgs e)
        {
            llamada_formulario();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            llamada_formulario();
        }

        private void canel11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            llamada_formulario();
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {

        }

        private void contenedor_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        

        
    }
}
