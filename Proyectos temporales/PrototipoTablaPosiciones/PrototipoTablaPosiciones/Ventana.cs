using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrototipoTablaPosiciones
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            //f.MdiParent = this;
            f.TopLevel = false;            
            this.splitContainer1.Panel2.Controls.Add(f);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            //f.MdiParent = this;
            f.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(f);
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            //f.MdiParent = this;
            f.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(f);
            f.Show();
        }
    }
}
