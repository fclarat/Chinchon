using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chinchon
{
    public partial class Form1 : Form
    {

        BE.Jugador jugador1;
        BE.Jugador jugador2;
        BLL.Mazo mazo;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jugador1 = new BE.Jugador();
            jugador2 = new BE.Jugador();
            mazo = new BLL.Mazo();

            mazo.PruebaFuncionamiento();


        }


        void enlazarJugadores()
        {

        }


        void enlazarMazo()
        {
            listMazo.DataSource = null;
            listMazo.DataSource = mazo;
            

        }

        private void listJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listMazo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
