namespace TableSoft
{
    partial class frmHistorialTicketsAgente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lnkVolver = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblPreguntasFrecuentes = new System.Windows.Forms.Label();
            this.lblBibliotecasPUCP = new System.Windows.Forms.Label();
            this.lblSistemaDeMesaDeAyuda = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMiCuenta = new System.Windows.Forms.Label();
            this.lblMisTickets = new System.Windows.Forms.Label();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.Asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkVolver
            // 
            this.lnkVolver.AutoSize = true;
            this.lnkVolver.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkVolver.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.lnkVolver.Location = new System.Drawing.Point(30, 164);
            this.lnkVolver.Name = "lnkVolver";
            this.lnkVolver.Size = new System.Drawing.Size(56, 16);
            this.lnkVolver.TabIndex = 26;
            this.lnkVolver.TabStop = true;
            this.lnkVolver.Text = "< Volver";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asunto,
            this.ID,
            this.Empleado,
            this.FechaDeApertura,
            this.FechaDeCierre,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(46, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(783, 268);
            this.dataGridView1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(28, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Historial de Tickets";
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(208)))));
            this.pnl.Controls.Add(this.label5);
            this.pnl.Controls.Add(this.lblMiCuenta);
            this.pnl.Controls.Add(this.lblMisTickets);
            this.pnl.Controls.Add(this.lblCerrarSesion);
            this.pnl.Location = new System.Drawing.Point(-1, 96);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(872, 51);
            this.pnl.TabIndex = 23;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.pnlTitulo.Controls.Add(this.lblPreguntasFrecuentes);
            this.pnlTitulo.Controls.Add(this.lblBibliotecasPUCP);
            this.pnlTitulo.Controls.Add(this.lblSistemaDeMesaDeAyuda);
            this.pnlTitulo.Location = new System.Drawing.Point(-1, -1);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(872, 100);
            this.pnlTitulo.TabIndex = 22;
            // 
            // lblPreguntasFrecuentes
            // 
            this.lblPreguntasFrecuentes.AutoSize = true;
            this.lblPreguntasFrecuentes.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreguntasFrecuentes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPreguntasFrecuentes.Location = new System.Drawing.Point(799, 58);
            this.lblPreguntasFrecuentes.Name = "lblPreguntasFrecuentes";
            this.lblPreguntasFrecuentes.Size = new System.Drawing.Size(64, 23);
            this.lblPreguntasFrecuentes.TabIndex = 3;
            this.lblPreguntasFrecuentes.Text = "Ayuda";
            // 
            // lblBibliotecasPUCP
            // 
            this.lblBibliotecasPUCP.AutoSize = true;
            this.lblBibliotecasPUCP.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBibliotecasPUCP.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBibliotecasPUCP.Location = new System.Drawing.Point(14, 58);
            this.lblBibliotecasPUCP.Name = "lblBibliotecasPUCP";
            this.lblBibliotecasPUCP.Size = new System.Drawing.Size(158, 23);
            this.lblBibliotecasPUCP.TabIndex = 2;
            this.lblBibliotecasPUCP.Text = "Bibliotecas PUCP";
            // 
            // lblSistemaDeMesaDeAyuda
            // 
            this.lblSistemaDeMesaDeAyuda.AutoSize = true;
            this.lblSistemaDeMesaDeAyuda.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaDeMesaDeAyuda.ForeColor = System.Drawing.Color.White;
            this.lblSistemaDeMesaDeAyuda.Location = new System.Drawing.Point(12, 16);
            this.lblSistemaDeMesaDeAyuda.Name = "lblSistemaDeMesaDeAyuda";
            this.lblSistemaDeMesaDeAyuda.Size = new System.Drawing.Size(328, 33);
            this.lblSistemaDeMesaDeAyuda.TabIndex = 1;
            this.lblSistemaDeMesaDeAyuda.Text = "Sistema de Mesa de Ayuda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(464, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mi Equipo";
            // 
            // lblMiCuenta
            // 
            this.lblMiCuenta.AutoSize = true;
            this.lblMiCuenta.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiCuenta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMiCuenta.Location = new System.Drawing.Point(343, 14);
            this.lblMiCuenta.Name = "lblMiCuenta";
            this.lblMiCuenta.Size = new System.Drawing.Size(99, 23);
            this.lblMiCuenta.TabIndex = 10;
            this.lblMiCuenta.Text = "Mi Cuenta";
            // 
            // lblMisTickets
            // 
            this.lblMisTickets.AutoSize = true;
            this.lblMisTickets.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMisTickets.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMisTickets.Location = new System.Drawing.Point(574, 14);
            this.lblMisTickets.Name = "lblMisTickets";
            this.lblMisTickets.Size = new System.Drawing.Size(157, 23);
            this.lblMisTickets.TabIndex = 9;
            this.lblMisTickets.Text = "Gestionar Tickets";
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCerrarSesion.Location = new System.Drawing.Point(741, 14);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(126, 23);
            this.lblCerrarSesion.TabIndex = 8;
            this.lblCerrarSesion.Text = "Cerrar Sesion";
            // 
            // Asunto
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Asunto.DefaultCellStyle = dataGridViewCellStyle16;
            this.Asunto.HeaderText = "Asunto";
            this.Asunto.Name = "Asunto";
            this.Asunto.ReadOnly = true;
            this.Asunto.Width = 200;
            // 
            // ID
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle17;
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // FechaDeApertura
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeApertura.DefaultCellStyle = dataGridViewCellStyle18;
            this.FechaDeApertura.HeaderText = "Fecha de Apertura";
            this.FechaDeApertura.Name = "FechaDeApertura";
            this.FechaDeApertura.ReadOnly = true;
            this.FechaDeApertura.Width = 120;
            // 
            // FechaDeCierre
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeCierre.DefaultCellStyle = dataGridViewCellStyle19;
            this.FechaDeCierre.HeaderText = "Fecha de Cierre";
            this.FechaDeCierre.Name = "FechaDeCierre";
            this.FechaDeCierre.ReadOnly = true;
            this.FechaDeCierre.Width = 120;
            // 
            // Estado
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.DefaultCellStyle = dataGridViewCellStyle20;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.button1.Location = new System.Drawing.Point(721, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 29);
            this.button1.TabIndex = 27;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmHistorialTicketsAgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 565);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lnkVolver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "frmHistorialTicketsAgente";
            this.Text = "frmHistorialTicketsAgente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkVolver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblPreguntasFrecuentes;
        private System.Windows.Forms.Label lblBibliotecasPUCP;
        private System.Windows.Forms.Label lblSistemaDeMesaDeAyuda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMiCuenta;
        private System.Windows.Forms.Label lblMisTickets;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button button1;
    }
}