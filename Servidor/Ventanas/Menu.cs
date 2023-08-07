using Entidades;
using Entidades.LogicaServidor;
using Newtonsoft.Json;
using Servidor.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor
{
    public partial class Menu : Form
    {
        #region Parametros
        //Configuración del protocolo TCP.
        TcpListener tcpListener;
        bool servidorIniciado = false;
        Thread subprocesoEscuchaClientes;
        EscribirEnTextboxDelegado Bitacora;
        ModificarListBoxDelegado Clientes;

        //Delegado para modificar interfaz.
        private delegate void EscribirEnTextboxDelegado(string texto);
        private delegate void ModificarListBoxDelegado(string texto, bool agregar);

        //Se instancia un semaforo para que solo pueda trabajar un hilo a la vez.
        Semaphore semaforo;
        #endregion

        public Menu()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

            //Llama a las funciones delegadas para los cambios en la interfaz.
            Bitacora = new EscribirEnTextboxDelegado(EscribirEnTextbox);
            Clientes = new ModificarListBoxDelegado(ModificarListBox);
            lblEstado.ForeColor = Color.Red;
            btnDesconectar.Enabled = false;

            //Se configura un semaforo que solo un hilo trabajando.
            semaforo = new Semaphore(1, 6);


        }


        #region Arrastrar Formulario 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Botones de la barra superior
        //METODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR LA VENTANA CON COORDENADAS
        int lx, ly;
        int sw, sh;
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Está seguro de cerrar el programa?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

        }
        #endregion

        #region Rellenar panel contenedor
        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form VentanaContenedor = formHijo as Form;
            VentanaContenedor.TopLevel = false;
            VentanaContenedor.FormBorderStyle = FormBorderStyle.None;
            VentanaContenedor.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(VentanaContenedor);
            this.pnlContenedor.Tag = VentanaContenedor;
            VentanaContenedor.Show();
        }

        #endregion

        #region Botones del menú principal
        private void btnRegistrarSede_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RegistrarSede());
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RegistrarCliente());
        }

        private void btnRegistraSedeCliente_Click(object sender, EventArgs e)
        {
            Utilidades.Validaciones();
            if (Utilidades.validar_RegistroSede == true && Utilidades.validar_RegistroCliente == true)
            {
                AbrirFormEnPanel(new RegistrarSedeCliente());
            }
            else if (Utilidades.validar_RegistroSede == false)
            {
                MessageBox.Show("Debe registrar una sede primero!");
            }
            else if (Utilidades.validar_RegistroCliente == false)
            {
                MessageBox.Show("Debe registrar un cliente primero!");
            }


        }

        private void btnRegistraCupoSede_Click(object sender, EventArgs e)
        {
            Utilidades.Validaciones();
            if (Utilidades.validar_RegistroSede == true && Utilidades.validar_SedeActiva == true)
            {
                AbrirFormEnPanel(new RegistrarCupoSede());
            }
            else if (Utilidades.validar_RegistroSede == false)
            {
                MessageBox.Show("Debe registrar una sede para asignar cupos.");
            }
            else if (Utilidades.validar_SedeActiva == false)
            {
                MessageBox.Show("Debe registrar una sede activa para asignar cupos.");
            }

        }

        private void btnConsultaSedeCliente_Click(object sender, EventArgs e)
        {
            Utilidades.Validaciones();
            if (Utilidades.validar_RegistroAfiliacion == true)
            {
                AbrirFormEnPanel(new ConsultaSedeCliente());
            }
            else
            {
                MessageBox.Show("Debe registrar una afiliación primero!");
            }

        }

        private void btnConsultaSede_Click(object sender, EventArgs e)
        {
            Utilidades.Validaciones();
            if (Utilidades.validar_RegistroSede == true)
            {
                AbrirFormEnPanel(new ConsultaSede());
            }
            else
            {
                MessageBox.Show("Debe registrar una sede primero!");
            }

        }

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            Utilidades.Validaciones();
            if (Utilidades.validar_RegistroCliente == true)
            {
                AbrirFormEnPanel(new ConsultaCliente());
            }
            else
            {
                MessageBox.Show("Debe registrar una sede primero!");
            }

        }

        private void btnConsultaCupoSede_Click(object sender, EventArgs e)
        {
            Utilidades.Validaciones();
            if (Utilidades.validar_RegistroCupo == true)
            {
                AbrirFormEnPanel(new ConsultaCupoSede());
            }
            else
            {
                MessageBox.Show("Debe registrar cupos de sede primero!");
            }

        }
        #endregion

        #region Métodos delegados para modificar la interfaz 
        private void EscribirEnTextbox(string texto)
        {
            txtRegistro.AppendText(DateTime.Now.ToString() + " - " + texto);
            txtRegistro.AppendText(Environment.NewLine);
        }

        private void ModificarListBox(string texto, bool agregar)
        {
            if (agregar)
            {
                listBitacora.Items.Add(texto);
            }
            else
            {
                listBitacora.Items.Remove(texto);
            }

        }
        #endregion

        #region Conexion Servidor <-> Cliente
        private void btnConectar_Click(object sender, EventArgs e)
        {
            semaforo.WaitOne();
            try
            {
                lock (this)
                {
                    

                    //Se define una dirección IP y un puerto para poder hacer la conexión.
                    IPAddress local = IPAddress.Parse("127.0.0.1");
                    tcpListener = new TcpListener(local, 15810);
                    servidorIniciado = true;

                    //Se crea subproceso que escuche los mensajes de la aplicación cliente.
                    subprocesoEscuchaClientes = new Thread(new ThreadStart(EscucharClientes));
                    subprocesoEscuchaClientes.Start();
                    subprocesoEscuchaClientes.IsBackground = true;
                    lblEstado.Text = "Conectado.";
                    lblEstado.ForeColor = Color.Green;
                    btnConectar.Enabled = false;
                    btnDesconectar.Enabled = true;

                    txtRegistro.Text = "Servidor iniciado... en (127.0.0.1, 15810)";
                    txtRegistro.AppendText(Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            semaforo.Release();
            
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            semaforo.WaitOne();
            try
            {
                lock (this)
                {
                    servidorIniciado = false;
                    tcpListener.Stop();
                    lblEstado.ForeColor = Color.Red;
                    lblEstado.Text = "Desconectado.";
                    btnConectar.Enabled = true;
                    btnDesconectar.Enabled = false;
                    Thread.Sleep(100);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            semaforo.Release();
        }

        #region Métodos para Conexion
        private void EscucharClientes()
        {
            try
            {
                tcpListener.Start();
                while (servidorIniciado)
                {
                    TcpClient client = tcpListener.AcceptTcpClient();
                    Thread clientThread = new Thread(new ParameterizedThreadStart(ComunicacionCliente));
                    clientThread.Start(client);  
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.Message); //Muestra en consola en caso de error {Excepción WSACancelBlockingCall}
            }
        }
        private void ComunicacionCliente(object pClient)
        {
            //Metodo con el cual codifica el mensaje proveniente del cliente.
            TcpClient tcCliente = (TcpClient)pClient;
            StreamReader reader = new StreamReader(tcCliente.GetStream());
            StreamWriter servidorStreamWriter = new StreamWriter(tcCliente.GetStream());

            while (servidorIniciado)
            {
                try
                {
                    var mensaje = reader.ReadLine();
                    ConexionServidor<object> mensajeRecibido = JsonConvert.DeserializeObject<ConexionServidor<object>>(mensaje);
                    SeleccionarMetodo(mensajeRecibido.Metodo, mensaje, ref servidorStreamWriter);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    break;
                }
            }
            tcCliente.Close();
            servidorIniciado = true;
        }
        public void SeleccionarMetodo(string pMetodo, string pMensaje, ref StreamWriter servidorStreamWriter)
        {
            switch (pMetodo)
            {
                case "Conectar":
                    ConexionServidor<string> mensajeConectar = JsonConvert.DeserializeObject<ConexionServidor<string>>(pMensaje);// Se deserializa el objeto recibido mediante json
                    Conectar(mensajeConectar.Entidad);
                    break;
                case "Desconectar":
                    ConexionServidor<string> mensajeDesconectar = JsonConvert.DeserializeObject<ConexionServidor<string>>(pMensaje);//Se deserializa el objeto recibido mediante json
                    Desconectar(mensajeDesconectar.Entidad);
                    break;
                case "AgregarReserva":
                    ConexionServidor<ReservaSesion> crearReserva = JsonConvert.DeserializeObject<ConexionServidor<ReservaSesion>>(pMensaje);// Se deserializa el objeto recibido mediante json
                    AgregarReserva(crearReserva.Entidad);
                    break;
                case "ConsultaReserva":
                    ConexionServidor<string> consultarReserva = JsonConvert.DeserializeObject<ConexionServidor<string>>(pMensaje);
                    ConsultaReserva(consultarReserva.Entidad, ref servidorStreamWriter);
                    break;
                case "ConsultarSedesAfiliadas":
                    ConexionServidor<string> consultarSede = JsonConvert.DeserializeObject<ConexionServidor<string>>(pMensaje);// Se deserializa el objeto recibido mediante json
                    ConsultarSede(consultarSede.Entidad, ref servidorStreamWriter);
                    break;
                case "ConsultarClientes":
                    ConsultarClientes(ref servidorStreamWriter);
                    break;
                case "ConsultarClientesNombre":
                    ConexionServidor<string> consultarNombres = JsonConvert.DeserializeObject<ConexionServidor<string>>(pMensaje);// Se deserializa el objeto recibido mediante json
                    ConsultarNombres(consultarNombres.Entidad, ref servidorStreamWriter);
                    break;

                default:
                    break;
            }
        }
        #endregion
       
        #region Métodos para el Cliente
        private void Conectar(string pIdentificadorCliente)
        {
            bool login = true;
            Utilidades.ValidarLogin(login, pIdentificadorCliente);
            if (login == true)
            {
                txtRegistro.Invoke(Bitacora, new object[] { pIdentificadorCliente + " se ha conectado..." });
                listBitacora.Invoke(Clientes, new object[] { pIdentificadorCliente, true });
            }
            else
            {
                txtRegistro.Invoke(Bitacora, new object[] { "Intento de inicio de sesión fallido..." });
            }


        }
        private void Desconectar(string pIdentificadorCliente)
        {
            txtRegistro.Invoke(Bitacora, new object[] { pIdentificadorCliente + " se ha desconectado!" });
            listBitacora.Invoke(Clientes, new object[] { pIdentificadorCliente, false });
            servidorIniciado = false;
        }

        private void ConsultaReserva(string idcliente, ref StreamWriter servidorStreamWriter)
        {
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(ReservacionesBD.LeerReservaSesion(idcliente)));
            servidorStreamWriter.Flush();
        }

        private void ConsultarSede(string idcliente, ref StreamWriter servidorStreamWriter)
        {
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(ReservacionesBD.SearchSedeAfiliado(idcliente)));
            servidorStreamWriter.Flush();
        }

        private void ConsultarClientes(ref StreamWriter servidorStreamWriter)
        {
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(SedeClienteBD.LeerClienteAfiliado()));
            servidorStreamWriter.Flush();
        }

        private void AgregarReserva(ReservaSesion reserva)
        {
            string eventoReserva;
            eventoReserva = ("El cliente {" + reserva.IdCliente + "} realizó una reservación.");
            txtRegistro.Invoke(Bitacora, eventoReserva);
            ReservacionesBD.RealizarReserva(reserva);
        }

        private void ConsultarNombres(string idcliente, ref StreamWriter servidorStreamWriter)
        {
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(ClienteBD.SelectNombre(idcliente)));
            servidorStreamWriter.Flush();
        }

        #endregion
        #endregion

    }
}
