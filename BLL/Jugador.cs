using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Jugador
    {
        public bool robarDelMazo(BE.Mazo mazo, BE.Jugador jug)
        {
            bool error = false;

            if (mazo.CARTAS.Count() >= 1)
            {
                jug.MANO.CARTAS.Add(mazo.CARTAS[0]);
                mazo.CARTAS.RemoveAt(0);
                jug.MANO.CARTAS = this.ordenarMano(jug.MANO.CARTAS);
            } 
            else
            {
                error = true;
            }

            //Todo mezclar descarte en el mazo?
            return error;

        }

        public bool robarDelDescarte(BE.Descarte des, BE.Jugador jug)
        {
            bool error = false;

            if (des.CARTAS.Count() >= 1 )
            {
                jug.MANO.CARTAS.Add(des.CARTAS[0]);
                des.CARTAS.RemoveAt(0);
            }
            else
            {
                error = true;
            }

            return error;

        }

        public void descartarCarta(BE.Descarte des, BE.Jugador jug, BE.Carta carta)
        {

            jug.MANO.CARTAS.Remove(carta);
            des.CARTAS.Add(carta);
        }

        private List<BE.Carta> ordenarMano(List<BE.Carta> cartas)
        {
            return cartas.OrderBy(x => x.PALO).ThenBy(x => x.NUMERO).ToList();

        }

        public bool cortar (BE.Jugador jug, BE.Carta carta)
        {
            bool cortarValido = false;


            List<BE.Carta> manoAux = jug.MANO.CARTAS;
            manoAux.Remove(carta);

            manoAux = this.Pierna(manoAux);
            manoAux = this.Escalera(manoAux);

            if(manoAux.Count() <= 1 )
            {
                cortarValido = true;
            }

            return cortarValido;
        }

        private List<BE.Carta> verificarPorNumero(List<BE.Carta> manoAux)
        {
            List<BE.Carta> cartasIguales = new List<BE.Carta>();

            foreach (BE.Carta carta in manoAux)
            {
                var cartasIgualesAux = (from BE.Carta c in manoAux
                                     where c.NUMERO.Equals(carta.NUMERO)
                                     select c).ToList();

                if (cartasIgualesAux.Count().Equals(4) || cartasIgualesAux.Count().Equals(3))
                {
                    cartasIguales = cartasIgualesAux;
                    break;
                }

            }

            return cartasIguales;
        }

        private List<BE.Carta> Pierna(List<BE.Carta> cartas)
        {
            List<BE.Carta> cartasASacar = this.verificarPorNumero(cartas);

            if (cartasASacar.Count() > 1)
            {
                foreach (BE.Carta carta in cartasASacar)
                {
                    cartas.Remove(carta);
                }

                cartasASacar = this.verificarPorNumero(cartas);
                foreach (BE.Carta carta in cartasASacar)
                {
                    cartas.Remove(carta);
                }
            }

            return cartas;
        }


        private List<BE.Carta> VerificarEscalera(List<BE.Carta> manoAux, string palo)
        {
            List<BE.Carta> cartasIguales = new List<BE.Carta>();

            List<BE.Carta> cartasIgualesAux = (from BE.Carta c in manoAux
                             where c.PALO.Equals(palo)
                                     select c)
                                 .OrderBy(x => x.NUMERO)
                                 .ToList();

            if (cartasIgualesAux.Count().Equals(7))
            {
                if (cartasIgualesAux[6].NUMERO == cartasIgualesAux[0].NUMERO + 6)
                {
                    cartasIguales = cartasIgualesAux;
                }
            }
            if (cartasIgualesAux.Count().Equals(4))
            {
                if (cartasIgualesAux[3].NUMERO == cartasIgualesAux[0].NUMERO + 3)
                {
                    cartasIguales = cartasIgualesAux;
                }
            }
            if (cartasIgualesAux.Count().Equals(3))
            {
                if (cartasIgualesAux[2].NUMERO == cartasIgualesAux[0].NUMERO + 2)
                {
                    cartasIguales = cartasIgualesAux;
                }
            }

            return cartasIguales;

        }

        private List<BE.Carta> Escalera(List<BE.Carta> cartas)
        {
            //Puede tener como máximo 2 escaleras del mismo palo. 

            string[] palos = { "Copa", "Basto", "Espada", "Oro" };
            foreach(string palo in palos)
            {
                List<BE.Carta> cartasASacar = this.VerificarEscalera(cartas, palo);

                if (cartasASacar.Count() > 1)
                {
                    foreach (BE.Carta carta in cartasASacar)
                    {
                        cartas.Remove(carta);
                    }

                    cartasASacar = this.VerificarEscalera(cartas, palo);
                    foreach (BE.Carta carta in cartasASacar)
                    {
                        cartas.Remove(carta);
                    }
                }
            }

            return cartas;
        }

    }
}
