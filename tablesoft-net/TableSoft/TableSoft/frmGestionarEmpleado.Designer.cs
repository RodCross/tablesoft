namespace TableSoft
{
    partial class frmGestionarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarEmpleado));
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblDatosEmpleado = new System.Windows.Forms.Label();
            this.picEye = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.lblBiblioteca = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtEmailPersonal = new System.Windows.Forms.TextBox();
            this.lblEmailPersonal = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIDEmpleado = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cboBiblioteca = new System.Windows.Forms.ComboBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(569, 537);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(102, 33);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(569, 537);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 33);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(569, 21);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 33);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.pnlTitulo.Controls.Add(this.lblDatosEmpleado);
            this.pnlTitulo.Controls.Add(this.btnCancelar);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(700, 70);
            this.pnlTitulo.TabIndex = 13;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // lblDatosEmpleado
            // 
            this.lblDatosEmpleado.AutoSize = true;
            this.lblDatosEmpleado.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDatosEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblDatosEmpleado.Location = new System.Drawing.Point(30, 22);
            this.lblDatosEmpleado.Name = "lblDatosEmpleado";
            this.lblDatosEmpleado.Size = new System.Drawing.Size(207, 27);
            this.lblDatosEmpleado.TabIndex = 1;
            this.lblDatosEmpleado.Text = "Datos del empleado";
            // 
            // picEye
            // 
            this.picEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEye.Image = global::TableSoft.Properties.Resources.Eye;
            this.picEye.Location = new System.Drawing.Point(642, 315);
            this.picEye.Name = "picEye";
            this.picEye.Size = new System.Drawing.Size(29, 28);
            this.picEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEye.TabIndex = 56;
            this.picEye.TabStop = false;
            this.picEye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picEye_MouseDown);
            this.picEye.MouseEnter += new System.EventHandler(this.picEye_MouseEnter);
            this.picEye.MouseLeave += new System.EventHandler(this.picEye_MouseLeave);
            this.picEye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picEye_MouseUp);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(170, 315);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(501, 28);
            this.txtPass.TabIndex = 6;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblPass.Location = new System.Drawing.Point(66, 318);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(89, 21);
            this.lblPass.TabIndex = 20;
            this.lblPass.Text = "Contraseña";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(170, 278);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(204, 28);
            this.txtTel.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblDireccion.Location = new System.Drawing.Point(80, 244);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 21);
            this.lblDireccion.TabIndex = 18;
            this.lblDireccion.Text = "Dirección";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(170, 241);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(501, 28);
            this.txtDireccion.TabIndex = 4;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblTel.Location = new System.Drawing.Point(35, 281);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(120, 21);
            this.lblTel.TabIndex = 19;
            this.lblTel.Text = "Teléfono celular";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaterno
            // 
            this.txtMaterno.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterno.Location = new System.Drawing.Point(170, 204);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(501, 28);
            this.txtMaterno.TabIndex = 3;
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblMaterno.Location = new System.Drawing.Point(25, 207);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(130, 21);
            this.lblMaterno.TabIndex = 17;
            this.lblMaterno.Text = "Apellido Materno";
            this.lblMaterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaterno.Location = new System.Drawing.Point(170, 167);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(501, 28);
            this.txtPaterno.TabIndex = 2;
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblPaterno.Location = new System.Drawing.Point(30, 170);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(125, 21);
            this.lblPaterno.TabIndex = 16;
            this.lblPaterno.Text = "Apellido Paterno";
            this.lblPaterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBiblioteca
            // 
            this.lblBiblioteca.AutoSize = true;
            this.lblBiblioteca.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblBiblioteca.Location = new System.Drawing.Point(78, 432);
            this.lblBiblioteca.Name = "lblBiblioteca";
            this.lblBiblioteca.Size = new System.Drawing.Size(77, 21);
            this.lblBiblioteca.TabIndex = 23;
            this.lblBiblioteca.Text = "Biblioteca";
            this.lblBiblioteca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(170, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(501, 28);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(170, 389);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(204, 28);
            this.txtDNI.TabIndex = 8;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblDNI.Location = new System.Drawing.Point(118, 392);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(37, 21);
            this.lblDNI.TabIndex = 22;
            this.lblDNI.Text = "DNI";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmailPersonal
            // 
            this.txtEmailPersonal.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailPersonal.Location = new System.Drawing.Point(170, 469);
            this.txtEmailPersonal.Name = "txtEmailPersonal";
            this.txtEmailPersonal.Size = new System.Drawing.Size(501, 28);
            this.txtEmailPersonal.TabIndex = 10;
            // 
            // lblEmailPersonal
            // 
            this.lblEmailPersonal.AutoSize = true;
            this.lblEmailPersonal.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblEmailPersonal.Location = new System.Drawing.Point(64, 472);
            this.lblEmailPersonal.Name = "lblEmailPersonal";
            this.lblEmailPersonal.Size = new System.Drawing.Size(91, 21);
            this.lblEmailPersonal.TabIndex = 24;
            this.lblEmailPersonal.Text = "Email PUCP";
            this.lblEmailPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblNombre.Location = new System.Drawing.Point(87, 133);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 21);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIDEmpleado
            // 
            this.lblIDEmpleado.AutoSize = true;
            this.lblIDEmpleado.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDEmpleado.Location = new System.Drawing.Point(130, 96);
            this.lblIDEmpleado.Name = "lblIDEmpleado";
            this.lblIDEmpleado.Size = new System.Drawing.Size(25, 21);
            this.lblIDEmpleado.TabIndex = 14;
            this.lblIDEmpleado.Text = "ID";
            this.lblIDEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(170, 352);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(204, 28);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.Enabled = false;
            this.txtIDEmpleado.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDEmpleado.Location = new System.Drawing.Point(170, 93);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.ReadOnly = true;
            this.txtIDEmpleado.Size = new System.Drawing.Size(204, 28);
            this.txtIDEmpleado.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblCodigo.Location = new System.Drawing.Point(95, 355);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 21);
            this.lblCodigo.TabIndex = 21;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboBiblioteca
            // 
            this.cboBiblioteca.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.cboBiblioteca.FormattingEnabled = true;
            this.cboBiblioteca.Location = new System.Drawing.Point(170, 429);
            this.cboBiblioteca.Name = "cboBiblioteca";
            this.cboBiblioteca.Size = new System.Drawing.Size(501, 29);
            this.cboBiblioteca.TabIndex = 9;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(170, 509);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(15, 14);
            this.chkActivo.TabIndex = 57;
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblActivo.Location = new System.Drawing.Point(102, 502);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(53, 21);
            this.lblActivo.TabIndex = 58;
            this.lblActivo.Text = "Activo";
            this.lblActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmGestionarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 596);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.cboBiblioteca);
            this.Controls.Add(this.picEye);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.lblMaterno);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.lblPaterno);
            this.Controls.Add(this.lblBiblioteca);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtEmailPersonal);
            this.Controls.Add(this.lblEmailPersonal);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIDEmpleado);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtIDEmpleado);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionarEmpleado";
            this.Text = "Datos del empleado";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblDatosEmpleado;
        private System.Windows.Forms.PictureBox picEye;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.Label lblBiblioteca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtEmailPersonal;
        private System.Windows.Forms.Label lblEmailPersonal;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIDEmpleado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cboBiblioteca;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label lblActivo;
    }
}