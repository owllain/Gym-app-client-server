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
    public partial class RegistrarCliente : Form
    {
        public RegistrarCliente()
        {
            InitializeComponent();
            cbGenero.Items.Add('M');
            cbGenero.Items.Add('F');
        }

        #region Botones de la interfaz
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Registro de datos para {Clientes}
        private void btnRegistraSedes_Click(object sender, EventArgs e)
        {
            bool banderaCliente = false;
            try
            {
                if (txtId.Text != "")
                {
                    if (txtNombre.Text != "")
                    {
                        if (txtApellido1.Text != "")
                        {
                            if (txtApellido2.Text != "")
                            {
                                if ((Convert.ToString(cbGenero.SelectedItem)) != "")
                                {
                                    banderaCliente = true;
                                }
                                else { MessageBox.Show("Debe ingresar un genero.", "Atención!"); }
                            }
                            else { MessageBox.Show("Debe ingresar un segundo apellido.", "Atención!"); }
                        }
                        else { MessageBox.Show("Debe ingresar un primer apellido.", "Atención!"); }
                    }
                    else { MessageBox.Show("Debe ingresar un nombre.", "Atención!"); }
                }
                else
                { MessageBox.Show("Debe ingresar un ID.", "Atención!"); }


                if (banderaCliente == true)
                {
                    //Asignación de valores
                    Cliente cliente = new Cliente();
                    cliente.Identificacion = txtId.Text;
                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellido1 = txtApellido1.Text;
                    cliente.Apellido2 = txtApellido2.Text;
                    cliente.FechaNacimiento = Convert.ToDateTime(dtpNacimiento.Text);

                    if (Convert.ToChar(cbGenero.SelectedItem) == 'M')
                    {
                        cliente.Genero = 'M';
                    }
                    if (Convert.ToChar(cbGenero.SelectedItem) == 'F')
                    {
                        cliente.Genero = 'F';
                    }

                    cliente.FechaRegistro = Convert.ToDateTime(dtpIngreso.Text);

                    //Inserta en la base de datos el objeto Cliente.
                    ClienteBD.InsertCliente(cliente);


                    MessageBox.Show("Cliente registrado correctamente.", "Atención!");
                    if (MessageBox.Show("¿Desea registrar más clientes?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        banderaCliente = false;
                        LimpiarTxt();
                    }
                    else
                    {
                        this.Close();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Metodos
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Debe ingresar unicamente valores númericos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Debe ingresar unicamente letras. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Debe ingresar unicamente letras. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Debe ingresar unicamente letras. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void LimpiarTxt()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            cbGenero.SelectedIndex = -1;
            dtpIngreso.Value = DateTime.Now;

        }
        #endregion


    }
}
