namespace TableSoft
{
    partial class frmInicioSupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSupervisor));
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.lklLogout = new System.Windows.Forms.LinkLabel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBibliotecasPUCP = new System.Windows.Forms.Label();
            this.lblTituloSistema = new System.Windows.Forms.Label();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.pnlInt = new System.Windows.Forms.Panel();
            this.pnlDer = new System.Windows.Forms.Panel();
            this.picGenerar = new System.Windows.Forms.PictureBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblGenerarReportes = new System.Windows.Forms.Label();
            this.lblDetalleGenerar = new System.Windows.Forms.Label();
            this.pnlMed = new System.Windows.Forms.Panel();
            this.picGestionar = new System.Windows.Forms.PictureBox();
            this.btnGestionar = new System.Windows.Forms.Button();
            this.lblGestionarTickets = new System.Windows.Forms.Label();
            this.lblDetalleGestionar = new System.Windows.Forms.Label();
            this.pnlIzq = new System.Windows.Forms.Panel();
            this.picAtender = new System.Windows.Forms.PictureBox();
            this.lblAtender = new System.Windows.Forms.Label();
            this.lblDetalleAtender = new System.Windows.Forms.Label();
            this.btnAtender = new System.Windows.Forms.Button();
            this.lblNombreEquipo = new System.Windows.Forms.Label();
            this.pnlOpciones.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.pnlExt.SuspendLayout();
            this.pnlInt.SuspendLayout();
            this.pnlDer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGenerar)).BeginInit();
            this.pnlMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGestionar)).BeginInit();
            this.pnlIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAtender)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(208)))));
            this.pnlOpciones.Controls.Add(this.lklLogout);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 106);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(1274, 51);
            this.pnlOpciones.TabIndex = 2;
            // 
            // lklLogout
            // 
            this.lklLogout.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.lklLogout.AutoSize = true;
            this.lklLogout.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklLogout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lklLogout.LinkColor = System.Drawing.Color.White;
            this.lklLogout.Location = new System.Drawing.Point(1118, 13);
            this.lklLogout.Name = "lklLogout";
            this.lklLogout.Size = new System.Drawing.Size(128, 25);
            this.lklLogout.TabIndex = 0;
            this.lklLogout.TabStop = true;
            this.lklLogout.Text = "Cerrar sesión";
            this.lklLogout.VisitedLinkColor = System.Drawing.Color.White;
            this.lklLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklLogout_LinkClicked);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.pnlTitulo.Controls.Add(this.lblNombreEquipo);
            this.pnlTitulo.Controls.Add(this.lblSupervisor);
            this.pnlTitulo.Controls.Add(this.lblUsuario);
            this.pnlTitulo.Controls.Add(this.lblBibliotecasPUCP);
            this.pnlTitulo.Controls.Add(this.lblTituloSistema);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1274, 106);
            this.pnlTitulo.TabIndex = 1;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupervisor.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisor.ForeColor = System.Drawing.Color.White;
            this.lblSupervisor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSupervisor.Location = new System.Drawing.Point(1115, 25);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSupervisor.Size = new System.Drawing.Size(131, 20);
            this.lblSupervisor.TabIndex = 4;
            this.lblSupervisor.Text = "SUPERVISOR";
            this.lblSupervisor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUsuario.Location = new System.Drawing.Point(834, 45);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsuario.Size = new System.Drawing.Size(412, 20);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Apellidos, Nombres";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBibliotecasPUCP
            // 
            this.lblBibliotecasPUCP.AutoSize = true;
            this.lblBibliotecasPUCP.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.5F);
            this.lblBibliotecasPUCP.ForeColor = System.Drawing.Color.White;
            this.lblBibliotecasPUCP.Location = new System.Drawing.Point(24, 59);
            this.lblBibliotecasPUCP.Name = "lblBibliotecasPUCP";
            this.lblBibliotecasPUCP.Size = new System.Drawing.Size(159, 26);
            this.lblBibliotecasPUCP.TabIndex = 0;
            this.lblBibliotecasPUCP.Text = "Bibliotecas PUCP";
            // 
            // lblTituloSistema
            // 
            this.lblTituloSistema.AutoSize = true;
            this.lblTituloSistema.Font = new System.Drawing.Font("Microsoft PhagsPa", 19.25F, System.Drawing.FontStyle.Bold);
            this.lblTituloSistema.ForeColor = System.Drawing.Color.White;
            this.lblTituloSistema.Location = new System.Drawing.Point(23, 17);
            this.lblTituloSistema.Name = "lblTituloSistema";
            this.lblTituloSistema.Size = new System.Drawing.Size(340, 34);
            this.lblTituloSistema.TabIndex = 0;
            this.lblTituloSistema.Text = "Sistema de Mesa de Ayuda";
            // 
            // pnlExt
            // 
            this.pnlExt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.pnlExt.Controls.Add(this.pnlInt);
            this.pnlExt.Location = new System.Drawing.Point(28, 185);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(1218, 352);
            this.pnlExt.TabIndex = 0;
            // 
            // pnlInt
            // 
            this.pnlInt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInt.Controls.Add(this.pnlDer);
            this.pnlInt.Controls.Add(this.pnlMed);
            this.pnlInt.Controls.Add(this.pnlIzq);
            this.pnlInt.Location = new System.Drawing.Point(29, 26);
            this.pnlInt.Name = "pnlInt";
            this.pnlInt.Size = new System.Drawing.Size(1156, 300);
            this.pnlInt.TabIndex = 0;
            // 
            // pnlDer
            // 
            this.pnlDer.BackColor = System.Drawing.Color.Transparent;
            this.pnlDer.Controls.Add(this.picGenerar);
            this.pnlDer.Controls.Add(this.btnGenerar);
            this.pnlDer.Controls.Add(this.lblGenerarReportes);
            this.pnlDer.Controls.Add(this.lblDetalleGenerar);
            this.pnlDer.Location = new System.Drawing.Point(773, 3);
            this.pnlDer.Name = "pnlDer";
            this.pnlDer.Size = new System.Drawing.Size(379, 294);
            this.pnlDer.TabIndex = 2;
            // 
            // picGenerar
            // 
            this.picGenerar.Image = global::TableSoft.Properties.Resources.InicioSupervisorReporte;
            this.picGenerar.InitialImage = ((System.Drawing.Image)(resources.GetObject("picGenerar.InitialImage")));
            this.picGenerar.Location = new System.Drawing.Point(20, 57);
            this.picGenerar.Name = "picGenerar";
            this.picGenerar.Size = new System.Drawing.Size(110, 149);
            this.picGenerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGenerar.TabIndex = 9;
            this.picGenerar.TabStop = false;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(32, 229);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(316, 44);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar reporte de mi equipo";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblGenerarReportes
            // 
            this.lblGenerarReportes.AutoSize = true;
            this.lblGenerarReportes.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerarReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.lblGenerarReportes.Location = new System.Drawing.Point(85, 14);
            this.lblGenerarReportes.Name = "lblGenerarReportes";
            this.lblGenerarReportes.Size = new System.Drawing.Size(209, 32);
            this.lblGenerarReportes.TabIndex = 0;
            this.lblGenerarReportes.Text = "Generar reportes";
            this.lblGenerarReportes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetalleGenerar
            // 
            this.lblDetalleGenerar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblDetalleGenerar.Location = new System.Drawing.Point(146, 99);
            this.lblDetalleGenerar.Name = "lblDetalleGenerar";
            this.lblDetalleGenerar.Size = new System.Drawing.Size(202, 63);
            this.lblDetalleGenerar.TabIndex = 0;
            this.lblDetalleGenerar.Text = "Genera a detalle un reporte de los tickets atendidos de mi equipo";
            this.lblDetalleGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMed
            // 
            this.pnlMed.BackColor = System.Drawing.Color.Transparent;
            this.pnlMed.Controls.Add(this.picGestionar);
            this.pnlMed.Controls.Add(this.btnGestionar);
            this.pnlMed.Controls.Add(this.lblGestionarTickets);
            this.pnlMed.Controls.Add(this.lblDetalleGestionar);
            this.pnlMed.Location = new System.Drawing.Point(388, 3);
            this.pnlMed.Name = "pnlMed";
            this.pnlMed.Size = new System.Drawing.Size(379, 294);
            this.pnlMed.TabIndex = 1;
            // 
            // picGestionar
            // 
            this.picGestionar.Image = global::TableSoft.Properties.Resources.InicioEmpleadoVer;
            this.picGestionar.InitialImage = ((System.Drawing.Image)(resources.GetObject("picGestionar.InitialImage")));
            this.picGestionar.Location = new System.Drawing.Point(20, 57);
            this.picGestionar.Name = "picGestionar";
            this.picGestionar.Size = new System.Drawing.Size(110, 149);
            this.picGestionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGestionar.TabIndex = 8;
            this.picGestionar.TabStop = false;
            // 
            // btnGestionar
            // 
            this.btnGestionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnGestionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionar.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionar.ForeColor = System.Drawing.Color.White;
            this.btnGestionar.Location = new System.Drawing.Point(32, 229);
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.Size = new System.Drawing.Size(316, 44);
            this.btnGestionar.TabIndex = 0;
            this.btnGestionar.Text = "Gestionar mis tickets";
            this.btnGestionar.UseVisualStyleBackColor = false;
            this.btnGestionar.Click += new System.EventHandler(this.btnGestionar_Click);
            // 
            // lblGestionarTickets
            // 
            this.lblGestionarTickets.AutoSize = true;
            this.lblGestionarTickets.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionarTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(121)))), ((int)(((byte)(53)))));
            this.lblGestionarTickets.Location = new System.Drawing.Point(86, 14);
            this.lblGestionarTickets.Name = "lblGestionarTickets";
            this.lblGestionarTickets.Size = new System.Drawing.Size(206, 32);
            this.lblGestionarTickets.TabIndex = 0;
            this.lblGestionarTickets.Text = "Gestionar tickets";
            this.lblGestionarTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetalleGestionar
            // 
            this.lblDetalleGestionar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleGestionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblDetalleGestionar.Location = new System.Drawing.Point(146, 99);
            this.lblDetalleGestionar.Name = "lblDetalleGestionar";
            this.lblDetalleGestionar.Size = new System.Drawing.Size(202, 63);
            this.lblDetalleGestionar.TabIndex = 0;
            this.lblDetalleGestionar.Text = "Administra los archivos del historial de todos tus tickets de soporte, actuales y" +
    " pasadas.";
            this.lblDetalleGestionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlIzq
            // 
            this.pnlIzq.BackColor = System.Drawing.Color.Transparent;
            this.pnlIzq.Controls.Add(this.picAtender);
            this.pnlIzq.Controls.Add(this.lblAtender);
            this.pnlIzq.Controls.Add(this.lblDetalleAtender);
            this.pnlIzq.Controls.Add(this.btnAtender);
            this.pnlIzq.Location = new System.Drawing.Point(3, 3);
            this.pnlIzq.Name = "pnlIzq";
            this.pnlIzq.Size = new System.Drawing.Size(379, 294);
            this.pnlIzq.TabIndex = 0;
            // 
            // picAtender
            // 
            this.picAtender.Image = global::TableSoft.Properties.Resources.InicioEmpleadoAbrir;
            this.picAtender.Location = new System.Drawing.Point(31, 69);
            this.picAtender.Name = "picAtender";
            this.picAtender.Size = new System.Drawing.Size(96, 124);
            this.picAtender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAtender.TabIndex = 3;
            this.picAtender.TabStop = false;
            // 
            // lblAtender
            // 
            this.lblAtender.AutoSize = true;
            this.lblAtender.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.lblAtender.Location = new System.Drawing.Point(81, 14);
            this.lblAtender.Name = "lblAtender";
            this.lblAtender.Size = new System.Drawing.Size(216, 32);
            this.lblAtender.TabIndex = 0;
            this.lblAtender.Text = "Tickets de equipo";
            this.lblAtender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetalleAtender
            // 
            this.lblDetalleAtender.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleAtender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblDetalleAtender.Location = new System.Drawing.Point(145, 99);
            this.lblDetalleAtender.Name = "lblDetalleAtender";
            this.lblDetalleAtender.Size = new System.Drawing.Size(202, 63);
            this.lblDetalleAtender.TabIndex = 0;
            this.lblDetalleAtender.Text = "Revisa aquí los nuevos tickets de tu equipo esperados a ser atentidos";
            this.lblDetalleAtender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAtender
            // 
            this.btnAtender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnAtender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtender.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtender.ForeColor = System.Drawing.Color.White;
            this.btnAtender.Location = new System.Drawing.Point(31, 229);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(316, 44);
            this.btnAtender.TabIndex = 0;
            this.btnAtender.Text = "Atender nuevo ticket";
            this.btnAtender.UseVisualStyleBackColor = false;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // lblNombreEquipo
            // 
            this.lblNombreEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreEquipo.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEquipo.ForeColor = System.Drawing.Color.White;
            this.lblNombreEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNombreEquipo.Location = new System.Drawing.Point(834, 65);
            this.lblNombreEquipo.Name = "lblNombreEquipo";
            this.lblNombreEquipo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombreEquipo.Size = new System.Drawing.Size(412, 20);
            this.lblNombreEquipo.TabIndex = 5;
            this.lblNombreEquipo.Text = "Apellidos, Nombres";
            this.lblNombreEquipo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmInicioSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 561);
            this.Controls.Add(this.pnlExt);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicioSupervisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yanapay | Inicio";
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlExt.ResumeLayout(false);
            this.pnlInt.ResumeLayout(false);
            this.pnlDer.ResumeLayout(false);
            this.pnlDer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGenerar)).EndInit();
            this.pnlMed.ResumeLayout(false);
            this.pnlMed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGestionar)).EndInit();
            this.pnlIzq.ResumeLayout(false);
            this.pnlIzq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAtender)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.LinkLabel lklLogout;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblBibliotecasPUCP;
        private System.Windows.Forms.Label lblTituloSistema;
        private System.Windows.Forms.Panel pnlExt;
        private System.Windows.Forms.Panel pnlInt;
        private System.Windows.Forms.Panel pnlDer;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblGenerarReportes;
        private System.Windows.Forms.Label lblDetalleGenerar;
        private System.Windows.Forms.Panel pnlMed;
        private System.Windows.Forms.PictureBox picGestionar;
        private System.Windows.Forms.Button btnGestionar;
        private System.Windows.Forms.Label lblGestionarTickets;
        private System.Windows.Forms.Label lblDetalleGestionar;
        private System.Windows.Forms.Panel pnlIzq;
        private System.Windows.Forms.PictureBox picAtender;
        private System.Windows.Forms.Label lblAtender;
        private System.Windows.Forms.Label lblDetalleAtender;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.PictureBox picGenerar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.Label lblNombreEquipo;
    }
}