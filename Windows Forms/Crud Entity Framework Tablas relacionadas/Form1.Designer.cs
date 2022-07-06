namespace Crud_Entity_Framework_Tablas_relacionadas
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
            this.sptcProductos = new System.Windows.Forms.SplitContainer();
            this.dtgvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sptcProductos)).BeginInit();
            this.sptcProductos.Panel2.SuspendLayout();
            this.sptcProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // sptcProductos
            // 
            this.sptcProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptcProductos.Location = new System.Drawing.Point(0, 0);
            this.sptcProductos.Name = "sptcProductos";
            this.sptcProductos.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sptcProductos.Panel2
            // 
            this.sptcProductos.Panel2.Controls.Add(this.dtgvProductos);
            this.sptcProductos.Size = new System.Drawing.Size(684, 425);
            this.sptcProductos.SplitterDistance = 90;
            this.sptcProductos.TabIndex = 0;
            // 
            // dtgvProductos
            // 
            this.dtgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProductos.Location = new System.Drawing.Point(0, 0);
            this.dtgvProductos.MultiSelect = false;
            this.dtgvProductos.Name = "dtgvProductos";
            this.dtgvProductos.ReadOnly = true;
            this.dtgvProductos.RowHeadersWidth = 51;
            this.dtgvProductos.RowTemplate.Height = 24;
            this.dtgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProductos.Size = new System.Drawing.Size(684, 331);
            this.dtgvProductos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 425);
            this.Controls.Add(this.sptcProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sptcProductos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptcProductos)).EndInit();
            this.sptcProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sptcProductos;
        private System.Windows.Forms.DataGridView dtgvProductos;
    }
}

