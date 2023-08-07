using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Utilidades
    {
        #region Propiedades
        public static bool validar_RegistroSede = false;
        public static bool validar_RegistroCliente = false;
        public static bool validar_RegistroAfiliacion = false;
        public static bool validar_RegistroCupo = false;
        public static bool validar_SedeActiva = false;
        public static bool clienteConectado = false;
        public static string clienteActivo; 
        #endregion

        #region Metodos auxiliares
        public static void Validaciones()
        {
            #region Sede
            SqlConnection conexion_Sede;
            SqlCommand comando_Sede = new SqlCommand();
            string sentencia_Sede;
            SqlDataReader reader_Sede;
            string cadenaConexion_Sede = ("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion_Sede = new SqlConnection(cadenaConexion_Sede);

            sentencia_Sede = " Select	IdSede,    Nombre,    Direccion,	    Estado,     Telefono" +
                       " From	    Sede";

            comando_Sede.CommandType = CommandType.Text;
            comando_Sede.CommandText = sentencia_Sede;
            comando_Sede.Connection = conexion_Sede;
            conexion_Sede.Open();

            reader_Sede = comando_Sede.ExecuteReader();

            if (reader_Sede.HasRows)
            {
                validar_RegistroSede = true;
                while (reader_Sede.Read())
                {
                    if (reader_Sede.GetBoolean(3) != false)
                    {
                        validar_SedeActiva = true;
                    }
                }

            }
            conexion_Sede.Close();
            #endregion
            #region Cliente
            SqlConnection conexion_Cliente;
            SqlCommand comando_Cliente = new SqlCommand();
            string sentencia_Cliente;
            SqlDataReader reader_Cliente;
            string cadenaConexion_Cliente = ("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion_Cliente = new SqlConnection(cadenaConexion_Cliente);

            sentencia_Cliente = " Select	IdCliente,    Nombre,    PrimerApellido,	    SegundoApellido,     FechaNacimiento,     Genero,     Genero" +
                       " From	    Cliente";

            comando_Cliente.CommandType = CommandType.Text;
            comando_Cliente.CommandText = sentencia_Cliente;
            comando_Cliente.Connection = conexion_Cliente;
            conexion_Cliente.Open();

            reader_Cliente = comando_Cliente.ExecuteReader();

            if (reader_Cliente.HasRows)
            {
                validar_RegistroCliente = true;
            }
            conexion_Cliente.Close();
            #endregion
            #region Afiliacion
            SqlConnection conexion_Afiliacion;
            SqlCommand comando_Afiliacion = new SqlCommand();
            string sentencia_Afiliacion;
            SqlDataReader reader_Afiliacion;
            string cadenaConexion_Afiliacion = ("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion_Afiliacion = new SqlConnection(cadenaConexion_Afiliacion);

            sentencia_Afiliacion = " Select	IdSede,    Nombre,    Direccion,	    Estado,     Telefono" +
                       " From	    Sede";

            comando_Afiliacion.CommandType = CommandType.Text;
            comando_Afiliacion.CommandText = sentencia_Afiliacion;
            comando_Afiliacion.Connection = conexion_Afiliacion;
            conexion_Afiliacion.Open();

            reader_Afiliacion = comando_Afiliacion.ExecuteReader();

            if (reader_Afiliacion.HasRows)
            {
                validar_RegistroAfiliacion = true;
            }
            conexion_Afiliacion.Close();
            #endregion
            #region Cupo
            SqlConnection conexion_Cupo;
            SqlCommand comando_Cupo = new SqlCommand();
            string sentencia_Cupo;
            SqlDataReader reader_Cupo;
            string cadenaConexion_Cupo = ("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion_Cupo = new SqlConnection(cadenaConexion_Cupo);

            sentencia_Cupo = " Select	IdSede,    FechaCupo,    Cupos" +
                       " From	    CupoSede";

            comando_Cupo.CommandType = CommandType.Text;
            comando_Cupo.CommandText = sentencia_Cupo;
            comando_Cupo.Connection = conexion_Cupo;
            conexion_Cupo.Open();

            reader_Cupo = comando_Cupo.ExecuteReader();

            if (reader_Cupo.HasRows)
            {
                validar_RegistroCupo = true;
            }
            conexion_Cupo.Close();
            #endregion
        }

        public static bool ValidarLogin(bool login, string id_Cliente) 
        {
            login = false;
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
                    if(id_Cliente == reader["IdCliente"].ToString())
                    {
                        login = true;
                    }
                    
                }
            }
            conexion.Close();


            return login;
        }
        #endregion






    }
}
