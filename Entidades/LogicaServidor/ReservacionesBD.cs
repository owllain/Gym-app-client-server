using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.LogicaServidor
{
    public class ReservacionesBD
    {
        public static List<ReservaSesion> LeerReservaSesion(string id)
        {
            List<ReservaSesion> listaReservaSesion = new List<ReservaSesion>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;
            string cadenaConexion = ("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion = new SqlConnection(cadenaConexion);

            sentencia = " Select	IdReserva,    IdSede,	    IdCliente,	    Fecha" +
                           " From	    Reserva";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            conexion.Open();

            reader = comando.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if(id == reader["IdCliente"].ToString())
                    {
                        listaReservaSesion.Add(new ReservaSesion
                        {
                            IdReserva = reader.GetInt32(0),
                            IdSede = reader.GetInt32(1),
                            IdCliente = reader.GetString(2),
                            Fecha = reader.GetDateTime(3)

                        });
                    }
                   

                }
            }
            conexion.Close();
            return listaReservaSesion;
        }

        public static void RealizarReserva(ReservaSesion pReserva)
        {
            int Cupos = 0;
            //Se inicializa la conexión con la base de datos.
            SqlConnection conexion = new SqlConnection("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion.Open();

            //Se envian parametros para insertar en la tabla.
            string cadena = "Insert into [dbo].[Reserva](IdReserva,IdSede,IdCliente,Fecha) " +
                "values (@IdReserva,@IdSede,@IdCliente,@Fecha)";
            SqlCommand comando = new SqlCommand(cadena, conexion);

            //Creación de parametros
            comando.Parameters.Add("@IdReserva", SqlDbType.Int);
            comando.Parameters.Add("@IdSede", SqlDbType.Int);
            comando.Parameters.Add("@IdCliente", SqlDbType.VarChar);
            comando.Parameters.Add("@Fecha", SqlDbType.DateTime);

            //Asignación de valores
            comando.Parameters["@IdReserva"].Value = pReserva.IdReserva;
            comando.Parameters["@IdSede"].Value = pReserva.IdSede;
            comando.Parameters["@IdCliente"].Value = pReserva.IdCliente;
            comando.Parameters["@Fecha"].Value = pReserva.Fecha;

            Cupos = CupoActual(Convert.ToString(pReserva.IdSede));
            AplicarReserva(Convert.ToString(pReserva.IdSede), Cupos);
            comando.ExecuteNonQuery();
            conexion.Close();

        }

        #region Consulta del Registro
        public static List<string> SearchSedeAfiliado(string idcliente)
        {
            List<string> listaSedeAfiliado = new List<string>();
            string CadenaSede;
            bool CupoSede;
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader registro;
            string cadenaConexion = ("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion = new SqlConnection(cadenaConexion);

            sentencia = " Select	IdAfiliacion,    FechaAfiliacion,	    IdCliente,     IdSede" +
                        " From	    AfiliacionSede";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            conexion.Open();

            registro = comando.ExecuteReader();

            if (registro.HasRows)
            {

                while (registro.Read())
                {
                    if (idcliente == registro["IdCliente"].ToString())
                    {
                        CadenaSede = registro["IdSede"].ToString();
                        CupoSede = ValidarCupo(CadenaSede);

                        if (CupoSede == true)
                        {
                            if (!listaSedeAfiliado.Contains(CadenaSede))
                            {
                                listaSedeAfiliado.Add(CadenaSede);
                            }
                        }
                    }
                }
            }
            conexion.Close();
            return listaSedeAfiliado;
        }

        public static bool ValidarCupo(string CupoSede)
        {
            bool cupoExistente = false;
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;
            string cadenaConexion = ("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion = new SqlConnection(cadenaConexion);

            sentencia = " Select	IdSede,    FechaCupo,	    Cupos" +
                           " From	    CupoSede";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            conexion.Open();

            reader = comando.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (CupoSede == reader["IdSede"].ToString())
                    {
                        cupoExistente = true;
                    }
                }
            }

            conexion.Close();
            return cupoExistente;
        }

        public static void AplicarReserva(string IdSede, int CupoActual)
        {
            SqlConnection conexion = new SqlConnection("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            int CupoActualizado = CupoActual - 1;
            string sentencia = "Update CupoSede set Cupos = '" + CupoActualizado + "' Where IdSede = '" + IdSede + "'";
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public static int CupoActual(string IdSede)
        {
            int CupoActual = 0;
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;
            string cadenaConexion = ("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion = new SqlConnection(cadenaConexion);

            sentencia = " Select	IdSede,    FechaCupo,	    Cupos" +
                           " From	    CupoSede";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            conexion.Open();

            reader = comando.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (IdSede == reader["IdSede"].ToString())
                    {
                        CupoActual = Convert.ToInt32(reader["Cupos"].ToString());
                    }
                }
            }

            conexion.Close();
            return CupoActual;

        }

        #endregion

    }
}
