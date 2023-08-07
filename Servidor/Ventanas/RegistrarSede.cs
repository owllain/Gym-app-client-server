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

namespace Servidor
{
    public partial class RegistrarSede : Form
    {
        public RegistrarSede()
        {
            InitializeComponent();
            cbEstado.Items.Add("Activo");
            cbEstado.Items.Add("Inactivo");
           
        }

        #region Metodos de registro de datos
        private void btnRegistraSedes_Click(object sender, EventArgs e)
        {
            bool banderaSede = false;

            try {

                if (txtId.Text != "")
                {
                    if (txtNombre.Text != "")
                    {
                        if (txtDireccion.Text != "")
                        {
                            if (cbEstado.SelectedIndex != -1)
                            {
                                if (txtTelefono.Text != "")
                                {
                                    banderaSede = true;
                                }
                                else { MessageBox.Show("Debe ingresar un teléfono.", "Atención!"); }
                            }
                            else { MessageBox.Show("Debe seleccionar un estado.", "Atención!"); }
                        }
                        else { MessageBox.Show("Debe ingresar una dirección.", "Atención!"); }
                    }
                    else { MessageBox.Show("Debe ingresar un nombre.", "Atención!"); }
                }
                else { MessageBox.Show("Debe ingresar un ID.", "Atención!"); }

                if(banderaSede == true)
                {
                    //Asignación de valores
                    Sede sede = new Sede();
                    sede.IdSede = Convert.ToInt32(txtId.Text);
                    sede.Nombre = txtNombre.Text;
                    sede.Direccion = txtDireccion.Text;
                    if ((Convert.ToString(cbEstado.SelectedItem)) == "Activo")
                    {
                        sede.Estado = true;
                    }
                    else
                    {
                        sede.Estado = false;
                    }
                    sede.Telefono = txtTelefono.Text;

                    //Inserta en la base de datos el objeto Sede.
                    SedeBD.InsertSede(sede);

                    MessageBox.Show("Sede guardada correctamente!", "Atención!");
                    if (MessageBox.Show("¿Desea registrar más sedes?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        banderaSede = false;
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
                Console.WriteLine(ex.Message);
            } 
        }
        #endregion

        #region Botones interfaz
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Debe ingresar unicamente valores númericos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void LimpiarTxt()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            cbEstado.SelectedIndex = -1;
        }
        #endregion

    }
}
