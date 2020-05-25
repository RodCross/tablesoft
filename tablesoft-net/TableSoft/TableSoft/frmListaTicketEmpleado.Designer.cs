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
            this.pnl = new System.Windows.Forms.Panel();
            this.lblMiCuenta = new System.Windows.Forms.Label();
            this.lblMisTickets = new System.Windows.Forms.Label();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblPreguntasFrecuentes = new System.Windows.Forms.Label();
            this.lblBibliotecasPUCP = new System.Windows.Forms.Label();
            this.lblSistemaDeMesaDeAyuda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.lnkVolver = new System.Windows.Forms.LinkLabel();
            this.pnl.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(208)))));
            this.pnl.Controls.Add(this.lblMiCuenta);
            this.pnl.Controls.Add(this.lblMisTickets);
            this.pnl.Controls.Add(this.lblCerrarSesion);
            this.pnl.Location = new System.Drawing.Point(0, 97);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(872, 51);
            this.pnl.TabIndex = 3;
            // 
            // lblMiCuenta
            // 
            this.lblMiCuenta.AutoSize = true;
            this.lblMiCuenta.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiCuenta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMiCuenta.Location = new System.Drawing.Point(488, 15);
            this.lblMiCuenta.Name = "lblMiCuenta";
            this.lblMiCuenta.Size = new System.Drawing.Size(99, 23);
            this.lblMiCuenta.TabIndex = 6;
            this.lblMiCuenta.Text = "Mi Cuenta";
            // 
            // lblMisTickets
            // 
            this.lblMisTickets.AutoSize = true;
            this.lblMisTickets.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMisTickets.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMisTickets.Location = new System.Drawing.Point(610, 15);
            this.lblMisTickets.Name = "lblMisTickets";
            this.lblMisTickets.Size = new System.Drawing.Size(104, 23);
            this.lblMisTickets.TabIndex = 5;
            this.lblMisTickets.Text = "Mis Tickets";
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCerrarSesion.Location = new System.Drawing.Point(737, 15);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(126, 23);
            this.lblCerrarSesion.TabIndex = 4;
            this.lblCerrarSesion.Text = "Cerrar Sesion";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.pnlTitulo.Controls.Add(this.lblPreguntasFrecuentes);
            this.pnlTitulo.Controls.Add(this.lblBibliotecasPUCP);
            this.pnlTitulo.Controls.Add(this.lblSistemaDeMesaDeAyuda);
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(872, 100);
            this.pnlTitulo.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(29, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Historial de Tickets";
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
            this.FechaDeApertura,
            this.FechaDeCierre,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(47, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(783, 268);
            this.dataGridView1.TabIndex = 9;
            // 
            // Asunto
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Asunto.DefaultCellStyle = dataGridViewCellStyle1;
            this.Asunto.HeaderText = "Asunto";
            this.Asunto.Name = "Asunto";
            this.Asunto.ReadOnly = true;
            this.Asunto.Width = 240;
            // 
            // ID
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FechaDeApertura
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeApertura.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaDeApertura.HeaderText = "Fecha de Apertura";
            this.FechaDeApertura.Name = "FechaDeApertura";
            this.FechaDeApertura.ReadOnly = true;
            this.FechaDeApertura.Width = 150;
            // 
            // FechaDeCierre
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeCierre.DefaultCellStyle = dataGridViewCellStyle4;
            this.FechaDeCierre.HeaderText = "Fecha de Cierre";
            this.FechaDeCierre.Name = "FechaDeCierre";
            this.FechaDeCierre.ReadOnly = true;
            this.FechaDeCierre.Width = 150;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.button1.Location = new System.Drawing.Point(722, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lnkVolver
            // 
            this.lnkVolver.AutoSize = true;
            this.lnkVolver.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkVolver.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.lnkVolver.Location = new System.Drawing.Point(31, 165);
            this.lnkVolver.Name = "lnkVolver";
            this.lnkVolver.Size = new System.Drawing.Size(56, 16);
            this.lnkVolver.TabIndex = 21;
            this.lnkVolver.TabStop = true;
            this.lnkVolver.Text = "< Volver";
            // 
            // frmListaTicketEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 564);
            this.Controls.Add(this.lnkVolver);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.pnlTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaTicketEmpleado";
            this.Text = "frmListaTicketEmpleado";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lblMiCuenta;
        private System.Windows.Forms.Label lblMisTickets;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblPreguntasFrecuentes;
        private System.Windows.Forms.Label lblBibliotecasPUCP;
        private System.Windows.Forms.Label lblSistemaDeMesaDeAyuda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.LinkLabel lnkVolver;
    }
}