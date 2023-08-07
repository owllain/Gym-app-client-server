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
    public partial class RegistrarCupoSede : Form
    {
        public RegistrarCupoSede()
        {
            InitializeComponent();
            CargarSedes();
            dtpRegCupo.MaxDate = DateTime.Now.Date.AddDays(30);
            dtpRegCupo.MinDate = DateTime.Now.Date.AddDays(0);
        }

        #region Metodos de llenado de datos
        public void CargarSedes()
        {
            dgvSedes.DataSource = SedeClienteBD.CargarSedes();

        }
        #endregion

        #region Metodos para validación
        private void LimpiarTxt()
        {
            txtIdSede.Text = "";
            txtRegCupo.Text = "";
            dtpRegCupo.Value = DateTime.Now;

        }

        private void txtRegCupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Debe ingresar unicamente valores númericos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIdSede_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Debe ingresar unicamente valores númericos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        #endregion

        #region Metodos de botones
        private void btnSeleccionarSede_Click(object sender, EventArgs e)
        {
            bool validar_cupo = false;
            bool existe_cupo = false;

            try
            {
                //Paso 1: Pasa por las validaciiones para guardar en el arreglo de la clase CupoSede
                if (txtRegCupo.Text != "")
                {
                    if (dtpRegCupo.Text != "")
                    {
                        if (txtIdSede.Text != "")
                        {
                            foreach (DataGridViewRow row in dgvSedes.Rows)
                            {
                                if (row.Cells[0].Value.ToString() == txtIdSede.Text)
                                {
                                    validar_cupo = true;

                                    if (validar_cupo == true)
                                    {
                                        //Asignación de valores
                                        CupoSede cupo = new CupoSede();
                                        cupo.IdSede = Convert.ToInt32(row.Cells[0].Value.ToString());
                                        cupo.FechaCupo = Convert.ToDateTime(dtpRegCupo.Text);
                                        cupo.Cupos = Convert.ToInt32(txtRegCupo.Text);
                                        existe_cupo = CupoBD.ValidarCupoSede(cupo);
                                        if(existe_cupo == false)
                                        {
                                            CupoBD.InsertCupo(cupo);
                                            MessageBox.Show("Cupo registrado con exito.", "Atención!");
                                        }
                                        else if(existe_cupo == true)
                                        {
                                            MessageBox.Show("Esta Sede ya tiene cupos asignados para la fecha seleccionada.", "Atención!");
                                        }
                                        
                                       
                                        
                                    }
                                }

                            }

                        }

                        if (validar_cupo == false)
                        {
                            MessageBox.Show("El ID ingresado no corresponde a ninguna Sede Activa." + "\nNo se realizó el registro!", "Atención!");
                        }

                        validar_cupo = false;
                        if (MessageBox.Show("¿Desea registrar más cupos?", "Atención!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            LimpiarTxt();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
