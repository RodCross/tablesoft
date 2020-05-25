namespace TableSoft
{
    partial class frmAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyuda));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblPreguntasFrecuentes = new System.Windows.Forms.Label();
            this.lblBibliotecasPUCP = new System.Windows.Forms.Label();
            this.lblSistemaDeMesaDeAyuda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlTitulo.TabIndex = 1;
            // 
            // lblPreguntasFrecuentes
            // 
            this.lblPreguntasFrecuentes.AutoSize = true;
            this.lblPreguntasFrecuentes.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreguntasFrecuentes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPreguntasFrecuentes.Location = new System.Drawing.Point(779, 64);
            this.lblPreguntasFrecuentes.Name = "lblPreguntasFrecuentes";
            this.lblPreguntasFrecuentes.Size = new System.Drawing.Size(83, 16);
            this.lblPreguntasFrecuentes.TabIndex = 3;
            this.lblPreguntasFrecuentes.Text = "Iniciar Sesión";
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
            this.label1.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(13, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ayuda";
            // 
            // frmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAyuda";
            this.Text = "frmAyuda";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblPreguntasFrecuentes;
        private System.Windows.Forms.Label lblBibliotecasPUCP;
        private System.Windows.Forms.Label lblSistemaDeMesaDeAyuda;
        private System.Windows.Forms.Label label1;
    }
}