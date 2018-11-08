using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class MP_Carta
    {
        Acceso acceso = new Acceso();

        public List<BE.Carta> Listar()
        {
            List<BE.Carta> cartas = new List<BE.Carta>();
            acceso.Abrir();
            DataTable tabla = acceso.Leer("ListarCartas", null);
            acceso.Cerrar();
            foreach (DataRow registro in tabla.Rows)
            {
                BE.Carta carta = new BE.Carta();
                carta.ID = int.Parse(registro["id"].ToString());
                carta.NUMERO = int.Parse(registro["numero"].ToString());
                carta.PALO = registro["paloNombre"].ToString();
                cartas.Add(carta);
            }


            return cartas;
        }



    }
}
