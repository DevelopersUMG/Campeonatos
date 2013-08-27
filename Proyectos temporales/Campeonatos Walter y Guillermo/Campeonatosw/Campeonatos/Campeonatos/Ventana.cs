using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Campeonatos
{
    public partial class Ventana : Form
    {

        public Ventana()
        {
            InitializeComponent();
            /*
            if (!File.Exists("configuraciones.adst"))
            {
                new Configuración().ShowDialog();
                
            }
            //new form_bienvenida().ShowDialog();
             */
            Contenedor.IsSplitterFixed = true;
            Contenedor.FixedPanel = FixedPanel.Panel1;            
        }

        public void adaptar()
        {
            pic_logo.Location = new Point((Contenedor.Panel1.Size.Width / 2) - (pic_logo.Size.Width / 2), Contenedor.Panel1.Size.Height - pic_logo.Size.Height);
            //pic_logo.Image = Image.FromFile(@Properties.Settings.Default.logo);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form1 f = new Form1();
            //f.MdiParent = this;
            f.TopLevel = false;            
            this.splitContainer1.Panel2.Controls.Add(f);
            f.Show();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Form1 f = new Form1();
            //f.MdiParent = this;
            f.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(f);
            f.Show();*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*Form1 f = new Form1();
            //f.MdiParent = this;
            f.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(f);
            f.Show();*/
        }

        private void Ventana_Load(object sender, EventArgs e)
        {
            /*
            if (!File.Exists("configuraciones.adst"))
            {
                this.Close();
            }
            */
            adaptar();
        }

        private void Ventana_SizeChanged(object sender, EventArgs e)
        {
            adaptar();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuración conf = new Configuración();
            conf.ShowDialog();
            adaptar();
        }
    }
}
