
namespace Servidor
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenuVertical = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.gpBotones = new System.Windows.Forms.GroupBox();
            this.btnRegistraCupoSede = new System.Windows.Forms.Button();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.btnConsultaCupoSede = new System.Windows.Forms.Button();
            this.btnRegistrarSede = new System.Windows.Forms.Button();
            this.btnConsultaCliente = new System.Windows.Forms.Button();
            this.btnRegistraSedeCliente = new System.Windows.Forms.Button();
            this.btnConsultaSede = new System.Windows.Forms.Button();
            this.btnConsultaSedeCliente = new System.Windows.Forms.Button();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.pnlMonitor = new System.Windows.Forms.Panel();
            this.gpRegistro = new System.Windows.Forms.GroupBox();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.gpClientes = new System.Windows.Forms.GroupBox();
            this.listBitacora = new System.Windows.Forms.ListBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.Manual_PresioneF1 = new System.Windows.Forms.HelpProvider();
            this.pnlMenuVertical.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpBotones.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.pnlMonitor.SuspendLayout();
            this.gpRegistro.SuspendLayout();
            this.gpClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuVertical
            // 
            this.pnlMenuVertical.BackColor = System.Drawing.Color.Navy;
            this.pnlMenuVertical.Controls.Add(this.groupBox1);
            this.pnlMenuVertical.Controls.Add(this.label1);
            this.pnlMenuVertical.Controls.Add(this.pictureBox1);
            this.pnlMenuVertical.Controls.Add(this.lblEncabezado);
            this.pnlMenuVertical.Controls.Add(this.gpBotones);
            this.pnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuVertical.Name = "pnlMenuVertical";
            this.pnlMenuVertical.Size = new System.Drawing.Size(265, 750);
            this.pnlMenuVertical.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.btnDesconectar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.Location = new System.Drawing.Point(3, 627);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 111);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel de control";
            // 
            // btnConectar
            // 
            this.btnConectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConectar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnConectar.FlatAppearance.BorderSize = 0;
            this.btnConectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConectar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConectar.Location = new System.Drawing.Point(8, 69);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConectar.Size = new System.Drawing.Size(120, 35);
            this.btnConectar.TabIndex = 51;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesconectar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDesconectar.FlatAppearance.BorderSize = 0;
            this.btnDesconectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDesconectar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDesconectar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesconectar.Location = new System.Drawing.Point(132, 69);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDesconectar.Size = new System.Drawing.Size(120, 35);
            this.btnDesconectar.TabIndex = 52;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 57;
            this.label2.Text = "Estado:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEstado.Location = new System.Drawing.Point(80, 20);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(81, 20);
            this.lblEstado.TabIndex = 58;
            this.lblEstado.Text = "Sin iniciar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(69, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 45);
            this.label1.TabIndex = 53;
            this.label1.Text = "SERVIDOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Servidor.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEncabezado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEncabezado.Location = new System.Drawing.Point(69, 9);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(190, 47);
            this.lblEncabezado.TabIndex = 0;
            this.lblEncabezado.Text = " FITUNED";
            // 
            // gpBotones
            // 
            this.gpBotones.BackColor = System.Drawing.Color.Navy;
            this.gpBotones.Controls.Add(this.btnRegistraCupoSede);
            this.gpBotones.Controls.Add(this.btnRegistrarCliente);
            this.gpBotones.Controls.Add(this.btnConsultaCupoSede);
            this.gpBotones.Controls.Add(this.btnRegistrarSede);
            this.gpBotones.Controls.Add(this.btnConsultaCliente);
            this.gpBotones.Controls.Add(this.btnRegistraSedeCliente);
            this.gpBotones.Controls.Add(this.btnConsultaSede);
            this.gpBotones.Controls.Add(this.btnConsultaSedeCliente);
            this.gpBotones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpBotones.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpBotones.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.gpBotones.Location = new System.Drawing.Point(3, 110);
            this.gpBotones.Name = "gpBotones";
            this.gpBotones.Size = new System.Drawing.Size(259, 502);
            this.gpBotones.TabIndex = 52;
            this.gpBotones.TabStop = false;
            this.gpBotones.Text = "Menú";
            // 
            // btnRegistraCupoSede
            // 
            this.btnRegistraCupoSede.FlatAppearance.BorderSize = 0;
            this.btnRegistraCupoSede.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRegistraCupoSede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistraCupoSede.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistraCupoSede.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistraCupoSede.Image = global::Servidor.Properties.Resources.calendar;
            this.btnRegistraCupoSede.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistraCupoSede.Location = new System.Drawing.Point(6, 200);
            this.btnRegistraCupoSede.Name = "btnRegistraCupoSede";
            this.btnRegistraCupoSede.Size = new System.Drawing.Size(247, 50);
            this.btnRegistraCupoSede.TabIndex = 9;
            this.btnRegistraCupoSede.Text = "             Registrar Cupo por Sede";
            this.btnRegistraCupoSede.UseVisualStyleBackColor = true;
            this.btnRegistraCupoSede.Click += new System.EventHandler(this.btnRegistraCupoSede_Click);
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCliente.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarCliente.Image = global::Servidor.Properties.Resources.libreta_de_contactos;
            this.btnRegistrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCliente.Location = new System.Drawing.Point(6, 88);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(247, 50);
            this.btnRegistrarCliente.TabIndex = 3;
            this.btnRegistrarCliente.Text = "Registrar Cliente";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // btnConsultaCupoSede
            // 
            this.btnConsultaCupoSede.FlatAppearance.BorderSize = 0;
            this.btnConsultaCupoSede.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultaCupoSede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaCupoSede.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultaCupoSede.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConsultaCupoSede.Image = global::Servidor.Properties.Resources.growth;
            this.btnConsultaCupoSede.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaCupoSede.Location = new System.Drawing.Point(6, 424);
            this.btnConsultaCupoSede.Name = "btnConsultaCupoSede";
            this.btnConsultaCupoSede.Size = new System.Drawing.Size(247, 50);
            this.btnConsultaCupoSede.TabIndex = 8;
            this.btnConsultaCupoSede.Text = "             Consulta Cupos por Sede";
            this.btnConsultaCupoSede.UseVisualStyleBackColor = true;
            this.btnConsultaCupoSede.Click += new System.EventHandler(this.btnConsultaCupoSede_Click);
            // 
            // btnRegistrarSede
            // 
            this.btnRegistrarSede.BackColor = System.Drawing.Color.Navy;
            this.btnRegistrarSede.FlatAppearance.BorderSize = 0;
            this.btnRegistrarSede.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRegistrarSede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarSede.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarSede.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarSede.Image = global::Servidor.Properties.Resources.gym;
            this.btnRegistrarSede.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarSede.Location = new System.Drawing.Point(6, 32);
            this.btnRegistrarSede.Name = "btnRegistrarSede";
            this.btnRegistrarSede.Size = new System.Drawing.Size(247, 50);
            this.btnRegistrarSede.TabIndex = 2;
            this.btnRegistrarSede.Text = "Registrar Sede";
            this.btnRegistrarSede.UseVisualStyleBackColor = false;
            this.btnRegistrarSede.Click += new System.EventHandler(this.btnRegistrarSede_Click);
            // 
            // btnConsultaCliente
            // 
            this.btnConsultaCliente.FlatAppearance.BorderSize = 0;
            this.btnConsultaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaCliente.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultaCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConsultaCliente.Image = global::Servidor.Properties.Resources.sportman;
            this.btnConsultaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaCliente.Location = new System.Drawing.Point(6, 368);
            this.btnConsultaCliente.Name = "btnConsultaCliente";
            this.btnConsultaCliente.Size = new System.Drawing.Size(247, 50);
            this.btnConsultaCliente.TabIndex = 7;
            this.btnConsultaCliente.Text = "Consulta Cliente";
            this.btnConsultaCliente.UseVisualStyleBackColor = true;
            this.btnConsultaCliente.Click += new System.EventHandler(this.btnConsultaCliente_Click);
            // 
            // btnRegistraSedeCliente
            // 
            this.btnRegistraSedeCliente.FlatAppearance.BorderSize = 0;
            this.btnRegistraSedeCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRegistraSedeCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistraSedeCliente.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistraSedeCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistraSedeCliente.Image = global::Servidor.Properties.Resources.derivacion;
            this.btnRegistraSedeCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistraSedeCliente.Location = new System.Drawing.Point(6, 144);
            this.btnRegistraSedeCliente.Name = "btnRegistraSedeCliente";
            this.btnRegistraSedeCliente.Size = new System.Drawing.Size(247, 50);
            this.btnRegistraSedeCliente.TabIndex = 4;
            this.btnRegistraSedeCliente.Text = "             Registrar Sede de Cliente";
            this.btnRegistraSedeCliente.UseVisualStyleBackColor = true;
            this.btnRegistraSedeCliente.Click += new System.EventHandler(this.btnRegistraSedeCliente_Click);
            // 
            // btnConsultaSede
            // 
            this.btnConsultaSede.FlatAppearance.BorderSize = 0;
            this.btnConsultaSede.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultaSede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaSede.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultaSede.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConsultaSede.Image = global::Servidor.Properties.Resources.lockers;
            this.btnConsultaSede.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaSede.Location = new System.Drawing.Point(6, 312);
            this.btnConsultaSede.Name = "btnConsultaSede";
            this.btnConsultaSede.Size = new System.Drawing.Size(247, 50);
            this.btnConsultaSede.TabIndex = 6;
            this.btnConsultaSede.Text = "Consulta Sede";
            this.btnConsultaSede.UseVisualStyleBackColor = true;
            this.btnConsultaSede.Click += new System.EventHandler(this.btnConsultaSede_Click);
            // 
            // btnConsultaSedeCliente
            // 
            this.btnConsultaSedeCliente.FlatAppearance.BorderSize = 0;
            this.btnConsultaSedeCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConsultaSedeCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaSedeCliente.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultaSedeCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConsultaSedeCliente.Image = global::Servidor.Properties.Resources.online_store;
            this.btnConsultaSedeCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaSedeCliente.Location = new System.Drawing.Point(6, 256);
            this.btnConsultaSedeCliente.Name = "btnConsultaSedeCliente";
            this.btnConsultaSedeCliente.Size = new System.Drawing.Size(247, 50);
            this.btnConsultaSedeCliente.TabIndex = 5;
            this.btnConsultaSedeCliente.Text = "             Consulta Sede de Cliente";
            this.btnConsultaSedeCliente.UseVisualStyleBackColor = true;
            this.btnConsultaSedeCliente.Click += new System.EventHandler(this.btnConsultaSedeCliente_Click);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.Controls.Add(this.btnMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.btnMaximizar);
            this.pnlBarraTitulo.Controls.Add(this.btnSalir);
            this.pnlBarraTitulo.Controls.Add(this.btnRestaurar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(265, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(719, 32);
            this.pnlBarraTitulo.TabIndex = 1;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Servidor.Properties.Resources.menos;
            this.btnMinimizar.Location = new System.Drawing.Point(644, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::Servidor.Properties.Resources.detener;
            this.btnMaximizar.Location = new System.Drawing.Point(670, 6);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::Servidor.Properties.Resources.cruzar;
            this.btnSalir.Location = new System.Drawing.Point(696, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(20, 20);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 1;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::Servidor.Properties.Resources.capas;
            this.btnRestaurar.Location = new System.Drawing.Point(670, 6);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 4;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // pnlMonitor
            // 
            this.pnlMonitor.BackColor = System.Drawing.Color.Navy;
            this.pnlMonitor.Controls.Add(this.gpRegistro);
            this.pnlMonitor.Controls.Add(this.gpClientes);
            this.pnlMonitor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMonitor.Location = new System.Drawing.Point(265, 612);
            this.pnlMonitor.Name = "pnlMonitor";
            this.pnlMonitor.Size = new System.Drawing.Size(719, 138);
            this.pnlMonitor.TabIndex = 11;
            // 
            // gpRegistro
            // 
            this.gpRegistro.BackColor = System.Drawing.Color.Transparent;
            this.gpRegistro.Controls.Add(this.txtRegistro);
            this.gpRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpRegistro.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpRegistro.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.gpRegistro.Location = new System.Drawing.Point(371, 9);
            this.gpRegistro.Name = "gpRegistro";
            this.gpRegistro.Size = new System.Drawing.Size(290, 126);
            this.gpRegistro.TabIndex = 54;
            this.gpRegistro.TabStop = false;
            this.gpRegistro.Text = "Registro de solicitudes";
            // 
            // txtRegistro
            // 
            this.txtRegistro.BackColor = System.Drawing.Color.White;
            this.txtRegistro.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtRegistro.Location = new System.Drawing.Point(6, 21);
            this.txtRegistro.Multiline = true;
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRegistro.Size = new System.Drawing.Size(274, 89);
            this.txtRegistro.TabIndex = 0;
            // 
            // gpClientes
            // 
            this.gpClientes.BackColor = System.Drawing.Color.Transparent;
            this.gpClientes.Controls.Add(this.listBitacora);
            this.gpClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpClientes.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpClientes.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.gpClientes.Location = new System.Drawing.Point(53, 9);
            this.gpClientes.Name = "gpClientes";
            this.gpClientes.Size = new System.Drawing.Size(290, 126);
            this.gpClientes.TabIndex = 53;
            this.gpClientes.TabStop = false;
            this.gpClientes.Text = "Bitácora de conexiones";
            // 
            // listBitacora
            // 
            this.listBitacora.FormattingEnabled = true;
            this.listBitacora.ItemHeight = 17;
            this.listBitacora.Location = new System.Drawing.Point(6, 23);
            this.listBitacora.Name = "listBitacora";
            this.listBitacora.Size = new System.Drawing.Size(274, 89);
            this.listBitacora.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(265, 32);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(719, 580);
            this.pnlContenedor.TabIndex = 12;
            // 
            // Manual_PresioneF1
            // 
            this.Manual_PresioneF1.HelpNamespace = "C:\\Users\\tvlin\\OneDrive\\Documentos\\Workspace\\ProyectoFinal_AlvaroCascante\\Manual_" +
    "ProyectoFinal.html";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(984, 750);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMonitor);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.pnlMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Menu";
            this.Manual_PresioneF1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "  ";
            this.pnlMenuVertical.ResumeLayout(false);
            this.pnlMenuVertical.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpBotones.ResumeLayout(false);
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.pnlMonitor.ResumeLayout(false);
            this.gpRegistro.ResumeLayout(false);
            this.gpRegistro.PerformLayout();
            this.gpClientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuVertical;
        private System.Windows.Forms.Button btnRegistraCupoSede;
        private System.Windows.Forms.Button btnConsultaCupoSede;
        private System.Windows.Forms.Button btnConsultaCliente;
        private System.Windows.Forms.Button btnConsultaSede;
        private System.Windows.Forms.Button btnConsultaSedeCliente;
        private System.Windows.Forms.Button btnRegistraSedeCliente;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.Button btnRegistrarSede;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.GroupBox gpBotones;
        private System.Windows.Forms.Panel pnlMonitor;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox gpClientes;
        private System.Windows.Forms.ListBox listBitacora;
        private System.Windows.Forms.GroupBox gpRegistro;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.HelpProvider Manual_PresioneF1;
    }
}

