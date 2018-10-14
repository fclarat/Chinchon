using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Carta
    {

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string palo;

        public string PALO
        {
            get { return palo; }
            set { palo = value; }
        }

        private int numero;

        public int NUMERO
        {
            get { return numero; }
            set { numero = value; }
        }
    }
}
