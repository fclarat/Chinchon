using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Jugador
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string usuario;

        public string USUARIO
        {
            get { return usuario; }
            set { usuario = value; }
        }


        private Mano mano = new Mano();

        public Mano MANO
        {
            get { return mano; }
            set { mano = value; }
        }

        private int puntosPartida = 0;

        public int PUNTOSPARTIDA
        {
            get { return puntosPartida; }
            set { puntosPartida = value; }
        }

        private int puntosHistorico = 0;

        public int PUNTOSHISTORICOS
        {
            get { return puntosHistorico; }
            set { puntosHistorico = value; }
        }


        public override string ToString()
        {
            return this.USUARIO + ": " + this.puntosPartida;
        }

    }
}
