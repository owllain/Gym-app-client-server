using Entidades;
using Entidades.LogicaServidor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor.Ventanas
{
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = ClienteBD.SelectCliente();
            btnConsultaCliente.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
