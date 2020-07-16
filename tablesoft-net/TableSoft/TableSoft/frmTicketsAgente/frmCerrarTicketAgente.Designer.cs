namespace TableSoft
{
    partial class frmCerrarTicketAgente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCerrarTicketAgente));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblActualizarEstado = new System.Windows.Forms.Label();
            this.lblIngresarComentario = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.rtfComentario = new System.Windows.Forms.RichTextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.pnlTitulo.Controls.Add(this.btnCancelar);
            this.pnlTitulo.Controls.Add(this.lblActualizarEstado);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(540, 57);
            this.pnlTitulo.TabIndex = 3;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(401, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 33);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblActualizarEstado
            // 
            this.lblActualizarEstado.AutoSize = true;
            this.lblActualizarEstado.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarEstado.ForeColor = System.Drawing.Color.White;
            this.lblActualizarEstado.Location = new System.Drawing.Point(19, 16);
            this.lblActualizarEstado.Name = "lblActualizarEstado";
            this.lblActualizarEstado.Size = new System.Drawing.Size(122, 25);
            this.lblActualizarEstado.TabIndex = 1;
            this.lblActualizarEstado.Text = "Cerrar ticket";
            // 
            // lblIngresarComentario
            // 
            this.lblIngresarComentario.AutoSize = true;
            this.lblIngresarComentario.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.lblIngresarComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblIngresarComentario.Location = new System.Drawing.Point(21, 115);
            this.lblIngresarComentario.Name = "lblIngresarComentario";
            this.lblIngresarComentario.Size = new System.Drawing.Size(320, 18);
            this.lblIngresarComentario.TabIndex = 4;
            this.lblIngresarComentario.Text = "Ingresa un comentario acerca de la resolución:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(380, 403);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(140, 40);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // rtfComentario
            // 
            this.rtfComentario.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfComentario.Location = new System.Drawing.Point(20, 143);
            this.rtfComentario.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.rtfComentario.Name = "rtfComentario";
            this.rtfComentario.Size = new System.Drawing.Size(500, 242);
            this.rtfComentario.TabIndex = 1;
            this.rtfComentario.Text = "";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblMensaje.Location = new System.Drawing.Point(21, 80);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(410, 18);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "¿Estás seguro de que deseas marcar el ticket como resuelto?";
            // 
            // frmCerrarTicketAgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 460);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.rtfComentario);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblIngresarComentario);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCerrarTicketAgente";
            this.Text = "Actualizar estado";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblIngresarComentario;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblActualizarEstado;
        private System.Windows.Forms.RichTextBox rtfComentario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMensaje;
    }
}