using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        BE.Jugador jugador1;
        BE.Jugador jugador2;
        BLL.Mazo mazoAction;
        BE.Mazo mazo = new BE.Mazo();
        BE.Descarte descarte = new BE.Descarte();
        BE.Turno turno = new BE.Turno();


        private void button1_Click(object sender, EventArgs e)
        {
            jugador1 = new BE.Jugador();
            jugador2 = new BE.Jugador();
            mazoAction = new BLL.Mazo();
            mazo.CARTAS = mazoAction.PruebaFuncionamiento().ToList();


            turno.JUGADORES.Add(jugador1);
            turno.JUGADORES.Add(jugador2);

            mazoAction.Repartir(turno, mazo);


            turno.INDICE = 0;

           
            enlazarMazo();
            enlazarJugadores();
            enlazarJugador();

        }


        void enlazarJugadores()
        {
            listJugadores.DataSource = null;
            listJugadores.DataSource = turno.JUGADORES;

        }

        void enlazarJugador()
        {
            listMano.DataSource = null;
            listMano.DataSource = turno.JUGADORATUAL.MANO.CARTAS;

        }



        void enlazarMazo()
        {
            listMazo.DataSource = null;
            listMazo.DataSource = mazo.CARTAS;


        }

    }
}

