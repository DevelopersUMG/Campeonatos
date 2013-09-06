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
    public partial class Seleccion_campeonato : Form
    {

        DBConnect db = new DBConnect(Properties.Settings.Default.ruta);
        private bool band = false;
        Estadisticas estad;

        public Seleccion_campeonato()
        {
            InitializeComponent();
        }

        public void estadistica(Estadisticas e)
        {
            band = true;
            this.estad = e;
        }

        private void Seleccion_campeonato_Load(object sender, EventArgs e)
        {
            string query = "select idcampeonato,nombre as 'Nombre' from campeonato";
            campeonato_dgw.DataSource = db.consultarGrid(query).DataSource;
            campeonato_dgw.Columns[0].Visible = false;
            //campeonato_dgw.CurrentCell = campeonato_dgw[0,1];
        }

        private void campeonato_dgw_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(campeonato_dgw.Rows[e.RowIndex].Cells[0].Value);
            string nom = campeonato_dgw.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (!band)
            {                
                Partidos par = new Partidos(id, nom);
                par.ShowDialog();
            }
            else
            {
                this.Close();
                estad.sele_campeonato(id, nom);                
            }
        }
    }
}
