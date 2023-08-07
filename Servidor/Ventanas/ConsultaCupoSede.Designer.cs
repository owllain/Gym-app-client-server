
namespace Servidor.Ventanas
{
    partial class ConsultaCupoSede
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
            this.btnConsultaCupo = new System.Windows.Forms.Button();
            this.lblEncabezadoReg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCupoSede = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCupoSede)).BeginInit();
            this.SuspendLayout();
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
            this.btnSalir.TabIndex = 35;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnConsultaCupo.Location = new System.Drawing.Point(557, 537);
            this.btnConsultaCupo.Name = "btnConsultaCupo";
            this.btnConsultaCupo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConsultaCupo.Size = new System.Drawing.Size(150, 30);
            this.btnConsultaCupo.TabIndex = 34;
            this.btnConsultaCupo.Text = "Consultar\r\n";
            this.btnConsultaCupo.UseVisualStyleBackColor = false;
            this.btnConsultaCupo.Click += new System.EventHandler(this.btnConsultaCupo_Click);
            // 
            // lblEncabezadoReg
            // 
            this.lblEncabezadoReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEncabezadoReg.AutoSize = true;
            this.lblEncabezadoReg.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEncabezadoReg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEncabezadoReg.Location = new System.Drawing.Point(72, 25);
            this.lblEncabezadoReg.Name = "lblEncabezadoReg";
            this.lblEncabezadoReg.Size = new System.Drawing.Size(622, 77);
            this.lblEncabezadoReg.TabIndex = 32;
            this.lblEncabezadoReg.Text = "Consulta de Cupos";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvCupoSede);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(27, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 366);
            this.panel1.TabIndex = 33;
            // 
            // dgvCupoSede
            // 
            this.dgvCupoSede.AllowUserToAddRows = false;
            this.dgvCupoSede.AllowUserToDeleteRows = false;
            this.dgvCupoSede.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCupoSede.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCupoSede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCupoSede.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCupoSede.Location = new System.Drawing.Point(0, 0);
            this.dgvCupoSede.Name = "dgvCupoSede";
            this.dgvCupoSede.ReadOnly = true;
            this.dgvCupoSede.RowTemplate.Height = 25;
            this.dgvCupoSede.Size = new System.Drawing.Size(666, 366);
            this.dgvCupoSede.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(527, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 36);
            this.label1.TabIndex = 36;
            this.label1.Text = "por Sede";
            // 
            // ConsultaCupoSede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultaCupo);
            this.Controls.Add(this.lblEncabezadoReg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaCupoSede";
            this.Text = "ConsultaCupoSede";
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCupoSede)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Button btnConsultaCupo;
        private System.Windows.Forms.Label lblEncabezadoReg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCupoSede;
        private System.Windows.Forms.Label label1;
    }
}