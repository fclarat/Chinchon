using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Turno
    {
        private int indice;

        public int INDICE
        {
            get { return indice; }
            set { indice = value; }
        }


        public Jugador JUGADORATUAL
        {
            get { return jugadores[indice]; }

        }


        private List<Jugador> jugadores = new List<Jugador>();

        public List<Jugador> JUGADORES
        {
            get { return jugadores; }

        }
    }
}
