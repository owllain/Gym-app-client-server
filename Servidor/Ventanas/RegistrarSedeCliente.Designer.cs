
namespace Servidor.Ventanas
{
    partial class RegistrarSedeCliente
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
            this.lblSedeRegistrar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSedesReg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSedesreg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSedes = new System.Windows.Forms.DataGridView();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.lblClientesreg = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.lblEncabezadoReg = new System.Windows.Forms.Label();
            this.btnRegistraSedes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdSedeCliente = new System.Windows.Forms.TextBox();
            this.btnSeleccionarSede = new System.Windows.Forms.Button();
            this.dtpRegAfiliacion = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSedesReg)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSedeRegistrar
            // 
            this.lblSedeRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSedeRegistrar.AutoSize = true;
            this.lblSedeRegistrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSedeRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSedeRegistrar.Location = new System.Drawing.Point(15, 426);
            this.lblSedeRegistrar.Name = "lblSedeRegistrar";
            this.lblSedeRegistrar.Size = new System.Drawing.Size(308, 24);
            this.lblSedeRegistrar.TabIndex = 41;
            this.lblSedeRegistrar.Text = "Sede  en proceso de registro:";
            this.lblSedeRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvSedesReg);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(15, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 83);
            this.panel2.TabIndex = 40;
            // 
            // dgvSedesReg
            // 
            this.dgvSedesReg.AllowUserToAddRows = false;
            this.dgvSedesReg.AllowUserToDeleteRows = false;
            this.dgvSedesReg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSedesReg.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSedesReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSedesReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSedesReg.Location = new System.Drawing.Point(0, 0);
            this.dgvSedesReg.Name = "dgvSedesReg";
            this.dgvSedesReg.ReadOnly = true;
            this.dgvSedesReg.RowTemplate.Height = 25;
            this.dgvSedesReg.Size = new System.Drawing.Size(692, 83);
            this.dgvSedesReg.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Fecha de la afiliación:";
            // 
            // lblSedesreg
            // 
            this.lblSedesreg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSedesreg.AutoSize = true;
            this.lblSedesreg.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSedesreg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSedesreg.Location = new System.Drawing.Point(15, 229);
            this.lblSedesreg.Name = "lblSedesreg";
            this.lblSedesreg.Size = new System.Drawing.Size(211, 24);
            this.lblSedesreg.TabIndex = 37;
            this.lblSedesreg.Text = "Seleccione la sede:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvSedes);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(15, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 138);
            this.panel1.TabIndex = 36;
            // 
            // dgvSedes
            // 
            this.dgvSedes.AllowUserToAddRows = false;
            this.dgvSedes.AllowUserToDeleteRows = false;
            this.dgvSedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSedes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSedes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSedes.Location = new System.Drawing.Point(0, 0);
            this.dgvSedes.Name = "dgvSedes";
            this.dgvSedes.ReadOnly = true;
            this.dgvSedes.RowTemplate.Height = 25;
            this.dgvSedes.Size = new System.Drawing.Size(692, 138);
            this.dgvSedes.TabIndex = 18;
            // 
            // cbClientes
            // 
            this.cbClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(12, 129);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(695, 29);
            this.cbClientes.TabIndex = 35;
            this.cbClientes.SelectedIndexChanged += new System.EventHandler(this.cbClientes_SelectedIndexChanged_1);
            // 
            // lblClientesreg
            // 
            this.lblClientesreg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClientesreg.AutoSize = true;
            this.lblClientesreg.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClientesreg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClientesreg.Location = new System.Drawing.Point(12, 102);
            this.lblClientesreg.Name = "lblClientesreg";
            this.lblClientesreg.Size = new System.Drawing.Size(292, 24);
            this.lblClientesreg.TabIndex = 34;
            this.lblClientesreg.Text = "Lista de Clientes registrados:";
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
            this.btnSalir.TabIndex = 33;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblEncabezadoReg
            // 
            this.lblEncabezadoReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEncabezadoReg.AutoSize = true;
            this.lblEncabezadoReg.Font = new System.Drawing.Font("Century Gothic", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEncabezadoReg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEncabezadoReg.Location = new System.Drawing.Point(49, 9);
            this.lblEncabezadoReg.Name = "lblEncabezadoReg";
            this.lblEncabezadoReg.Size = new System.Drawing.Size(660, 66);
            this.lblEncabezadoReg.TabIndex = 32;
            this.lblEncabezadoReg.Text = "Registro de Afiliaciones";
            // 
            // btnRegistraSedes
            // 
            this.btnRegistraSedes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistraSedes.BackColor = System.Drawing.Color.Navy;
            this.btnRegistraSedes.FlatAppearance.BorderSize = 0;
            this.btnRegistraSedes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRegistraSedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistraSedes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistraSedes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistraSedes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistraSedes.Location = new System.Drawing.Point(561, 544);
            this.btnRegistraSedes.Name = "btnRegistraSedes";
            this.btnRegistraSedes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRegistraSedes.Size = new System.Drawing.Size(150, 25);
            this.btnRegistraSedes.TabIndex = 42;
            this.btnRegistraSedes.Text = "Guardar";
            this.btnRegistraSedes.UseVisualStyleBackColor = false;
            this.btnRegistraSedes.Click += new System.EventHandler(this.btnRegistraSedes_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(232, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "ID:";
            // 
            // txtIdSedeCliente
            // 
            this.txtIdSedeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdSedeCliente.Location = new System.Drawing.Point(274, 230);
            this.txtIdSedeCliente.Name = "txtIdSedeCliente";
            this.txtIdSedeCliente.Size = new System.Drawing.Size(150, 23);
            this.txtIdSedeCliente.TabIndex = 44;
            this.txtIdSedeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdSedeCliente_KeyPress);
            // 
            // btnSeleccionarSede
            // 
            this.btnSeleccionarSede.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionarSede.BackColor = System.Drawing.Color.Navy;
            this.btnSeleccionarSede.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarSede.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSeleccionarSede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarSede.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeleccionarSede.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSeleccionarSede.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarSede.Location = new System.Drawing.Point(446, 230);
            this.btnSeleccionarSede.Name = "btnSeleccionarSede";
            this.btnSeleccionarSede.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSeleccionarSede.Size = new System.Drawing.Size(150, 25);
            this.btnSeleccionarSede.TabIndex = 43;
            this.btnSeleccionarSede.Text = "Registrar Sede";
            this.btnSeleccionarSede.UseVisualStyleBackColor = false;
            this.btnSeleccionarSede.Click += new System.EventHandler(this.btnSeleccionarSede_Click);
            // 
            // dtpRegAfiliacion
            // 
            this.dtpRegAfiliacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpRegAfiliacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegAfiliacion.Location = new System.Drawing.Point(274, 194);
            this.dtpRegAfiliacion.Name = "dtpRegAfiliacion";
            this.dtpRegAfiliacion.Size = new System.Drawing.Size(150, 23);
            this.dtpRegAfiliacion.TabIndex = 47;
            this.dtpRegAfiliacion.Value = new System.DateTime(2022, 3, 24, 0, 0, 0, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.Navy;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(405, 544);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLimpiar.Size = new System.Drawing.Size(150, 25);
            this.btnLimpiar.TabIndex = 48;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // RegistrarSedeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 579);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dtpRegAfiliacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdSedeCliente);
            this.Controls.Add(this.btnSeleccionarSede);
            this.Controls.Add(this.btnRegistraSedes);
            this.Controls.Add(this.lblSedeRegistrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSedesreg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.lblClientesreg);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblEncabezadoReg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarSedeCliente";
            this.Text = "RegistrarSedeCliente";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSedesReg)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSedeRegistrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSedesReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSedesreg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSedes;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label lblClientesreg;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label lblEncabezadoReg;
        private System.Windows.Forms.Button btnRegistraSedes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdSedeCliente;
        private System.Windows.Forms.Button btnSeleccionarSede;
        private System.Windows.Forms.DateTimePicker dtpRegAfiliacion;
        private System.Windows.Forms.Button btnLimpiar;
    }
}