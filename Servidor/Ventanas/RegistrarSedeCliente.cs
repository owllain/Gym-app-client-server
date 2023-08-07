using Entidades;
using Entidades.LogicaServidor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor.Ventanas
{
    public partial class RegistrarSedeCliente : Form
    {
        int id_afiliacion;
        string id_cliente = "";
        string id_Sede = "";
        bool bandera_cliente;
        bool bandera_sedereg = false;

        public RegistrarSedeCliente()
        {
            InitializeComponent();
            CargarClientes();
            CargarSedes();

        }

        #region Botones interfaz
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxt();
        }
        #endregion

        #region Metodos
        private void LimpiarTxt()
        {
            cbClientes.Enabled = true;
            btnSeleccionarSede.Enabled = true;
            dgvSedesReg.DataSource = null;
            dgvSedesReg.Refresh();
            txtIdSedeCliente.Text = "";
            dtpRegAfiliacion.Value = DateTime.Now;


        }

        private void txtIdSedeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Debe ingresar unicamente valores númericos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cbClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }
        #endregion

        #region Metodos de llenado de datos
        public void CargarClientes()
        {
            
            cbClientes.DataSource=SedeClienteBD.SelectCliente();
            

        }

        public void CargarSedes()
        {
            dgvSedes.DataSource = SedeClienteBD.CargarSedes();
        }
        #endregion

        #region Metodos de registro de datos
        private void btnSeleccionarSede_Click(object sender, EventArgs e)
        {
            
            try
            {

                //PASO #1 Le notifica al usuario que el valor que ingreso no es válido. 
                if (txtIdSedeCliente.Text != "")
                {
                   bandera_sedereg = SedeClienteBD.ValidaSede(txtIdSedeCliente.Text);
                }
                else
                {
                    MessageBox.Show("Debe ingresar un ID de sede valido para afiliar!", "Atencion!");
                }


                //Paso #2: Una vez pasada las validaciones, llama al método que conecta con la base de datos y agrega la sede al datagridview.
                if (bandera_sedereg == true)
                {
                    dgvSedesReg.DataSource = SedeClienteBD.SelectSede(txtIdSedeCliente.Text);
                    id_Sede = txtIdSedeCliente.Text;
                }
                else
                {
                    MessageBox.Show("Debe ingresar un ID de sede valido para afiliar!", "Atencion!");
                }

                cbClientes.Enabled = false;
                btnSeleccionarSede.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRegistraSedes_Click(object sender, EventArgs e)
        {

            try
            {
                Random randomReg = new Random();
                if (dgvSedesReg.Rows.Count > 0)
                {

                    #region Busca al cliente en la BD.
                    if (cbClientes.SelectedIndex != -1)
                    {
                        id_cliente = SedeClienteBD.InsertClienteSede(cbClientes.SelectedItem.ToString());

                        if (cbClientes.SelectedItem.ToString().Contains(id_cliente))
                        {
                            bandera_cliente = true;
                        }


                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un cliente a registrar!", "Atención!");
                    }
                    #endregion

                    #region Guardar Afiliacion en la BD.
                    //Paso 2: Guardar la información de la afiliación en la base de datos.
                    if (bandera_cliente == true)
                    {

                        foreach (DataGridViewRow row in dgvSedesReg.Rows)
                        {
                            id_afiliacion = randomReg.Next(1, 10001);

                            //Asignación de valores
                            AfiliacionSede afiliacioncliente = new AfiliacionSede();
                            AfiliacionClienteSede afiliacionClienteSede = new AfiliacionClienteSede();

                            afiliacioncliente.ID_Afiliacion = id_afiliacion;
                            afiliacioncliente.Fecha_Afiliacion = Convert.ToDateTime(dtpRegAfiliacion.Text);
                            afiliacioncliente.IdCliente = id_cliente;
                            afiliacionClienteSede.IdSede = Convert.ToInt32(id_Sede);
                            SedeClienteBD.InsertAfiliacionSede(afiliacionClienteSede, afiliacioncliente);

                            MessageBox.Show("Afiliación registrada correctamente.", "Atención!");
                            if (MessageBox.Show("¿Desea registrar más afiliaciones?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                LimpiarTxt();
                                cbClientes.Enabled = true;
                                dgvSedesReg.Rows.Clear();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                    }
                    #endregion
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una sede a registrar!", "Atención!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        #endregion
    }
}
