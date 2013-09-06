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
    public partial class Insertar_varios : Form
    {
        public Insertar_varios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect(Properties.Settings.Default.ruta);
            string tabla = "jugador";
            Dictionary<string, string> dict;
            for (int i = 1; i < 100; i++)
            {
                dict = new Dictionary<string, string>();
                dict.Add("nombre", "jugador" + i);
                db.insertar(tabla, dict);
            }
        }
    }
}
