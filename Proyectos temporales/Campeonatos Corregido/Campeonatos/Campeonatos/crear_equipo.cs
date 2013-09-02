// AUTOR: EDWIN OTTONIEL RODRIGUEZ TAYLOR
// 0901-07-1527
// FORM QUE CREA EQUIPOS


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
    public partial class crear_equipo : Form
    {
        DBConnect db = new DBConnect(Properties.Settings.Default.ruta);
        int id_equipo;
        
        string nombre, encargado, telefono;


        public crear_equipo()
        {
            InitializeComponent();
            
        }

        private void crear_equipo_Load(object sender, EventArgs e)
        {
            string query2 = "select idequipo as 'ID', nombre as 'Nombre', encargado as 'Entrenador', telefono as 'Telefono' from equipo ";
            bd_equipos_grid.DataSource = db.consultarGrid(query2).DataSource;
            bd_equipos_grid.Columns[0].Visible = false;
            bd_equipos_grid.CurrentCell = bd_equipos_grid[1, 0];
        }

        private void button_crear_equipo_Click(object sender, EventArgs e)
        {
            string tabla = "equipo";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("nombre", nombre_equipo_text.Text);
            dict.Add("encargado", encargado_text.Text);
            dict.Add("telefono", telefono_text.Text);

            db.insertar(tabla, dict);

            string query2 = "select idequipo as 'ID', nombre as 'Nombre', encargado as 'Entrenador', telefono as 'Telefono' from equipo ";
            bd_equipos_grid.DataSource = db.consultarGrid(query2).DataSource;
            bd_equipos_grid.Columns[0].Visible = false;

            nombre_equipo_text.Text = "";
            encargado_text.Text = "";
            telefono_text.Text = "";
        }

        private void grid_bd_equipos_Click(object sender, EventArgs e)
        {
            int rowIndex = bd_equipos_grid.CurrentCell.RowIndex;
            //int id_equipo;


            equipo_seleccionado_text.Text = bd_equipos_grid.Rows[rowIndex].Cells[1].Value.ToString();

            id_equipo =Convert.ToInt32(bd_equipos_grid.Rows[rowIndex].Cells[0].Value);
            encargado = bd_equipos_grid.Rows[rowIndex].Cells[2].Value.ToString();
            nombre = bd_equipos_grid.Rows[rowIndex].Cells[1].Value.ToString();
            telefono = bd_equipos_grid.Rows[rowIndex].Cells[3].Value.ToString();

            
        }

        private void button_ver_jugadores_Click(object sender, EventArgs e)
        {
            ficha_equipo f = new ficha_equipo(id_equipo, nombre, encargado, telefono);
            f.ShowDialog();
        }

        
    }
}
