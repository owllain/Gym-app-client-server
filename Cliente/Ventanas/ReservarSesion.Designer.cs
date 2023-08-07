
namespace Cliente.Ventanas
{
    partial class ReservarSesion
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtReserva = new System.Windows.Forms.TextBox();
            this.lblReservacion = new System.Windows.Forms.Label();
            this.lblEncabezadoReg = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblSede = new System.Windows.Forms.Label();
            this.cbSedes = new System.Windows.Forms.ComboBox();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(343, 281);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(150, 23);
            this.dtpFecha.TabIndex = 57;
            this.dtpFecha.Value = new System.DateTime(2022, 4, 29, 0, 0, 0, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFecha.Location = new System.Drawing.Point(161, 274);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(95, 30);
            this.lblFecha.TabIndex = 58;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtReserva
            // 
            this.txtReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReserva.Enabled = false;
            this.txtReserva.Location = new System.Drawing.Point(343, 246);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(150, 23);
            this.txtReserva.TabIndex = 55;
            // 
            // lblReservacion
            // 
            this.lblReservacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReservacion.AutoSize = true;
            this.lblReservacion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReservacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReservacion.Location = new System.Drawing.Point(161, 237);
            this.lblReservacion.Name = "lblReservacion";
            this.lblReservacion.Size = new System.Drawing.Size(168, 30);
            this.lblReservacion.TabIndex = 56;
            this.lblReservacion.Text = "Reservacion:";
            // 
            // lblEncabezadoReg
            // 
            this.lblEncabezadoReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEncabezadoReg.AutoSize = true;
            this.lblEncabezadoReg.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEncabezadoReg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEncabezadoReg.Location = new System.Drawing.Point(75, 9);
            this.lblEncabezadoReg.Name = "lblEncabezadoReg";
            this.lblEncabezadoReg.Size = new System.Drawing.Size(482, 77);
            this.lblEncabezadoReg.TabIndex = 60;
            this.lblEncabezadoReg.Text = "Reservaciones";
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(343, 170);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(150, 23);
            this.txtCliente.TabIndex = 61;
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCliente.Location = new System.Drawing.Point(161, 163);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(107, 30);
            this.lblCliente.TabIndex = 62;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblSede
            // 
            this.lblSede.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSede.AutoSize = true;
            this.lblSede.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSede.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSede.Location = new System.Drawing.Point(161, 200);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(80, 30);
            this.lblSede.TabIndex = 64;
            this.lblSede.Text = "Sede:";
            // 
            // cbSedes
            // 
            this.cbSedes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSedes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSedes.FormattingEnabled = true;
            this.cbSedes.Location = new System.Drawing.Point(343, 205);
            this.cbSedes.Name = "cbSedes";
            this.cbSedes.Size = new System.Drawing.Size(150, 29);
            this.cbSedes.TabIndex = 65;
            // 
            // btnReserva
            // 
            this.btnReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReserva.BackColor = System.Drawing.Color.Navy;
            this.btnReserva.FlatAppearance.BorderSize = 0;
            this.btnReserva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserva.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReserva.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReserva.Location = new System.Drawing.Point(473, 523);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReserva.Size = new System.Drawing.Size(150, 50);
            this.btnReserva.TabIndex = 66;
            this.btnReserva.Text = "Reservar";
            this.btnReserva.UseVisualStyleBackColor = false;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::Cliente.Properties.Resources.cruzar;
            this.btnSalir.Location = new System.Drawing.Point(12, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(27, 28);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 67;
            this.btnSalir.TabStop = false;
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
            this.btnLimpiar.Location = new System.Drawing.Point(317, 523);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLimpiar.Size = new System.Drawing.Size(150, 50);
            this.btnLimpiar.TabIndex = 68;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // ReservarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 585);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.cbSedes);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblEncabezadoReg);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtReserva);
            this.Controls.Add(this.lblReservacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservarSesion";
            this.Text = "ReservaSesion";
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtReserva;
        private System.Windows.Forms.Label lblReservacion;
        private System.Windows.Forms.Label lblEncabezadoReg;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.ComboBox cbSedes;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
    }
}