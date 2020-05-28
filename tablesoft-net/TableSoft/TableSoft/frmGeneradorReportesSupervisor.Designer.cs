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
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.chkPorcentajeDemRes = new System.Windows.Forms.CheckBox();
            this.chkTicketsEscalados = new System.Windows.Forms.CheckBox();
            this.chkTicketsDemorados = new System.Windows.Forms.CheckBox();
            this.chkTicketsResueltos = new System.Windows.Forms.CheckBox();
            this.lblUrgencia = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblAgente = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblReportes = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(562, 202);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(192, 20);
            this.dtpFechaFin.TabIndex = 33;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(166, 201);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(192, 20);
            this.dtpFechaInicio.TabIndex = 32;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblFechaFin.Location = new System.Drawing.Point(437, 201);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(96, 21);
            this.lblFechaFin.TabIndex = 31;
            this.lblFechaFin.Text = "Fecha de fin:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblFechaInicio.Location = new System.Drawing.Point(21, 201);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(115, 21);
            this.lblFechaInicio.TabIndex = 30;
            this.lblFechaInicio.Text = "Fecha de inicio:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(427, 426);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 33);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Generar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(166, 165);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(192, 21);
            this.comboBox3.TabIndex = 28;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(166, 132);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(192, 21);
            this.comboBox2.TabIndex = 27;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.chkPorcentajeDemRes);
            this.groupBox1.Controls.Add(this.chkTicketsEscalados);
            this.groupBox1.Controls.Add(this.chkTicketsDemorados);
            this.groupBox1.Controls.Add(this.chkTicketsResueltos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.groupBox1.Location = new System.Drawing.Point(25, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 158);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Indicadores:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(422, 76);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(267, 21);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "Porcentaje de tickets escalados/resueltos";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // chkPorcentajeDemRes
            // 
            this.chkPorcentajeDemRes.AutoSize = true;
            this.chkPorcentajeDemRes.Location = new System.Drawing.Point(422, 39);
            this.chkPorcentajeDemRes.Name = "chkPorcentajeDemRes";
            this.chkPorcentajeDemRes.Size = new System.Drawing.Size(277, 21);
            this.chkPorcentajeDemRes.TabIndex = 18;
            this.chkPorcentajeDemRes.Text = "Porcentaje de tickets demorados/resueltos";
            this.chkPorcentajeDemRes.UseVisualStyleBackColor = true;
            // 
            // chkTicketsEscalados
            // 
            this.chkTicketsEscalados.AutoSize = true;
            this.chkTicketsEscalados.Location = new System.Drawing.Point(36, 113);
            this.chkTicketsEscalados.Name = "chkTicketsEscalados";
            this.chkTicketsEscalados.Size = new System.Drawing.Size(200, 21);
            this.chkTicketsEscalados.TabIndex = 2;
            this.chkTicketsEscalados.Text = "Cantidad de tickets escalados";
            this.chkTicketsEscalados.UseVisualStyleBackColor = true;
            // 
            // chkTicketsDemorados
            // 
            this.chkTicketsDemorados.AutoSize = true;
            this.chkTicketsDemorados.Location = new System.Drawing.Point(36, 76);
            this.chkTicketsDemorados.Name = "chkTicketsDemorados";
            this.chkTicketsDemorados.Size = new System.Drawing.Size(210, 21);
            this.chkTicketsDemorados.TabIndex = 1;
            this.chkTicketsDemorados.Text = "Cantidad de tickets demorados";
            this.chkTicketsDemorados.UseVisualStyleBackColor = true;
            // 
            // chkTicketsResueltos
            // 
            this.chkTicketsResueltos.AutoSize = true;
            this.chkTicketsResueltos.Location = new System.Drawing.Point(36, 39);
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
            this.lblUrgencia.Location = new System.Drawing.Point(61, 132);
            this.lblUrgencia.Name = "lblUrgencia";
            this.lblUrgencia.Size = new System.Drawing.Size(75, 21);
            this.lblUrgencia.TabIndex = 24;
            this.lblUrgencia.Text = "Urgencia:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblCategoria.Location = new System.Drawing.Point(56, 97);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(80, 21);
            this.lblCategoria.TabIndex = 23;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblAgente
            // 
            this.lblAgente.AutoSize = true;
            this.lblAgente.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblAgente.Location = new System.Drawing.Point(74, 165);
            this.lblAgente.Name = "lblAgente";
            this.lblAgente.Size = new System.Drawing.Size(62, 21);
            this.lblAgente.TabIndex = 22;
            this.lblAgente.Text = "Agente:";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.pnlTitulo.Controls.Add(this.lblReportes);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(827, 70);
            this.pnlTitulo.TabIndex = 21;
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblReportes.ForeColor = System.Drawing.Color.White;
            this.lblReportes.Location = new System.Drawing.Point(30, 23);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(194, 27);
            this.lblReportes.TabIndex = 0;
            this.lblReportes.Text = "Reporte de Tickets";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(297, 426);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(106, 33);
            this.btnVolver.TabIndex = 34;
            this.btnVolver.Text = "< Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // frmGeneradorReportesSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 471);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblUrgencia);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblAgente);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGeneradorReportesSupervisor";
            this.Text = "frmGeneradorReportesSupervisor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox chkPorcentajeDemRes;
        private System.Windows.Forms.CheckBox chkTicketsEscalados;
        private System.Windows.Forms.CheckBox chkTicketsDemorados;
        private System.Windows.Forms.CheckBox chkTicketsResueltos;
        private System.Windows.Forms.Label lblUrgencia;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblAgente;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.Button btnVolver;
    }
}