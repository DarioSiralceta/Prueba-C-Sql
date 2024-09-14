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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDisco
            // 
            this.dataGridDisco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDisco.Location = new System.Drawing.Point(12, 44);
            this.dataGridDisco.MultiSelect = false;
            this.dataGridDisco.Name = "dataGridDisco";
            this.dataGridDisco.ReadOnly = true;
            this.dataGridDisco.RowHeadersWidth = 51;
            this.dataGridDisco.RowTemplate.Height = 24;
            this.dataGridDisco.Size = new System.Drawing.Size(750, 293);
            this.dataGridDisco.TabIndex = 0;
            this.dataGridDisco.SelectionChanged += new System.EventHandler(this.dataGridDisco_SelectionChanged);
            // 
            // pictureBoxDisco
            // 
            this.pictureBoxDisco.Location = new System.Drawing.Point(785, 44);
            this.pictureBoxDisco.Name = "pictureBoxDisco";
            this.pictureBoxDisco.Size = new System.Drawing.Size(305, 293);
            this.pictureBoxDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDisco.TabIndex = 1;
            this.pictureBoxDisco.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 363);
            this.Controls.Add(this.pictureBoxDisco);
            this.Controls.Add(this.dataGridDisco);
            this.MaximumSize = new System.Drawing.Size(1138, 410);
            this.MinimumSize = new System.Drawing.Size(1138, 410);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disco";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDisco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDisco;
        private System.Windows.Forms.PictureBox pictureBoxDisco;
    }
}

