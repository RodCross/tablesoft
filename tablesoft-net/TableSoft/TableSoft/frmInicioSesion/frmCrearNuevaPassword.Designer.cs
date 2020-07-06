namespace TableSoft
{
    partial class frmCrearNuevaPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearNuevaPassword));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblBibliotecasPUCP = new System.Windows.Forms.Label();
            this.lblTituloSistema = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtNuevaPass = new System.Windows.Forms.TextBox();
            this.btnCrearPass = new System.Windows.Forms.Button();
            this.lblNuevaPass = new System.Windows.Forms.Label();
            this.lblTituloRecuperar = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblErrConfirm = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.picEye = new System.Windows.Forms.PictureBox();
            this.lblErrNuevaPass = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).BeginInit();
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
            this.pnlLogin.Controls.Add(this.picEye);
            this.pnlLogin.Controls.Add(this.txtNuevaPass);
            this.pnlLogin.Controls.Add(this.lblErrNuevaPass);
            this.pnlLogin.Controls.Add(this.lblConfirm);
            this.pnlLogin.Controls.Add(this.txtConfirm);
            this.pnlLogin.Controls.Add(this.lblErrConfirm);
            this.pnlLogin.Controls.Add(this.btnCrearPass);
            this.pnlLogin.Controls.Add(this.lblNuevaPass);
            this.pnlLogin.ForeColor = System.Drawing.Color.White;
            this.pnlLogin.Location = new System.Drawing.Point(237, 200);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(410, 286);
            this.pnlLogin.TabIndex = 0;
            // 
            // txtNuevaPass
            // 
            this.txtNuevaPass.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaPass.Location = new System.Drawing.Point(30, 54);
            this.txtNuevaPass.Name = "txtNuevaPass";
            this.txtNuevaPass.PasswordChar = '•';
            this.txtNuevaPass.Size = new System.Drawing.Size(323, 28);
            this.txtNuevaPass.TabIndex = 0;
            // 
            // btnCrearPass
            // 
            this.btnCrearPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnCrearPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPass.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPass.ForeColor = System.Drawing.Color.White;
            this.btnCrearPass.Location = new System.Drawing.Point(30, 206);
            this.btnCrearPass.Name = "btnCrearPass";
            this.btnCrearPass.Size = new System.Drawing.Size(351, 50);
            this.btnCrearPass.TabIndex = 2;
            this.btnCrearPass.Text = "Crear nueva contraseña";
            this.btnCrearPass.UseVisualStyleBackColor = false;
            this.btnCrearPass.Click += new System.EventHandler(this.btnCrearPass_Click);
            // 
            // lblNuevaPass
            // 
            this.lblNuevaPass.AutoSize = true;
            this.lblNuevaPass.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblNuevaPass.Location = new System.Drawing.Point(28, 26);
            this.lblNuevaPass.Name = "lblNuevaPass";
            this.lblNuevaPass.Size = new System.Drawing.Size(148, 21);
            this.lblNuevaPass.TabIndex = 3;
            this.lblNuevaPass.Text = "Nueva contraseña";
            this.lblNuevaPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloRecuperar
            // 
            this.lblTituloRecuperar.AutoSize = true;
            this.lblTituloRecuperar.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRecuperar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblTituloRecuperar.Location = new System.Drawing.Point(316, 140);
            this.lblTituloRecuperar.Name = "lblTituloRecuperar";
            this.lblTituloRecuperar.Size = new System.Drawing.Size(253, 25);
            this.lblTituloRecuperar.TabIndex = 2;
            this.lblTituloRecuperar.Text = "Crea una nueva contraseña";
            this.lblTituloRecuperar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.Location = new System.Drawing.Point(30, 137);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '•';
            this.txtConfirm.Size = new System.Drawing.Size(351, 28);
            this.txtConfirm.TabIndex = 1;
            // 
            // lblErrConfirm
            // 
            this.lblErrConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lblErrConfirm.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.75F);
            this.lblErrConfirm.ForeColor = System.Drawing.Color.Red;
            this.lblErrConfirm.Location = new System.Drawing.Point(29, 164);
            this.lblErrConfirm.Name = "lblErrConfirm";
            this.lblErrConfirm.Size = new System.Drawing.Size(352, 23);
            this.lblErrConfirm.TabIndex = 6;
            this.lblErrConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblConfirm.Location = new System.Drawing.Point(28, 109);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(276, 21);
            this.lblConfirm.TabIndex = 5;
            this.lblConfirm.Text = "Confirmación de nueva contraseña";
            this.lblConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picEye
            // 
            this.picEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEye.Image = global::TableSoft.Properties.Resources.Eye;
            this.picEye.Location = new System.Drawing.Point(352, 54);
            this.picEye.Name = "picEye";
            this.picEye.Size = new System.Drawing.Size(29, 28);
            this.picEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEye.TabIndex = 57;
            this.picEye.TabStop = false;
            this.picEye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picEye_MouseDown);
            this.picEye.MouseEnter += new System.EventHandler(this.picEye_MouseEnter);
            this.picEye.MouseLeave += new System.EventHandler(this.picEye_MouseLeave);
            this.picEye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picEye_MouseUp);
            // 
            // lblErrNuevaPass
            // 
            this.lblErrNuevaPass.BackColor = System.Drawing.Color.Transparent;
            this.lblErrNuevaPass.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.75F);
            this.lblErrNuevaPass.ForeColor = System.Drawing.Color.Red;
            this.lblErrNuevaPass.Location = new System.Drawing.Point(29, 81);
            this.lblErrNuevaPass.Name = "lblErrNuevaPass";
            this.lblErrNuevaPass.Size = new System.Drawing.Size(352, 23);
            this.lblErrNuevaPass.TabIndex = 4;
            this.lblErrNuevaPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCrearNuevaPassword
            // 
            this.AcceptButton = this.btnCrearPass;
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
            this.Name = "frmCrearNuevaPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crea tu nueva contraseña";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblBibliotecasPUCP;
        private System.Windows.Forms.Label lblTituloSistema;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtNuevaPass;
        private System.Windows.Forms.Button btnCrearPass;
        private System.Windows.Forms.Label lblNuevaPass;
        private System.Windows.Forms.Label lblTituloRecuperar;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblErrConfirm;
        private System.Windows.Forms.PictureBox picEye;
        private System.Windows.Forms.Label lblErrNuevaPass;
    }
}