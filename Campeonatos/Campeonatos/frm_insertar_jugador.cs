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

namespace Campeonatos
{
    public partial class frm_insertar_jugador : Form
    {
        
        public frm_insertar_jugador()
        {
            InitializeComponent();
        }
        validacionCampos va = new validacionCampos();

        DBConnect db = new DBConnect("campeonato.sqlite");

        bool modificado = false;
        int row = -1;

        private void datos(out string tabla, out Dictionary<string, string> dict)
        {
            tabla = "jugador";
            dict = new Dictionary<string, string>();
            dict.Add("nombre", txt_nombre_jugador.Text.ToString());
            dict.Add("direccion", txt_direccion_jugador.Text.ToString());
            dict.Add("telefono", txt_tel_jugador.Text.ToString());
        }



        private void btn_consulta_Click(object sender, EventArgs e)
        {
                string tabla;
                Dictionary<string, string> dict;
                datos(out tabla, out dict);
                if (!modificado)
                {               
                    db.insertar(tabla, dict);                
                }
                else
                {
                    db.actualizar(tabla, dict, "idjugador='" + grid1.CurrentRow.Cells["idjugador"].Value + "'");/////////////
                }
                modificado = false;
                txt_nombre_jugador.Text = "";
                txt_direccion_jugador.Text = "";
                txt_tel_jugador.Text = "";

                controldatagrid();
        


           
        }

        private void frm_insertar_jugador_Load(object sender, EventArgs e)
        {
            controldatagrid();
            lbl_total_jugadores.Text = "Total de jugadores: " + grid1.RowCount;
            
        }

       
      
     

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            panel_insercion.Visible = true;
        }

        private void controldatagrid() { 
         
            grid1.Columns.Clear();

            grid1.DataSource = db.consultarGrid("select idjugador, nombre as 'Nombre del Jugador',telefono as 'Telefono del jugador',direccion as 'Direccion del jugador' from jugador").DataSource;

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Editar";
            col.Name = "Editar";
            grid1.Columns.Add(col);

            col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Eliminar";
            col.Name = "Eliminar";
            grid1.Columns.Add(col);

           
           grid1.Columns[0].Visible = false;

           
        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex + 1;
            if (this.grid1.Columns[e.ColumnIndex].Name == "Editar")
            {
                string query = "select nombre,telefono,direccion from jugador where idjugador = '" + grid1.CurrentRow.Cells["idjugador"].Value + "'";
                ArrayList array = db.consultar(query);
                foreach (Dictionary<string, string> v in array)
                {
                    txt_nombre_jugador.Text = v["nombre"];
                    txt_direccion_jugador.Text = v["direccion"];
                    txt_tel_jugador.Text = v["telefono"];
                    modificado = true;
                }
                panel_insercion.Visible = true;
                txt_nombre_jugador.Focus();

            }
            else if (this.grid1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("¿Estás seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                    int p = Convert.ToInt32(grid1.CurrentRow.Cells["idjugador"].Value);
                    db.eliminar("jugador", "idjugador=" + p);

                    MessageBox.Show("Registro eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    controldatagrid();
                }
            }
           
        }

        private void rdb_nombre_CheckedChanged(object sender, EventArgs e)
        {
            grid1.Sort(grid1.Columns["Nombre del Jugador"], ListSortDirection.Ascending);
            
        }

        private void rdb_telefono_CheckedChanged(object sender, EventArgs e)
        {
            grid1.Sort(grid1.Columns["Telefono del jugador"], ListSortDirection.Ascending);
        }

        private void rdb_direccion_CheckedChanged(object sender, EventArgs e)
        {
            grid1.Sort(grid1.Columns["Direccion del jugador"], ListSortDirection.Ascending);
        }

        private void txt_nombre_jugador_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.soloLetras_palabras(e);
        }

        private void txt_nombre_jugador_Leave(object sender, EventArgs e)
        {
            va.escrituraLetras(txt_nombre_jugador);   
        }

        private void txt_tel_jugador_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.soloNumeros(e);
        }

        private void txt_tel_jugador_Leave(object sender, EventArgs e)
        {
            va.escrituraNumeros(txt_tel_jugador);
        }

        private void txt_direccion_jugador_Leave(object sender, EventArgs e)
        {
            va.escrituraAlfanumerico(txt_direccion_jugador);
        }

        private void txt_direccion_jugador_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.alfanumerico(e);
        }

       

       
    }
}
