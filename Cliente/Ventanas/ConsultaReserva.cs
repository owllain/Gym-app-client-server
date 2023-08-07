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
    public partial class ConsultaReserva : Form
    {
        public string Identificacion;
        Semaphore semaforo;
        CargarRegistroDelegado LlenarDataGridView;
        public ConsultaReserva(string idcliente)
        {
            InitializeComponent();
            Asignaciones(idcliente);

            //Inicializa metodo para el delegado.
            LlenarDataGridView = new CargarRegistroDelegado(CargarReserva);

            //Se instancia un semaforo que solo permita un hilo de 6 trabajando al mismo tiempo.
            semaforo = new Semaphore(1, 1);

           
        }

        #region Delegados para subprocesos
        private delegate void CargarRegistroDelegado(string id);

        public void CargarReserva(string id)
        {
            dgvReservas.DataSource = ClienteTCP.ConsultarReservas(id);
        }

        #endregion
        private void btnConsultaCupo_Click(object sender, EventArgs e)
        {
            semaforo.WaitOne();
            lock (this)
            {
                dgvReservas.Invoke(LlenarDataGridView, Identificacion);
            }
            semaforo.Release();
             
            //dgvReservas.DataSource = ClienteTCP.ConsultarReservas(Identificacion);
            
        }

        public void  Asignaciones(string id)
        {
            Identificacion = id;
        }

    }
}
