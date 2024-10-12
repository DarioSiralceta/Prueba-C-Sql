namespace ProyectoDiscos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridDisco = new System.Windows.Forms.DataGridView();
            this.pictureBoxDisco = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btneliminarFisico = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblfiltroAvanzado = new System.Windows.Forms.Label();
            this.txtfiltroAvanzado = new System.Windows.Forms.TextBox();
            this.btnRestablecer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDisco
            // 
            this.dataGridDisco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDisco.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridDisco.Location = new System.Drawing.Point(12, 75);
            this.dataGridDisco.Name = "dataGridDisco";
            this.dataGridDisco.ReadOnly = true;
            this.dataGridDisco.RowHeadersWidth = 51;
            this.dataGridDisco.RowTemplate.Height = 24;
            this.dataGridDisco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDisco.Size = new System.Drawing.Size(750, 293);
            this.dataGridDisco.TabIndex = 0;
            this.dataGridDisco.SelectionChanged += new System.EventHandler(this.dataGridDisco_SelectionChanged);
            // 
            // pictureBoxDisco
            // 
            this.pictureBoxDisco.Location = new System.Drawing.Point(782, 75);
            this.pictureBoxDisco.Name = "pictureBoxDisco";
            this.pictureBoxDisco.Size = new System.Drawing.Size(305, 293);
            this.pictureBoxDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDisco.TabIndex = 1;
            this.pictureBoxDisco.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(30, 389);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(230, 389);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btneliminarFisico
            // 
            this.btneliminarFisico.Location = new System.Drawing.Point(456, 389);
            this.btneliminarFisico.Name = "btneliminarFisico";
            this.btneliminarFisico.Size = new System.Drawing.Size(75, 23);
            this.btneliminarFisico.TabIndex = 4;
            this.btneliminarFisico.Text = "Eliminar Fisico";
            this.btneliminarFisico.UseVisualStyleBackColor = true;
            this.btneliminarFisico.Click += new System.EventHandler(this.btneliminarFisico_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(27, 52);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(84, 16);
            this.lblFiltro.TabIndex = 5;
            this.lblFiltro.Text = "Filtro Rapido";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(144, 49);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(161, 22);
            this.txtFiltro.TabIndex = 6;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(707, 459);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(106, 23);
            this.btnFiltro.TabIndex = 7;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(9, 462);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(51, 16);
            this.lblCampo.TabIndex = 8;
            this.lblCampo.Text = "Campo";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(93, 458);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(106, 24);
            this.cboCampo.TabIndex = 9;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(226, 462);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(49, 16);
            this.lblCriterio.TabIndex = 10;
            this.lblCriterio.Text = "Criterio";
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(308, 458);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(106, 24);
            this.cboCriterio.TabIndex = 11;
            // 
            // lblfiltroAvanzado
            // 
            this.lblfiltroAvanzado.AutoSize = true;
            this.lblfiltroAvanzado.Location = new System.Drawing.Point(441, 462);
            this.lblfiltroAvanzado.Name = "lblfiltroAvanzado";
            this.lblfiltroAvanzado.Size = new System.Drawing.Size(100, 16);
            this.lblfiltroAvanzado.TabIndex = 12;
            this.lblfiltroAvanzado.Text = "Filtro Avanzado";
            // 
            // txtfiltroAvanzado
            // 
            this.txtfiltroAvanzado.Location = new System.Drawing.Point(574, 459);
            this.txtfiltroAvanzado.Name = "txtfiltroAvanzado";
            this.txtfiltroAvanzado.Size = new System.Drawing.Size(106, 22);
            this.txtfiltroAvanzado.TabIndex = 13;
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Location = new System.Drawing.Point(885, 459);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(106, 23);
            this.btnRestablecer.TabIndex = 14;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 509);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.txtfiltroAvanzado);
            this.Controls.Add(this.lblfiltroAvanzado);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btneliminarFisico);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pictureBoxDisco);
            this.Controls.Add(this.dataGridDisco);
            this.MinimumSize = new System.Drawing.Size(1138, 410);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disco";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDisco;
        private System.Windows.Forms.PictureBox pictureBoxDisco;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btneliminarFisico;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lblfiltroAvanzado;
        private System.Windows.Forms.TextBox txtfiltroAvanzado;
        private System.Windows.Forms.Button btnRestablecer;
    }
}

