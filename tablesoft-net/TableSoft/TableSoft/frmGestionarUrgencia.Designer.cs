namespace TableSoft
{
    partial class frmGestionarUrgencia
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblDatosUrgencia = new System.Windows.Forms.Label();
            this.gpbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.txtPlazoMaximo = new System.Windows.Forms.TextBox();
            this.lblPlazoMaximo = new System.Windows.Forms.Label();
            this.lblIDUrgencia = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIDUrgencia = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            this.gpbDatosGenerales.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.pnlTitulo.Controls.Add(this.lblDatosUrgencia);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(768, 70);
            this.pnlTitulo.TabIndex = 9;
            // 
            // lblDatosUrgencia
            // 
            this.lblDatosUrgencia.AutoSize = true;
            this.lblDatosUrgencia.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDatosUrgencia.ForeColor = System.Drawing.Color.White;
            this.lblDatosUrgencia.Location = new System.Drawing.Point(30, 23);
            this.lblDatosUrgencia.Name = "lblDatosUrgencia";
            this.lblDatosUrgencia.Size = new System.Drawing.Size(161, 27);
            this.lblDatosUrgencia.TabIndex = 0;
            this.lblDatosUrgencia.Text = "Datos Urgencia";
            // 
            // gpbDatosGenerales
            // 
            this.gpbDatosGenerales.Controls.Add(this.txtPlazoMaximo);
            this.gpbDatosGenerales.Controls.Add(this.lblPlazoMaximo);
            this.gpbDatosGenerales.Controls.Add(this.lblIDUrgencia);
            this.gpbDatosGenerales.Controls.Add(this.txtNombre);
            this.gpbDatosGenerales.Controls.Add(this.txtIDUrgencia);
            this.gpbDatosGenerales.Controls.Add(this.lblNombre);
            this.gpbDatosGenerales.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatosGenerales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.gpbDatosGenerales.Location = new System.Drawing.Point(35, 103);
            this.gpbDatosGenerales.Name = "gpbDatosGenerales";
            this.gpbDatosGenerales.Size = new System.Drawing.Size(694, 164);
            this.gpbDatosGenerales.TabIndex = 8;
            this.gpbDatosGenerales.TabStop = false;
            this.gpbDatosGenerales.Text = "Datos Generales";
            // 
            // txtPlazoMaximo
            // 
            this.txtPlazoMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlazoMaximo.Location = new System.Drawing.Point(161, 114);
            this.txtPlazoMaximo.Name = "txtPlazoMaximo";
            this.txtPlazoMaximo.Size = new System.Drawing.Size(381, 26);
            this.txtPlazoMaximo.TabIndex = 6;
            // 
            // lblPlazoMaximo
            // 
            this.lblPlazoMaximo.AutoSize = true;
            this.lblPlazoMaximo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblPlazoMaximo.Location = new System.Drawing.Point(37, 116);
            this.lblPlazoMaximo.Name = "lblPlazoMaximo";
            this.lblPlazoMaximo.Size = new System.Drawing.Size(110, 21);
            this.lblPlazoMaximo.TabIndex = 5;
            this.lblPlazoMaximo.Text = "Plazo Maximo:";
            // 
            // lblIDUrgencia
            // 
            this.lblIDUrgencia.AutoSize = true;
            this.lblIDUrgencia.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDUrgencia.Location = new System.Drawing.Point(53, 28);
            this.lblIDUrgencia.Name = "lblIDUrgencia";
            this.lblIDUrgencia.Size = new System.Drawing.Size(94, 21);
            this.lblIDUrgencia.TabIndex = 1;
            this.lblIDUrgencia.Text = "ID Urgencia:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(161, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(188, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // txtIDUrgencia
            // 
            this.txtIDUrgencia.Enabled = false;
            this.txtIDUrgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDUrgencia.Location = new System.Drawing.Point(161, 26);
            this.txtIDUrgencia.Name = "txtIDUrgencia";
            this.txtIDUrgencia.ReadOnly = true;
            this.txtIDUrgencia.Size = new System.Drawing.Size(67, 26);
            this.txtIDUrgencia.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.lblNombre.Location = new System.Drawing.Point(76, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 21);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(303, 284);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(102, 33);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(411, 284);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(102, 33);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(519, 284);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 33);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(627, 284);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 33);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmGestionarUrgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 334);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.gpbDatosGenerales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionarUrgencia";
            this.Text = "frmGestionarUrgencia";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.gpbDatosGenerales.ResumeLayout(false);
            this.gpbDatosGenerales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblDatosUrgencia;
        private System.Windows.Forms.GroupBox gpbDatosGenerales;
        private System.Windows.Forms.TextBox txtPlazoMaximo;
        private System.Windows.Forms.Label lblPlazoMaximo;
        private System.Windows.Forms.Label lblIDUrgencia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIDUrgencia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}