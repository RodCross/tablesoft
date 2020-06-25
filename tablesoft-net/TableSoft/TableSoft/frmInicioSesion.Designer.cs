namespace TableSoft
{
    partial class frmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lklFAQ = new System.Windows.Forms.LinkLabel();
            this.lblBibliotecasPUCP = new System.Windows.Forms.Label();
            this.lblTituloSistema = new System.Windows.Forms.Label();
            this.lblTituloLogin = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lklForgot = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblErrEmail = new System.Windows.Forms.Label();
            this.lblErrPassword = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.pnlTitulo.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
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
            this.lklFAQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lklFAQ.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklFAQ.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lklFAQ.LinkColor = System.Drawing.Color.White;
            this.lklFAQ.Location = new System.Drawing.Point(743, 68);
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
            this.lblBibliotecasPUCP.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBibliotecasPUCP.ForeColor = System.Drawing.Color.White;
            this.lblBibliotecasPUCP.Location = new System.Drawing.Point(24, 59);
            this.lblBibliotecasPUCP.Name = "lblBibliotecasPUCP";
            this.lblBibliotecasPUCP.Size = new System.Drawing.Size(159, 26);
            this.lblBibliotecasPUCP.TabIndex = 2;
            this.lblBibliotecasPUCP.Text = "Bibliotecas PUCP";
            // 
            // lblTituloSistema
            // 
            this.lblTituloSistema.AutoSize = true;
            this.lblTituloSistema.Font = new System.Drawing.Font("Microsoft PhagsPa", 19.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSistema.ForeColor = System.Drawing.Color.White;
            this.lblTituloSistema.Location = new System.Drawing.Point(23, 17);
            this.lblTituloSistema.Name = "lblTituloSistema";
            this.lblTituloSistema.Size = new System.Drawing.Size(340, 34);
            this.lblTituloSistema.TabIndex = 1;
            this.lblTituloSistema.Text = "Sistema de Mesa de Ayuda";
            // 
            // lblTituloLogin
            // 
            this.lblTituloLogin.AutoSize = true;
            this.lblTituloLogin.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblTituloLogin.Location = new System.Drawing.Point(329, 128);
            this.lblTituloLogin.Name = "lblTituloLogin";
            this.lblTituloLogin.Size = new System.Drawing.Size(227, 25);
            this.lblTituloLogin.TabIndex = 2;
            this.lblTituloLogin.Text = "Inicia sesión en Yanapay";
            this.lblTituloLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.txtEmail);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.lklForgot);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.lblContraseña);
            this.pnlLogin.Controls.Add(this.lblEmail);
            this.pnlLogin.Controls.Add(this.lblErrEmail);
            this.pnlLogin.Controls.Add(this.lblErrPassword);
            this.pnlLogin.ForeColor = System.Drawing.Color.White;
            this.pnlLogin.Location = new System.Drawing.Point(237, 172);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(410, 364);
            this.pnlLogin.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(30, 65);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(351, 28);
            this.txtEmail.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(30, 216);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(351, 50);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lklForgot
            // 
            this.lklForgot.AutoSize = true;
            this.lklForgot.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklForgot.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(204)))));
            this.lklForgot.Location = new System.Drawing.Point(127, 285);
            this.lklForgot.Name = "lklForgot";
            this.lklForgot.Size = new System.Drawing.Size(157, 17);
            this.lklForgot.TabIndex = 3;
            this.lklForgot.TabStop = true;
            this.lklForgot.Text = "¿Olvidaste tu contraseña?";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(30, 148);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(351, 28);
            this.txtPassword.TabIndex = 1;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblContraseña.Location = new System.Drawing.Point(28, 120);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(96, 21);
            this.lblContraseña.TabIndex = 6;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblEmail.Location = new System.Drawing.Point(28, 37);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 21);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblErrEmail
            // 
            this.lblErrEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblErrEmail.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.75F);
            this.lblErrEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrEmail.Location = new System.Drawing.Point(29, 92);
            this.lblErrEmail.Name = "lblErrEmail";
            this.lblErrEmail.Size = new System.Drawing.Size(352, 23);
            this.lblErrEmail.TabIndex = 5;
            this.lblErrEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblErrPassword
            // 
            this.lblErrPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblErrPassword.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.75F);
            this.lblErrPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrPassword.Location = new System.Drawing.Point(29, 175);
            this.lblErrPassword.Name = "lblErrPassword";
            this.lblErrPassword.Size = new System.Drawing.Size(352, 23);
            this.lblErrPassword.TabIndex = 7;
            this.lblErrPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picExit
            // 
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = global::TableSoft.Properties.Resources.Exit;
            this.picExit.Location = new System.Drawing.Point(805, 484);
            this.picExit.Margin = new System.Windows.Forms.Padding(6);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(52, 52);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 2;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picExit_MouseDown);
            this.picExit.MouseEnter += new System.EventHandler(this.picExit_MouseEnter);
            this.picExit.MouseLeave += new System.EventHandler(this.picExit_MouseLeave);
            this.picExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picExit_MouseUp);
            // 
            // frmInicioSesion
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.lblTituloLogin);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicioSesion";
            this.Text = "TableSoft";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTituloSistema;
        private System.Windows.Forms.Label lblBibliotecasPUCP;
        private System.Windows.Forms.Label lblTituloLogin;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lklForgot;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.LinkLabel lklFAQ;
        private System.Windows.Forms.Label lblErrEmail;
        private System.Windows.Forms.Label lblErrPassword;
    }
}