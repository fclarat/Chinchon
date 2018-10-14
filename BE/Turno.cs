using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Turno
    {
        private int indice;

        public int Indice
        {
            get { return indice; }
            set { indice = value; }
        }


        public Jugador JugadorActual
        {
            get { return jugadores[indice]; }

        }


        private List<Jugador> jugadores = new List<Jugador>();

        public List<Jugador> Jugadores
        {
            get { return jugadores; }

        }
    }
}
