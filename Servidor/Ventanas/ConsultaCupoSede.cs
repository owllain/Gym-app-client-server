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
    public partial class ConsultaCupoSede : Form
    {
        public ConsultaCupoSede()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultaCupo_Click(object sender, EventArgs e)
        {
            dgvCupoSede.DataSource = CupoBD.LeerCupoSede();
            btnConsultaCupo.Enabled = false;
        }
    }
}
