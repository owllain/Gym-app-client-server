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
    public partial class ConsultaSedeCliente : Form
    {
        public ConsultaSedeCliente()
        {
            InitializeComponent();
            LoadCliente();
        }
        #region Metodo llenado de datos
        public void LoadCliente()
        {
            cbClientes.DataSource = SedeClienteBD.SearchClienteAfiliado();
        }

        #endregion


        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {

            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader registro;
            string cadenaConexion = ("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion = new SqlConnection(cadenaConexion);

            sentencia = " Select	IdCliente,    Nombre,	    PrimerApellido,     SegundoApellido,     FechaNacimiento,     Genero,     FechaIngreso" +
                       " From	    Cliente";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            conexion.Open();

            registro = comando.ExecuteReader();

            if (cbClientes.SelectedIndex != -1)
            {
                if (registro.HasRows)
                {
                    while (registro.Read())
                    {

                        if (cbClientes.SelectedItem.ToString() == ("Identificación: " + registro["IdCliente"].ToString() + " Nombre completo: " + registro["Nombre"].ToString() + " " +
                                registro["PrimerApellido"].ToString() + " " +
                                registro["SegundoApellido"].ToString()))
                        {
                            CargarSedeCliente(registro["IdCliente"].ToString());
                        }


                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente para mostrar sus sedes afiliadas");
            }

               
            conexion.Close();
            btnConsultarCliente.Enabled = false;
        }

        public void CargarSedeCliente(string idcliente)
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader registro;
            string cadenaConexion = ("server=ENRIQUE-ES ; database=FITUNED ; integrated security = true");
            conexion = new SqlConnection(cadenaConexion);

            sentencia = " Select	IdAfiliacion,    FechaAfiliacion,	    IdCliente,	    IdSede" +
                       " From	    AfiliacionSede";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            conexion.Open();

            registro = comando.ExecuteReader();

            if (registro.HasRows)
            {

                while (registro.Read())
                {
                   if(idcliente == registro["IdCliente"].ToString())
                    {
                        dgvSedesReg.Rows.Add(registro["IdAfiliacion"].ToString(), registro["FechaAfiliacion"].ToString(),
                            registro["IdCliente"].ToString(), registro["IdSede"].ToString());
                    }


                }
            }
            conexion.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvSedesReg.Rows.Clear();
            btnConsultarCliente.Enabled = true;
            cbClientes.Enabled = true;
           
        }
    }
}
