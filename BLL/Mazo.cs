using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Mazo
    {
        DAL.MP_Carta mp_carta = new DAL.MP_Carta();

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

        public void Repartir(BE.Turno turno, BE.Mazo mazo, BLL.Jugador jugAction)
        {

            foreach(BE.Jugador jug in turno.JUGADORES)
            {
                for(int i=0; i < 7; i++)
                {
                    jugAction.robarDelMazo(mazo, jug);

                    //Update
                    //jug.MANO.CARTAS.Add(mazo.CARTAS[0]);
                    //mazo.CARTAS.RemoveAt(0);

                }
            }
            

        }

        public List<BE.Carta> LlenarMazo()
        {
            List<BE.Carta> cartas = new List<BE.Carta>();

            cartas = mp_carta.Listar();

            cartas = this.ShuffleDeck(cartas);
            return cartas;
        }

        public List<BE.Carta> PruebaFuncionamiento()
        {
           

            List<BE.Carta> cartas = new List<BE.Carta>();
            int id = 1;
            for(int i = 1; i < 13; i++)
            {
                BE.Carta carta = new BE.Carta();
                carta.ID = id;
                carta.PALO = "Copa";
                carta.NUMERO = i;

                id++;
                cartas.Add(carta);
            }
            for (int i = 1; i < 13; i++)
            {
                BE.Carta carta = new BE.Carta();
                carta.ID = id;
                carta.PALO = "Basto";
                carta.NUMERO = i;

                id++;
                cartas.Add(carta);
            }
            for (int i = 1; i < 13; i++)
            {
                BE.Carta carta = new BE.Carta();
                carta.ID = id;
                carta.PALO = "Espada";
                carta.NUMERO = i;

                id++;
                cartas.Add(carta);
            }
            for (int i = 1; i < 13; i++)
            {
                BE.Carta carta = new BE.Carta();
                carta.ID = id;
                carta.PALO = "Oro";
                carta.NUMERO = i;

                id++;
                cartas.Add(carta);
            }



            cartas = this.ShuffleDeck(cartas);
            return cartas;
        }
    }
}
