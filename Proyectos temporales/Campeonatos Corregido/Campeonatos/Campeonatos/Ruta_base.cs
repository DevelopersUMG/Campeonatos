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

namespace Campeonatos
{
    public partial class Ruta_base : Form
    {
        public Ruta_base()
        {
            InitializeComponent();
        }

        private void btn_examinar_Click(object sender, EventArgs e)
        {
            DialogResult result = Abrir_archivo.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txt_path.Text = Abrir_archivo.FileName;
            }
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            if (txt_path.Text != "")
            {
                txt_path.Text = txt_path.Text.ToLower();
                string[] v = txt_path.Text.Split('.');
                if (v[v.Length - 1] == "sqlite")
                {
                    if (txt_path.Text != Properties.Settings.Default.ruta && Properties.Settings.Default.ruta != "")
                    {
                        if (MessageBox.Show("¿Está seguro de cambiar la ubicación de la base de datos? La aplicación se riniciará para efectuar los cambios", "Guardar ruta de base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Properties.Settings.Default.ruta = txt_path.Text;
                            Application.Restart();
                        }
                    }
                    else if (Properties.Settings.Default.ruta == "")
                    {
                        Properties.Settings.Default.ruta = txt_path.Text;
                        Application.Restart();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("La base de datos tiene que tener la extensión .sqlite para poder ser reconocida");
                }
                //Properties.Settings.Default.ruta = txt_path.Text;
                //Properties.Settings.Default.ruta = "campeonato.sqlite";
                
            }
            else
            {
                MessageBox.Show("Para guardar la ruta no debe estar vacía");
            }
        }
    }
}
