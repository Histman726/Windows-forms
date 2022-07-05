namespace CRUD_Entity_Framework__DateTime
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
            this.sptcPersonas = new System.Windows.Forms.SplitContainer();
            this.dtgvPersonas = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sptcPersonas)).BeginInit();
            this.sptcPersonas.Panel1.SuspendLayout();
            this.sptcPersonas.Panel2.SuspendLayout();
            this.sptcPersonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // sptcPersonas
            // 
            this.sptcPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptcPersonas.Location = new System.Drawing.Point(0, 0);
            this.sptcPersonas.Name = "sptcPersonas";
            this.sptcPersonas.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sptcPersonas.Panel1
            // 
            this.sptcPersonas.Panel1.Controls.Add(this.btnEliminar);
            this.sptcPersonas.Panel1.Controls.Add(this.btnRefrescar);
            this.sptcPersonas.Panel1.Controls.Add(this.btnEditar);
            this.sptcPersonas.Panel1.Controls.Add(this.btnNuevo);
            // 
            // sptcPersonas.Panel2
            // 
            this.sptcPersonas.Panel2.Controls.Add(this.dtgvPersonas);
            this.sptcPersonas.Size = new System.Drawing.Size(800, 450);
            this.sptcPersonas.SplitterDistance = 91;
            this.sptcPersonas.TabIndex = 0;
            // 
            // dtgvPersonas
            // 
            this.dtgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvPersonas.Location = new System.Drawing.Point(0, 0);
            this.dtgvPersonas.MultiSelect = false;
            this.dtgvPersonas.Name = "dtgvPersonas";
            this.dtgvPersonas.ReadOnly = true;
            this.dtgvPersonas.RowHeadersWidth = 51;
            this.dtgvPersonas.RowTemplate.Height = 24;
            this.dtgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPersonas.Size = new System.Drawing.Size(800, 355);
            this.dtgvPersonas.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 43);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(111, 43);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(713, 43);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 2;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(209, 43);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sptcPersonas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sptcPersonas.Panel1.ResumeLayout(false);
            this.sptcPersonas.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptcPersonas)).EndInit();
            this.sptcPersonas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sptcPersonas;
        private System.Windows.Forms.DataGridView dtgvPersonas;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

