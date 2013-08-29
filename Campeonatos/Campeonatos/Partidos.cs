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
using SQLiteConnect; //DLL - Luis Angel Ramos Gómez 0901-09-2113
using Calendario;    //DLL - Luis Angel Ramos Gómez 0901-09-2113

namespace Campeonatos
{
    public partial class Partidos : Form
    {
        int idtorneo;
        DBConnect db = new DBConnect(Properties.Settings.Default.ruta);
        int[] idequipos;

        public Partidos(int t,string n)
        {
            InitializeComponent();
            idtorneo = t;
            torneo_lbl.Text += n;
        }

        private void Partidos_Load(object sender, EventArgs e)
        {
            string query = "select idequipo,nombre from equipo where idcampeonato = "+idtorneo;
            equipos_data.DataSource = db.consultarGrid(query).DataSource;
            equipos_data.Columns[0].Visible = false;
            idequipos = new int[equipos_data.RowCount];
            for (int i = 0; i < equipos_data.RowCount; i++)
            {
                idequipos[i] = Convert.ToInt32(equipos_data.Rows[i].Cells[0].Value);
            }
            total_eq_lbl.Text += " " + equipos_data.RowCount;
            query = "select generado from campeonato where idcampeonato = " + idtorneo;
            System.Collections.ArrayList a = db.consultar(query);
            foreach (Dictionary<string, string> d in a)
            {
                if (d["generado"] == "0")
                {
                    calendario_panel.Visible = false;
                }
                else
                {
                    generar_btn.Visible = false;
                    info_lbl.Visible = false;
                    consultar_calendario();
                }
            }

            System.Collections.ArrayList array = db.consultar("select nombre from campeonato");
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (Dictionary<string, string> d in array)
            {
                torneo_cmb.Items.Add(d["nombre"]);
            }
            
        }

        private void generar_btn_Click(object sender, EventArgs e)
        {
            combinar();
            MessageBox.Show("¡Calendario generado éxitosamente!");
        }

        private void combinar()
        {
            bool impar = false;
            calendario_panel.Visible = true;
            generar_btn.Visible = false;
            info_lbl.Visible = false;
            int total = equipos_data.RowCount;
            if ((total % 2) == 1)
            {
                total++;
                impar = true;
            }
            Combinaciones cm = new Combinaciones();
            int f, c;
            int[,] matriz;
            cm.combinar(total, out f, out c, out matriz);

// Sustituyendo nombres de equipos           
            string[,] nombres = new string[f, c];
            for (int k = 1; k <= idequipos.Length; k++)
            {
                for (int i = 0; i < f; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        if (matriz[i, j] == k)
                        {
                            if (impar && k == total)
                            {
                                matriz[i, j] = 0;
                                nombres[i, j] = "";
                            }
                            else
                            {
                                matriz[i, j] = idequipos[k - 1];
                                Console.WriteLine(matriz[i, j].ToString());
                                nombres[i, j] = equipos_data.Rows[k - 1].Cells[1].Value.ToString();
                            }
                        }
                        //Console.Write(matriz[i, j]);
                    }
                    //Console.Write("\n");
                }
            }

//Dividir partidos en parejas
            int tam = f * (c / 2);
            int co = 0;
            int[,] mb = new int[2, tam];
            string[,] nb = new string[2, tam];
            for (int j = 0; j < c; j += 2)            
            {
                for (int i = 0; i < f; i++)
                {
                    mb[0, co] = matriz[i, j];
                    mb[1, co] = matriz[i, j + 1];
                    nb[0, co] = nombres[i, j];                    
                    nb[1, co] = nombres[i, j + 1];
                    co++;
                }
                
            }
            int arbitro = 1;
            int cancha = 1;
            int ronda = 1;
            DateTime fecha = DateTime.Today;
//Dividir por jornadas
            co = 0;
            int medio = total / 2;
            int mas = medio + 1;
            calendario_grid.ColumnCount = 3;
            calendario_grid.RowCount = (f * (c/2))+(c/2);
            int jornada = 0;            
            for (int i = 0; i < calendario_grid.RowCount; i++)
            {
                if (i == 0)
                {
                    calendario_grid.Rows[i].Cells[0].Value = "Jornada "+(jornada+1);
                    calendario_grid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    calendario_grid.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    for (int j = 1; j <= 2; j++)
                    {
                        calendario_grid.Rows[i].Cells[j].Value = "";
                    }
                    jornada++;
                }
                else if (((mas * jornada) / (i + 1)) == 0)
                {
                    calendario_grid.Rows[i].Cells[0].Value = "Jornada " + (jornada + 1);
                    calendario_grid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    calendario_grid.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    for (int j = 1; j <= 2; j++)
                    {
                        calendario_grid.Rows[i].Cells[j].Value = "";
                    }
                    jornada++;
                    arbitro = 1;
                    cancha = 1;
                    fecha = fecha.AddDays(7);
                }
                else
                {                    
                    calendario_grid.Rows[i].Cells[0].Value = nb[0, co];
                    calendario_grid.Rows[i].Cells[1].Value = "-";
                    if (nb[1, co] == "")
                    {
                        nb[1, co] = "Descanso";
                    }
                    calendario_grid.Rows[i].Cells[2].Value = nb[1, co];
                    //calendario_grid.Rows[i].Cells[3].Value = mb[0, co];
                    //calendario_grid.Rows[i].Cells[4].Value = mb[1, co];
                    
//Inserción base de datos
                    string tabla = "partido";
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("idcampeonato", idtorneo.ToString());
                    dict.Add("idarbitro", arbitro.ToString());
                    dict.Add("idcancha", cancha.ToString());
                    dict.Add("idronda", ronda.ToString());
                    dict.Add("fecha", fecha.ToString());
                    db.insertar(tabla, dict);
                    arbitro++;
                    cancha++;

                    int idpartido = 0;
                    System.Collections.ArrayList tor = db.consultar("select max(idpartido) as 'siguiente' from partido");
                    foreach (Dictionary<string, string> d in tor)
                    {
                        idpartido = Convert.ToInt32(d["siguiente"]);
                    }

                    Console.WriteLine(idpartido.ToString());

                    tabla = "detalle_partido";
                    dict = new Dictionary<string, string>();
                    dict.Add("idpartido", idpartido.ToString());
                    dict.Add("idequipo", mb[0, co].ToString());
                    dict.Add("localia", "1");
                    db.insertar(tabla, dict);

                    dict = new Dictionary<string, string>();
                    dict.Add("idpartido", idpartido.ToString());
                    dict.Add("idequipo", mb[1, co].ToString());
                    dict.Add("localia", "0");
                    db.insertar(tabla, dict);

                    tabla = "campeonato";
                    dict = new Dictionary<string, string>();
                    dict.Add("generado", "1");
                    string condicion = "idcampeonato = " + idtorneo;
                    db.actualizar(tabla, dict, condicion);

                    co++;
                }                
            }

        }

        /*
         Dim Sql As String
                    Sql = "select e.id_equipo,e.nombre as Visitante,d.punteo, de.punteo, eq.id_equipo, eq.nombre as 'Local',e.logo,eq.logo "
                    Sql += "from equipo e, equipo eq, detalle_partido d, detalle_partido de "
                    Sql += "where de.partido = d.partido and d.partido = " + p(z).ToString + " and "
                    Sql += "d.equipo=e.id_equipo and de.equipo=eq.id_equipo and de.localia=1 and d.localia=2;"          
         */

        private void consultar_calendario()
        {
            int total = equipos_data.RowCount;
            if ((total % 2) == 1)
            {
                total++;
            }
            int medio = (total / 2)+1;
            string query = "select p.idpartido as 'idpartido', d.idequipo,e.nombre as 'nombre', d.goles as 'goles',d.localia,p.ingresado as 'ingresado' from detalle_partido d, equipo e, partido p where e.idequipo=d.idequipo";
            query += " and p.idpartido = d.idpartido and p.idcampeonato = "+idtorneo;
            System.Collections.ArrayList array = db.consultar(query);
            int c = 0;
            int r = 0;
            int j = 0;
            int t = (array.Count/2) + ((array.Count/2)/(total/2));
            Console.WriteLine((array.Count/2)/(total/2));
            calendario_grid.RowCount = t;
            calendario_grid.ColumnCount = 7;
            calendario_grid.Columns[2].Width = 20;
            calendario_grid.Columns[6].Visible = false;
            foreach (Dictionary<string, string> d in array)
            {
                if (r == 0)
                {
                    calendario_grid.Rows[r].Cells[0].Value = "Jornada " + (j + 1);
                    calendario_grid.Rows[r].DefaultCellStyle.BackColor = Color.Red;
                    calendario_grid.Rows[r].DefaultCellStyle.ForeColor = Color.White;
                    j++;
                    r++;
                }
                
                else if ((medio * j) == r)
                {
                    Console.WriteLine((medio * j));
                    calendario_grid.Rows[r].Cells[0].Value = "Jornada " + (j + 1);
                    calendario_grid.Rows[r].DefaultCellStyle.BackColor = Color.Red;
                    calendario_grid.Rows[r].DefaultCellStyle.ForeColor = Color.White;
                    j++;
                    r++;
                }
                
                if ((c % 2) == 0)
                {
                    calendario_grid.Rows[r].Cells[0].Value = d["nombre"];
                    calendario_grid.Rows[r].Cells[1].Value = d["goles"];
                    calendario_grid.Rows[r].Cells[2].Value = "-";                    
                }
                else
                {
                    calendario_grid.Rows[r].Cells[4].Value = d["nombre"];
                    calendario_grid.Rows[r].Cells[3].Value = d["goles"];
                    DataGridViewButtonCell btncl = new DataGridViewButtonCell();
                    if(d["ingresado"]== "1"){
                        btncl.Value = "Ver ficha";
                    }else{
                        btncl.Value = "Ingresar resultado";
                    }
                    calendario_grid.Rows[r].Cells[5] = btncl;
                    calendario_grid.Rows[r].Cells[6].Value = d["idpartido"];
                    r++;                    
                }
                c++;
            }


           
        }

        private void torneo_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = torneo_cmb.SelectedItem.ToString();
            System.Collections.ArrayList a = db.consultar("select idcampeonato,nombre from campeonato where nombre = '"+text +"'");
            foreach (Dictionary<string, string> d in a)
            {
                idtorneo =Convert.ToInt32(d["idcampeonato"]);
                torneo_lbl.Text = "Torneo: "+ d["nombre"];
            }
            Partidos_Load(sender, e);
        }

        private void calendario_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == calendario_grid.ColumnCount - 2)
            {
                int i =Convert.ToInt32(calendario_grid.Rows[e.RowIndex].Cells[calendario_grid.ColumnCount - 1].Value);
                if (calendario_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Ingresar resultado")
                {
                    new Ficha_partido(i).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Cambiando");
                }
            }
        }

        

    }
}
