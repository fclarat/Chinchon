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

        BE.Jugador jugador1;
        BE.Jugador jugador2;
        BLL.Mazo mazoAction;
        BE.Mazo mazo = new BE.Mazo();
        BE.Descarte descarte = new BE.Descarte();
        BE.Turno turno = new BE.Turno();
        BLL.Turno turnoAction = new BLL.Turno();
        BLL.Jugador jugadorAction = new BLL.Jugador();

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            jugador1 = new BE.Jugador();
            jugador1.ID = 1;
            jugador2 = new BE.Jugador();
            jugador2.ID = 2;
            mazoAction = new BLL.Mazo();
            mazo.CARTAS = mazoAction.PruebaFuncionamiento().ToList();


            turno.JUGADORES.Add(jugador1);
            turno.JUGADORES.Add(jugador2);

            mazoAction.Repartir(turno, mazo, jugadorAction);


            turno.INDICE = 0;


            btnRobar.Enabled = true;
            btnRobarDes.Enabled = true;
            btnDescartar.Enabled = false;
            enlazar();

        }


   

        private void btnRobar_Click(object sender, EventArgs e)
        {
            jugadorAction.robarDelMazo(mazo, turno.JUGADORATUAL);
            changeBtnEnable();
            enlazar();

        }

        private void btnRobarDes_Click(object sender, EventArgs e)
        {
            bool pudoRobar = false;
            pudoRobar = jugadorAction.robarDelDescarte(descarte, turno.JUGADORATUAL);

            if (pudoRobar)
            {
                changeBtnEnable();
                enlazar();
            }
            else
            {
                MessageBox.Show("No hay cartas en el descarte, por favor robá del mazo");
            }

        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            BE.Carta carta = (BE.Carta) listMano.SelectedItem;

            jugadorAction.descartarCarta(descarte, turno.JUGADORATUAL, carta);
            turnoAction.SiguienteTurno(turno);

            enlazar();
            changeBtnEnable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        #region LOAD y Enlazar
        private void Form1_Load(object sender, EventArgs e)
        {
            btnDescartar.Enabled = false;
            btnRobar.Enabled = false;
            btnRobarDes.Enabled = false;
        }

        private void changeBtnEnable()
        {
            btnDescartar.Enabled = !btnDescartar.Enabled;
            btnRobar.Enabled = !btnRobar.Enabled;
            btnRobarDes.Enabled = !btnRobarDes.Enabled;
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
            listMazo.DisplayMember = "REVERSO";
        }

        void enlazarDescarte()
        {
            listDescarte.DataSource = null;
            listDescarte.DataSource = descarte.CARTAS;
        }


        void enlazar()
        {
            enlazarMazo();
            enlazarDescarte();
            enlazarJugadores();
            enlazarJugador();
            labelId.Text = turno.JUGADORATUAL.ID.ToString();
        }


        #endregion

        private void btnCortar_Click(object sender, EventArgs e)
        {
            //Carta con la que corta
            BE.Carta carta = (BE.Carta)listMano.SelectedItem;

            if (jugadorAction.cortar(turno.JUGADORATUAL, carta))
            {
                MessageBox.Show("CORTASTE");
            }
            else
            {
                MessageBox.Show("No seas pillo, no podes cortar");
            }


        }
    }
}

