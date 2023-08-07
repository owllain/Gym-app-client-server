using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.LogicaServidor
{
   public class CupoBD
    {
        public static void InsertCupo(CupoSede cupo)
        {
            //Se inicializa la conexión con la base de datos
            SqlConnection conexion = new SqlConnection("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion.Open();

            //Se envian parametros para insertar en la tabla.
            string cadena = "insert into CupoSede(IdSede,FechaCupo,Cupos) values (@IdSede,@FechaCupo,@Cupos)";
            SqlCommand comando = new SqlCommand(cadena, conexion);

            //Creación de parametros
            comando.Parameters.Add("@IdSede", SqlDbType.Int);
            comando.Parameters.Add("@FechaCupo", SqlDbType.DateTime);
            comando.Parameters.Add("@Cupos", SqlDbType.Int);

            //Asignación de valores
            comando.Parameters["@IdSede"].Value = cupo.IdSede;
            comando.Parameters["@FechaCupo"].Value = cupo.FechaCupo;
            comando.Parameters["@Cupos"].Value = cupo.Cupos;

            //Ejecución de los comandos
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public static List<CupoSede> LeerCupoSede()
        {
            List<CupoSede> listaCupoSede = new List<CupoSede>();
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
                    listaCupoSede.Add(new CupoSede
                    {
                        IdSede = reader.GetInt32(0),
                        FechaCupo = reader.GetDateTime(1),
                        Cupos = reader.GetInt32(2)

                    });
                }
            }
            conexion.Close();
            return listaCupoSede;
        }

        public static bool ValidarCupoSede(CupoSede cupo)
        {
            bool cupo_existente = false;
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
                    if((cupo.IdSede == Convert.ToInt32(reader["IdSede"].ToString())) && (cupo.FechaCupo == Convert.ToDateTime(reader["FechaCupo"])))
                    {

                            cupo_existente = true;
   
                    }


                }
            }
            conexion.Close();
            return cupo_existente;
        }

    }
}
