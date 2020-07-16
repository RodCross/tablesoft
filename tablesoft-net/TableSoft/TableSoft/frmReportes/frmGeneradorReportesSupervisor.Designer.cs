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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblReportes = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGenerarReporteCategoria = new System.Windows.Forms.Button();
            this.btnGenerarReporteUrgencia = new System.Windows.Forms.Button();
            this.btnGenerarReporteAgente = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblCategoria.Location = new System.Drawing.Point(116, 127);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(0, 26);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.pnlTitulo.Controls.Add(this.lblReportes);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(592, 86);
            this.pnlTitulo.TabIndex = 8;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.ForeColor = System.Drawing.Color.White;
            this.lblReportes.Location = new System.Drawing.Point(32, 27);
            this.lblReportes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(352, 36);
            this.lblReportes.TabIndex = 0;
            this.lblReportes.Text = "Generar reporte de tickets";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(24, 366);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(141, 41);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "< Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGenerarReporteCategoria
            // 
            this.btnGenerarReporteCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerarReporteCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarReporteCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporteCategoria.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporteCategoria.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporteCategoria.Location = new System.Drawing.Point(141, 122);
            this.btnGenerarReporteCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerarReporteCategoria.Name = "btnGenerarReporteCategoria";
            this.btnGenerarReporteCategoria.Size = new System.Drawing.Size(308, 47);
            this.btnGenerarReporteCategoria.TabIndex = 15;
            this.btnGenerarReporteCategoria.Text = "Generar reporte de categoría";
            this.btnGenerarReporteCategoria.UseVisualStyleBackColor = false;
            this.btnGenerarReporteCategoria.Click += new System.EventHandler(this.btnGenerarReporteCategoria_Click);
            // 
            // btnGenerarReporteUrgencia
            // 
            this.btnGenerarReporteUrgencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerarReporteUrgencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarReporteUrgencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporteUrgencia.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporteUrgencia.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporteUrgencia.Location = new System.Drawing.Point(141, 201);
            this.btnGenerarReporteUrgencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerarReporteUrgencia.Name = "btnGenerarReporteUrgencia";
            this.btnGenerarReporteUrgencia.Size = new System.Drawing.Size(308, 47);
            this.btnGenerarReporteUrgencia.TabIndex = 16;
            this.btnGenerarReporteUrgencia.Text = "Generar reporte de urgencia";
            this.btnGenerarReporteUrgencia.UseVisualStyleBackColor = false;
            this.btnGenerarReporteUrgencia.Click += new System.EventHandler(this.btnGenerarReporteUrgencia_Click);
            // 
            // btnGenerarReporteAgente
            // 
            this.btnGenerarReporteAgente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerarReporteAgente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarReporteAgente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporteAgente.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporteAgente.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporteAgente.Location = new System.Drawing.Point(141, 279);
            this.btnGenerarReporteAgente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerarReporteAgente.Name = "btnGenerarReporteAgente";
            this.btnGenerarReporteAgente.Size = new System.Drawing.Size(308, 47);
            this.btnGenerarReporteAgente.TabIndex = 17;
            this.btnGenerarReporteAgente.Text = "Generar reporte de agente";
            this.btnGenerarReporteAgente.UseVisualStyleBackColor = false;
            this.btnGenerarReporteAgente.Click += new System.EventHandler(this.btnGenerarReporteAgente_Click);
            // 
            // frmGeneradorReportesSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 436);
            this.Controls.Add(this.btnGenerarReporteAgente);
            this.Controls.Add(this.btnGenerarReporteUrgencia);
            this.Controls.Add(this.btnGenerarReporteCategoria);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGeneradorReportesSupervisor";
            this.Text = "Generar reporte de tickets";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.Button btnGenerarReporteCategoria;
        private System.Windows.Forms.Button btnGenerarReporteUrgencia;
        private System.Windows.Forms.Button btnGenerarReporteAgente;
    }
}