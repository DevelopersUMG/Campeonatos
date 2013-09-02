//AUTORES:
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

        bool modi = false;
        DBConnect db = new DBConnect(Properties.Settings.Default.ruta);
        int row = -1;

        public void consultar()
        {
            tblequipo.Columns.Clear();
            tblequipo.DataSource = db.consultarGrid("select idequipo,nombre as 'Nombre',encargado as 'Encargado',telefono as 'Teléfono',idcampeonato from equipo").DataSource;

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            //col.Text = "Editar";
            col.Name = "Edición";
            tblequipo.Columns.Add(col);

            col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            //col.Text = "Eliminar";
            col.Name = "Eliminación";
            tblequipo.Columns.Add(col);

            tblequipo.Columns[0].Visible = false;
            tblequipo.Columns[4].Visible = false;
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
            txtnombrequipo.Text = "";
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
                db.actualizar(tabla, dict, "idequipo='"+tblequipo[0, tblequipo.CurrentRow.Index].Value + "'");
            }
            modi = false;
            txtnombrequipo.Text = "";
            txtencargado.Text = "";
            txttelefono.Text = "";
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
            if (this.tblequipo.Columns[e.ColumnIndex].Name == "Edición")
            {
                string query = "select nombre,encargado,telefono from equipo where idequipo = '" + tblequipo[0, tblequipo.CurrentRow.Index].Value + "'";
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
            else if (this.tblequipo.Columns[e.ColumnIndex].Name == "Eliminación")
            {
                if (MessageBox.Show("¿Estás seguro de eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = 0;
                    id = Convert.ToInt32(tblequipo[0, tblequipo.CurrentRow.Index].Value);
                    //MessageBox.Show(id.ToString());
                    db.eliminar("equipo", "idequipo=" + id);
                    MessageBox.Show("Registro eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void tblequipo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (this.tblequipo.Columns[e.ColumnIndex].Name == "Edición")
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    DataGridViewButtonCell celBoton = this.tblequipo.Rows[e.RowIndex].Cells["Edición"] as DataGridViewButtonCell;
                    celBoton = this.tblequipo.Rows[e.RowIndex].Cells["Edición"] as DataGridViewButtonCell;
                    Console.WriteLine(Environment.CurrentDirectory);
                    Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\editar.ico");
                    //Icon icoAtomico = new Icon(Properties.Resources.editar.ToString());//+ @"\editar.ico");

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.tblequipo.Rows[e.RowIndex].Height = icoAtomico.Height;// +10;
                    this.tblequipo.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
                if (this.tblequipo.Columns[e.ColumnIndex].Name == "Eliminación")
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    DataGridViewButtonCell celBoton = this.tblequipo.Rows[e.RowIndex].Cells["Eliminación"] as DataGridViewButtonCell;
                    celBoton = this.tblequipo.Rows[e.RowIndex].Cells["Eliminación"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\editar.ico");                
                    Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\eliminar.ico");
                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.tblequipo.Rows[e.RowIndex].Height = icoAtomico.Height;// +10;
                    this.tblequipo.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
            }
        }
    }
}
