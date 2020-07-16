namespace TableSoft
{
    partial class frmRecuperarEnvioExitoso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperarEnvioExitoso));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblBibliotecasPUCP = new System.Windows.Forms.Label();
            this.lblTituloSistema = new System.Windows.Forms.Label();
            this.lblTituloExito = new System.Windows.Forms.Label();
            this.lblTextoRecuperacion = new System.Windows.Forms.Label();
            this.lblTextoCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lklRegresar = new System.Windows.Forms.LinkLabel();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lklReenviar = new System.Windows.Forms.LinkLabel();
            this.lblErrCodigo = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
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
            this.pnlTitulo.TabIndex = 3;
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
            // lblTituloExito
            // 
            this.lblTituloExito.AutoSize = true;
            this.lblTituloExito.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloExito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblTituloExito.Location = new System.Drawing.Point(158, 127);
            this.lblTituloExito.Name = "lblTituloExito";
            this.lblTituloExito.Size = new System.Drawing.Size(569, 36);
            this.lblTituloExito.TabIndex = 5;
            this.lblTituloExito.Text = "Te hemos enviado el email de recuperación";
            this.lblTituloExito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextoRecuperacion
            // 
            this.lblTextoRecuperacion.BackColor = System.Drawing.Color.Transparent;
            this.lblTextoRecuperacion.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoRecuperacion.ForeColor = System.Drawing.Color.Black;
            this.lblTextoRecuperacion.Location = new System.Drawing.Point(132, 179);
            this.lblTextoRecuperacion.Name = "lblTextoRecuperacion";
            this.lblTextoRecuperacion.Size = new System.Drawing.Size(621, 74);
            this.lblTextoRecuperacion.TabIndex = 6;
            this.lblTextoRecuperacion.Text = "Echa un vistazo a tu bandeja de entrada. Si no aparece después de 15 minutos, rev" +
    "isa tu carpeta de correo no deseado.";
            this.lblTextoRecuperacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextoCodigo
            // 
            this.lblTextoCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblTextoCodigo.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblTextoCodigo.Location = new System.Drawing.Point(146, 258);
            this.lblTextoCodigo.Name = "lblTextoCodigo";
            this.lblTextoCodigo.Size = new System.Drawing.Size(592, 50);
            this.lblTextoCodigo.TabIndex = 7;
            this.lblTextoCodigo.Text = "Ingresa aquí el código de 6 dígitos que te enviamos:";
            this.lblTextoCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft PhagsPa", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.Location = new System.Drawing.Point(307, 330);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(272, 69);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lklRegresar
            // 
            this.lklRegresar.AutoSize = true;
            this.lklRegresar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklRegresar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(204)))));
            this.lklRegresar.Location = new System.Drawing.Point(291, 515);
            this.lklRegresar.Name = "lklRegresar";
            this.lklRegresar.Size = new System.Drawing.Size(303, 21);
            this.lklRegresar.TabIndex = 2;
            this.lklRegresar.TabStop = true;
            this.lklRegresar.Text = "He cometido un error al ingresar mi email.";
            this.lklRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lklRegresar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklRegresar_LinkClicked);
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(208)))));
            this.btnVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(306, 432);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(272, 50);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lklReenviar
            // 
            this.lklReenviar.AutoSize = true;
            this.lklReenviar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklReenviar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(204)))));
            this.lklReenviar.Location = new System.Drawing.Point(419, 401);
            this.lklReenviar.Name = "lklReenviar";
            this.lklReenviar.Size = new System.Drawing.Size(103, 17);
            this.lklReenviar.TabIndex = 4;
            this.lklReenviar.TabStop = true;
            this.lklReenviar.Text = "Reenviar código";
            this.lklReenviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lklReenviar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklReenviar_LinkClicked);
            // 
            // lblErrCodigo
            // 
            this.lblErrCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblErrCodigo.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblErrCodigo.Location = new System.Drawing.Point(306, 398);
            this.lblErrCodigo.Name = "lblErrCodigo";
            this.lblErrCodigo.Size = new System.Drawing.Size(153, 23);
            this.lblErrCodigo.TabIndex = 8;
            this.lblErrCodigo.Text = "Código incorrecto. R";
            this.lblErrCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmRecuperarEnvioExitoso
            // 
            this.AcceptButton = this.btnVerificar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lklReenviar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblErrCodigo);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lklRegresar);
            this.Controls.Add(this.lblTextoCodigo);
            this.Controls.Add(this.lblTextoRecuperacion);
            this.Controls.Add(this.lblTituloExito);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecuperarEnvioExitoso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envío exitoso de correo de recuperación";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblBibliotecasPUCP;
        private System.Windows.Forms.Label lblTituloSistema;
        private System.Windows.Forms.Label lblTituloExito;
        private System.Windows.Forms.Label lblTextoRecuperacion;
        private System.Windows.Forms.Label lblTextoCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.LinkLabel lklRegresar;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.LinkLabel lklReenviar;
        private System.Windows.Forms.Label lblErrCodigo;
        private System.Windows.Forms.Button btnVolver;
    }
}