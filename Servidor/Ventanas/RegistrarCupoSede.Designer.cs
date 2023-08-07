
namespace Servidor.Ventanas
{
    partial class RegistrarCupoSede
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
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.lblEncabezadoReg = new System.Windows.Forms.Label();
            this.dtpRegCupo = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCupos = new System.Windows.Forms.Label();
            this.txtRegCupo = new System.Windows.Forms.TextBox();
            this.lblRegistroCupos = new System.Windows.Forms.Label();
            this.lblListaSedes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdSede = new System.Windows.Forms.TextBox();
            this.btnSeleccionarSede = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSedes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSedes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::Servidor.Properties.Resources.cruzar;
            this.btnSalir.Location = new System.Drawing.Point(12, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(27, 28);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 39;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblEncabezadoReg
            // 
            this.lblEncabezadoReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEncabezadoReg.AutoSize = true;
            this.lblEncabezadoReg.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEncabezadoReg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEncabezadoReg.Location = new System.Drawing.Point(79, 12);
            this.lblEncabezadoReg.Name = "lblEncabezadoReg";
            this.lblEncabezadoReg.Size = new System.Drawing.Size(594, 77);
            this.lblEncabezadoReg.TabIndex = 40;
            this.lblEncabezadoReg.Text = "Registro de Cupos";
            // 
            // dtpRegCupo
            // 
            this.dtpRegCupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpRegCupo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegCupo.Location = new System.Drawing.Point(319, 188);
            this.dtpRegCupo.Name = "dtpRegCupo";
            this.dtpRegCupo.Size = new System.Drawing.Size(150, 23);
            this.dtpRegCupo.TabIndex = 53;
            this.dtpRegCupo.Value = new System.DateTime(2022, 3, 27, 0, 0, 0, 0);
            // 
            // lblFechaCupos
            // 
            this.lblFechaCupos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaCupos.AutoSize = true;
            this.lblFechaCupos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaCupos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFechaCupos.Location = new System.Drawing.Point(76, 187);
            this.lblFechaCupos.Name = "lblFechaCupos";
            this.lblFechaCupos.Size = new System.Drawing.Size(237, 24);
            this.lblFechaCupos.TabIndex = 54;
            this.lblFechaCupos.Text = "Fecha de habilitación:";
            // 
            // txtRegCupo
            // 
            this.txtRegCupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegCupo.Location = new System.Drawing.Point(319, 146);
            this.txtRegCupo.Name = "txtRegCupo";
            this.txtRegCupo.Size = new System.Drawing.Size(150, 23);
            this.txtRegCupo.TabIndex = 51;
            this.txtRegCupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegCupo_KeyPress);
            // 
            // lblRegistroCupos
            // 
            this.lblRegistroCupos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistroCupos.AutoSize = true;
            this.lblRegistroCupos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegistroCupos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRegistroCupos.Location = new System.Drawing.Point(76, 146);
            this.lblRegistroCupos.Name = "lblRegistroCupos";
            this.lblRegistroCupos.Size = new System.Drawing.Size(186, 24);
            this.lblRegistroCupos.TabIndex = 52;
            this.lblRegistroCupos.Text = "Cupos a habilitar:";
            // 
            // lblListaSedes
            // 
            this.lblListaSedes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblListaSedes.AutoSize = true;
            this.lblListaSedes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListaSedes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblListaSedes.Location = new System.Drawing.Point(76, 225);
            this.lblListaSedes.Name = "lblListaSedes";
            this.lblListaSedes.Size = new System.Drawing.Size(237, 24);
            this.lblListaSedes.TabIndex = 50;
            this.lblListaSedes.Text = "Lista de Sedes Activas:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(249, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 57;
            this.label2.Text = "ID de la sede:";
            // 
            // txtIdSede
            // 
            this.txtIdSede.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdSede.Location = new System.Drawing.Point(406, 261);
            this.txtIdSede.Name = "txtIdSede";
            this.txtIdSede.Size = new System.Drawing.Size(130, 23);
            this.txtIdSede.TabIndex = 56;
            this.txtIdSede.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdSede_KeyPress);
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
            this.btnSeleccionarSede.Location = new System.Drawing.Point(542, 255);
            this.btnSeleccionarSede.Name = "btnSeleccionarSede";
            this.btnSeleccionarSede.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSeleccionarSede.Size = new System.Drawing.Size(152, 43);
            this.btnSeleccionarSede.TabIndex = 55;
            this.btnSeleccionarSede.Text = "Registrar Cupos";
            this.btnSeleccionarSede.UseVisualStyleBackColor = false;
            this.btnSeleccionarSede.Click += new System.EventHandler(this.btnSeleccionarSede_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvSedes);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(12, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 257);
            this.panel1.TabIndex = 58;
            // 
            // dgvSedes
            // 
            this.dgvSedes.AllowUserToAddRows = false;
            this.dgvSedes.AllowUserToDeleteRows = false;
            this.dgvSedes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSedes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSedes.Location = new System.Drawing.Point(0, 0);
            this.dgvSedes.Name = "dgvSedes";
            this.dgvSedes.ReadOnly = true;
            this.dgvSedes.RowTemplate.Height = 25;
            this.dgvSedes.Size = new System.Drawing.Size(695, 257);
            this.dgvSedes.TabIndex = 18;
            // 
            // RegistrarCupoSede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdSede);
            this.Controls.Add(this.btnSeleccionarSede);
            this.Controls.Add(this.dtpRegCupo);
            this.Controls.Add(this.lblFechaCupos);
            this.Controls.Add(this.txtRegCupo);
            this.Controls.Add(this.lblRegistroCupos);
            this.Controls.Add(this.lblListaSedes);
            this.Controls.Add(this.lblEncabezadoReg);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarCupoSede";
            this.Text = "RegistrarCupoSede";
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label lblEncabezadoReg;
        private System.Windows.Forms.DateTimePicker dtpRegCupo;
        private System.Windows.Forms.Label lblFechaCupos;
        private System.Windows.Forms.TextBox txtRegCupo;
        private System.Windows.Forms.Label lblRegistroCupos;
        private System.Windows.Forms.Label lblListaSedes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdSede;
        private System.Windows.Forms.Button btnSeleccionarSede;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSedes;
    }
}