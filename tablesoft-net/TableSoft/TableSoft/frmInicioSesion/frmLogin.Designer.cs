    namespace TableSoft
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlMov1 = new System.Windows.Forms.Panel();
            this.pnlMov2 = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tmrEmailEnter = new System.Windows.Forms.Timer(this.components);
            this.tmrPasswordEnter = new System.Windows.Forms.Timer(this.components);
            this.tmrEmailLeave = new System.Windows.Forms.Timer(this.components);
            this.tmrPasswordLeave = new System.Windows.Forms.Timer(this.components);
            this.lblForgot = new System.Windows.Forms.Label();
            this.picTogglePassword = new System.Windows.Forms.PictureBox();
            this.picCia = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picEmailBox = new System.Windows.Forms.PictureBox();
            this.picPasswordBox = new System.Windows.Forms.PictureBox();
            this.pnlBoxes = new System.Windows.Forms.Panel();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.pnlMov2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTogglePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmailBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordBox)).BeginInit();
            this.pnlBoxes.SuspendLayout();
            this.pnlEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.pnlPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo1.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.lblTitulo1.Location = new System.Drawing.Point(50, 123);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(209, 34);
            this.lblTitulo1.TabIndex = 3;
            this.lblTitulo1.Text = "INICIA SESIÓN EN";
            this.lblTitulo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo2.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.lblTitulo2.Location = new System.Drawing.Point(50, 157);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(142, 34);
            this.lblTitulo2.TabIndex = 4;
            this.lblTitulo2.Text = "YANAPAY";
            this.lblTitulo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.5F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(11, 20);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 20);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            this.txtEmail.MouseEnter += new System.EventHandler(this.picEmailBox_MouseEnter);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(11, 20);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(236, 21);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.MouseEnter += new System.EventHandler(this.picPasswordBox_MouseEnter);
            // 
            // pnlMov1
            // 
            this.pnlMov1.ForeColor = System.Drawing.Color.Transparent;
            this.pnlMov1.Location = new System.Drawing.Point(0, 0);
            this.pnlMov1.Name = "pnlMov1";
            this.pnlMov1.Size = new System.Drawing.Size(400, 45);
            this.pnlMov1.TabIndex = 1;
            this.pnlMov1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMov_MouseDown);
            // 
            // pnlMov2
            // 
            this.pnlMov2.BackColor = System.Drawing.Color.Transparent;
            this.pnlMov2.Controls.Add(this.picClose);
            this.pnlMov2.ForeColor = System.Drawing.Color.Transparent;
            this.pnlMov2.Location = new System.Drawing.Point(396, 0);
            this.pnlMov2.Name = "pnlMov2";
            this.pnlMov2.Size = new System.Drawing.Size(884, 45);
            this.pnlMov2.TabIndex = 2;
            this.pnlMov2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMov_MouseDown);
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::TableSoft.Properties.Resources.Close;
            this.picClose.Location = new System.Drawing.Point(828, -1);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(56, 46);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 13;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseDown);
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            this.picClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picClose_MouseUp);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.lblEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblEmail.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblEmail.Location = new System.Drawing.Point(16, 14);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 21);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "EMAIL";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmail.Click += new System.EventHandler(this.picEmailBox_Click);
            this.lblEmail.MouseEnter += new System.EventHandler(this.picEmailBox_MouseEnter);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.lblPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPassword.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblPassword.Location = new System.Drawing.Point(16, 14);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(124, 21);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "CONTRASEÑA";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPassword.Click += new System.EventHandler(this.picPasswordBox_Click);
            this.lblPassword.MouseEnter += new System.EventHandler(this.picPasswordBox_MouseEnter);
            // 
            // tmrEmailEnter
            // 
            this.tmrEmailEnter.Interval = 5;
            this.tmrEmailEnter.Tick += new System.EventHandler(this.tmrEmailEnter_Tick);
            // 
            // tmrPasswordEnter
            // 
            this.tmrPasswordEnter.Interval = 10;
            this.tmrPasswordEnter.Tick += new System.EventHandler(this.tmrPasswordEnter_Tick);
            // 
            // tmrEmailLeave
            // 
            this.tmrEmailLeave.Interval = 10;
            this.tmrEmailLeave.Tick += new System.EventHandler(this.tmrEmailLeave_Tick);
            // 
            // tmrPasswordLeave
            // 
            this.tmrPasswordLeave.Interval = 5;
            this.tmrPasswordLeave.Tick += new System.EventHandler(this.tmrPasswordLeave_Tick);
            // 
            // lblForgot
            // 
            this.lblForgot.AutoSize = true;
            this.lblForgot.BackColor = System.Drawing.Color.Transparent;
            this.lblForgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgot.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblForgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.lblForgot.Location = new System.Drawing.Point(53, 610);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(156, 16);
            this.lblForgot.TabIndex = 2;
            this.lblForgot.Text = "OLVIDÉ MI CONTRASEÑA";
            this.lblForgot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblForgot.Click += new System.EventHandler(this.lblForgot_Click);
            this.lblForgot.MouseEnter += new System.EventHandler(this.lblForgot_MouseEnter);
            this.lblForgot.MouseLeave += new System.EventHandler(this.lblForgot_MouseLeave);
            // 
            // picTogglePassword
            // 
            this.picTogglePassword.BackColor = System.Drawing.Color.Transparent;
            this.picTogglePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTogglePassword.Image = global::TableSoft.Properties.Resources.PasswordHidden;
            this.picTogglePassword.Location = new System.Drawing.Point(252, 5);
            this.picTogglePassword.Name = "picTogglePassword";
            this.picTogglePassword.Size = new System.Drawing.Size(20, 41);
            this.picTogglePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTogglePassword.TabIndex = 13;
            this.picTogglePassword.TabStop = false;
            this.picTogglePassword.Visible = false;
            this.picTogglePassword.Click += new System.EventHandler(this.picTogglePassword_Click);
            this.picTogglePassword.MouseEnter += new System.EventHandler(this.picPasswordBox_MouseEnter);
            // 
            // picCia
            // 
            this.picCia.Image = global::TableSoft.Properties.Resources.Cia;
            this.picCia.Location = new System.Drawing.Point(396, 0);
            this.picCia.Name = "picCia";
            this.picCia.Size = new System.Drawing.Size(885, 721);
            this.picCia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCia.TabIndex = 0;
            this.picCia.TabStop = false;
            this.picCia.Click += new System.EventHandler(this.OnOuterClick);
            // 
            // picLogin
            // 
            this.picLogin.Image = global::TableSoft.Properties.Resources.LoginDisabled;
            this.picLogin.Location = new System.Drawing.Point(157, 445);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(84, 64);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogin.TabIndex = 8;
            this.picLogin.TabStop = false;
            this.picLogin.Click += new System.EventHandler(this.picLogin_Click);
            this.picLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picLogin_MouseDown);
            this.picLogin.MouseEnter += new System.EventHandler(this.picLogin_MouseEnter);
            this.picLogin.MouseLeave += new System.EventHandler(this.picLogin_MouseLeave);
            this.picLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picLogin_MouseUp);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::TableSoft.Properties.Resources.LogoPucpSpa;
            this.picLogo.Location = new System.Drawing.Point(52, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(91, 82);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // picEmailBox
            // 
            this.picEmailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.picEmailBox.Image = global::TableSoft.Properties.Resources.LoginBox;
            this.picEmailBox.Location = new System.Drawing.Point(2, 2);
            this.picEmailBox.Name = "picEmailBox";
            this.picEmailBox.Size = new System.Drawing.Size(286, 47);
            this.picEmailBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmailBox.TabIndex = 11;
            this.picEmailBox.TabStop = false;
            this.picEmailBox.Click += new System.EventHandler(this.picEmailBox_Click);
            this.picEmailBox.MouseEnter += new System.EventHandler(this.picEmailBox_MouseEnter);
            this.picEmailBox.MouseLeave += new System.EventHandler(this.picEmailBox_MouseLeave);
            // 
            // picPasswordBox
            // 
            this.picPasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.picPasswordBox.Image = global::TableSoft.Properties.Resources.LoginBox;
            this.picPasswordBox.Location = new System.Drawing.Point(2, 2);
            this.picPasswordBox.Name = "picPasswordBox";
            this.picPasswordBox.Size = new System.Drawing.Size(286, 47);
            this.picPasswordBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPasswordBox.TabIndex = 12;
            this.picPasswordBox.TabStop = false;
            this.picPasswordBox.Click += new System.EventHandler(this.picPasswordBox_Click);
            this.picPasswordBox.MouseEnter += new System.EventHandler(this.picPasswordBox_MouseEnter);
            this.picPasswordBox.MouseLeave += new System.EventHandler(this.picPasswordBox_MouseLeave);
            // 
            // pnlBoxes
            // 
            this.pnlBoxes.BackColor = System.Drawing.Color.Transparent;
            this.pnlBoxes.Controls.Add(this.pnlPassword);
            this.pnlBoxes.Controls.Add(this.pnlEmail);
            this.pnlBoxes.Controls.Add(this.picLogo);
            this.pnlBoxes.Controls.Add(this.lblForgot);
            this.pnlBoxes.Controls.Add(this.picLogin);
            this.pnlBoxes.Controls.Add(this.lblTitulo2);
            this.pnlBoxes.Controls.Add(this.lblTitulo1);
            this.pnlBoxes.Controls.Add(this.lblError);
            this.pnlBoxes.Location = new System.Drawing.Point(0, 45);
            this.pnlBoxes.Name = "pnlBoxes";
            this.pnlBoxes.Size = new System.Drawing.Size(400, 675);
            this.pnlBoxes.TabIndex = 0;
            this.pnlBoxes.Click += new System.EventHandler(this.OnOuterClick);
            // 
            // pnlEmail
            // 
            this.pnlEmail.Controls.Add(this.lblEmail);
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Controls.Add(this.picEmailBox);
            this.pnlEmail.Location = new System.Drawing.Point(54, 236);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(290, 51);
            this.pnlEmail.TabIndex = 0;
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(41)))), ((int)(((byte)(204)))));
            this.lblError.Location = new System.Drawing.Point(51, 204);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(315, 96);
            this.lblError.TabIndex = 5;
            this.lblError.Visible = false;
            // 
            // picLoading
            // 
            this.picLoading.Image = global::TableSoft.Properties.Resources.Loading;
            this.picLoading.Location = new System.Drawing.Point(148, 296);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(103, 96);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoading.TabIndex = 17;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // pnlPassword
            // 
            this.pnlPassword.Controls.Add(this.picTogglePassword);
            this.pnlPassword.Controls.Add(this.lblPassword);
            this.pnlPassword.Controls.Add(this.txtPassword);
            this.pnlPassword.Controls.Add(this.picPasswordBox);
            this.pnlPassword.Location = new System.Drawing.Point(54, 298);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(290, 51);
            this.pnlPassword.TabIndex = 1;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlMov2);
            this.Controls.Add(this.picCia);
            this.Controls.Add(this.pnlBoxes);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.pnlMov1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yanapay | Iniciar sesión";
            this.Click += new System.EventHandler(this.OnOuterClick);
            this.pnlMov2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTogglePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmailBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordBox)).EndInit();
            this.pnlBoxes.ResumeLayout(false);
            this.pnlBoxes.PerformLayout();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCia;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.Panel pnlMov1;
        private System.Windows.Forms.Panel pnlMov2;
        private System.Windows.Forms.PictureBox picPasswordBox;
        private System.Windows.Forms.PictureBox picEmailBox;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Timer tmrEmailEnter;
        private System.Windows.Forms.Timer tmrPasswordEnter;
        private System.Windows.Forms.Timer tmrEmailLeave;
        private System.Windows.Forms.Timer tmrPasswordLeave;
        private System.Windows.Forms.PictureBox picTogglePassword;
        private System.Windows.Forms.Label lblForgot;
        private System.Windows.Forms.Panel pnlBoxes;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Panel pnlPassword;
    }
}