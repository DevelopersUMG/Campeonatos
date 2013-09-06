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
    public partial class Configuración : Form
    {

        bool first = true;
        DBConnect db = new DBConnect(Properties.Settings.Default.ruta);

        public Configuración()
        {
            InitializeComponent();
            if (File.Exists("configuraciones.adst"))
            {
                tab_configuraciones.TabPages.RemoveAt(0);
                btn_sig_3.Text = "Guardar";
                btn_finalizar.Text = "Guardar";
                lbl_titulo_admin.Text = "Cambiar contraseña de administrador";
                lbl_usuario_admin.Text = "Contraseña antigua:";
                lbl_pass_admin.Text = "Nueva contraseña:";
                lbl_pass2_admin.Text = "Confirme nueva contraseña:";                
                first = false;
            }
            else
            {
                this.ControlBox = false;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Configuración_Load(object sender, EventArgs e)
        {

        }

        private void Abrir_archivo_FileOk(object sender, CancelEventArgs e)
        {

        }       

        private void btn_sig_1_Click(object sender, EventArgs e)
        {
            tab_configuraciones.SelectedIndex = 1;
        }

        private void btn_sig_2_Click(object sender, EventArgs e)
        {
            tab_configuraciones.SelectedIndex = 2;
        }

        private void btn_sig_3_Click(object sender, EventArgs e)
        {
            if (txt_path.Text != "")
            {
                //Properties.Settings.Default.ruta = txt_path.Text;
                Properties.Settings.Default.ruta = Properties.Settings.Default.ruta;
                tab_configuraciones.SelectedIndex = 3;
            }
            else
            {
                MessageBox.Show("Debe ingresar la ruta correcta");
            }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            if (!first)
            {

            }
                if (txt_nombre_emp.Text == "" || txt_direccion_emp.Text == "" || txt_logotipo.Text == "")
                {
                    MessageBox.Show("No pueden existir campos vacios");
                }
                else
                {
                    try
                    {
                        StreamWriter f = new StreamWriter("configuraciones.adst");
                        f.WriteLine(txt_nombre_emp + "\n" + txt_direccion_emp);
                        f.Close();
                        FileInfo img = new FileInfo(txt_logotipo.Text);
                        string[] ve = txt_logotipo.Text.Split('.');
                        Properties.Settings.Default.logo = "logo." + ve[ve.Length - 1];
                        if (File.Exists(Properties.Settings.Default.logo)){
                            File.Delete(Properties.Settings.Default.logo);
                        }
                        img.CopyTo(Properties.Settings.Default.logo);
                        Properties.Settings.Default.Save();
                        this.Close();
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
        }

        private void btn_guardar_admin_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "" || txt_pass.Text == "" || txt_pass2.Text == "")
            {
                MessageBox.Show("No puede dejar campos en blanco");
            }
            else
            {
                if (txt_pass.Text == txt_pass2.Text)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("nombre", txt_usuario.Text);
                    dict.Add("pass", txt_pass.Text);
                    dict.Add("rol", "1");
                    //db.insertar("usuario", dict);
                    db.actualizar("usuario", dict, "idusuario=1");
                    tab_configuraciones.SelectedIndex = 2;
                }
                else
                {
                    MessageBox.Show("Contraseñas no coinciden");
                }
            }
        }

        private void btn_examinar_Click(object sender, EventArgs e)
        {
            DialogResult result = Abrir_archivo.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txt_path.Text = Abrir_archivo.FileName;
            }
        }

        private void btn_examinar_logo_Click(object sender, EventArgs e)
        {
            DialogResult result = Abrir_archivo.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {                
                txt_logotipo.Text = Abrir_archivo.FileName;
            }
        }

        private void txt_path_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
    }
}
