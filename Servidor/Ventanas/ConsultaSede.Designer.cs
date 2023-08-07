
namespace Servidor.Ventanas
{
    partial class ConsultaSede
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
            this.btnConsultaSede = new System.Windows.Forms.Button();
            this.lblEncabezadoReg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSedes = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultaSede
            // 
            this.btnConsultaSede.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultaSede.BackColor = System.Drawing.Color.Navy;
            this.btnConsultaSede.FlatAppearance.BorderSize = 0;
            this.btnConsultaSede.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultaSede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaSede.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultaSede.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConsultaSede.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaSede.Location = new System.Drawing.Point(557, 537);
            this.btnConsultaSede.Name = "btnConsultaSede";
            this.btnConsultaSede.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConsultaSede.Size = new System.Drawing.Size(150, 30);
            this.btnConsultaSede.TabIndex = 25;
            this.btnConsultaSede.Text = "Consultar\r\n";
            this.btnConsultaSede.UseVisualStyleBackColor = false;
            this.btnConsultaSede.Click += new System.EventHandler(this.btnConsultaSede_Click);
            // 
            // lblEncabezadoReg
            // 
            this.lblEncabezadoReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEncabezadoReg.AutoSize = true;
            this.lblEncabezadoReg.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEncabezadoReg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEncabezadoReg.Location = new System.Drawing.Point(72, 25);
            this.lblEncabezadoReg.Name = "lblEncabezadoReg";
            this.lblEncabezadoReg.Size = new System.Drawing.Size(608, 77);
            this.lblEncabezadoReg.TabIndex = 23;
            this.lblEncabezadoReg.Text = "Consulta de Sedes";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvSedes);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(27, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 366);
            this.panel1.TabIndex = 24;
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
            this.dgvSedes.Size = new System.Drawing.Size(666, 366);
            this.dgvSedes.TabIndex = 18;
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
            this.btnSalir.TabIndex = 31;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ConsultaSede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 579);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultaSede);
            this.Controls.Add(this.lblEncabezadoReg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaSede";
            this.Text = "ConsultaSede";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaSede;
        private System.Windows.Forms.Label lblEncabezadoReg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSedes;
        private System.Windows.Forms.PictureBox btnSalir;
    }
}