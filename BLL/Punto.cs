using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Punto
    {
        public bool cortarPartida(BE.Turno turno)
        {
            bool termino = false;

            foreach (BE.Jugador jug in turno.JUGADORES)
            {
                if (jug == turno.JUGADORATUAL)
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
                        SumarHistorico(turno.JUGADORES, jug);
                        termino = true;
                    }
                }
            }

            return termino;
        }

        private void SumarHistorico(List<BE.Jugador> jugadores ,BE.Jugador jugPerdedor)
        {
            DAL.MP_Jugador mpJugador = new DAL.MP_Jugador();

            foreach (BE.Jugador jugador in jugadores)
            {
                if (jugador == jugPerdedor)
                {
                    mpJugador.sumarPuntosYPartida(jugador.ID, 5);
                }
                else
                {
                    mpJugador.sumarPuntosYPartida(jugador.ID, 0);
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
