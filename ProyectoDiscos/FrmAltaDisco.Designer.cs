namespace ProyectoDiscos
{
    partial class FrmAltaDisco
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblTipoEdicion = new System.Windows.Forms.Label();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.cboTipoEdicion = new System.Windows.Forms.ComboBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.pictureBoxDisco = new System.Windows.Forms.PictureBox();
            this.btnagregarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(64, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(103, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo del Album";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(30, 118);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(143, 16);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha de Lanzamiento";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(26, 175);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(147, 16);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad de Canciones";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(200, 46);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 22);
            this.txtTitulo.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(200, 112);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(200, 175);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(67, 406);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(127, 292);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(40, 16);
            this.lblEstilo.TabIndex = 8;
            this.lblEstilo.Text = "Estilo";
            // 
            // lblTipoEdicion
            // 
            this.lblTipoEdicion.AutoSize = true;
            this.lblTipoEdicion.Location = new System.Drawing.Point(65, 349);
            this.lblTipoEdicion.Name = "lblTipoEdicion";
            this.lblTipoEdicion.Size = new System.Drawing.Size(102, 16);
            this.lblTipoEdicion.TabIndex = 9;
            this.lblTipoEdicion.Text = "Tipo de Edicion";
            // 
            // cboEstilo
            // 
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(200, 284);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(121, 24);
            this.cboEstilo.TabIndex = 5;
            // 
            // cboTipoEdicion
            // 
            this.cboTipoEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEdicion.FormattingEnabled = true;
            this.cboTipoEdicion.Location = new System.Drawing.Point(200, 341);
            this.cboTipoEdicion.Name = "cboTipoEdicion";
            this.cboTipoEdicion.Size = new System.Drawing.Size(121, 24);
            this.cboTipoEdicion.TabIndex = 6;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(89, 239);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(72, 16);
            this.lblUrlImagen.TabIndex = 12;
            this.lblUrlImagen.Text = "Url Imagen";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(200, 236);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(100, 22);
            this.txtUrlImagen.TabIndex = 4;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // pictureBoxDisco
            // 
            this.pictureBoxDisco.Location = new System.Drawing.Point(481, 52);
            this.pictureBoxDisco.Name = "pictureBoxDisco";
            this.pictureBoxDisco.Size = new System.Drawing.Size(324, 313);
            this.pictureBoxDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDisco.TabIndex = 14;
            this.pictureBoxDisco.TabStop = false;
            // 
            // btnagregarImagen
            // 
            this.btnagregarImagen.Location = new System.Drawing.Point(317, 226);
            this.btnagregarImagen.Name = "btnagregarImagen";
            this.btnagregarImagen.Size = new System.Drawing.Size(135, 32);
            this.btnagregarImagen.TabIndex = 15;
            this.btnagregarImagen.Text = "Agregar Imagen";
            this.btnagregarImagen.UseVisualStyleBackColor = true;
            this.btnagregarImagen.Click += new System.EventHandler(this.btnagregarImagen_Click);
            // 
            // FrmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 455);
            this.Controls.Add(this.btnagregarImagen);
            this.Controls.Add(this.pictureBoxDisco);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.cboTipoEdicion);
            this.Controls.Add(this.cboEstilo);
            this.Controls.Add(this.lblTipoEdicion);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmAltaDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Disco";
            this.Load += new System.EventHandler(this.FrmAltaDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblTipoEdicion;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.ComboBox cboTipoEdicion;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.PictureBox pictureBoxDisco;
        private System.Windows.Forms.Button btnagregarImagen;
    }
}