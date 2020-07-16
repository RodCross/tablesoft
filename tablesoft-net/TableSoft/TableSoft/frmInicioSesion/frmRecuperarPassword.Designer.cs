namespace TableSoft
{
    partial class frmRecuperarPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperarPassword));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblBibliotecasPUCP = new System.Windows.Forms.Label();
            this.lblTituloSistema = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblTextoRecuperar = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblErrEmail = new System.Windows.Forms.Label();
            this.lblTituloRecuperar = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.pnlTitulo.Controls.Add(this.btnVolver);
            this.pnlTitulo.Controls.Add(this.lblBibliotecasPUCP);
            this.pnlTitulo.Controls.Add(this.lblTituloSistema);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(884, 106);
            this.pnlTitulo.TabIndex = 1;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(736, 52);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(119, 33);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Ir a Inicio";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
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
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.lblTextoRecuperar);
            this.pnlLogin.Controls.Add(this.txtEmail);
            this.pnlLogin.Controls.Add(this.btnEnviarEmail);
            this.pnlLogin.Controls.Add(this.lblEmail);
            this.pnlLogin.Controls.Add(this.lblErrEmail);
            this.pnlLogin.ForeColor = System.Drawing.Color.White;
            this.pnlLogin.Location = new System.Drawing.Point(237, 200);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(410, 286);
            this.pnlLogin.TabIndex = 0;
            // 
            // lblTextoRecuperar
            // 
            this.lblTextoRecuperar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoRecuperar.ForeColor = System.Drawing.Color.Black;
            this.lblTextoRecuperar.Location = new System.Drawing.Point(29, 30);
            this.lblTextoRecuperar.Name = "lblTextoRecuperar";
            this.lblTextoRecuperar.Size = new System.Drawing.Size(352, 53);
            this.lblTextoRecuperar.TabIndex = 2;
            this.lblTextoRecuperar.Text = "Si olvidaste tu contraseña y perdiste el acceso a tu cuenta, ingresa tu email par" +
    "a recibir un correo de recuperación.";
            this.lblTextoRecuperar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(30, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(351, 28);
            this.txtEmail.TabIndex = 0;
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(208)))));
            this.btnEnviarEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarEmail.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarEmail.ForeColor = System.Drawing.Color.White;
            this.btnEnviarEmail.Location = new System.Drawing.Point(30, 206);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(351, 50);
            this.btnEnviarEmail.TabIndex = 1;
            this.btnEnviarEmail.Text = "Enviar email de recuperación";
            this.btnEnviarEmail.UseVisualStyleBackColor = false;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblEmail.Location = new System.Drawing.Point(28, 105);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 21);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblErrEmail
            // 
            this.lblErrEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblErrEmail.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.75F);
            this.lblErrEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrEmail.Location = new System.Drawing.Point(29, 160);
            this.lblErrEmail.Name = "lblErrEmail";
            this.lblErrEmail.Size = new System.Drawing.Size(352, 23);
            this.lblErrEmail.TabIndex = 4;
            this.lblErrEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloRecuperar
            // 
            this.lblTituloRecuperar.AutoSize = true;
            this.lblTituloRecuperar.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRecuperar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblTituloRecuperar.Location = new System.Drawing.Point(331, 140);
            this.lblTituloRecuperar.Name = "lblTituloRecuperar";
            this.lblTituloRecuperar.Size = new System.Drawing.Size(222, 25);
            this.lblTituloRecuperar.TabIndex = 2;
            this.lblTituloRecuperar.Text = "Recupera tu contraseña";
            this.lblTituloRecuperar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRecuperarPassword
            // 
            this.AcceptButton = this.btnEnviarEmail;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.lblTituloRecuperar);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecuperarPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yanapay | Recuperar contraseña";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblBibliotecasPUCP;
        private System.Windows.Forms.Label lblTituloSistema;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblErrEmail;
        private System.Windows.Forms.Label lblTituloRecuperar;
        private System.Windows.Forms.Label lblTextoRecuperar;
        private System.Windows.Forms.Button btnVolver;
    }
}