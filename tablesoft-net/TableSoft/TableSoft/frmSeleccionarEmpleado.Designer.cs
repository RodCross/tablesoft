namespace TableSoft
{
    partial class frmSeleccionarEmpleado
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
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvGestionar = new System.Windows.Forms.DataGridView();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTicketsEspera = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAgente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionar)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(1129, 453);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(119, 33);
            this.btnSeleccionar.TabIndex = 14;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(982, 453);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(119, 33);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(826, 453);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(119, 33);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "< Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // dgvGestionar
            // 
            this.dgvGestionar.AllowUserToAddRows = false;
            this.dgvGestionar.AllowUserToDeleteRows = false;
            this.dgvGestionar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dgvGestionar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGestionar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestionar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Codigo,
            this.DNI,
            this.Rol,
            this.Equipo,
            this.EmailPersonal,
            this.EmailAgente});
            this.dgvGestionar.Location = new System.Drawing.Point(12, 76);
            this.dgvGestionar.Name = "dgvGestionar";
            this.dgvGestionar.ReadOnly = true;
            this.dgvGestionar.Size = new System.Drawing.Size(1236, 362);
            this.dgvGestionar.TabIndex = 12;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.pnlTitulo.Controls.Add(this.lblTicketsEspera);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1258, 70);
            this.pnlTitulo.TabIndex = 10;
            // 
            // lblTicketsEspera
            // 
            this.lblTicketsEspera.AutoSize = true;
            this.lblTicketsEspera.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTicketsEspera.ForeColor = System.Drawing.Color.White;
            this.lblTicketsEspera.Location = new System.Drawing.Point(30, 23);
            this.lblTicketsEspera.Name = "lblTicketsEspera";
            this.lblTicketsEspera.Size = new System.Drawing.Size(199, 27);
            this.lblTicketsEspera.TabIndex = 0;
            this.lblTicketsEspera.Text = "Lista de Empleados";
            // 
            // ID
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 350;
            // 
            // Codigo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // DNI
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.DNI.DefaultCellStyle = dataGridViewCellStyle3;
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Rol
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.Rol.DefaultCellStyle = dataGridViewCellStyle4;
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // Equipo
            // 
            this.Equipo.HeaderText = "Equipo";
            this.Equipo.Name = "Equipo";
            this.Equipo.ReadOnly = true;
            // 
            // EmailPersonal
            // 
            this.EmailPersonal.HeaderText = "Email Personal";
            this.EmailPersonal.Name = "EmailPersonal";
            this.EmailPersonal.ReadOnly = true;
            this.EmailPersonal.Width = 230;
            // 
            // EmailAgente
            // 
            this.EmailAgente.HeaderText = "Email Agente";
            this.EmailAgente.Name = "EmailAgente";
            this.EmailAgente.ReadOnly = true;
            this.EmailAgente.Width = 170;
            // 
            // frmSeleccionarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 501);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvGestionar);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "frmSeleccionarEmpleado";
            this.Text = "frmSeleccionarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionar)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvGestionar;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTicketsEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAgente;
    }
}