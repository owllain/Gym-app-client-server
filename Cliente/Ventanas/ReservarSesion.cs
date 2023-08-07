using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente.Ventanas
{
    public partial class ReservarSesion : Form
    {
        int IdReserva;
        Semaphore semaforo;

        public ReservarSesion(string idcliente)
        {
            InitializeComponent();
            Asignaciones(idcliente);
            //Se instancia un semaforo que solo permita un hilo de 6 trabajando al mismo tiempo.
            semaforo = new Semaphore(1, 1);
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            if (cbSedes.SelectedIndex != -1)
            {
                Thread NuevaReserva = new Thread(new ParameterizedThreadStart(NuevaReservacion));
                NuevaReserva.Start(Convert.ToInt32(cbSedes.SelectedItem.ToString()));
                NuevaReserva.IsBackground = true;
            }
            else { MessageBox.Show("Debe seleccionar una Sede.", "Atención!"); }


        }

        public void NuevaReservacion(object sede)
        {
            semaforo.WaitOne();
            try
            {

                if (cbSedes.Items.Count == 0)
                {
                    MessageBox.Show("Las sedes afiliadas no poseen cupo disponible! \nContacte con el administrador.", "Atención!");
                }
                else
                {
                        lock (this)
                        {
                            ReservaSesion reserva = new ReservaSesion();
                            reserva.IdReserva = IdReserva;
                            reserva.IdSede = Convert.ToInt32(sede);
                            reserva.IdCliente = txtCliente.Text;
                            reserva.Fecha = Convert.ToDateTime(dtpFecha.Text);
                            ClienteTCP.AgregarReserva(reserva);
                            MessageBox.Show("Reserva guardada correctamente!", "Atención!");
                        }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            semaforo.Release();
        }

        private void Asignaciones(string idcliente)
        {
            //ID de la Reserva
            Random randomReg = new Random();
            IdReserva = randomReg.Next(1, 10001);
            txtReserva.Text = ("#" + IdReserva);
            txtCliente.Text = idcliente;
            cbSedes.DataSource = ClienteTCP.ConsultarSedesAfiliadas(txtCliente.Text);
            dtpFecha.MaxDate = DateTime.Now.Date.AddDays(2);
            dtpFecha.MinDate = DateTime.Now.Date.AddDays(0);


        }

    }
}
