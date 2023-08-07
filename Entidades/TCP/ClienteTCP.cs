using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteTCP
    {
        private static IPAddress ipServidor;
        private static TcpClient cliente;
        private static IPEndPoint serverEndPoint;
        private static StreamWriter clienteStreamWriter;
        private static StreamReader clienteStreamReader;
        public static int clienteIdentificador { get; set; }
        public static TcpClient Cliente
        {
            get { return cliente;}
        }

        #region MétodosGestionanComunicacion 

        public static bool Conectar(string pIdentificadorCliente)
        {
            try
            {
                ipServidor = IPAddress.Parse("127.0.0.1");
                cliente = new TcpClient();
                serverEndPoint = new IPEndPoint(ipServidor, 15810);
                cliente.Connect(serverEndPoint);
                ClienteSocket<string> mensajeConectar = new ClienteSocket<string> { Metodo = "Conectar", Entidad = pIdentificadorCliente };

                clienteStreamReader = new StreamReader(cliente.GetStream());
                clienteStreamWriter = new StreamWriter(cliente.GetStream());
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeConectar));
                clienteStreamWriter.Flush();


            }
            catch (SocketException)
            {

                return false;
            }

            return true;
        }

        public static void Desconectar(string pIdentificadorCliente)
        {
            ClienteSocket<string> mensajeDesconectar = new ClienteSocket<string> { Metodo = "Desconectar", Entidad = pIdentificadorCliente };

            clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeDesconectar));
            clienteStreamWriter.Flush();
            //Se cierra la conexión del cliente
            cliente.Close();
        }
        #endregion

        #region MétodosNegocioCliente
        public static List<ReservaSesion> ConsultarReservas(string idcliente)
        {
            List<ReservaSesion> listaReserva= new List<ReservaSesion>();
            try
            {
                if (cliente != null && cliente.Connected)
                {
                    ClienteSocket<string> mensajeConsultaReserva = new ClienteSocket<string> { Metodo = "ConsultaReserva", Entidad = idcliente };

                    clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeConsultaReserva));
                    clienteStreamWriter.Flush();

                    var mensajeRespuesta = clienteStreamReader.ReadLine();
                    listaReserva = JsonConvert.DeserializeObject<List<ReservaSesion>>(mensajeRespuesta);
                }
                else
                {
                    throw new Exception("No se puede ejecutar la acción, NO hay conexión con el servidor");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return listaReserva;
        }

        public static List<string> ConsultarSedesAfiliadas(string pIdentificacion)
        {
            List<string> listaSedeAfilado = new List<string>();
            try
            {
                
                if (cliente != null && cliente.Connected)
                {
                    ClienteSocket<string> mensajeConsultaReserva = new ClienteSocket<string> { Metodo = "ConsultarSedesAfiliadas", Entidad = pIdentificacion };

                    clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeConsultaReserva));
                    clienteStreamWriter.Flush();

                    var mensajeRespuesta = clienteStreamReader.ReadLine();
                    listaSedeAfilado = JsonConvert.DeserializeObject<List<string>>(mensajeRespuesta);
                }
                else
                {
                    throw new Exception("No se puede ejecutar la acción, NO hay conexión con el servidor");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return listaSedeAfilado;
        }

        public static void AgregarReserva(ReservaSesion reserva)
        {
           
            try
            {

                if (cliente != null && cliente.Connected)
                {
                    ClienteSocket<ReservaSesion> mensajeConectar = new ClienteSocket<ReservaSesion> { Metodo = "AgregarReserva", Entidad = reserva };
                    clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeConectar));
                    clienteStreamWriter.Flush();

                }
                else
                {
                    throw new Exception("No se puede ejecutar la acción, NO hay conexión con el servidor");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }

        public static List<string> ConsultarClientes()
        {
            List<string> listaClientesAfiliados = new List<string>();
            try
            {
                if (cliente != null && cliente.Connected)
                {
                    ClienteSocket<string> mensajeConsultaReserva = new ClienteSocket<string> { Metodo = "ConsultarClientes" };

                    clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeConsultaReserva));
                    clienteStreamWriter.Flush();

                    var mensajeRespuesta = clienteStreamReader.ReadLine();
                    listaClientesAfiliados = JsonConvert.DeserializeObject<List<string>>(mensajeRespuesta);
                }
                else
                {
                    throw new Exception("No se puede ejecutar la acción, NO hay conexión con el servidor");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }
            return listaClientesAfiliados;
        }

        public static string ConsultarNombre (string pIdentificacion)
        {
            string listaNombre = "";
            try
            {

                if (cliente != null && cliente.Connected)
                {
                    ClienteSocket<string> mensajeConsultaNombre = new ClienteSocket<string> { Metodo = "ConsultarClientesNombre", Entidad = pIdentificacion };

                    clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeConsultaNombre));
                    clienteStreamWriter.Flush();

                    var mensajeRespuesta = clienteStreamReader.ReadLine();
                    listaNombre = JsonConvert.DeserializeObject<string>(mensajeRespuesta);
                }
                else
                {
                    throw new Exception("No se puede ejecutar la acción, NO hay conexión con el servidor");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return listaNombre;
        }

        #endregion




    }
}
