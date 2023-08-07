using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.LogicaServidor
{
    public class SedeClienteBD
    {
        #region Registro de Afiliaciones
        public static void InsertAfiliacionSede(AfiliacionClienteSede Sede, AfiliacionSede ClienteSede)
        {
            //Se inicializa la conexión con la base de datos
            SqlConnection conexion_afiliacion = new SqlConnection("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion_afiliacion.Open();

            //Se envian parametros para insertar en la tabla.
            string cadena = "insert into AfiliacionSede(IdAfiliacion,FechaAfiliacion,IdCliente,IdSede) values (@IdAfiliacion,@FechaAfiliacion,@IdCliente,@IdSede)";
            SqlCommand comando_afiliacion = new SqlCommand(cadena, conexion_afiliacion);

            //Creación de parametros
            comando_afiliacion.Parameters.Add("@IdAfiliacion", SqlDbType.Int);
            comando_afiliacion.Parameters.Add("@FechaAfiliacion", SqlDbType.DateTime);
            comando_afiliacion.Parameters.Add("@IdCliente", SqlDbType.VarChar);
            comando_afiliacion.Parameters.Add("@IdSede", SqlDbType.Int);
            //Asignación de valores
            comando_afiliacion.Parameters["@IdAfiliacion"].Value = ClienteSede.ID_Afiliacion;
            comando_afiliacion.Parameters["@FechaAfiliacion"].Value = ClienteSede.Fecha_Afiliacion;
            comando_afiliacion.Parameters["@IdCliente"].Value = ClienteSede.IdCliente;
            comando_afiliacion.Parameters["@IdSede"].Value = Sede.IdSede;
            comando_afiliacion.ExecuteNonQuery();
            conexion_afiliacion.Close();
        }

        public static List<Sede> SelectSede(string IdSede)
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
                    if (reader.GetInt32(0) == Convert.ToInt32(IdSede))
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
            }
            conexion.Close();
            return listaSede;
        }

        public static List<string> SelectCliente()
        {
            List<string> listaClientes = new List<string>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader registro;
            string cadenaConexion = ("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion = new SqlConnection(cadenaConexion);

            sentencia = " Select	IdCliente,    Nombre,	    PrimerApellido,     SegundoApellido,     FechaNacimiento,     Genero,     FechaIngreso" +
                       " From	    Cliente";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            conexion.Open();

            registro = comando.ExecuteReader();

            if (registro.HasRows)
            {
                while (registro.Read())
                {
                    listaClientes.Add("Identificación: " + registro["IdCliente"].ToString() + " Nombre completo: " + registro["Nombre"].ToString() + " " +
                        registro["PrimerApellido"].ToString() + " " +
                        registro["SegundoApellido"].ToString());

                }
            }
            conexion.Close();



            return listaClientes;
        }

        public static List<Sede> CargarSedes()
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
                    if (reader.GetBoolean(3) != false)
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
            }
            conexion.Close();
            return listaSede;
        }

        public static string InsertClienteSede(string CB_Cliente)
        {

            //Paso 1: se obtiene el cliente de la base de datos comparandolo con el combobox.
            string IdCliente = "";
            SqlConnection conexion_cliente;
            SqlCommand comando_cliente = new SqlCommand();
            string sentencia;
            SqlDataReader registro;
            string cadenaConexion = ("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion_cliente = new SqlConnection(cadenaConexion);

            sentencia = " Select	IdCliente,    Nombre,	    PrimerApellido,     SegundoApellido,     FechaNacimiento,     Genero,     FechaIngreso" +
                       " From	    Cliente";

            comando_cliente.CommandType = CommandType.Text;
            comando_cliente.CommandText = sentencia;
            comando_cliente.Connection = conexion_cliente;
            conexion_cliente.Open();

            registro = comando_cliente.ExecuteReader();

            if (registro.HasRows)
            {
                while (registro.Read())
                {
                    if (CB_Cliente.Contains(registro["IdCliente"].ToString()))
                    {
                        IdCliente = registro["IdCliente"].ToString();
                    }
                }
            }

            conexion_cliente.Close();

            return IdCliente;
        }

        public static bool ValidaSede(string IDSede)
        {
            bool Existencia = false;
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader registro;
            string cadenaConexion = ("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion = new SqlConnection(cadenaConexion);

            sentencia = " Select	IdSede,    Nombre,    Direccion,	    Estado,     Telefono" +
              " From	    Sede";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            conexion.Open();

            registro = comando.ExecuteReader();

            if (registro.HasRows)
            {
                while (registro.Read())
                {
                    if (IDSede == registro["IdSede"].ToString())
                    {
                        Existencia = true;
                    }

                }
            }
            conexion.Close();

            return Existencia;
        }
        #endregion

        #region Consulta del Registro
        public static List<string> SearchClienteAfiliado()
        {
            List<string> listaClientesAfiliados = new List<string>();
            string CadenaCliente;
            string id_cliente;
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
                    id_cliente = registro["IdCliente"].ToString();
                    CadenaCliente = CargarClienteAfiliado(id_cliente);
                    if (CadenaCliente.Contains(id_cliente))
                    {
                        if (!listaClientesAfiliados.Contains(CadenaCliente))
                        {
                            listaClientesAfiliados.Add(CadenaCliente);
                        }
                        
                    }
                }
            }
            conexion.Close();
            return listaClientesAfiliados;
        }
        public static string CargarClienteAfiliado(string IDCliente)
        {
            string CadenaCliente = "";
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader registro;
            string cadenaConexion = ("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion = new SqlConnection(cadenaConexion);

            sentencia = " Select	IdCliente,    Nombre,	    PrimerApellido,     SegundoApellido,     FechaNacimiento,     Genero,     FechaIngreso" +
                       " From	    Cliente";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            conexion.Open();

            registro = comando.ExecuteReader();

            if (registro.HasRows)
            {
                while (registro.Read())
                {
                    if (IDCliente == registro["IdCliente"].ToString())
                    {
                        CadenaCliente = ("Identificación: " + registro["IdCliente"].ToString() + " Nombre completo: " + registro["Nombre"].ToString() + " " +
                        registro["PrimerApellido"].ToString() + " " +
                        registro["SegundoApellido"].ToString());
                    }

                }
            }
            conexion.Close();

            return CadenaCliente;
        }

        public static List<string> LeerClienteAfiliado()
        {
            List<string> listaClienteAfiliado = new List<string>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;
            string cadenaConexion = ("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion = new SqlConnection(cadenaConexion);

            sentencia = " Select	IdAfiliacion,    FechaAfiliacion,	    IdCliente,	    IdSede" +
                           " From	    AfiliacionSede";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            conexion.Open();

            reader = comando.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    listaClienteAfiliado.Add(reader["IdCliente"].ToString());

                }
            }
            conexion.Close();
            return listaClienteAfiliado;
        }

        #endregion
    }
}
