namespace Herramienta_ListView
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
            this.lstvAlimentos = new System.Windows.Forms.ListView();
            this.txtAlimento = new System.Windows.Forms.TextBox();
            this.gbGrupos = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.rdbFrutas = new System.Windows.Forms.RadioButton();
            this.rdbCarnes = new System.Windows.Forms.RadioButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbGrupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvAlimentos
            // 
            this.lstvAlimentos.HideSelection = false;
            this.lstvAlimentos.Location = new System.Drawing.Point(11, 10);
            this.lstvAlimentos.Name = "lstvAlimentos";
            this.lstvAlimentos.Size = new System.Drawing.Size(506, 265);
            this.lstvAlimentos.TabIndex = 0;
            this.lstvAlimentos.UseCompatibleStateImageBehavior = false;
            this.lstvAlimentos.View = System.Windows.Forms.View.SmallIcon;
            this.lstvAlimentos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstvAlimentos_MouseClick);
            // 
            // txtAlimento
            // 
            this.txtAlimento.Location = new System.Drawing.Point(23, 304);
            this.txtAlimento.Name = "txtAlimento";
            this.txtAlimento.Size = new System.Drawing.Size(100, 22);
            this.txtAlimento.TabIndex = 1;
            // 
            // gbGrupos
            // 
            this.gbGrupos.Controls.Add(this.btnAdicionar);
            this.gbGrupos.Controls.Add(this.rdbFrutas);
            this.gbGrupos.Controls.Add(this.rdbCarnes);
            this.gbGrupos.Location = new System.Drawing.Point(246, 291);
            this.gbGrupos.Name = "gbGrupos";
            this.gbGrupos.Size = new System.Drawing.Size(271, 140);
            this.gbGrupos.TabIndex = 2;
            this.gbGrupos.TabStop = false;
            this.gbGrupos.Text = "Grupos";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(90, 90);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Agregar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // rdbFrutas
            // 
            this.rdbFrutas.AutoSize = true;
            this.rdbFrutas.Checked = true;
            this.rdbFrutas.Location = new System.Drawing.Point(155, 50);
            this.rdbFrutas.Name = "rdbFrutas";
            this.rdbFrutas.Size = new System.Drawing.Size(65, 20);
            this.rdbFrutas.TabIndex = 1;
            this.rdbFrutas.TabStop = true;
            this.rdbFrutas.Text = "Frutas";
            this.rdbFrutas.UseVisualStyleBackColor = true;
            // 
            // rdbCarnes
            // 
            this.rdbCarnes.AutoSize = true;
            this.rdbCarnes.Location = new System.Drawing.Point(27, 51);
            this.rdbCarnes.Name = "rdbCarnes";
            this.rdbCarnes.Size = new System.Drawing.Size(71, 20);
            this.rdbCarnes.TabIndex = 0;
            this.rdbCarnes.Text = "Carnes";
            this.rdbCarnes.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(538, 23);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(44, 16);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "label1";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(541, 56);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.gbGrupos);
            this.Controls.Add(this.txtAlimento);
            this.Controls.Add(this.lstvAlimentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGrupos.ResumeLayout(false);
            this.gbGrupos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvAlimentos;
        private System.Windows.Forms.TextBox txtAlimento;
        private System.Windows.Forms.GroupBox gbGrupos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.RadioButton rdbFrutas;
        private System.Windows.Forms.RadioButton rdbCarnes;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

