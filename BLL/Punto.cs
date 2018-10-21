using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Punto
    {
        public void cortarPartida(BE.Turno turno)
        {
            foreach (BE.Jugador jug in turno.JUGADORES)
            {
                if(jug == turno.JUGADORATUAL)
                {
                    //todo ver si corto con mano entera o no
                    turno.JUGADORATUAL.PUNTOSPARTIDA -= 10;
                }
                else
                {
                    jug.PUNTOSPARTIDA += this.SumarPuntosMano(jug);
                    if (jug.PUNTOSPARTIDA > 100)
                    {
                        // termianar partida actual y sumar puntos historicos y guardar en la db
                    }
                }
            }
        }


        private int SumarPuntosMano(BE.Jugador jug)
        {
            int total = 0;

            foreach (BE.Carta carta in jug.MANO.CARTAS)
            {
                if(carta.NUMERO <= 9)
                {
                    total += carta.NUMERO;
                }
                else
                {
                    total += 10;
                }
            }

            return total;
        }



    }
}
