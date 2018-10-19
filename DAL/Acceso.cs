using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    internal class Acceso
    {

        const string cadena = @"Initial Catalog=chinchon; Data Source=LAPTOP-PFG7Q0F8\SQLEXPRESS; Integrated SEcurity=SSPI";
        //const string cadena = @"Initial Catalog=chinchon; Data Source=.\SQL_UAI; Integrated SEcurity=SSPI";



        private SqlConnection conexion;
        private SqlTransaction Transaccion;

        public void Abrir()
        {
            conexion = new SqlConnection(cadena);
            conexion.Open();
        }
        public void Cerrar()
        {
            conexion.Close();
            conexion = null;
        }
        public void IniciarTx()
        {
            if (Transaccion == null)
            {
                Transaccion = conexion.BeginTransaction();
            }
        }
        public void Confirmar()
        {
            Transaccion.Commit();
            Transaccion = null;
        }
        public void Cancelar()
        {
            Transaccion.Rollback();
            Transaccion = null;
        }



        public SqlParameter CrearParametro(string nombre, string valor)
        {
            SqlParameter p = new SqlParameter(nombre, valor);
            p.DbType = DbType.String;
            return p;
        }

        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter p = new SqlParameter(nombre, valor);
            p.DbType = DbType.Int32;
            return p;
        }

        public SqlParameter CrearParametro(string nombre, float valor)
        {
            SqlParameter p = new SqlParameter(nombre, valor);
            p.DbType = DbType.Single;
            return p;
        }

        private SqlCommand CrearComando(string nombreSP, List<SqlParameter> parametros)
        {
            SqlCommand comando = new SqlCommand(nombreSP, conexion);
            if (parametros != null && parametros.Count > 0)
            {
                comando.Parameters.AddRange(parametros.ToArray());
            }
            if (Transaccion != null)
            {
                comando.Transaction = Transaccion;
            }
            comando.CommandType = CommandType.StoredProcedure;
            return comando;

        }

        public DataTable Leer(string nombreSP, List<SqlParameter> parametros)
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = CrearComando(nombreSP, parametros);
            adaptador.Fill(tabla);
            adaptador = null;
            GC.Collect();
            return tabla;
        }

        public int Escribir(string nombreSP, List<SqlParameter> parametros)
        {
            SqlCommand comando = CrearComando(nombreSP, parametros);
            int fa = 0;
            try
            {
                fa = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                fa = -1;
            }
            comando.Parameters.Clear();
            comando = null;
            GC.Collect();
            return fa;
        }

        public int LeerEscalar(string nombreSP, List<SqlParameter> parametros)
        {

            SqlCommand comando = CrearComando(nombreSP, parametros);
            int fa = 0;
            try
            {
                fa = int.Parse(comando.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                fa = -1;
            }
            comando = null;
            GC.Collect();
            return fa;
        }

    }
}
