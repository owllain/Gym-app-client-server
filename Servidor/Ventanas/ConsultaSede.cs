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
    public partial class ConsultaSede : Form
    {
        public ConsultaSede()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultaSede_Click(object sender, EventArgs e)
        {
            dgvSedes.DataSource = SedeBD.SelectSede();
            btnConsultaSede.Enabled = false;
        }
    }
}
