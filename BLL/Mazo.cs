using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Mazo
    {

        public List<BE.Carta> ShuffleDeck(List<BE.Carta> cartas)
        {
            var list = cartas;
            var randomizedList = new List<BE.Carta>();
            var rnd = new Random();
            while (list.Count != 0)
            {
                var index = rnd.Next(0, list.Count);
                randomizedList.Add(list[index]);
                list.RemoveAt(index);
            }

            return randomizedList;
        }

        public void Repartir(BE.Turno turno, BE.Mazo mazo)
        {

            foreach(BE.Jugador jug in turno.JUGADORES)
            {
                for(int i=0; i < 7; i++)
                {
                    jug.MANO.CARTAS.Add(mazo.CARTAS[0]);
                    mazo.CARTAS.RemoveAt(0);

                }
            }
            

        }

        public List<BE.Carta> PruebaFuncionamiento()
        {
            //TODO: sacar esto de la base de datos
            List<BE.Carta> cartas = new List<BE.Carta>();
            BE.Carta carta1 = new BE.Carta();
            carta1.ID = 1;
            carta1.PALO = "Copa";
            carta1.NUMERO = 1;
            BE.Carta carta2 = new BE.Carta();
            carta2.ID = 2;
            carta2.PALO = "Copa";
            carta2.NUMERO = 2;
            BE.Carta carta3 = new BE.Carta();
            carta3.ID = 3;
            carta3.PALO = "Copa";
            carta3.NUMERO = 3;
            BE.Carta carta4 = new BE.Carta();
            carta4.ID = 20;
            carta4.PALO = "Basto";
            carta4.NUMERO = 20;
            BE.Carta carta5 = new BE.Carta();
            carta5.ID = 21;
            carta5.PALO = "Basto";
            carta5.NUMERO = 21;
            BE.Carta carta6 = new BE.Carta();
            carta6.ID = 38;
            carta6.PALO = "Basto";
            carta6.NUMERO = 38;
            BE.Carta carta7 = new BE.Carta();
            carta7.ID = 40;
            carta7.PALO = "Basto";
            carta7.NUMERO = 40;
            cartas.Add(carta1);
            cartas.Add(carta2);
            cartas.Add(carta3);
            cartas.Add(carta4);
            cartas.Add(carta5);
            cartas.Add(carta6);
            cartas.Add(carta6);
            cartas.Add(carta7);
            cartas.Add(carta7);
            cartas.Add(carta2);
            cartas.Add(carta2);
            cartas.Add(carta2);
            cartas.Add(carta1);
            cartas.Add(carta1);
            cartas.Add(carta1);
            cartas.Add(carta4);
            cartas.Add(carta4);
            cartas.Add(carta5);

            cartas = this.ShuffleDeck(cartas);

            return cartas;
        }
    }
}
