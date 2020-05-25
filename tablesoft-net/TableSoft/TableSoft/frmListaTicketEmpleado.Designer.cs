namespace TableSoft
{
    partial class frmListaTicketEmpleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaTicketEmpleado));
            this.dgvGestionar = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.lblMiCuenta = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblFAQ = new System.Windows.Forms.Label();
            this.lblBibliotecasPUCP = new System.Windows.Forms.Label();
            this.lblTituloSistema = new System.Windows.Forms.Label();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionar)).BeginInit();
            this.pnlOpciones.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGestionar
            // 
            this.dgvGestionar.AllowUserToAddRows = false;
            this.dgvGestionar.AllowUserToDeleteRows = false;
            this.dgvGestionar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dgvGestionar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestionar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Asunto,
            this.Empleado,
            this.FechaApertura,
            this.FechaCierre,
            this.Estado});
            this.dgvGestionar.Location = new System.Drawing.Point(35, 215);
            this.dgvGestionar.Name = "dgvGestionar";
            this.dgvGestionar.ReadOnly = true;
            this.dgvGestionar.Size = new System.Drawing.Size(994, 436);
            this.dgvGestionar.TabIndex = 0;
            // 
            // ID
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 75;
            // 
            // Asunto
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Asunto.DefaultCellStyle = dataGridViewCellStyle2;
            this.Asunto.HeaderText = "Asunto";
            this.Asunto.Name = "Asunto";
            this.Asunto.ReadOnly = true;
            this.Asunto.Width = 275;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            this.Empleado.Width = 200;
            // 
            // FechaApertura
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaApertura.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaApertura.HeaderText = "Fecha de apertura";
            this.FechaApertura.Name = "FechaApertura";
            this.FechaApertura.ReadOnly = true;
            this.FechaApertura.Width = 150;
            // 
            // FechaCierre
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaCierre.DefaultCellStyle = dataGridViewCellStyle4;
            this.FechaCierre.HeaderText = "Fecha de cierre";
            this.FechaCierre.Name = "FechaCierre";
            this.FechaCierre.ReadOnly = true;
            this.FechaCierre.Width = 150;
            // 
            // Estado
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.DefaultCellStyle = dataGridViewCellStyle5;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(208)))));
            this.pnlOpciones.Controls.Add(this.lblMiCuenta);
            this.pnlOpciones.Controls.Add(this.lblLogout);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 106);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(1064, 51);
            this.pnlOpciones.TabIndex = 0;
            // 
            // lblMiCuenta
            // 
            this.lblMiCuenta.AutoSize = true;
            this.lblMiCuenta.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiCuenta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMiCuenta.Location = new System.Drawing.Point(780, 14);
            this.lblMiCuenta.Name = "lblMiCuenta";
            this.lblMiCuenta.Size = new System.Drawing.Size(95, 23);
            this.lblMiCuenta.TabIndex = 0;
            this.lblMiCuenta.Text = "Mi cuenta";
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLogout.Location = new System.Drawing.Point(905, 14);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(124, 23);
            this.lblLogout.TabIndex = 0;
            this.lblLogout.Text = "Cerrar sesión";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.pnlTitulo.Controls.Add(this.lblFAQ);
            this.pnlTitulo.Controls.Add(this.lblBibliotecasPUCP);
            this.pnlTitulo.Controls.Add(this.lblTituloSistema);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1064, 106);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblFAQ
            // 
            this.lblFAQ.AutoSize = true;
            this.lblFAQ.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFAQ.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFAQ.Location = new System.Drawing.Point(898, 70);
            this.lblFAQ.Name = "lblFAQ";
            this.lblFAQ.Size = new System.Drawing.Size(131, 16);
            this.lblFAQ.TabIndex = 0;
            this.lblFAQ.Text = "Preguntas frecuentes";
            this.lblFAQ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBibliotecasPUCP
            // 
            this.lblBibliotecasPUCP.AutoSize = true;
            this.lblBibliotecasPUCP.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBibliotecasPUCP.ForeColor = System.Drawing.Color.White;
            this.lblBibliotecasPUCP.Location = new System.Drawing.Point(25, 64);
            this.lblBibliotecasPUCP.Name = "lblBibliotecasPUCP";
            this.lblBibliotecasPUCP.Size = new System.Drawing.Size(158, 23);
            this.lblBibliotecasPUCP.TabIndex = 0;
            this.lblBibliotecasPUCP.Text = "Bibliotecas PUCP";
            // 
            // lblTituloSistema
            // 
            this.lblTituloSistema.AutoSize = true;
            this.lblTituloSistema.Font = new System.Drawing.Font("Lato Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSistema.ForeColor = System.Drawing.Color.White;
            this.lblTituloSistema.Location = new System.Drawing.Point(23, 17);
            this.lblTituloSistema.Name = "lblTituloSistema";
            this.lblTituloSistema.Size = new System.Drawing.Size(344, 33);
            this.lblTituloSistema.TabIndex = 0;
            this.lblTituloSistema.Text = "Sistema de Mesa de Ayuda";
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Lato Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblHistorial.Location = new System.Drawing.Point(30, 175);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(172, 25);
            this.lblHistorial.TabIndex = 0;
            this.lblHistorial.Text = "Gestionar tickets";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(910, 669);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(119, 33);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // frmListaTicketEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 721);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.dgvGestionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaTicketEmpleado";
            this.Text = "Historial de tickets";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionar)).EndInit();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGestionar;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblBibliotecasPUCP;
        private System.Windows.Forms.Label lblTituloSistema;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblFAQ;
        private System.Windows.Forms.Label lblMiCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}