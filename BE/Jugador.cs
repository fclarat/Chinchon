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



    }
}
