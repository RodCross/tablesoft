namespace TableSoft
{
    partial class frmInfoTicketEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoTicketEmpleado));
            this.pnlMensajes = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblInfoTicket = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.lblUrg = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblTituloUrg = new System.Windows.Forms.Label();
            this.lblTituloCat = new System.Windows.Forms.Label();
            this.lblTituloId = new System.Windows.Forms.Label();
            this.lblTituloActFij = new System.Windows.Forms.Label();
            this.lblTituloFecIni = new System.Windows.Forms.Label();
            this.lblTituloBib = new System.Windows.Forms.Label();
            this.lblTituloFecCieEst = new System.Windows.Forms.Label();
            this.lblTituloEstado = new System.Windows.Forms.Label();
            this.lblActFij = new System.Windows.Forms.Label();
            this.lblBib = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFecCieEst = new System.Windows.Forms.Label();
            this.lblFecIni = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlComentario = new System.Windows.Forms.Panel();
            this.btnResponder = new System.Windows.Forms.Button();
            this.rtfRespuesta = new System.Windows.Forms.RichTextBox();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.pnlDatos.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.pnlComentario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMensajes
            // 
            this.pnlMensajes.AutoScroll = true;
            this.pnlMensajes.Location = new System.Drawing.Point(320, 121);
            this.pnlMensajes.Name = "pnlMensajes";
            this.pnlMensajes.Size = new System.Drawing.Size(732, 287);
            this.pnlMensajes.TabIndex = 4;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(933, 21);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(119, 33);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblInfoTicket
            // 
            this.lblInfoTicket.AutoSize = true;
            this.lblInfoTicket.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTicket.ForeColor = System.Drawing.Color.White;
            this.lblInfoTicket.Location = new System.Drawing.Point(30, 22);
            this.lblInfoTicket.Name = "lblInfoTicket";
            this.lblInfoTicket.Size = new System.Drawing.Size(230, 27);
            this.lblInfoTicket.TabIndex = 1;
            this.lblInfoTicket.Text = "Información del ticket";
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.lblUrg);
            this.pnlDatos.Controls.Add(this.lblCat);
            this.pnlDatos.Controls.Add(this.lblTituloUrg);
            this.pnlDatos.Controls.Add(this.lblTituloCat);
            this.pnlDatos.Controls.Add(this.lblTituloId);
            this.pnlDatos.Controls.Add(this.lblTituloActFij);
            this.pnlDatos.Controls.Add(this.lblTituloFecIni);
            this.pnlDatos.Controls.Add(this.lblTituloBib);
            this.pnlDatos.Controls.Add(this.lblTituloFecCieEst);
            this.pnlDatos.Controls.Add(this.lblTituloEstado);
            this.pnlDatos.Controls.Add(this.lblActFij);
            this.pnlDatos.Controls.Add(this.lblBib);
            this.pnlDatos.Controls.Add(this.lblEstado);
            this.pnlDatos.Controls.Add(this.lblFecCieEst);
            this.pnlDatos.Controls.Add(this.lblFecIni);
            this.pnlDatos.Controls.Add(this.lblId);
            this.pnlDatos.Location = new System.Drawing.Point(12, 76);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(302, 553);
            this.pnlDatos.TabIndex = 2;
            // 
            // lblUrg
            // 
            this.lblUrg.BackColor = System.Drawing.Color.Transparent;
            this.lblUrg.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblUrg.ForeColor = System.Drawing.Color.Black;
            this.lblUrg.Location = new System.Drawing.Point(21, 444);
            this.lblUrg.Name = "lblUrg";
            this.lblUrg.Size = new System.Drawing.Size(260, 23);
            this.lblUrg.TabIndex = 13;
            this.lblUrg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCat
            // 
            this.lblCat.BackColor = System.Drawing.Color.Transparent;
            this.lblCat.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCat.ForeColor = System.Drawing.Color.Black;
            this.lblCat.Location = new System.Drawing.Point(21, 380);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(260, 23);
            this.lblCat.TabIndex = 11;
            this.lblCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloUrg
            // 
            this.lblTituloUrg.AutoSize = true;
            this.lblTituloUrg.Font = new System.Drawing.Font("Microsoft PhagsPa", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblTituloUrg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblTituloUrg.Location = new System.Drawing.Point(20, 418);
            this.lblTituloUrg.Name = "lblTituloUrg";
            this.lblTituloUrg.Size = new System.Drawing.Size(81, 22);
            this.lblTituloUrg.TabIndex = 12;
            this.lblTituloUrg.Text = "Urgencia";
            // 
            // lblTituloCat
            // 
            this.lblTituloCat.AutoSize = true;
            this.lblTituloCat.Font = new System.Drawing.Font("Microsoft PhagsPa", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblTituloCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblTituloCat.Location = new System.Drawing.Point(20, 354);
            this.lblTituloCat.Name = "lblTituloCat";
            this.lblTituloCat.Size = new System.Drawing.Size(88, 22);
            this.lblTituloCat.TabIndex = 10;
            this.lblTituloCat.Text = "Categoría";
            // 
            // lblTituloId
            // 
            this.lblTituloId.AutoSize = true;
            this.lblTituloId.Font = new System.Drawing.Font("Microsoft PhagsPa", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblTituloId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblTituloId.Location = new System.Drawing.Point(20, 10);
            this.lblTituloId.Name = "lblTituloId";
            this.lblTituloId.Size = new System.Drawing.Size(109, 22);
            this.lblTituloId.TabIndex = 0;
            this.lblTituloId.Text = "ID del ticket";
            // 
            // lblTituloActFij
            // 
            this.lblTituloActFij.AutoSize = true;
            this.lblTituloActFij.Font = new System.Drawing.Font("Microsoft PhagsPa", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblTituloActFij.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblTituloActFij.Location = new System.Drawing.Point(20, 482);
            this.lblTituloActFij.Name = "lblTituloActFij";
            this.lblTituloActFij.Size = new System.Drawing.Size(93, 22);
            this.lblTituloActFij.TabIndex = 14;
            this.lblTituloActFij.Text = "Activo fijo";
            // 
            // lblTituloFecIni
            // 
            this.lblTituloFecIni.AutoSize = true;
            this.lblTituloFecIni.Font = new System.Drawing.Font("Microsoft PhagsPa", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblTituloFecIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblTituloFecIni.Location = new System.Drawing.Point(20, 74);
            this.lblTituloFecIni.Name = "lblTituloFecIni";
            this.lblTituloFecIni.Size = new System.Drawing.Size(128, 22);
            this.lblTituloFecIni.TabIndex = 2;
            this.lblTituloFecIni.Text = "Fecha de inicio";
            // 
            // lblTituloBib
            // 
            this.lblTituloBib.AutoSize = true;
            this.lblTituloBib.Font = new System.Drawing.Font("Microsoft PhagsPa", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblTituloBib.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblTituloBib.Location = new System.Drawing.Point(20, 266);
            this.lblTituloBib.Name = "lblTituloBib";
            this.lblTituloBib.Size = new System.Drawing.Size(90, 22);
            this.lblTituloBib.TabIndex = 8;
            this.lblTituloBib.Text = "Biblioteca";
            // 
            // lblTituloFecCieEst
            // 
            this.lblTituloFecCieEst.AutoSize = true;
            this.lblTituloFecCieEst.Font = new System.Drawing.Font("Microsoft PhagsPa", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblTituloFecCieEst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblTituloFecCieEst.Location = new System.Drawing.Point(20, 138);
            this.lblTituloFecCieEst.Name = "lblTituloFecCieEst";
            this.lblTituloFecCieEst.Size = new System.Drawing.Size(208, 22);
            this.lblTituloFecCieEst.TabIndex = 4;
            this.lblTituloFecCieEst.Text = "Fecha estimada de cierre";
            // 
            // lblTituloEstado
            // 
            this.lblTituloEstado.AutoSize = true;
            this.lblTituloEstado.Font = new System.Drawing.Font("Microsoft PhagsPa", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblTituloEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.lblTituloEstado.Location = new System.Drawing.Point(20, 202);
            this.lblTituloEstado.Name = "lblTituloEstado";
            this.lblTituloEstado.Size = new System.Drawing.Size(63, 22);
            this.lblTituloEstado.TabIndex = 6;
            this.lblTituloEstado.Text = "Estado";
            // 
            // lblActFij
            // 
            this.lblActFij.BackColor = System.Drawing.Color.Transparent;
            this.lblActFij.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblActFij.ForeColor = System.Drawing.Color.Black;
            this.lblActFij.Location = new System.Drawing.Point(21, 508);
            this.lblActFij.Name = "lblActFij";
            this.lblActFij.Size = new System.Drawing.Size(260, 23);
            this.lblActFij.TabIndex = 15;
            this.lblActFij.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBib
            // 
            this.lblBib.BackColor = System.Drawing.Color.Transparent;
            this.lblBib.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblBib.ForeColor = System.Drawing.Color.Black;
            this.lblBib.Location = new System.Drawing.Point(21, 292);
            this.lblBib.Name = "lblBib";
            this.lblBib.Size = new System.Drawing.Size(260, 47);
            this.lblBib.TabIndex = 9;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(21, 228);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(260, 23);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFecCieEst
            // 
            this.lblFecCieEst.BackColor = System.Drawing.Color.Transparent;
            this.lblFecCieEst.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblFecCieEst.ForeColor = System.Drawing.Color.Black;
            this.lblFecCieEst.Location = new System.Drawing.Point(21, 164);
            this.lblFecCieEst.Name = "lblFecCieEst";
            this.lblFecCieEst.Size = new System.Drawing.Size(260, 23);
            this.lblFecCieEst.TabIndex = 5;
            this.lblFecCieEst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFecIni
            // 
            this.lblFecIni.BackColor = System.Drawing.Color.Transparent;
            this.lblFecIni.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblFecIni.ForeColor = System.Drawing.Color.Black;
            this.lblFecIni.Location = new System.Drawing.Point(21, 100);
            this.lblFecIni.Name = "lblFecIni";
            this.lblFecIni.Size = new System.Drawing.Size(260, 23);
            this.lblFecIni.TabIndex = 3;
            this.lblFecIni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(21, 36);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(260, 23);
            this.lblId.TabIndex = 1;
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(115)))));
            this.pnlTitulo.Controls.Add(this.btnVolver);
            this.pnlTitulo.Controls.Add(this.lblInfoTicket);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1064, 70);
            this.pnlTitulo.TabIndex = 1;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // pnlComentario
            // 
            this.pnlComentario.Controls.Add(this.btnResponder);
            this.pnlComentario.Controls.Add(this.rtfRespuesta);
            this.pnlComentario.Location = new System.Drawing.Point(320, 414);
            this.pnlComentario.Name = "pnlComentario";
            this.pnlComentario.Size = new System.Drawing.Size(732, 215);
            this.pnlComentario.TabIndex = 0;
            // 
            // btnResponder
            // 
            this.btnResponder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(208)))));
            this.btnResponder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResponder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponder.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponder.ForeColor = System.Drawing.Color.White;
            this.btnResponder.Location = new System.Drawing.Point(230, 154);
            this.btnResponder.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(252, 45);
            this.btnResponder.TabIndex = 1;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = false;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // rtfRespuesta
            // 
            this.rtfRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfRespuesta.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfRespuesta.Location = new System.Drawing.Point(24, 24);
            this.rtfRespuesta.Name = "rtfRespuesta";
            this.rtfRespuesta.Size = new System.Drawing.Size(663, 112);
            this.rtfRespuesta.TabIndex = 0;
            this.rtfRespuesta.Text = "";
            // 
            // lblAsunto
            // 
            this.lblAsunto.BackColor = System.Drawing.Color.Transparent;
            this.lblAsunto.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAsunto.ForeColor = System.Drawing.Color.Black;
            this.lblAsunto.Location = new System.Drawing.Point(339, 78);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(668, 37);
            this.lblAsunto.TabIndex = 3;
            this.lblAsunto.Text = "Asunto del ticket";
            this.lblAsunto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picRefresh
            // 
            this.picRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefresh.Image = global::TableSoft.Properties.Resources.refresh_button_png_1;
            this.picRefresh.Location = new System.Drawing.Point(1012, 76);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(40, 39);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRefresh.TabIndex = 14;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // frmInfoTicketEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 640);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.lblAsunto);
            this.Controls.Add(this.pnlComentario);
            this.Controls.Add(this.pnlMensajes);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInfoTicketEmpleado";
            this.Text = "Información del ticket";
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlComentario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMensajes;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblInfoTicket;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblFecCieEst;
        private System.Windows.Forms.Label lblFecIni;
        private System.Windows.Forms.Label lblActFij;
        private System.Windows.Forms.Label lblBib;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTituloUrg;
        private System.Windows.Forms.Label lblTituloCat;
        private System.Windows.Forms.Label lblTituloId;
        private System.Windows.Forms.Label lblTituloActFij;
        private System.Windows.Forms.Label lblTituloFecIni;
        private System.Windows.Forms.Label lblTituloBib;
        private System.Windows.Forms.Label lblTituloFecCieEst;
        private System.Windows.Forms.Label lblTituloEstado;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblUrg;
        private System.Windows.Forms.Panel pnlComentario;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.RichTextBox rtfRespuesta;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.PictureBox picRefresh;
    }
}