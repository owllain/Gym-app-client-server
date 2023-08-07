
namespace Cliente.Ventanas
{
    partial class ConsultaReserva
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
            this.btnConsultaCupo = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEncabezadoReg
            // 
            this.lblEncabezadoReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEncabezadoReg.AutoSize = true;
            this.lblEncabezadoReg.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEncabezadoReg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEncabezadoReg.Location = new System.Drawing.Point(75, 9);
            this.lblEncabezadoReg.Name = "lblEncabezadoReg";
            this.lblEncabezadoReg.Size = new System.Drawing.Size(448, 56);
            this.lblEncabezadoReg.TabIndex = 62;
            this.lblEncabezadoReg.Text = "Consulta Reservas";
            // 
            // btnConsultaCupo
            // 
            this.btnConsultaCupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultaCupo.BackColor = System.Drawing.Color.Navy;
            this.btnConsultaCupo.FlatAppearance.BorderSize = 0;
            this.btnConsultaCupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultaCupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaCupo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultaCupo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConsultaCupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaCupo.Location = new System.Drawing.Point(473, 527);
            this.btnConsultaCupo.Name = "btnConsultaCupo";
            this.btnConsultaCupo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConsultaCupo.Size = new System.Drawing.Size(150, 46);
            this.btnConsultaCupo.TabIndex = 64;
            this.btnConsultaCupo.Text = "Consultar\r\n";
            this.btnConsultaCupo.UseVisualStyleBackColor = false;
            this.btnConsultaCupo.Click += new System.EventHandler(this.btnConsultaCupo_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(75, 102);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowTemplate.Height = 25;
            this.dgvReservas.Size = new System.Drawing.Size(482, 376);
            this.dgvReservas.TabIndex = 63;
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
            this.btnSalir.TabIndex = 65;
            this.btnSalir.TabStop = false;
            // 
            // ConsultaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 585);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultaCupo);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.lblEncabezadoReg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaReserva";
            this.Text = "ConsultaReserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncabezadoReg;
        private System.Windows.Forms.Button btnConsultaCupo;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.PictureBox btnSalir;
    }
}