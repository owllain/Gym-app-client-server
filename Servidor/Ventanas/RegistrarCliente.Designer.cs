
namespace Servidor.Ventanas
{
    partial class RegistrarCliente
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
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblEncabezadoReg = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnRegistraSedes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngreso.Location = new System.Drawing.Point(413, 409);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(150, 23);
            this.dtpIngreso.TabIndex = 37;
            this.dtpIngreso.Value = new System.DateTime(2022, 3, 27, 0, 0, 0, 0);
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(413, 319);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(150, 23);
            this.dtpNacimiento.TabIndex = 47;
            this.dtpNacimiento.Value = new System.DateTime(2022, 3, 27, 0, 0, 0, 0);
            // 
            // cbGenero
            // 
            this.cbGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(413, 359);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(150, 29);
            this.cbGenero.TabIndex = 36;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido2.Location = new System.Drawing.Point(413, 274);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(150, 23);
            this.txtApellido2.TabIndex = 35;
            this.txtApellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido2_KeyPress);
            // 
            // txtApellido1
            // 
            this.txtApellido1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido1.Location = new System.Drawing.Point(413, 229);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(150, 23);
            this.txtApellido1.TabIndex = 34;
            this.txtApellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido1_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(413, 184);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 23);
            this.txtNombre.TabIndex = 33;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaIngreso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFechaIngreso.Location = new System.Drawing.Point(155, 409);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(192, 24);
            this.lblFechaIngreso.TabIndex = 46;
            this.lblFechaIngreso.Text = "Fecha de ingreso:";
            // 
            // lblGenero
            // 
            this.lblGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenero.Location = new System.Drawing.Point(155, 364);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(94, 24);
            this.lblGenero.TabIndex = 45;
            this.lblGenero.Text = "Genero:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaNacimiento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(155, 319);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(236, 24);
            this.lblFechaNacimiento.TabIndex = 44;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblApellido2
            // 
            this.lblApellido2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblApellido2.Location = new System.Drawing.Point(155, 274);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(196, 24);
            this.lblApellido2.TabIndex = 43;
            this.lblApellido2.Text = "Segundo apellido:";
            // 
            // lblApellido1
            // 
            this.lblApellido1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblApellido1.Location = new System.Drawing.Point(155, 229);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(166, 24);
            this.lblApellido1.TabIndex = 42;
            this.lblApellido1.Text = "Primer apellido:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreCliente.Location = new System.Drawing.Point(155, 184);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(100, 24);
            this.lblNombreCliente.TabIndex = 41;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Location = new System.Drawing.Point(413, 139);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 23);
            this.txtId.TabIndex = 32;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdentificacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIdentificacion.Location = new System.Drawing.Point(155, 139);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(153, 24);
            this.lblIdentificacion.TabIndex = 40;
            this.lblIdentificacion.Text = "Identificación:";
            // 
            // lblEncabezadoReg
            // 
            this.lblEncabezadoReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEncabezadoReg.AutoSize = true;
            this.lblEncabezadoReg.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEncabezadoReg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEncabezadoReg.Location = new System.Drawing.Point(79, 12);
            this.lblEncabezadoReg.Name = "lblEncabezadoReg";
            this.lblEncabezadoReg.Size = new System.Drawing.Size(642, 77);
            this.lblEncabezadoReg.TabIndex = 39;
            this.lblEncabezadoReg.Text = "Registro de Clientes";
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
            this.btnSalir.TabIndex = 38;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistraSedes
            // 
            this.btnRegistraSedes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistraSedes.BackColor = System.Drawing.Color.Navy;
            this.btnRegistraSedes.FlatAppearance.BorderSize = 0;
            this.btnRegistraSedes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRegistraSedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistraSedes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistraSedes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistraSedes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistraSedes.Location = new System.Drawing.Point(557, 517);
            this.btnRegistraSedes.Name = "btnRegistraSedes";
            this.btnRegistraSedes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRegistraSedes.Size = new System.Drawing.Size(150, 50);
            this.btnRegistraSedes.TabIndex = 48;
            this.btnRegistraSedes.Text = "Guardar";
            this.btnRegistraSedes.UseVisualStyleBackColor = false;
            this.btnRegistraSedes.Click += new System.EventHandler(this.btnRegistraSedes_Click);
            // 
            // RegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 579);
            this.Controls.Add(this.btnRegistraSedes);
            this.Controls.Add(this.dtpIngreso);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblApellido2);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.lblEncabezadoReg);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarCliente";
            this.Text = "RegistrarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblEncabezadoReg;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Button btnRegistraSedes;
    }
}