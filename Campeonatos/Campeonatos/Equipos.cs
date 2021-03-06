﻿//AUTORES:
//WALTER QUIJADA 0901-10-934
//GUILLERMO CANEL 0901-09-12084
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SQLiteConnect;

namespace Campeonatos
{
    public partial class Equipos : Form
    {
        public Equipos()
        {
            InitializeComponent();
        }
        validacionCampos va = new validacionCampos();

        bool modi = false;
        DBConnect db = new DBConnect(Properties.Settings.Default.ruta);
        int row = -1;

        public void consultar()
        {
            tblequipo.Columns.Clear();
            tblequipo.DataSource = db.consultarGrid("select idequipo,nombre,encargado,telefono,idcampeonato from equipo").DataSource;

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Editar";
            col.Name = "Edición";
            tblequipo.Columns.Add(col);

            col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Eliminar";
            col.Name = "Eliminación";
            tblequipo.Columns.Add(col);

            tblequipo.Columns[0].Visible = false;

            edicion_pnl.Visible = false;
            limpiar();
        }

        public void limpiar()
        {
            txtnombrequipo.Text = "";
            txtencargado.Text = "";
            txttelefono.Text = "";
        }

        private void Equipos_Load(object sender, EventArgs e)
        {
            consultar();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edicion_pnl.Visible = true;
            txtnombrequipo.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tabla;
            Dictionary<string, string> dict;
            datos(out tabla, out dict);
            if (!modi)
            {
                db.insertar(tabla, dict);
            }
            else
            {
                db.actualizar(tabla, dict, "idequipo="+row);
            }
            consultar();
        }

        private void datos(out string tabla, out Dictionary<string, string> dict)
        {
            tabla = "equipo";
            dict = new Dictionary<string, string>();
            dict.Add("nombre", txtnombrequipo.Text);
            dict.Add("encargado", txtencargado.Text);
            dict.Add("telefono", txttelefono.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex + 1;
            if (e.ColumnIndex == 0)
            {
                string query = "select nombre,encargado,telefono from equipo where idequipo = " + row;
                System.Collections.ArrayList array = db.consultar(query);
                foreach (Dictionary<string, string> v in array)
                {
                    txtnombrequipo.Text = v["nombre"];
                    txtencargado.Text = v["encargado"];
                    txttelefono.Text = v["telefono"];
                    modi = true;
                }
                edicion_pnl.Visible = true;
            }
            else if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Estas seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.eliminar("equipo", "idequipo=" + row);
                    MessageBox.Show("Registro eliminado");
                    consultar();
                }               
            }
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            txtencargado.Text = "";
            txtnombrequipo.Text = "";
            txttelefono.Text = "";
            edicion_pnl.Visible = false;
        }

        private void txtnombrequipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.soloLetras_palabras(e);
        }

        private void txtnombrequipo_Leave(object sender, EventArgs e)
        {
            va.escrituraLetras(txtnombrequipo);
        }

        private void txtencargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.soloLetras_palabras(e);
        }

        private void txtencargado_Leave(object sender, EventArgs e)
        {
            va.escrituraLetras(txtencargado);
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.soloNumeros(e);
        }

        private void txttelefono_Leave(object sender, EventArgs e)
        {
            va.escrituraNumeros(txttelefono);
        }
    }
}
