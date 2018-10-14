using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Mano
    {
        private List<Carta> _cartas;

        public List<Carta> Cartas
        {
            get { return _cartas; }
            set { _cartas = value; }
        }
    }
}
