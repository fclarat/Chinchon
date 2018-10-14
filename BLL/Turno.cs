using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Turno
    {
        public BE.Jugador SiguienteTurno(BE.Turno turno)
        {
            turno.INDICE++;
            if (turno.INDICE >= turno.JUGADORES.Count)
            {
                turno.INDICE = 0;
            }

            return turno.JUGADORATUAL;

        }

    }
}
