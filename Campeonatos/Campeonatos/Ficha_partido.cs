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
        private bool band = false;

        public Ficha_partido(int p)
        {
            InitializeComponent();
            idpartido = p;
        }

        public void set_var()
        {
            this.band = true;
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
            
            query = "select f.cod_ficha as 'idjugador', j.nombre as 'nombre' from ficha_jugador f, jugador j where f.idjugador=j.idjugador and f.estado==0 and f.idequipo = " + local;
            
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
            local_dgw.Columns[1].ReadOnly = true;

            query = "select f.cod_ficha as 'idjugador', j.nombre as 'nombre' from ficha_jugador f, jugador j where f.idjugador=j.idjugador and f.estado==0 and f.idequipo = " + visita;
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
            visita_dgw.Columns[1].ReadOnly = true;

            if (band)
            {
                consultar();
            }
        }

        private void consultar()
        {
            guardar_btn.Visible = false;
            llenar_estad(local_dgw);
            llenar_estad(visita_dgw);
        }

        private void llenar_estad(DataGridView data)
        {
            for (int i = 0; i < data.RowCount; i++)
            {
                string query = "select goles,tarjeta_amarilla,tarjeta_roja from detalles_jugador where idpartido=" + idpartido + " and cod_ficha=" + data.Rows[i].Cells[0].Value;
                System.Collections.ArrayList array = db.consultar(query);
                foreach (Dictionary<string, string> d in array)
                {
                    data.Rows[i].Cells[2].Value = d["goles"];
                    data.Rows[i].Cells[3].Value = d["tarjeta_amarilla"];
                    data.Rows[i].Cells[4].Value = d["tarjeta_roja"];
                }
            }
        }

        private void local_dgw_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (local_dgw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "")
            {
                local_dgw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0";
            }
            int g=0;
            for (int i = 0; i < local_dgw.RowCount; i++)
            {               
                g += Convert.ToInt32(local_dgw.Rows[i].Cells[2].Value);
            }
            gol_loc_tbx.Text = g.ToString();
        }

        private void local_dgw_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            local_dgw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
        }

        private void visita_dgw_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            visita_dgw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
        }

        private void visita_dgw_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (visita_dgw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "")
            {
                visita_dgw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0";
            }
            int g = 0;
            for (int i = 0; i < visita_dgw.RowCount; i++)
            {
                g += Convert.ToInt32(visita_dgw.Rows[i].Cells[2].Value);
            }
            gol_vis_tbx.Text = g.ToString();
        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            actualizar_fichas(local_dgw);
            actualizar_fichas(visita_dgw);
            actualizar_equipo(local, 1);
            actualizar_equipo(visita, 2);
            actualizar_estado();
            MessageBox.Show("Partido guardado");
            this.Close();
        }

        private void actualizar_fichas(DataGridView grid)
        {
            Dictionary<string, string> d =new  Dictionary<string, string>();
            d.Add("estado", "0");
            db.actualizar("ficha_jugador", d, "idequipo="+local);
            db.actualizar("ficha_jugador", d, "idequipo=" + visita);
            string tabla = "detalles_jugador";
            for (int i = 0; i < grid.RowCount; i++)
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("idpartido", idpartido.ToString());
                dict.Add("cod_ficha", grid.Rows[i].Cells[0].Value.ToString());
                dict.Add("goles", grid.Rows[i].Cells[2].Value.ToString());
                dict.Add("tarjeta_amarilla", grid.Rows[i].Cells[3].Value.ToString());
                dict.Add("tarjeta_roja", grid.Rows[i].Cells[4].Value.ToString());
                int a = Convert.ToInt32(grid.Rows[i].Cells[4].Value);
                int b = Convert.ToInt32(grid.Rows[i].Cells[3].Value);
                if (a == 1 || b == 2)
                {
                    string t = "ficha_jugador";
                    Dictionary<string, string> act = new Dictionary<string, string>();
                    act.Add("estado", "1");
                    db.actualizar(t, act, "cod_ficha=" + grid.Rows[i].Cells[0].Value);
                }
                db.insertar(tabla, dict);
                //Console.WriteLine(dict["goles"]);
            }
            
            //Console.WriteLine("Terminado");
        }

        private void actualizar_equipo(int id, int l)
        {
            string query = "select pj,pg,pe,pp,gf,ge,dif,pts from equipo where idequipo = "+id;
            System.Collections.ArrayList array = db.consultar(query);
            Dictionary<string, string> estad = new Dictionary<string, string>();
            foreach (Dictionary<string, string> d in array)
            {
                estad = d;
            }

            string tabla = "detalle_partido";
            string condicion = "idequipo = "+id +" and idpartido = "+idpartido;
            Dictionary<string, string> dict = new Dictionary<string, string>();
            if (l == 1)
            {
                dict.Add("goles", gol_loc_tbx.Text);
            }
            else
            {
                dict.Add("goles", gol_vis_tbx.Text);
            }
            db.actualizar(tabla, dict, condicion);

            int gol_l =Convert.ToInt32(gol_loc_tbx.Text);
            int gol_v =Convert.ToInt32(gol_vis_tbx.Text);
            bool band = false;
            bool gano = false;
            bool emp = false;
            if (gol_l > gol_v) band = true;
            else if (gol_l == gol_v) emp = true;
            else if(gol_l < gol_v) band = false;

            if (band && l == 1) gano = true;
            else if (emp) gano = false;
            else if (band && l == 2) gano = false;
            else if (!band && l == 1) gano = false;
            else if (!band && l == 2) gano = true;
            

            estad["pj"] = (Convert.ToInt32(estad["pj"])+1).ToString();
            if (gano) { estad["pg"] = (Convert.ToInt32(estad["pg"]) + 1).ToString(); estad["pts"] = (Convert.ToInt32(estad["pts"]) + 3).ToString(); }
            else if (emp) { estad["pe"] = (Convert.ToInt32(estad["pe"]) + 1).ToString(); estad["pts"] = (Convert.ToInt32(estad["pts"])+1).ToString(); }
            else if (!gano && !emp) { estad["pp"] = (Convert.ToInt32(estad["pp"]) + 1).ToString(); }
            if (l == 1)
            {
                estad["gf"] = (Convert.ToInt32(estad["gf"]) + gol_l).ToString();
                estad["ge"] = (Convert.ToInt32(estad["ge"]) + gol_v).ToString();
            }
            else
            {
                estad["gf"] = (Convert.ToInt32(estad["gf"]) + gol_v).ToString();
                estad["ge"] = (Convert.ToInt32(estad["ge"]) + gol_l).ToString();
            }
            estad["dif"] = (Convert.ToInt32(estad["gf"]) - Convert.ToInt32(estad["ge"])).ToString();
            //Console.WriteLine(estad["pj"] + "- " +estad["pg"] + "- " +estad["pe"] + "- " +estad["pp"] + "- " +estad["gf"] + "- " +estad["ge"] + "- " +estad["dif"] + "- ");
            tabla = "equipo";
            condicion = "idequipo="+id;
            db.actualizar(tabla, estad, condicion);
        }

        private void actualizar_estado()
        {
            string tabla = "partido";
            string condicion = "idpartido = "+idpartido;
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("ingresado", "1");
            db.actualizar(tabla, dict, condicion);
        }
    }
}
