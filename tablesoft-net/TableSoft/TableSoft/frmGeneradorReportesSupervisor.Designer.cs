namespace TableSoft
{
    partial class frmGeneradorReportesSupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneradorReportesSupervisor));
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cboAgente = new System.Windows.Forms.ComboBox();
            this.cboUrgencia = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.grpIndicadores = new System.Windows.Forms.GroupBox();
            this.chkPorcentajeEscRes = new System.Windows.Forms.CheckBox();
            this.chkPorcentajeDemRes = new System.Windows.Forms.CheckBox();
            this.chkTicketsEscalados = new System.Windows.Forms.CheckBox();
            this.chkTicketsDemorados = new System.Windows.Forms.CheckBox();
            this.chkTicketsResueltos = new System.Windows.Forms.CheckBox();
            this.lblUrgencia = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblAgente = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblReportes = new System.Windows.Forms.Label();
            this.grpIndicadores.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(185, 239);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(192, 24);
            this.dtpFechaFin.TabIndex = 4;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(185, 205);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(192, 24);
            this.dtpFechaInicio.TabIndex = 3;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblFechaFin.Location = new System.Drawing.Point(71, 239);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(93, 21);
            this.lblFechaFin.TabIndex = 13;
            this.lblFechaFin.Text = "Fecha de fin";
            this.lblFechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblFechaInicio.Location = new System.Drawing.Point(52, 205);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(112, 21);
            this.lblFechaInicio.TabIndex = 12;
            this.lblFechaInicio.Text = "Fecha de inicio";
            this.lblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(242, 571);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(106, 33);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cboAgente
            // 
            this.cboAgente.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAgente.FormattingEnabled = true;
            this.cboAgente.Location = new System.Drawing.Point(185, 171);
            this.cboAgente.Name = "cboAgente";
            this.cboAgente.Size = new System.Drawing.Size(192, 25);
            this.cboAgente.TabIndex = 2;
            // 
            // cboUrgencia
            // 
            this.cboUrgencia.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUrgencia.FormattingEnabled = true;
            this.cboUrgencia.Location = new System.Drawing.Point(185, 137);
            this.cboUrgencia.Name = "cboUrgencia";
            this.cboUrgencia.Size = new System.Drawing.Size(192, 25);
            this.cboUrgencia.TabIndex = 1;
            // 
            // cboCategoria
            // 
            this.cboCategoria.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(185, 103);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(192, 25);
            this.cboCategoria.TabIndex = 0;
            // 
            // grpIndicadores
            // 
            this.grpIndicadores.Controls.Add(this.chkPorcentajeEscRes);
            this.grpIndicadores.Controls.Add(this.chkPorcentajeDemRes);
            this.grpIndicadores.Controls.Add(this.chkTicketsEscalados);
            this.grpIndicadores.Controls.Add(this.chkTicketsDemorados);
            this.grpIndicadores.Controls.Add(this.chkTicketsResueltos);
            this.grpIndicadores.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIndicadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.grpIndicadores.Location = new System.Drawing.Point(38, 311);
            this.grpIndicadores.Name = "grpIndicadores";
            this.grpIndicadores.Size = new System.Drawing.Size(369, 223);
            this.grpIndicadores.TabIndex = 5;
            this.grpIndicadores.TabStop = false;
            this.grpIndicadores.Text = "Indicadores";
            // 
            // chkPorcentajeEscRes
            // 
            this.chkPorcentajeEscRes.AutoSize = true;
            this.chkPorcentajeEscRes.Location = new System.Drawing.Point(28, 179);
            this.chkPorcentajeEscRes.Name = "chkPorcentajeEscRes";
            this.chkPorcentajeEscRes.Size = new System.Drawing.Size(267, 21);
            this.chkPorcentajeEscRes.TabIndex = 4;
            this.chkPorcentajeEscRes.Text = "Porcentaje de tickets escalados/resueltos";
            this.chkPorcentajeEscRes.UseVisualStyleBackColor = true;
            // 
            // chkPorcentajeDemRes
            // 
            this.chkPorcentajeDemRes.AutoSize = true;
            this.chkPorcentajeDemRes.Location = new System.Drawing.Point(28, 143);
            this.chkPorcentajeDemRes.Name = "chkPorcentajeDemRes";
            this.chkPorcentajeDemRes.Size = new System.Drawing.Size(277, 21);
            this.chkPorcentajeDemRes.TabIndex = 3;
            this.chkPorcentajeDemRes.Text = "Porcentaje de tickets demorados/resueltos";
            this.chkPorcentajeDemRes.UseVisualStyleBackColor = true;
            // 
            // chkTicketsEscalados
            // 
            this.chkTicketsEscalados.AutoSize = true;
            this.chkTicketsEscalados.Location = new System.Drawing.Point(28, 107);
            this.chkTicketsEscalados.Name = "chkTicketsEscalados";
            this.chkTicketsEscalados.Size = new System.Drawing.Size(200, 21);
            this.chkTicketsEscalados.TabIndex = 2;
            this.chkTicketsEscalados.Text = "Cantidad de tickets escalados";
            this.chkTicketsEscalados.UseVisualStyleBackColor = true;
            // 
            // chkTicketsDemorados
            // 
            this.chkTicketsDemorados.AutoSize = true;
            this.chkTicketsDemorados.Location = new System.Drawing.Point(28, 71);
            this.chkTicketsDemorados.Name = "chkTicketsDemorados";
            this.chkTicketsDemorados.Size = new System.Drawing.Size(210, 21);
            this.chkTicketsDemorados.TabIndex = 1;
            this.chkTicketsDemorados.Text = "Cantidad de tickets demorados";
            this.chkTicketsDemorados.UseVisualStyleBackColor = true;
            // 
            // chkTicketsResueltos
            // 
            this.chkTicketsResueltos.AutoSize = true;
            this.chkTicketsResueltos.Location = new System.Drawing.Point(28, 35);
            this.chkTicketsResueltos.Name = "chkTicketsResueltos";
            this.chkTicketsResueltos.Size = new System.Drawing.Size(195, 21);
            this.chkTicketsResueltos.TabIndex = 0;
            this.chkTicketsResueltos.Text = "Cantidad de tickets resueltos";
            this.chkTicketsResueltos.UseVisualStyleBackColor = true;
            // 
            // lblUrgencia
            // 
            this.lblUrgencia.AutoSize = true;
            this.lblUrgencia.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrgencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblUrgencia.Location = new System.Drawing.Point(92, 137);
            this.lblUrgencia.Name = "lblUrgencia";
            this.lblUrgencia.Size = new System.Drawing.Size(72, 21);
            this.lblUrgencia.TabIndex = 10;
            this.lblUrgencia.Text = "Urgencia";
            this.lblUrgencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblCategoria.Location = new System.Drawing.Point(87, 103);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(77, 21);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoría";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAgente
            // 
            this.lblAgente.AutoSize = true;
            this.lblAgente.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblAgente.Location = new System.Drawing.Point(105, 171);
            this.lblAgente.Name = "lblAgente";
            this.lblAgente.Size = new System.Drawing.Size(59, 21);
            this.lblAgente.TabIndex = 11;
            this.lblAgente.Text = "Agente";
            this.lblAgente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.pnlTitulo.Controls.Add(this.lblReportes);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(444, 70);
            this.pnlTitulo.TabIndex = 8;
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
            this.btnVolver.Location = new System.Drawing.Point(97, 571);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(106, 33);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "< Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.ForeColor = System.Drawing.Color.White;
            this.lblReportes.Location = new System.Drawing.Point(24, 22);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(267, 27);
            this.lblReportes.TabIndex = 0;
            this.lblReportes.Text = "Generar reporte de tickets";
            // 
            // frmGeneradorReportesSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 640);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cboAgente);
            this.Controls.Add(this.cboUrgencia);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.grpIndicadores);
            this.Controls.Add(this.lblUrgencia);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblAgente);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGeneradorReportesSupervisor";
            this.Text = "frmGeneradorReportesSupervisor";
            this.grpIndicadores.ResumeLayout(false);
            this.grpIndicadores.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cboAgente;
        private System.Windows.Forms.ComboBox cboUrgencia;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.GroupBox grpIndicadores;
        private System.Windows.Forms.CheckBox chkPorcentajeEscRes;
        private System.Windows.Forms.CheckBox chkPorcentajeDemRes;
        private System.Windows.Forms.CheckBox chkTicketsEscalados;
        private System.Windows.Forms.CheckBox chkTicketsDemorados;
        private System.Windows.Forms.CheckBox chkTicketsResueltos;
        private System.Windows.Forms.Label lblUrgencia;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblAgente;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblReportes;
    }
}