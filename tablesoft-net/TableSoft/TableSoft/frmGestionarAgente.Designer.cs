namespace TableSoft
{
    partial class frmGestionarAgente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarAgente));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDatosEmpleado = new System.Windows.Forms.Label();
            this.txtEmailAgente = new System.Windows.Forms.TextBox();
            this.lblEmailAgente = new System.Windows.Forms.Label();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cboEquipo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtEmailPersonal = new System.Windows.Forms.TextBox();
            this.lblEmailPersonal = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblIDAgente = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtIDAgente = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.picEye = new System.Windows.Forms.PictureBox();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.pnlTitulo.Controls.Add(this.btnCancelar);
            this.pnlTitulo.Controls.Add(this.lblDatosEmpleado);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(933, 86);
            this.pnlTitulo.TabIndex = 15;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(759, 26);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 41);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDatosEmpleado
            // 
            this.lblDatosEmpleado.AutoSize = true;
            this.lblDatosEmpleado.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDatosEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblDatosEmpleado.Location = new System.Drawing.Point(40, 27);
            this.lblDatosEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosEmpleado.Name = "lblDatosEmpleado";
            this.lblDatosEmpleado.Size = new System.Drawing.Size(233, 36);
            this.lblDatosEmpleado.TabIndex = 1;
            this.lblDatosEmpleado.Text = "Datos del agente";
            // 
            // txtEmailAgente
            // 
            this.txtEmailAgente.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAgente.Location = new System.Drawing.Point(227, 673);
            this.txtEmailAgente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailAgente.Name = "txtEmailAgente";
            this.txtEmailAgente.Size = new System.Drawing.Size(667, 33);
            this.txtEmailAgente.TabIndex = 12;
            // 
            // lblEmailAgente
            // 
            this.lblEmailAgente.AutoSize = true;
            this.lblEmailAgente.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblEmailAgente.Location = new System.Drawing.Point(75, 677);
            this.lblEmailAgente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailAgente.Name = "lblEmailAgente";
            this.lblEmailAgente.Size = new System.Drawing.Size(124, 26);
            this.lblEmailAgente.TabIndex = 28;
            this.lblEmailAgente.Text = "Email agente";
            this.lblEmailAgente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboRol
            // 
            this.cboRol.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(227, 529);
            this.cboRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(271, 34);
            this.cboRol.TabIndex = 9;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblRol.Location = new System.Drawing.Point(163, 533);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(41, 26);
            this.lblRol.TabIndex = 25;
            this.lblRol.Text = "Rol";
            this.lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboEquipo
            // 
            this.cboEquipo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEquipo.FormattingEnabled = true;
            this.cboEquipo.Location = new System.Drawing.Point(227, 580);
            this.cboEquipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboEquipo.Name = "cboEquipo";
            this.cboEquipo.Size = new System.Drawing.Size(271, 34);
            this.cboEquipo.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(227, 160);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(667, 33);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(227, 479);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(271, 33);
            this.txtDNI.TabIndex = 8;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblDNI.Location = new System.Drawing.Point(157, 482);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(46, 26);
            this.lblDNI.TabIndex = 24;
            this.lblDNI.Text = "DNI";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmailPersonal
            // 
            this.txtEmailPersonal.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailPersonal.Location = new System.Drawing.Point(227, 628);
            this.txtEmailPersonal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailPersonal.Name = "txtEmailPersonal";
            this.txtEmailPersonal.Size = new System.Drawing.Size(667, 33);
            this.txtEmailPersonal.TabIndex = 11;
            // 
            // lblEmailPersonal
            // 
            this.lblEmailPersonal.AutoSize = true;
            this.lblEmailPersonal.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblEmailPersonal.Location = new System.Drawing.Point(57, 631);
            this.lblEmailPersonal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailPersonal.Name = "lblEmailPersonal";
            this.lblEmailPersonal.Size = new System.Drawing.Size(139, 26);
            this.lblEmailPersonal.TabIndex = 27;
            this.lblEmailPersonal.Text = "Email personal";
            this.lblEmailPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblNombre.Location = new System.Drawing.Point(116, 164);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 26);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblEquipo.Location = new System.Drawing.Point(129, 583);
            this.lblEquipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(74, 26);
            this.lblEquipo.TabIndex = 26;
            this.lblEquipo.Text = "Equipo";
            this.lblEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIDAgente
            // 
            this.lblIDAgente.AutoSize = true;
            this.lblIDAgente.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDAgente.Location = new System.Drawing.Point(173, 118);
            this.lblIDAgente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDAgente.Name = "lblIDAgente";
            this.lblIDAgente.Size = new System.Drawing.Size(31, 26);
            this.lblIDAgente.TabIndex = 16;
            this.lblIDAgente.Text = "ID";
            this.lblIDAgente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(227, 433);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(271, 33);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtIDAgente
            // 
            this.txtIDAgente.Enabled = false;
            this.txtIDAgente.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDAgente.Location = new System.Drawing.Point(227, 114);
            this.txtIDAgente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDAgente.Name = "txtIDAgente";
            this.txtIDAgente.ReadOnly = true;
            this.txtIDAgente.Size = new System.Drawing.Size(271, 33);
            this.txtIDAgente.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblCodigo.Location = new System.Drawing.Point(127, 437);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(77, 26);
            this.lblCodigo.TabIndex = 23;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(759, 757);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(136, 41);
            this.btnActualizar.TabIndex = 14;
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
            this.btnGuardar.Location = new System.Drawing.Point(759, 757);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 41);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtPaterno
            // 
            this.txtPaterno.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaterno.Location = new System.Drawing.Point(227, 206);
            this.txtPaterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(667, 33);
            this.txtPaterno.TabIndex = 2;
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblPaterno.Location = new System.Drawing.Point(40, 209);
            this.lblPaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(159, 26);
            this.lblPaterno.TabIndex = 18;
            this.lblPaterno.Text = "Apellido Paterno";
            this.lblPaterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaterno
            // 
            this.txtMaterno.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterno.Location = new System.Drawing.Point(227, 251);
            this.txtMaterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(667, 33);
            this.txtMaterno.TabIndex = 3;
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblMaterno.Location = new System.Drawing.Point(33, 255);
            this.lblMaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(166, 26);
            this.lblMaterno.TabIndex = 19;
            this.lblMaterno.Text = "Apellido Materno";
            this.lblMaterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(227, 297);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(667, 33);
            this.txtDireccion.TabIndex = 4;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblTel.Location = new System.Drawing.Point(113, 346);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(88, 26);
            this.lblTel.TabIndex = 21;
            this.lblTel.Text = "Teléfono";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(227, 342);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(271, 33);
            this.txtTel.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblDireccion.Location = new System.Drawing.Point(107, 300);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(94, 26);
            this.lblDireccion.TabIndex = 20;
            this.lblDireccion.Text = "Dirección";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(227, 388);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(667, 33);
            this.txtPass.TabIndex = 6;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblPass.Location = new System.Drawing.Point(88, 391);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(110, 26);
            this.lblPass.TabIndex = 22;
            this.lblPass.Text = "Contraseña";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picEye
            // 
            this.picEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEye.Image = global::TableSoft.Properties.Resources.Eye;
            this.picEye.Location = new System.Drawing.Point(856, 388);
            this.picEye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picEye.Name = "picEye";
            this.picEye.Size = new System.Drawing.Size(39, 34);
            this.picEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEye.TabIndex = 29;
            this.picEye.TabStop = false;
            this.picEye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picEye_MouseDown);
            this.picEye.MouseEnter += new System.EventHandler(this.picEye_MouseEnter);
            this.picEye.MouseLeave += new System.EventHandler(this.picEye_MouseLeave);
            this.picEye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picEye_MouseUp);
            // 
            // frmGestionarAgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 830);
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
            this.Controls.Add(this.txtEmailAgente);
            this.Controls.Add(this.lblEmailAgente);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.cboEquipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtEmailPersonal);
            this.Controls.Add(this.lblEmailPersonal);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.lblIDAgente);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtIDAgente);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGestionarAgente";
            this.Text = "frmGestionarAgentes";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblDatosEmpleado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtEmailAgente;
        private System.Windows.Forms.Label lblEmailAgente;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cboEquipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtEmailPersonal;
        private System.Windows.Forms.Label lblEmailPersonal;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblIDAgente;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtIDAgente;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.PictureBox picEye;
    }
}