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

        //BE.Jugador jugador1;
        //BE.Jugador jugador2;
        BLL.Mazo mazoAction;
        BE.Mazo mazo = new BE.Mazo();
        BE.Descarte descarte = new BE.Descarte();
        BE.Turno turno = new BE.Turno();
        BLL.Turno turnoAction = new BLL.Turno();
        BLL.Jugador jugadorAction = new BLL.Jugador();
        BLL.Punto puntoAction = new BLL.Punto();
        PictureBox[] manoImagenes = new PictureBox[8];

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //jugador1 = new BE.Jugador();
            //jugador1.ID = 8;
            //jugador1.USUARIO = "test pepe";
            //jugador2 = new BE.Jugador();
            //jugador2.ID = 9;
            //jugador2.USUARIO = "test Negrito";
            //turno.JUGADORES.Add(jugador1);
            //turno.JUGADORES.Add(jugador2);
            //mazo.CARTAS = mazoAction.PruebaFuncionamiento().ToList();  //sin base de datos

            mazoAction = new BLL.Mazo();
            mazo.CARTAS = mazoAction.LlenarMazo().ToList();

            mazoAction.Repartir(turno, mazo, jugadorAction);

            turno.INDICE = 0;

            descarte.CARTAS.RemoveRange(0, descarte.CARTAS.Count());

            button1.Enabled = false;
            btnRobar.Enabled = true;
            imgMazo.Enabled = true;
            btnRobarDes.Enabled = true;
            imgDescarte.Enabled = true;
            btnDescartar.Enabled = false;
            btnCortar.Enabled = false;
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
                MessageBox.Show("No hay cartas en el descarte, por favor robá del mazo");
            }
            else
            {
                changeBtnEnable();
                enlazar();
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
            ((Control)this.tabGame).Enabled = false;
            btnDescartar.Enabled = false;
            btnRobar.Enabled = false;
            imgMazo.Enabled = false;
            btnRobarDes.Enabled = false;
            imgDescarte.Enabled = false;
            btnCortar.Enabled = false;
            imgMazo.Image = Image.FromFile("..\\..\\img\\back.jpg");

            manoImagenes[0] = mano1;
            manoImagenes[1] = mano2;
            manoImagenes[2] = mano3;
            manoImagenes[3] = mano4;
            manoImagenes[4] = mano5;
            manoImagenes[5] = mano6;
            manoImagenes[6] = mano7;
            manoImagenes[7] = mano8;


            mostrarPuntajesTotales();
        }

        private void changeBtnEnable()
        {
            btnDescartar.Enabled = !btnDescartar.Enabled;
            btnRobar.Enabled = !btnRobar.Enabled;
            btnRobarDes.Enabled = !btnRobarDes.Enabled;
            btnCortar.Enabled = !btnCortar.Enabled;
            imgMazo.Enabled = !imgMazo.Enabled;
            imgDescarte.Enabled = !imgDescarte.Enabled;
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
            labelId.Text = turno.JUGADORATUAL.USUARIO.ToString();

            int i = 0;
            foreach (BE.Carta carta in turno.JUGADORATUAL.MANO.CARTAS)
            {
                manoImagenes[i].Image = Image.FromFile("..\\..\\img\\"+carta.PALO+ "\\" + carta.NUMERO + ".jpg");
                i++;
            }
        }

        void enlazarMazo()
        {
            listMazo.DataSource = null;
            listMazo.DataSource = mazo.CARTAS;
            listMazo.DisplayMember = "REVERSO";
        }

        void enlazarDescarte()
        {
            if(descarte.CARTAS.Count() > 0)
            {
                imgDescarte.Image = null;
                imgDescarte.Image = Image.FromFile("..\\..\\img\\" + descarte.CARTAS.First().PALO + "\\" + descarte.CARTAS.First().NUMERO + ".jpg");
            }
            else
            {
                imgDescarte.Image = null;
            }


            listDescarte.DataSource = null;
            listDescarte.DataSource = descarte.CARTAS;
        }

        void desEnlazarImagenesMano()
        {
            for (int i=0; i<8; i++ )
            {
                manoImagenes[i].Image = null;
            }
        }

        void enlazar()
        {
            desEnlazarImagenesMano();
            enlazarMazo();
            enlazarDescarte();
            enlazarJugadores();
            enlazarJugador();
           
        }


        #endregion

        private void btnCortar_Click(object sender, EventArgs e)
        {
            //Carta con la que corta
                BE.Carta carta = (BE.Carta)listMano.SelectedItem;

            if (jugadorAction.cortar(turno.JUGADORATUAL, carta))
            {
                MessageBox.Show("CORTASTE");
                puntoAction.cortarPartida(turno);
                FinalizarPartida();
            }
            else
            {
                MessageBox.Show("No seas pillo, no podes cortar");
            }


        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(turno.JUGADORES.Count() > 3)
            {
                MessageBox.Show("La cantidad Maxima de jugadores es 4");

            }
            else
            {
                if (jugadorAction.login(txtUser.Text, txtPass.Text, turno))
                {
                    MessageBox.Show("Jugador agregado a la partida");
                    txtUser.Text = "";
                    txtPass.Text = "";
                }
                else
                {
                    MessageBox.Show("Jugador NO agregado a la partida");
                }

                if (turno.JUGADORES.Count() > 1)
                {
                    ((Control)this.tabGame).Enabled = true;
                }
            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (jugadorAction.crear(txtCrearUser.Text, txtCrearPass.Text))
            {
                MessageBox.Show("Jugador Creado a la partida");
                txtUser.Text = txtCrearUser.Text;
                txtPass.Text = txtCrearPass.Text;
            }
            else
            {
                MessageBox.Show("Tuvimos un problema por favor intentelo más tarde");

            }
        }

        private void tabLogin_Click(object sender, EventArgs e)
        {

        }

        private void tabGame_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void imgMazo_Click(object sender, EventArgs e)
        {
            jugadorAction.robarDelMazo(mazo, turno.JUGADORATUAL);
            changeBtnEnable();
            enlazar();
        }

        private void imgDescarte_Click(object sender, EventArgs e)
        {
            bool pudoRobar = false;
            pudoRobar = jugadorAction.robarDelDescarte(descarte, turno.JUGADORATUAL);

            if (pudoRobar)
            {
                MessageBox.Show("No hay cartas en el descarte, por favor robá del mazo");
            }
            else
            {
                changeBtnEnable();
                enlazar();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("La partida aun no ha terminado, Queres finalizarla?", "FINALIZAR PARTIDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FinalizarPartida();
            }
        }

        private void FinalizarPartida()
        {
            button1.Enabled = true;
            btnRobar.Enabled = false;
            imgMazo.Enabled = false;
            btnRobarDes.Enabled = false;
            imgDescarte.Enabled = false;
            btnDescartar.Enabled = false;
            btnCortar.Enabled = false;
            descarte.CARTAS.RemoveRange(0, descarte.CARTAS.Count());
            turno.JUGADORATUAL.MANO.CARTAS.RemoveRange(0, turno.JUGADORATUAL.MANO.CARTAS.Count());
            enlazar();
        }

        private void mostrarPuntajesTotales()
        {

            gridPuntos.DataSource = jugadorAction.ListarTodos();
            this.gridPuntos.Columns["ID"].Visible = false;
            this.gridPuntos.Columns["MANO"].Visible = false;
            this.gridPuntos.Columns["PUNTOSPARTIDA"].Visible = false;
        }
    }


}

