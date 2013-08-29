//AUTOR:
//Luis Angel Ramos Gómez 0901-09-2113

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SQLiteConnect;

namespace Campeonatos
{
    public partial class Ventana : Form
    {

        string nameventana;
        

        public Ventana()
        {
            InitializeComponent();
            if (Properties.Settings.Default.ruta == "")
            {
                new Ruta_base().ShowDialog();
            }
            
            //new form_bienvenida().ShowDialog();
            
            Contenedor.IsSplitterFixed = true;
            Contenedor.FixedPanel = FixedPanel.Panel1;            
        }

        public void adaptar()
        {
            pic_logo.Location = new Point((Contenedor.Panel1.Size.Width / 2) - (pic_logo.Size.Width / 2), Contenedor.Panel1.Size.Height - pic_logo.Size.Height);
            //pic_logo.Image = Image.FromFile(@Properties.Settings.Default.logo);
            foreach (object control in Contenedor.Panel2.Controls)
            {
                if (control.GetType() == typeof(Form))
                {
                    int x = (Contenedor.Panel2.Width / 2) - (((Form)control).Width / 2);
                    int y = (Contenedor.Height / 2) - (((Form)control).Height / 2);
                    ((Form)control).Location = new Point(x, y);
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form1 f = new Form1();
            //f.MdiParent = this;
            f.TopLevel = false;            
            this.splitContainer1.Panel2.Controls.Add(f);
            f.Show();*/
            Application.Exit();
        }

       

        private void Ventana_Load(object sender, EventArgs e)
        {
            adaptar();
        }

        private void Ventana_SizeChanged(object sender, EventArgs e)
        {
            adaptar();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Ruta_base().ShowDialog();
        }

        private void btn_campeonatos_Click(object sender, EventArgs e)
        {
            abrir_modulo(new Torneos(), "Torneos");
        }

        private void btn_equipos_Click(object sender, EventArgs e)
        {
            abrir_modulo(new crear_equipo(), "Equipos");
        }

        private void abrir_modulo(Form f,string m)
        {
            if (Contenedor.Panel2.Controls.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de cerrar el módulo de " + nameventana + "?", "Cerrar módulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Contenedor.Panel2.Controls.RemoveAt(0);
                    int x = (Contenedor.Panel2.Width/2)-(f.Width/2);
                    int y = (Contenedor.Height/2)-(f.Height/2);
                    f.Location = new Point(x,y);
                    f.TopLevel = false;
                    Contenedor.Panel2.Controls.Add(f);
                    f.Show();
                    nameventana = m;
                }
            }
            else
            {
                f.TopLevel = false;
                int x = (Contenedor.Panel2.Width / 2) - (f.Width / 2);
                int y = (Contenedor.Height / 2) - (f.Height / 2);
                f.Location = new Point(x, y);
                Contenedor.Panel2.Controls.Add(f);
                f.Show();
                nameventana = m;
            }
        }

        private void btn_jugador_Click(object sender, EventArgs e)
        {
            abrir_modulo(new Frm_menu_jugadores(),"Jugadores");
        }

        private void btn_partidos_Click(object sender, EventArgs e)
        {
            int i=1;
            string s="";
            DBConnect db = new DBConnect(Properties.Settings.Default.ruta);
            System.Collections.ArrayList a = db.consultar("select nombre from campeonato where idcampeonato=1");
            foreach (Dictionary<string, string> d in a)
            {
                s = d["nombre"];
            }
            abrir_modulo(new Partidos(i, s), "Partidos");
        }
    }
}
