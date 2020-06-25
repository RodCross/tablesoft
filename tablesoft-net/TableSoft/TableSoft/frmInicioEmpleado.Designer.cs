namespace TableSoft
{
    partial class frmInicioEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioEmpleado));
            this.pnlExt = new System.Windows.Forms.Panel();
            this.pnlInt = new System.Windows.Forms.Panel();
            this.pnlDer = new System.Windows.Forms.Panel();
            this.picEstado = new System.Windows.Forms.PictureBox();
            this.btnEstado = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDetalleEstado = new System.Windows.Forms.Label();
            this.pnlIzq = new System.Windows.Forms.Panel();
            this.picAbrir = new System.Windows.Forms.PictureBox();
            this.lblAbrir = new System.Windows.Forms.Label();
            this.lblDetalleAbrir = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lklFAQ = new System.Windows.Forms.LinkLabel();
            this.lblBibliotecasPUCP = new System.Windows.Forms.Label();
            this.lblTituloSistema = new System.Windows.Forms.Label();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.lklLogout = new System.Windows.Forms.LinkLabel();
            this.pnlExt.SuspendLayout();
            this.pnlInt.SuspendLayout();
            this.pnlDer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEstado)).BeginInit();
            this.pnlIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAbrir)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlExt
            // 
            this.pnlExt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.pnlExt.Controls.Add(this.pnlInt);
            this.pnlExt.Location = new System.Drawing.Point(28, 185);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(829, 352);
            this.pnlExt.TabIndex = 0;
            // 
            // pnlInt
            // 
            this.pnlInt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInt.Controls.Add(this.pnlDer);
            this.pnlInt.Controls.Add(this.pnlIzq);
            this.pnlInt.Location = new System.Drawing.Point(29, 26);
            this.pnlInt.Name = "pnlInt";
            this.pnlInt.Size = new System.Drawing.Size(770, 300);
            this.pnlInt.TabIndex = 0;
            // 
            // pnlDer
            // 
            this.pnlDer.BackColor = System.Drawing.Color.Transparent;
            this.pnlDer.Controls.Add(this.picEstado);
            this.pnlDer.Controls.Add(this.btnEstado);
            this.pnlDer.Controls.Add(this.lblEstado);
            this.pnlDer.Controls.Add(this.lblDetalleEstado);
            this.pnlDer.Location = new System.Drawing.Point(388, 3);
            this.pnlDer.Name = "pnlDer";
            this.pnlDer.Size = new System.Drawing.Size(379, 294);
            this.pnlDer.TabIndex = 1;
            // 
            // picEstado
            // 
            this.picEstado.Image = global::TableSoft.Properties.Resources.InicioEmpleadoVer;
            this.picEstado.InitialImage = ((System.Drawing.Image)(resources.GetObject("picEstado.InitialImage")));
            this.picEstado.Location = new System.Drawing.Point(20, 57);
            this.picEstado.Name = "picEstado";
            this.picEstado.Size = new System.Drawing.Size(110, 149);
            this.picEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEstado.TabIndex = 8;
            this.picEstado.TabStop = false;
            // 
            // btnEstado
            // 
            this.btnEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstado.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado.ForeColor = System.Drawing.Color.White;
            this.btnEstado.Location = new System.Drawing.Point(32, 229);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(316, 44);
            this.btnEstado.TabIndex = 0;
            this.btnEstado.Text = "Ver estado de mis tickets";
            this.btnEstado.UseVisualStyleBackColor = false;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(121)))), ((int)(((byte)(53)))));
            this.lblEstado.Location = new System.Drawing.Point(91, 14);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(196, 32);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Estado de ticket";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetalleEstado
            // 
            this.lblDetalleEstado.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblDetalleEstado.Location = new System.Drawing.Point(146, 99);
            this.lblDetalleEstado.Name = "lblDetalleEstado";
            this.lblDetalleEstado.Size = new System.Drawing.Size(202, 63);
            this.lblDetalleEstado.TabIndex = 0;
            this.lblDetalleEstado.Text = "Proporcionamos archivos del historial de todas tus solicitudes de soporte, actual" +
    "es y pasadas.";
            this.lblDetalleEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlIzq
            // 
            this.pnlIzq.BackColor = System.Drawing.Color.Transparent;
            this.pnlIzq.Controls.Add(this.picAbrir);
            this.pnlIzq.Controls.Add(this.lblAbrir);
            this.pnlIzq.Controls.Add(this.lblDetalleAbrir);
            this.pnlIzq.Controls.Add(this.btnAbrir);
            this.pnlIzq.Location = new System.Drawing.Point(3, 3);
            this.pnlIzq.Name = "pnlIzq";
            this.pnlIzq.Size = new System.Drawing.Size(379, 294);
            this.pnlIzq.TabIndex = 0;
            // 
            // picAbrir
            // 
            this.picAbrir.Image = global::TableSoft.Properties.Resources.InicioEmpleadoAbrir;
            this.picAbrir.Location = new System.Drawing.Point(31, 69);
            this.picAbrir.Name = "picAbrir";
            this.picAbrir.Size = new System.Drawing.Size(96, 124);
            this.picAbrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAbrir.TabIndex = 3;
            this.picAbrir.TabStop = false;
            // 
            // lblAbrir
            // 
            this.lblAbrir.AutoSize = true;
            this.lblAbrir.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbrir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.lblAbrir.Location = new System.Drawing.Point(109, 14);
            this.lblAbrir.Name = "lblAbrir";
            this.lblAbrir.Size = new System.Drawing.Size(160, 32);
            this.lblAbrir.TabIndex = 0;
            this.lblAbrir.Text = "Nuevo ticket";
            this.lblAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetalleAbrir
            // 
            this.lblDetalleAbrir.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleAbrir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblDetalleAbrir.Location = new System.Drawing.Point(145, 99);
            this.lblDetalleAbrir.Name = "lblDetalleAbrir";
            this.lblDetalleAbrir.Size = new System.Drawing.Size(202, 63);
            this.lblDetalleAbrir.TabIndex = 0;
            this.lblDetalleAbrir.Text = "Por favor, brinda el mayor detalle posible para que podamos ayudarte de la mejor " +
    "manera.";
            this.lblDetalleAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.Color.White;
            this.btnAbrir.Location = new System.Drawing.Point(31, 229);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(316, 44);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir nuevo ticket";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.pnlTitulo.Controls.Add(this.lklFAQ);
            this.pnlTitulo.Controls.Add(this.lblBibliotecasPUCP);
            this.pnlTitulo.Controls.Add(this.lblTituloSistema);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(884, 106);
            this.pnlTitulo.TabIndex = 1;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // lklFAQ
            // 
            this.lklFAQ.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.lklFAQ.AutoSize = true;
            this.lklFAQ.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold);
            this.lklFAQ.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lklFAQ.LinkColor = System.Drawing.Color.White;
            this.lklFAQ.Location = new System.Drawing.Point(739, 68);
            this.lklFAQ.Name = "lklFAQ";
            this.lklFAQ.Size = new System.Drawing.Size(114, 17);
            this.lklFAQ.TabIndex = 0;
            this.lklFAQ.TabStop = true;
            this.lklFAQ.Text = "Manual de ayuda";
            this.lklFAQ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lklFAQ.VisitedLinkColor = System.Drawing.Color.White;
            this.lklFAQ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklFAQ_LinkClicked);
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
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(208)))));
            this.pnlOpciones.Controls.Add(this.lklLogout);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 106);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(884, 51);
            this.pnlOpciones.TabIndex = 2;
            // 
            // lklLogout
            // 
            this.lklLogout.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.lklLogout.AutoSize = true;
            this.lklLogout.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklLogout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lklLogout.LinkColor = System.Drawing.Color.White;
            this.lklLogout.Location = new System.Drawing.Point(729, 14);
            this.lklLogout.Name = "lklLogout";
            this.lklLogout.Size = new System.Drawing.Size(128, 25);
            this.lklLogout.TabIndex = 0;
            this.lklLogout.TabStop = true;
            this.lklLogout.Text = "Cerrar sesión";
            this.lklLogout.VisitedLinkColor = System.Drawing.Color.White;
            this.lklLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklLogout_LinkClicked);
            // 
            // frmInicioEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlExt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicioEmpleado";
            this.Text = "TableSoft";
            this.pnlExt.ResumeLayout(false);
            this.pnlInt.ResumeLayout(false);
            this.pnlDer.ResumeLayout(false);
            this.pnlDer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEstado)).EndInit();
            this.pnlIzq.ResumeLayout(false);
            this.pnlIzq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAbrir)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlExt;
        private System.Windows.Forms.Panel pnlInt;
        private System.Windows.Forms.Label lblAbrir;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lblDetalleAbrir;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDetalleEstado;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.PictureBox picEstado;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblBibliotecasPUCP;
        private System.Windows.Forms.Label lblTituloSistema;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Panel pnlDer;
        private System.Windows.Forms.Panel pnlIzq;
        private System.Windows.Forms.PictureBox picAbrir;
        private System.Windows.Forms.LinkLabel lklLogout;
        private System.Windows.Forms.LinkLabel lklFAQ;
    }
}