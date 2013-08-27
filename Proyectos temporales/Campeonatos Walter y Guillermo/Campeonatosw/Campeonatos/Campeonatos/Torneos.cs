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
using System.Collections;
namespace Campeonatos
{
    public partial class Torneos : Form
    {
        public Torneos()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect(Properties.Settings.Default.ruta);
        bool modi = false;
        int row = -1;

        public void consultar()
        {
            tblcalendario.Columns.Clear();

            tblcalendario.DataSource = db.consultarGrid("select idcampeonato,nombre,fecha_inicio,fecha_final from campeonato").DataSource;

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            //col.Text = "Editar";
            col.Name = "Edición";
            tblcalendario.Columns.Add(col);

            col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            //col.Text = "Eliminar";
            col.Name = "Eliminación";
            tblcalendario.Columns.Add(col);

            col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            //col.Text = "Ver equpipos";
            col.Name = "Equipos";
            tblcalendario.Columns.Add(col);
            tblcalendario .Columns[0].Visible = false;

            panel1.Visible = false;
        }

        private void Torneos_Load(object sender, EventArgs e)
        {
            consultar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            txtnombretorneo.Text = "";
            txtnombretorneo.Focus();
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
                db.actualizar(tabla, dict, "idcampeonato='" + tblcalendario[0, tblcalendario.CurrentRow.Index].Value+"'");/////////////
            }
            modi = false;
            txtnombretorneo.Text = "";
            consultar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex + 1;
            if (e.ColumnIndex==4)
            {
                string query = "select nombre,fecha_inicio,fecha_final from campeonato where idcampeonato = '" + tblcalendario[0, tblcalendario.CurrentRow.Index].Value+"'";
                ArrayList array = db.consultar(query);
                foreach (Dictionary<string,string> v in array)
                {
                    txtnombretorneo.Text = v["nombre"];
                    //dateTimePicker1.Value = DateTime.Parse(v["fecha_inicio"], "'dd'|'MM'|'yyyy'",System.Globalization.DateTimeStyles styles);
                    //dateTimePicker2.Value = v["fecha_final"];
                    modi = true;
                }
                panel1.Visible = true;
               
            }
            else if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("¿Estás seguro de eliminar este registro?", "Eliminar registro",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = 0;
                    String ob = tblcalendario[1, tblcalendario.CurrentRow.Index].Value.ToString();
                    //MessageBox.Show(tblcalendario[0, tblcalendario.CurrentRow.Index].Value.ToString());
                    id = Convert.ToInt32(tblcalendario[0, tblcalendario.CurrentRow.Index].Value);
                    db.eliminar("campeonato", "idcampeonato=" + id);
  
                    MessageBox.Show("Registro eliminado","Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    consultar();
                }
            }
            else if (e.ColumnIndex == 6)
            {
                String valor = tblcalendario.Rows[e.RowIndex].Cells[0].Value.ToString();
                //MessageBox.Show(valor);
                new Asignacion_torneo(Convert.ToInt32(valor)).ShowDialog();
            }
        }

        private void datos(out string tabla, out Dictionary<string,string> dict)
        {
            tabla = "campeonato";
            dict = new Dictionary<string, string>();
            dict.Add("nombre", txtnombretorneo.Text);
            dict.Add("fecha_inicio", txtfechainicio.Value.ToString());
            dict.Add("fecha_final", txtfechafinal.Value.ToString());
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (this.tblcalendario.Columns[e.ColumnIndex].Name == "Edición")
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    DataGridViewButtonCell celBoton = this.tblcalendario.Rows[e.RowIndex].Cells["Edición"] as DataGridViewButtonCell;
                    celBoton = this.tblcalendario.Rows[e.RowIndex].Cells["Edición"] as DataGridViewButtonCell;                    
                    Console.WriteLine(Environment.CurrentDirectory);
                    Icon icoAtomico = new Icon(Environment.CurrentDirectory+@"\editar.ico");
                    //Icon icoAtomico = new Icon(Properties.Resources.editar.ToString());//+ @"\editar.ico");

                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.tblcalendario.Rows[e.RowIndex].Height = icoAtomico.Height;// +10;
                    this.tblcalendario.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
                if (this.tblcalendario.Columns[e.ColumnIndex].Name == "Eliminación")
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    DataGridViewButtonCell celBoton = this.tblcalendario.Rows[e.RowIndex].Cells["Eliminación"] as DataGridViewButtonCell;
                    celBoton = this.tblcalendario.Rows[e.RowIndex].Cells["Eliminación"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\editar.ico");                
                    Icon icoAtomico = new Icon(Environment.CurrentDirectory+@"\eliminar.ico");
                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.tblcalendario.Rows[e.RowIndex].Height = icoAtomico.Height;// +10;
                    this.tblcalendario.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;                    
                }
                if (this.tblcalendario.Columns[e.ColumnIndex].Name == "Equipos")
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    DataGridViewButtonCell celBoton = this.tblcalendario.Rows[e.RowIndex].Cells["Equipos"] as DataGridViewButtonCell;
                    celBoton = this.tblcalendario.Rows[e.RowIndex].Cells["Equipos"] as DataGridViewButtonCell;
                    //Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\editar.ico");                
                    Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\pelota.ico");
                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                    this.tblcalendario.Rows[e.RowIndex].Height = icoAtomico.Height;// +10;
                    this.tblcalendario.Columns[e.ColumnIndex].Width = icoAtomico.Width + 10;
                    e.Handled = true;
                }
           }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            txtnombretorneo.Text = "";
        }
    }
}
