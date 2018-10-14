using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Mazo
    {

        private List<Carta> cartas;

        public List<Carta> CARTAS
        {
            get { return cartas; }
            set { cartas = value; }
        }
    }
}
