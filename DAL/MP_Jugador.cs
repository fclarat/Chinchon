using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MP_Jugador
    {

        Acceso acceso = new Acceso();


        public BE.Jugador IngresarUsuario(string user, string pass)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@usuario", user));
            parametros.Add(acceso.CrearParametro("@pass", pass));
            DataTable tabla = acceso.Leer("loguear_usuario", parametros);
            acceso.Cerrar();
            BE.Jugador jug = null;
            foreach (DataRow registro in tabla.Rows)
            {
                jug = new BE.Jugador();
                jug.ID = int.Parse(registro["id_user"].ToString());
                jug.USUARIO = registro["usuario"].ToString();
            }

            return jug;
        }

        public int InsertarJugador(string user, string pass)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@usuario", user));
            parametros.Add(acceso.CrearParametro("@pass", pass));
            acceso.Abrir();
            int fa = acceso.Escribir("insertar_usuario", parametros);
            acceso.Cerrar();
            return fa;
        }

        public int sumarPuntosYPartida(int id, int puntos)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id", id));
            parametros.Add(acceso.CrearParametro("@puntos", puntos));
            acceso.Abrir();
            int fa = acceso.Escribir("actualizar_puntos_partidas", parametros);
            acceso.Cerrar();
            return fa;
        }

        public List<BE.Jugador> listarJugadores()
        {
            List<BE.Jugador> jugadores = new List<BE.Jugador>();
            
            acceso.Abrir();
            DataTable tabla = acceso.Leer("listar_usuarios", null);
            acceso.Cerrar();
            
            foreach (DataRow registro in tabla.Rows)
            {
                BE.Jugador jug = null;
                jug = new BE.Jugador();
                jug.ID = int.Parse(registro["id_user"].ToString());
                jug.USUARIO = registro["usuario"].ToString();
                jug.PUNTOSHISTORICOS = Int32.Parse(registro["puntos"].ToString());
                jug.PARTIDASJUGADAS = Int32.Parse(registro["partidas_jugadas"].ToString());

                jugadores.Add(jug);
            }

            return jugadores;
        }

    }
}
