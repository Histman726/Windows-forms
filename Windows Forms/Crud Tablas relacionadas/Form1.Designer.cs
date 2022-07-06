namespace Crud_Tablas_relacionadas
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sptcProductos)).BeginInit();
            this.sptcProductos.Panel1.SuspendLayout();
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
            // sptcProductos.Panel1
            // 
            this.sptcProductos.Panel1.Controls.Add(this.btnEliminar);
            this.sptcProductos.Panel1.Controls.Add(this.btnEditar);
            this.sptcProductos.Panel1.Controls.Add(this.btnNuevo);
            // 
            // sptcProductos.Panel2
            // 
            this.sptcProductos.Panel2.Controls.Add(this.dtgvProductos);
            this.sptcProductos.Size = new System.Drawing.Size(800, 450);
            this.sptcProductos.SplitterDistance = 100;
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
            this.dtgvProductos.Size = new System.Drawing.Size(800, 346);
            this.dtgvProductos.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(34, 36);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(137, 36);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(246, 36);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sptcProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sptcProductos.Panel1.ResumeLayout(false);
            this.sptcProductos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptcProductos)).EndInit();
            this.sptcProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sptcProductos;
        private System.Windows.Forms.DataGridView dtgvProductos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
    }
}

