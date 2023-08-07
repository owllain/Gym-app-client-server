
namespace Servidor.Ventanas
{
    partial class ConsultaSedeCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEncabezadoReg = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.lblClientesreg = new System.Windows.Forms.Label();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.lblSedeRegistrar = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvSedesReg = new System.Windows.Forms.DataGridView();
            this.IdAfiliacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAfiliacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSedesReg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEncabezadoReg
            // 
            this.lblEncabezadoReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEncabezadoReg.AutoSize = true;
            this.lblEncabezadoReg.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEncabezadoReg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEncabezadoReg.Location = new System.Drawing.Point(81, 9);
            this.lblEncabezadoReg.Name = "lblEncabezadoReg";
            this.lblEncabezadoReg.Size = new System.Drawing.Size(626, 154);
            this.lblEncabezadoReg.TabIndex = 27;
            this.lblEncabezadoReg.Text = "Consulta de Sedes \r\nde Clientes";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::Servidor.Properties.Resources.cruzar;
            this.btnSalir.Location = new System.Drawing.Point(12, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(27, 28);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 26;
            this.btnSalir.TabStop = false;
            // 
            // cbClientes
            // 
            this.cbClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(6, 190);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(692, 29);
            this.cbClientes.TabIndex = 29;
            // 
            // lblClientesreg
            // 
            this.lblClientesreg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClientesreg.AutoSize = true;
            this.lblClientesreg.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClientesreg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClientesreg.Location = new System.Drawing.Point(9, 163);
            this.lblClientesreg.Name = "lblClientesreg";
            this.lblClientesreg.Size = new System.Drawing.Size(343, 24);
            this.lblClientesreg.TabIndex = 28;
            this.lblClientesreg.Text = "Lista de Clientes con afiliaciones:";
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultarCliente.BackColor = System.Drawing.Color.Navy;
            this.btnConsultarCliente.FlatAppearance.BorderSize = 0;
            this.btnConsultarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConsultarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarCliente.Location = new System.Drawing.Point(476, 237);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConsultarCliente.Size = new System.Drawing.Size(108, 50);
            this.btnConsultarCliente.TabIndex = 30;
            this.btnConsultarCliente.Text = "Consultar Cliente";
            this.btnConsultarCliente.UseVisualStyleBackColor = false;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // lblSedeRegistrar
            // 
            this.lblSedeRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSedeRegistrar.AutoSize = true;
            this.lblSedeRegistrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSedeRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSedeRegistrar.Location = new System.Drawing.Point(12, 303);
            this.lblSedeRegistrar.Name = "lblSedeRegistrar";
            this.lblSedeRegistrar.Size = new System.Drawing.Size(245, 24);
            this.lblSedeRegistrar.TabIndex = 34;
            this.lblSedeRegistrar.Text = "Lista de Sedes afiliadas:";
            this.lblSedeRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.Navy;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(590, 237);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLimpiar.Size = new System.Drawing.Size(108, 50);
            this.btnLimpiar.TabIndex = 36;
            this.btnLimpiar.Text = "Limpiar registro";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvSedesReg
            // 
            this.dgvSedesReg.AllowUserToAddRows = false;
            this.dgvSedesReg.AllowUserToDeleteRows = false;
            this.dgvSedesReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSedesReg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSedesReg.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSedesReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSedesReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAfiliacion,
            this.FechaAfiliacion,
            this.IdCliente,
            this.IdSede});
            this.dgvSedesReg.Location = new System.Drawing.Point(0, 0);
            this.dgvSedesReg.Name = "dgvSedesReg";
            this.dgvSedesReg.ReadOnly = true;
            this.dgvSedesReg.RowTemplate.Height = 25;
            this.dgvSedesReg.Size = new System.Drawing.Size(695, 226);
            this.dgvSedesReg.TabIndex = 18;
            // 
            // IdAfiliacion
            // 
            this.IdAfiliacion.HeaderText = "IdAfiliacion";
            this.IdAfiliacion.Name = "IdAfiliacion";
            this.IdAfiliacion.ReadOnly = true;
            // 
            // FechaAfiliacion
            // 
            this.FechaAfiliacion.HeaderText = "FechaAfiliacion";
            this.FechaAfiliacion.Name = "FechaAfiliacion";
            this.FechaAfiliacion.ReadOnly = true;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            // 
            // IdSede
            // 
            this.IdSede.HeaderText = "IdSede";
            this.IdSede.Name = "IdSede";
            this.IdSede.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvSedesReg);
            this.panel1.Location = new System.Drawing.Point(12, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 226);
            this.panel1.TabIndex = 37;
            // 
            // ConsultaSedeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblSedeRegistrar);
            this.Controls.Add(this.btnConsultarCliente);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.lblClientesreg);
            this.Controls.Add(this.lblEncabezadoReg);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaSedeCliente";
            this.Text = "ConsultaSedeCliente";
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSedesReg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncabezadoReg;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label lblClientesreg;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Label lblSedeRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvSedesReg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAfiliacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAfiliacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSede;
    }
}