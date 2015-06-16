namespace Presentacion
{
    partial class Libros
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Libros));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.getTipoResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cargarLibrosResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvlibros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.getTipoResponseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargarLibrosResponseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlibros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lithos Pro Regular", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 75);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta de Libros";
            // 
            // label3
            // 
            this.label3.Image = global::Presentacion.Properties.Resources.home_icon;
            this.label3.Location = new System.Drawing.Point(600, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 64);
            this.label3.TabIndex = 6;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvlibros
            // 
            this.dgvlibros.AllowUserToAddRows = false;
            this.dgvlibros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvlibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvlibros.BackgroundColor = System.Drawing.Color.White;
            this.dgvlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlibros.Location = new System.Drawing.Point(25, 99);
            this.dgvlibros.Name = "dgvlibros";
            this.dgvlibros.ReadOnly = true;
            this.dgvlibros.Size = new System.Drawing.Size(644, 251);
            this.dgvlibros.TabIndex = 7;
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(697, 444);
            this.Controls.Add(this.dgvlibros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Libros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getTipoResponseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargarLibrosResponseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource cargarLibrosResponseBindingSource;
        private System.Windows.Forms.BindingSource getTipoResponseBindingSource;
        private System.Windows.Forms.DataGridView dgvlibros;
    }
}