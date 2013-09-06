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
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
            Seleccion_campeonato sele = new Seleccion_campeonato();
            sele.estadistica(this);
            sele.ShowDialog();
        }

        private DBConnect db = new DBConnect(Properties.Settings.Default.ruta);
        private int idtorneo;
        private string nombre;
        private bool bandera = false;

        public void sele_campeonato(int i, string s)
        {
            this.idtorneo = i;
            this.nombre = s;
            nombre_lbl.Text = nombre;
            consultar_equipo();
            estadisticas_globales();
        }

        private void consultar_equipo()
        {
            string query = "select nombre as 'Nombre del equipo', pj as 'PJ', pg,pe,pp,gf,ge,pts,dif from equipo where idcampeonato = "+idtorneo;
            query += " order by pts desc,dif desc,gf desc,pg desc,pe desc,pp desc";
            equipos_dgw.DataSource = db.consultarGrid(query).DataSource;
            //equipos_dgw.Columns[0].Width = 200;
        }

        class equipo
        {
            public int ID { get; set; }
            public string TypeName { get; set; }
        }

        private void llenar_combo_equipos()
        {
            string query = "select idequipo,nombre from equipo where idcampeonato="+idtorneo;
            System.Collections.ArrayList array = db.consultar(query);
            List<equipo> accountList = new List<equipo>();
            accountList.Add(new equipo() { ID = 0, TypeName = "Todos los equipos" });
            foreach (Dictionary<string, string> d in array)
            {
                accountList.Add(new equipo(){ID=Convert.ToInt32(d["idequipo"]), TypeName=d["nombre"]});
            }           
            equipos_cmb.DataSource = accountList;
            equipos_cmb.DisplayMember = "TypeName";
            equipos_cmb.ValueMember = "ID";
        }

        private void cambiar_btn_Click(object sender, EventArgs e)
        {
            Seleccion_campeonato sele = new Seleccion_campeonato();
            sele.estadistica(this);
            sele.ShowDialog();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            llenar_combo_equipos();
            bandera = true;
        }

        private void equipos_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bandera)
            {
                if (Convert.ToInt32(equipos_cmb.SelectedValue) == 0)
                {
                    estadisticas_globales();
                }
                else
                {
                    consultar_por_equipo(); 
                }
            }
        }

        private void estadisticas_globales()
        {
            jugadores_dgw.ColumnCount = 5;
            jugadores_dgw.Columns[0].Name = "Nombre del jugador";
            jugadores_dgw.Columns[1].Name = "Equipo";
            jugadores_dgw.Columns[2].Name = "Goles";
            jugadores_dgw.Columns[3].Name = "Tarjetas Amarillas";
            jugadores_dgw.Columns[4].Name = "Tarjetas Rojas";

            string query = "select idequipo from equipo where idcampeonato = "+idtorneo;
            System.Collections.ArrayList array = db.consultar(query);
            int[] list_equipos = new int[array.Count];
            int c = 0;
            Console.WriteLine("Equipos:");
            foreach (Dictionary<string, string> d in array)
            {
                list_equipos[c] = Convert.ToInt32(d["idequipo"]);
                Console.WriteLine(list_equipos[c].ToString());
                c++;
            }
            ArrayList codigos_fichas = new ArrayList();
            ArrayList nombres = new ArrayList();
            ArrayList equipos = new ArrayList();
            Console.WriteLine("Codigos de fichas:");
            for (int i = 0; i < list_equipos.Length; i++)
            {
                query = "select f.cod_ficha as 'ficha' ,j.nombre as 'nombre', e.nombre as 'equipo' from ficha_jugador f, jugador j, equipo e where f.idequipo=e.idequipo and f.idjugador=j.idjugador and f.idequipo="+list_equipos[i];
                array = db.consultar(query);
                foreach (Dictionary<string, string> d in array)
                {
                    codigos_fichas.Add(Convert.ToInt32(d["ficha"]));
                    nombres.Add(d["nombre"]);
                    equipos.Add(d["equipo"]);
                    Console.WriteLine(d["nombre"]);
                }
            }
            ArrayList totales = new ArrayList();
            foreach (var v in codigos_fichas)
            {
                query = "select sum(goles) as 'g',sum(tarjeta_amarilla) as 'a',sum(tarjeta_roja) as 'r' from detalles_jugador where cod_ficha = "+v;
                array = db.consultar(query);
                foreach (Dictionary<string, string> d in array)
                {
                    totales.Add(d);
                    Console.WriteLine(d["g"]+" - " + d["a"]+" - "+d["r"]);
                }
            }
            jugadores_dgw.RowCount = nombres.Count;
            for (int i = 0; i < nombres.Count; i++)
            {
                jugadores_dgw.Rows[i].Cells[0].Value = nombres[i] as string;
                jugadores_dgw.Rows[i].Cells[1].Value = equipos[i] as string;
                Dictionary<string, string> d = totales[i] as Dictionary<string, string>;
                jugadores_dgw.Rows[i].Cells[2].Value = d["g"];
                jugadores_dgw.Rows[i].Cells[3].Value = d["a"];
                jugadores_dgw.Rows[i].Cells[4].Value = d["r"];
            }
            //this.dataGridView1.Sort(this.dataGridView1.Columns["Name"], ListSortDirection.Ascending);
            jugadores_dgw.Sort(jugadores_dgw.Columns["Goles"], ListSortDirection.Descending);
        }

        private void consultar_por_equipo()
        {

            jugadores_dgw.ColumnCount = 5;
            jugadores_dgw.Columns[0].Name = "Nombre del jugador";
            jugadores_dgw.Columns[1].Name = "Equipo";
            jugadores_dgw.Columns[2].Name = "Goles";
            jugadores_dgw.Columns[3].Name = "Tarjetas Amarillas";
            jugadores_dgw.Columns[4].Name = "Tarjetas Rojas";

            ArrayList codigos_fichas = new ArrayList();
            ArrayList nombres = new ArrayList();
            ArrayList equipos = new ArrayList();
            Console.WriteLine("Codigos de fichas:");
            
               string query = "select f.cod_ficha as 'ficha' ,j.nombre as 'nombre', e.nombre as 'equipo' from ficha_jugador f, jugador j, equipo e where f.idequipo=e.idequipo and f.idjugador=j.idjugador and f.idequipo=" + equipos_cmb.SelectedValue;
               ArrayList array = db.consultar(query);
                foreach (Dictionary<string, string> d in array)
                {
                    codigos_fichas.Add(Convert.ToInt32(d["ficha"]));
                    nombres.Add(d["nombre"]);
                    equipos.Add(d["equipo"]);
                    Console.WriteLine(d["nombre"]);
                
            }
            ArrayList totales = new ArrayList();
            foreach (var v in codigos_fichas)
            {
                query = "select sum(goles) as 'g',sum(tarjeta_amarilla) as 'a',sum(tarjeta_roja) as 'r' from detalles_jugador where cod_ficha = " + v;
                array = db.consultar(query);
                foreach (Dictionary<string, string> d in array)
                {
                    totales.Add(d);
                    Console.WriteLine(d["g"] + " - " + d["a"] + " - " + d["r"]);
                }
            }
            jugadores_dgw.RowCount = nombres.Count;
            for (int i = 0; i < nombres.Count; i++)
            {
                jugadores_dgw.Rows[i].Cells[0].Value = nombres[i] as string;
                jugadores_dgw.Rows[i].Cells[1].Value = equipos[i] as string;
                Dictionary<string, string> d = totales[i] as Dictionary<string, string>;
                jugadores_dgw.Rows[i].Cells[2].Value = d["g"];
                jugadores_dgw.Rows[i].Cells[3].Value = d["a"];
                jugadores_dgw.Rows[i].Cells[4].Value = d["r"];
            }
            //this.dataGridView1.Sort(this.dataGridView1.Columns["Name"], ListSortDirection.Ascending);
            jugadores_dgw.Sort(jugadores_dgw.Columns["Goles"], ListSortDirection.Descending);
        }

    }
}
