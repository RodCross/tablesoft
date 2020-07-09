namespace TableSoft
{
    partial class frmGestionarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarProveedor));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDatosProveedor = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblIDProveedor = new System.Windows.Forms.Label();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.txtIDProveedor = new System.Windows.Forms.TextBox();
            this.lblRUC = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.pnlTitulo.Controls.Add(this.btnCancelar);
            this.pnlTitulo.Controls.Add(this.lblDatosProveedor);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(700, 70);
            this.pnlTitulo.TabIndex = 10;
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
            this.btnCancelar.Location = new System.Drawing.Point(569, 21);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 33);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDatosProveedor
            // 
            this.lblDatosProveedor.AutoSize = true;
            this.lblDatosProveedor.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDatosProveedor.ForeColor = System.Drawing.Color.White;
            this.lblDatosProveedor.Location = new System.Drawing.Point(30, 22);
            this.lblDatosProveedor.Name = "lblDatosProveedor";
            this.lblDatosProveedor.Size = new System.Drawing.Size(211, 27);
            this.lblDatosProveedor.TabIndex = 1;
            this.lblDatosProveedor.Text = "Datos del proveedor";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblPais.Location = new System.Drawing.Point(111, 252);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(38, 21);
            this.lblPais.TabIndex = 15;
            this.lblPais.Text = "País";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(170, 210);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(501, 28);
            this.txtDireccion.TabIndex = 3;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblDireccion.Location = new System.Drawing.Point(72, 213);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 21);
            this.lblDireccion.TabIndex = 14;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(170, 366);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(305, 28);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblEmail.Location = new System.Drawing.Point(99, 369);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 21);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(170, 327);
            this.txtTelefono.MaxLength = 30;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(305, 28);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblTelefono.Location = new System.Drawing.Point(51, 330);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(96, 21);
            this.lblTelefono.TabIndex = 17;
            this.lblTelefono.Text = "Teléfono fijo";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblCiudad.Location = new System.Drawing.Point(88, 290);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(59, 21);
            this.lblCiudad.TabIndex = 16;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(170, 171);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(501, 28);
            this.txtRazonSocial.TabIndex = 2;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblRazonSocial.Location = new System.Drawing.Point(51, 174);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(96, 21);
            this.lblRazonSocial.TabIndex = 13;
            this.lblRazonSocial.Text = "Razón social";
            // 
            // lblIDProveedor
            // 
            this.lblIDProveedor.AutoSize = true;
            this.lblIDProveedor.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProveedor.Location = new System.Drawing.Point(122, 96);
            this.lblIDProveedor.Name = "lblIDProveedor";
            this.lblIDProveedor.Size = new System.Drawing.Size(25, 21);
            this.lblIDProveedor.TabIndex = 11;
            this.lblIDProveedor.Text = "ID";
            // 
            // txtRUC
            // 
            this.txtRUC.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUC.Location = new System.Drawing.Point(170, 132);
            this.txtRUC.MaxLength = 11;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(204, 28);
            this.txtRUC.TabIndex = 1;
            this.txtRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            // 
            // txtIDProveedor
            // 
            this.txtIDProveedor.Enabled = false;
            this.txtIDProveedor.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDProveedor.Location = new System.Drawing.Point(170, 93);
            this.txtIDProveedor.Name = "txtIDProveedor";
            this.txtIDProveedor.ReadOnly = true;
            this.txtIDProveedor.Size = new System.Drawing.Size(204, 28);
            this.txtIDProveedor.TabIndex = 0;
            // 
            // lblRUC
            // 
            this.lblRUC.AutoSize = true;
            this.lblRUC.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblRUC.Location = new System.Drawing.Point(106, 135);
            this.lblRUC.Name = "lblRUC";
            this.lblRUC.Size = new System.Drawing.Size(41, 21);
            this.lblRUC.TabIndex = 12;
            this.lblRUC.Text = "RUC";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(531, 419);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(140, 41);
            this.btnActualizar.TabIndex = 9;
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
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(531, 419);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 41);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboPais
            // 
            this.cboPais.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(170, 250);
            this.cboPais.Margin = new System.Windows.Forms.Padding(2);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(305, 29);
            this.cboPais.TabIndex = 4;
            this.cboPais.SelectedIndexChanged += new System.EventHandler(this.cboPais_SelectedIndexChanged);
            // 
            // cboCiudad
            // 
            this.cboCiudad.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Location = new System.Drawing.Point(170, 288);
            this.cboCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(305, 29);
            this.cboCiudad.TabIndex = 5;
            // 
            // frmGestionarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.cboCiudad);
            this.Controls.Add(this.cboPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.lblIDProveedor);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.txtIDProveedor);
            this.Controls.Add(this.lblRUC);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionarProveedor";
            this.Text = "Datos del proveedor";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblDatosProveedor;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblIDProveedor;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.TextBox txtIDProveedor;
        private System.Windows.Forms.Label lblRUC;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.ComboBox cboCiudad;
    }
}