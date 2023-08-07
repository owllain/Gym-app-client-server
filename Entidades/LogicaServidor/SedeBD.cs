using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.LogicaServidor
{
   public class SedeBD
    {
        public static void InsertSede(Sede sede)
        {
            //Se inicializa la conexión con la base de datos
            SqlConnection conexion = new SqlConnection("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion.Open();

            //Se envian parametros para insertar en la tabla.
            string cadena = "insert into Sede(IdSede,Nombre,Direccion,Estado,Telefono) values (@IdSede,@Nombre,@Direccion,@Estado,@Telefono)";
            SqlCommand comando = new SqlCommand(cadena, conexion);

            //Creación de parametros
            comando.Parameters.Add("@IdSede", SqlDbType.Int);
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar);
            comando.Parameters.Add("@Direccion", SqlDbType.VarChar);
            comando.Parameters.Add("@Estado", SqlDbType.Bit);
            comando.Parameters.Add("@Telefono", SqlDbType.VarChar);

            //Asignación de valores
            comando.Parameters["@IdSede"].Value = sede.IdSede;
            comando.Parameters["@Nombre"].Value = sede.Nombre;
            comando.Parameters["@Direccion"].Value = sede.Direccion;
            comando.Parameters["@Estado"].Value = sede.Estado;
            comando.Parameters["@Telefono"].Value = sede.Telefono;

            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public static List<Sede> SelectSede()
        {
            List<Sede> listaSede = new List<Sede>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;
            string cadenaConexion = ("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion = new SqlConnection(cadenaConexion);

            sentencia = " Select	IdSede,    Nombre,    Direccion,	    Estado,     Telefono" +
                       " From	    Sede";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listaSede.Add(new Sede
                    {
                        IdSede = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Direccion = reader.GetString(2),
                        Estado = reader.GetBoolean(3),
                        Telefono = reader.GetString(4),
                    });
                }
            }
            conexion.Close();
            return listaSede;
        }



    }
}
