using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Jugador
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private Mano mano = new Mano();

        public Mano Mano
        {
            get { return mano; }
            set { mano = value; }
        }



    }
}
