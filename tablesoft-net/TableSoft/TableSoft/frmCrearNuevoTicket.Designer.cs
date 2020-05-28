namespace TableSoft
{
    partial class frmCrearNuevoTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearNuevoTicket));
            this.lblAbrir = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.rtfDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.pnlCaracteristicas = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBiblioteca = new System.Windows.Forms.Label();
            this.lblActivoFijo = new System.Windows.Forms.Label();
            this.lblEstDoc = new System.Windows.Forms.Label();
            this.txtActivoFijo = new System.Windows.Forms.TextBox();
            this.cboBiblioteca = new System.Windows.Forms.ComboBox();
            this.lblUrgencia = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboUrgencia = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCampoObligatorio = new System.Windows.Forms.Label();
            this.lblCaracteristicas = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlInfo.SuspendLayout();
            this.pnlCaracteristicas.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAbrir
            // 
            this.lblAbrir.AutoSize = true;
            this.lblAbrir.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblAbrir.ForeColor = System.Drawing.Color.White;
            this.lblAbrir.Location = new System.Drawing.Point(30, 23);
            this.lblAbrir.Name = "lblAbrir";
            this.lblAbrir.Size = new System.Drawing.Size(222, 27);
            this.lblAbrir.TabIndex = 0;
            this.lblAbrir.Text = "Abrir un nuevo ticket";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(910, 545);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(119, 33);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblInfo.Location = new System.Drawing.Point(34, 88);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(122, 25);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Información";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.rtfDescripcion);
            this.pnlInfo.Controls.Add(this.lblDescripcion);
            this.pnlInfo.Controls.Add(this.txtAsunto);
            this.pnlInfo.Controls.Add(this.lblAsunto);
            this.pnlInfo.Location = new System.Drawing.Point(35, 127);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(638, 394);
            this.pnlInfo.TabIndex = 0;
            // 
            // rtfDescripcion
            // 
            this.rtfDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDescripcion.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfDescripcion.Location = new System.Drawing.Point(20, 101);
            this.rtfDescripcion.Name = "rtfDescripcion";
            this.rtfDescripcion.Size = new System.Drawing.Size(593, 276);
            this.rtfDescripcion.TabIndex = 1;
            this.rtfDescripcion.Text = "";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblDescripcion.Location = new System.Drawing.Point(18, 75);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(205, 20);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción de la situación *";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.Location = new System.Drawing.Point(20, 35);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(409, 28);
            this.txtAsunto.TabIndex = 0;
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblAsunto.Location = new System.Drawing.Point(18, 9);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(71, 20);
            this.lblAsunto.TabIndex = 0;
            this.lblAsunto.Text = "Asunto *";
            // 
            // pnlCaracteristicas
            // 
            this.pnlCaracteristicas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCaracteristicas.Controls.Add(this.txtEmail);
            this.pnlCaracteristicas.Controls.Add(this.lblEmail);
            this.pnlCaracteristicas.Controls.Add(this.lblBiblioteca);
            this.pnlCaracteristicas.Controls.Add(this.lblActivoFijo);
            this.pnlCaracteristicas.Controls.Add(this.lblEstDoc);
            this.pnlCaracteristicas.Controls.Add(this.txtActivoFijo);
            this.pnlCaracteristicas.Controls.Add(this.cboBiblioteca);
            this.pnlCaracteristicas.Controls.Add(this.lblUrgencia);
            this.pnlCaracteristicas.Controls.Add(this.cboCategoria);
            this.pnlCaracteristicas.Controls.Add(this.cboUrgencia);
            this.pnlCaracteristicas.Controls.Add(this.lblCategoria);
            this.pnlCaracteristicas.Location = new System.Drawing.Point(696, 127);
            this.pnlCaracteristicas.Name = "pnlCaracteristicas";
            this.pnlCaracteristicas.Size = new System.Drawing.Size(333, 394);
            this.pnlCaracteristicas.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(20, 349);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(288, 28);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblEmail.Location = new System.Drawing.Point(18, 323);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(152, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Tu email (opcional) :";
            // 
            // lblBiblioteca
            // 
            this.lblBiblioteca.AutoSize = true;
            this.lblBiblioteca.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiblioteca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblBiblioteca.Location = new System.Drawing.Point(18, 9);
            this.lblBiblioteca.Name = "lblBiblioteca";
            this.lblBiblioteca.Size = new System.Drawing.Size(89, 20);
            this.lblBiblioteca.TabIndex = 0;
            this.lblBiblioteca.Text = "Biblioteca *";
            // 
            // lblActivoFijo
            // 
            this.lblActivoFijo.AutoSize = true;
            this.lblActivoFijo.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivoFijo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblActivoFijo.Location = new System.Drawing.Point(18, 207);
            this.lblActivoFijo.Name = "lblActivoFijo";
            this.lblActivoFijo.Size = new System.Drawing.Size(273, 20);
            this.lblActivoFijo.TabIndex = 0;
            this.lblActivoFijo.Text = "N.° de activo fijo de equipo (opcional)";
            // 
            // lblEstDoc
            // 
            this.lblEstDoc.AutoSize = true;
            this.lblEstDoc.Font = new System.Drawing.Font("Microsoft PhagsPa", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblEstDoc.Location = new System.Drawing.Point(17, 288);
            this.lblEstDoc.Name = "lblEstDoc";
            this.lblEstDoc.Size = new System.Drawing.Size(229, 22);
            this.lblEstDoc.TabIndex = 0;
            this.lblEstDoc.Text = "¿Eres estudiante o docente?";
            // 
            // txtActivoFijo
            // 
            this.txtActivoFijo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivoFijo.Location = new System.Drawing.Point(20, 233);
            this.txtActivoFijo.Name = "txtActivoFijo";
            this.txtActivoFijo.Size = new System.Drawing.Size(288, 28);
            this.txtActivoFijo.TabIndex = 3;
            // 
            // cboBiblioteca
            // 
            this.cboBiblioteca.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBiblioteca.FormattingEnabled = true;
            this.cboBiblioteca.Location = new System.Drawing.Point(20, 35);
            this.cboBiblioteca.Name = "cboBiblioteca";
            this.cboBiblioteca.Size = new System.Drawing.Size(288, 29);
            this.cboBiblioteca.TabIndex = 0;
            // 
            // lblUrgencia
            // 
            this.lblUrgencia.AutoSize = true;
            this.lblUrgencia.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrgencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblUrgencia.Location = new System.Drawing.Point(18, 141);
            this.lblUrgencia.Name = "lblUrgencia";
            this.lblUrgencia.Size = new System.Drawing.Size(82, 20);
            this.lblUrgencia.TabIndex = 0;
            this.lblUrgencia.Text = "Urgencia *";
            // 
            // cboCategoria
            // 
            this.cboCategoria.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(20, 101);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(288, 29);
            this.cboCategoria.TabIndex = 1;
            // 
            // cboUrgencia
            // 
            this.cboUrgencia.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUrgencia.FormattingEnabled = true;
            this.cboUrgencia.Location = new System.Drawing.Point(20, 167);
            this.cboUrgencia.Name = "cboUrgencia";
            this.cboUrgencia.Size = new System.Drawing.Size(288, 29);
            this.cboUrgencia.TabIndex = 2;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblCategoria.Location = new System.Drawing.Point(18, 75);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(87, 20);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoría *";
            // 
            // lblCampoObligatorio
            // 
            this.lblCampoObligatorio.AutoSize = true;
            this.lblCampoObligatorio.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoObligatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblCampoObligatorio.Location = new System.Drawing.Point(36, 529);
            this.lblCampoObligatorio.Name = "lblCampoObligatorio";
            this.lblCampoObligatorio.Size = new System.Drawing.Size(128, 17);
            this.lblCampoObligatorio.TabIndex = 0;
            this.lblCampoObligatorio.Text = "* Campo obligatorio";
            // 
            // lblCaracteristicas
            // 
            this.lblCaracteristicas.AutoSize = true;
            this.lblCaracteristicas.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracteristicas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblCaracteristicas.Location = new System.Drawing.Point(695, 88);
            this.lblCaracteristicas.Name = "lblCaracteristicas";
            this.lblCaracteristicas.Size = new System.Drawing.Size(138, 25);
            this.lblCaracteristicas.TabIndex = 0;
            this.lblCaracteristicas.Text = "Características";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.pnlTitulo.Controls.Add(this.lblAbrir);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1064, 70);
            this.pnlTitulo.TabIndex = 4;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(760, 545);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(119, 33);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "< Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmCrearNuevoTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 600);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlCaracteristicas);
            this.Controls.Add(this.lblCampoObligatorio);
            this.Controls.Add(this.lblCaracteristicas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCrearNuevoTicket";
            this.Text = "Abrir un nuevo ticket";
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlCaracteristicas.ResumeLayout(false);
            this.pnlCaracteristicas.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAbrir;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.RichTextBox rtfDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Panel pnlCaracteristicas;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBiblioteca;
        private System.Windows.Forms.Label lblActivoFijo;
        private System.Windows.Forms.Label lblEstDoc;
        private System.Windows.Forms.TextBox txtActivoFijo;
        private System.Windows.Forms.ComboBox cboBiblioteca;
        private System.Windows.Forms.Label lblUrgencia;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboUrgencia;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCampoObligatorio;
        private System.Windows.Forms.Label lblCaracteristicas;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button btnVolver;
    }
}