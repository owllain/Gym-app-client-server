using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.LogicaServidor
{
   public class ClienteBD
    {
        public static void InsertCliente(Cliente cliente)
        {
            //Se inicializa la conexión con la base de datos.
            SqlConnection conexion = new SqlConnection("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion.Open();

            //Se envian parametros para insertar en la tabla.
            string cadena = "insert into Cliente(IdCliente,Nombre,PrimerApellido,SegundoApellido,FechaNacimiento,Genero,FechaIngreso) " +
                "values (@IdCliente,@Nombre,@PrimerApellido,@SegundoApellido,@FechaNacimiento,@Genero,@FechaIngreso)";
            SqlCommand comando = new SqlCommand(cadena, conexion);

            //Creación de parametros
            comando.Parameters.Add("@IdCliente", SqlDbType.VarChar);
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar);
            comando.Parameters.Add("@PrimerApellido", SqlDbType.VarChar);
            comando.Parameters.Add("@SegundoApellido", SqlDbType.VarChar);
            comando.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime);
            comando.Parameters.Add("@Genero", SqlDbType.VarChar);
            comando.Parameters.Add("@FechaIngreso", SqlDbType.DateTime);

            //Asignación de valores
            comando.Parameters["@IdCliente"].Value = cliente.Identificacion;
            comando.Parameters["@Nombre"].Value = cliente.Nombre;
            comando.Parameters["@PrimerApellido"].Value = cliente.Apellido1;
            comando.Parameters["@SegundoApellido"].Value = cliente.Apellido2;
            comando.Parameters["@FechaNacimiento"].Value = cliente.FechaNacimiento;
            comando.Parameters["@Genero"].Value = cliente.Genero;
            comando.Parameters["@FechaIngreso"].Value = cliente.FechaRegistro;
            comando.ExecuteNonQuery();
            conexion.Close();

        }

        public static List<Cliente> SelectCliente()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;
            string cadenaConexion = ("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion = new SqlConnection(cadenaConexion);

            sentencia = " Select	IdCliente,    Nombre,	    PrimerApellido,     SegundoApellido,     FechaNacimiento,     Genero,     FechaIngreso" +
                       " From	    Cliente";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listaClientes.Add(new Cliente
                    {
                        Identificacion = reader.GetString(0),
                        Nombre = reader.GetString(1),
                        Apellido1 = reader.GetString(2),
                        Apellido2 = reader.GetString(3),
                        FechaNacimiento = reader.GetDateTime(4),
                        Genero = Convert.ToChar(reader.GetString(5)),
                        FechaRegistro = reader.GetDateTime(6)
                    });
                }
            }
            conexion.Close();



            return listaClientes;
        }

        public static string SelectNombre(string idCliente)
        {
            

            string CadenaNombre = "";

            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;
            string cadenaConexion = ("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion = new SqlConnection(cadenaConexion);

            sentencia = " Select	IdCliente,    Nombre,	    PrimerApellido,     SegundoApellido,     FechaNacimiento,     Genero,     FechaIngreso" +
                       " From	    Cliente";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if(idCliente == reader["IdCliente"].ToString())
                    {
                        CadenaNombre = (reader["Nombre"].ToString() +" "+ reader["PrimerApellido"].ToString() + " " + reader["SegundoApellido"].ToString());
                    }
                }
            }
            conexion.Close();


            return CadenaNombre;
        }

    }
}
