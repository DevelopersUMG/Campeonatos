using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLiteConnect;
using System.Windows.Forms;

namespace Campeonatos
{
    class Seleccion_jugadores
    {
        private DBConnect db = new DBConnect(Properties.Settings.Default.ruta);
        private int torneo;
        private int equipo;
        private int[] list_equipos;
        private int[] list_jugadores;
        private DataGridView data = new DataGridView();

        public Seleccion_jugadores(int t,int e)
        {
            torneo = t;
            equipo = e;
            Console.WriteLine("Torneo: "+t + " - Equipo: "+e);
        }

        public DataGridView consultar(){
            equipos();
            jugadores();
            return data;
        }

        private void equipos()
        {
            string query = "select idequipo from equipo where idcampeonato = "+torneo+" and idequipo <> "+equipo;
            System.Collections.ArrayList array = db.consultar(query);
            int[] eq = new int[array.Count];
            int c = 0;
            foreach (Dictionary<string, string> d in array)
            {
                eq[c] =Convert.ToInt32(d["idequipo"]);
                //Console.WriteLine(eq[c].ToString());
                c++;
            }
            list_equipos = eq;
        }

        private void jugadores()
        {
            string query = "select j.idjugador as 'id' from jugador j, ficha_jugador f where f.idjugador=j.idjugador and (";
            for (int i = 0; i < list_equipos.Length; i++)
            {
                query += " f.idequipo = "+list_equipos[i];
                if (i != list_equipos.Length - 1)
                {
                    query += " or ";
                }
                else
                {
                    query += ")";
                }
            }
            Console.WriteLine(query);
            System.Collections.ArrayList ar = db.consultar(query);
            list_jugadores = new int[ar.Count];
            int c = 0;
            foreach (Dictionary<string, string> d in ar)
            {
                list_jugadores[c] = Convert.ToInt32(d["id"]);
                Console.WriteLine(list_jugadores[c].ToString());
                c++;
            }
            //d.DataSource = db.consultarGrid(query).DataSource;
            query = "select idjugador, nombre as 'Nombre', telefono as 'Telefono', direccion as 'Direccion' from jugador";
            if (list_jugadores.Length > 0)
            {
                query += " where ";

                for (int i = 0; i < list_jugadores.Length; i++)
                {
                    query += "idjugador <> " + list_jugadores[i];
                    if (i != list_jugadores.Length - 1)
                    {
                        query += " and ";
                    }
                }
            }
            data = new DataGridView();
            data.DataSource = db.consultarGrid(query).DataSource;
        }
    }
}
