using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente.Ventanas
{
    public partial class MenuPrincipal : Form
    {
        CambiarNombre Nombre;

        //Delegado para modificar interfaz.
        private delegate void CambiarNombre(string texto);

        public MenuPrincipal()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

            //Valida al servidor que el cliente realizó la conexión. 
            if (ClienteTCP.Cliente != null && ClienteTCP.Cliente.Connected)
            {
                Utilidades.clienteConectado = true;
            }
            else
            {
                Utilidades.clienteConectado = false;
            }

            btnConsultaReserva.Enabled = false;
            btnRegistraReserva.Enabled = false;
            Nombre = new CambiarNombre(EditarNombre);

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
                this.Close();
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

        #region Metodos para Paneles
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

        private void tmHoraFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void EditarNombre(string Nombre)
        {
            lblNombreUsuario.Text = ClienteTCP.ConsultarNombre(Nombre);
        }

        #endregion

        #region Menu Clientes
        private void btnRegistraReserva_Click(object sender, EventArgs e)
        {
            if (Utilidades.clienteConectado == true)
            {
                AbrirFormEnPanel(new ReservarSesion(txtUsuario.Text));
            }
            else
            {
                MessageBox.Show("Debe ingresar como usuario para acceder a las funciones.");
            }

        }

        private void btnConsultaReserva_Click(object sender, EventArgs e)
        {
            if (Utilidades.clienteConectado == true)
            {
                AbrirFormEnPanel(new ConsultaReserva(txtUsuario.Text));
            }
            else
            {
                MessageBox.Show("Debe ingresar como usuario para acceder a las funciones.");
            }

        }
        #endregion

        #region Conexion Cliente -> Servidor
        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (!(txtUsuario.Text.Equals(string.Empty)))
            {

                if (ClienteTCP.Conectar(txtUsuario.Text))
                {


                    if (ClienteTCP.ConsultarClientes().Contains(txtUsuario.Text))
                    {
                        Utilidades.clienteActivo = txtUsuario.Text;
                        ClienteTCP.clienteIdentificador = int.Parse(Utilidades.clienteActivo);
                        Utilidades.clienteConectado = true;
                        btnConsultaReserva.Enabled = true;
                        btnRegistraReserva.Enabled = true;
                        lblNombreUsuario.Invoke(Nombre, txtUsuario.Text);
                    }
                    else if (!ClienteTCP.ConsultarClientes().Contains(txtUsuario.Text))
                    {
                        MessageBox.Show("Este cliente no tiene Sedes Afiliadas en la base de datos");
                    }
                }
                else
                {
                    MessageBox.Show("Verifique que el servidor esté escuchando clientes...", "No es posible conectarse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }
            else
            {
                MessageBox.Show("Debe ingresar el identificador del cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            ClienteTCP.Desconectar(txtUsuario.Text);
            Utilidades.clienteConectado = false;
            btnConsultaReserva.Enabled = false;
            btnRegistraReserva.Enabled = false;
            lblNombreUsuario.Text = "";
        }
        #endregion

    }
}
