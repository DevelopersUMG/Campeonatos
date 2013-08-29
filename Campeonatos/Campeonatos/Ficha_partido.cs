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
    public partial class Ficha_partido : Form
    {
        int idpartido;
        DBConnect db = new DBConnect(Properties.Settings.Default.ruta);
        int local, visita;

        public Ficha_partido(int p)
        {
            InitializeComponent();
            idpartido = p;
        }

        private void Ficha_partido_Load(object sender, EventArgs e)
        {
            string query = "select e.idequipo as 'idequipo', e.nombre as 'nombre',d.goles as 'goles' from equipo e, detalle_partido d where e.idequipo=d.idequipo and d.idpartido = "+idpartido;
            System.Collections.ArrayList array = db.consultar(query);
            int c = 0;
            foreach (Dictionary<string, string> d in array)
            {
                if ((c % 2) == 0)
                {
                    local =Convert.ToInt32(d["idequipo"]);
                    local_lbl.Text = d["nombre"];
                    gol_loc_tbx.Text = d["goles"];
                }
                else
                {
                    visita = Convert.ToInt32(d["idequipo"]);
                    visita_lbl.Text = d["nombre"];
                    gol_vis_tbx.Text = d["goles"];
                }
                c++;
            }
            /*
            query = "select j.nombre as 'nombre',pu.nombre as 'puesto', d.goles as 'goles', d.tarjetasamar as 'amarillas', d.tarjetaroja as 'roja' ";
            query += "from jugador j, puesto pu, ficha_jugador f, detalless_jugador d ";
            query += "where f.idpuesto = pu.idpuesto and d.cod_ficha = f.cod_ficha and f.idjugador=j.idjugador and ";
            query += "f.idequipo = "+local + " and d.idpartido="+idpartido;
            MessageBox.Show(query);
            local_dgw.DataSource = db.consultarGrid(query).DataSource;
            */
            query = "select j.idjugador as 'idjugador', j.nombre as 'nombre' from ficha_jugador f, jugador j where f.idjugador=j.idjugador and f.idequipo = " + local;
            //local_dgw.DataSource = db.consultarGrid(query).DataSource;
            array = db.consultar(query);
            local_dgw.ColumnCount = 5;
            local_dgw.RowCount = array.Count;
            local_dgw.Columns[1].Name = "Nombre";
            local_dgw.Columns[2].Name = "Goles";
            local_dgw.Columns[3].Name = "T. Amari";
            local_dgw.Columns[4].Name = "T. Rojas";
            int r = 0;
            foreach (Dictionary<string, string> d in array)
            {
                local_dgw.Rows[r].Cells[0].Value = d["idjugador"];
                local_dgw.Rows[r].Cells[1].Value = d["nombre"];
                local_dgw.Rows[r].Cells[2].Value = "0";
                local_dgw.Rows[r].Cells[3].Value = "0";
                local_dgw.Rows[r].Cells[4].Value = "0";
                r++;
            }
            local_dgw.Columns[0].Visible = false;

            query = "select j.idjugador as 'idjugador', j.nombre as 'nombre' from ficha_jugador f, jugador j where f.idjugador=j.idjugador and f.idequipo = " + visita;
            //visita_dgw.DataSource = db.consultarGrid(query).DataSource;
            array = db.consultar(query);
            visita_dgw.ColumnCount = 5;
            visita_dgw.RowCount = array.Count;
            visita_dgw.Columns[1].Name = "Nombre";
            visita_dgw.Columns[2].Name = "Goles";
            visita_dgw.Columns[3].Name = "T. Amari";
            visita_dgw.Columns[4].Name = "T. Rojas";
            r = 0;
            foreach (Dictionary<string, string> d in array)
            {
                visita_dgw.Rows[r].Cells[0].Value = d["idjugador"];
                visita_dgw.Rows[r].Cells[1].Value = d["nombre"];
                visita_dgw.Rows[r].Cells[2].Value = "0";
                visita_dgw.Rows[r].Cells[3].Value = "0";
                visita_dgw.Rows[r].Cells[4].Value = "0";
                r++;
            }
            visita_dgw.Columns[0].Visible = false;
        }

        private void local_dgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            local_dgw.BeginEdit(true);
        }

        private void visita_dgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
