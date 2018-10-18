using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Descarte
    {
        private List<Carta> cartas = new List<Carta>();

        public List<Carta> CARTAS
        {
            get { return cartas; }
            set { cartas = value; }
        }

    }
}
