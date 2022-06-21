namespace Programa_1
{
    partial class Principal
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
            this.btn_Saludo = new System.Windows.Forms.Button();
            this.lbl_Saludo = new System.Windows.Forms.Label();
            this.btn_Despedida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Saludo
            // 
            this.btn_Saludo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Saludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Saludo.ForeColor = System.Drawing.Color.White;
            this.btn_Saludo.Location = new System.Drawing.Point(187, 61);
            this.btn_Saludo.Name = "btn_Saludo";
            this.btn_Saludo.Size = new System.Drawing.Size(198, 40);
            this.btn_Saludo.TabIndex = 0;
            this.btn_Saludo.Text = "Saludar";
            this.btn_Saludo.UseVisualStyleBackColor = false;
            this.btn_Saludo.Click += new System.EventHandler(this.btn_Saludo_Click);
            // 
            // lbl_Saludo
            // 
            this.lbl_Saludo.AutoSize = true;
            this.lbl_Saludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saludo.Location = new System.Drawing.Point(51, 71);
            this.lbl_Saludo.Name = "lbl_Saludo";
            this.lbl_Saludo.Size = new System.Drawing.Size(66, 20);
            this.lbl_Saludo.TabIndex = 1;
            this.lbl_Saludo.Text = "Saludar";
            // 
            // btn_Despedida
            // 
            this.btn_Despedida.BackColor = System.Drawing.Color.Brown;
            this.btn_Despedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Despedida.ForeColor = System.Drawing.Color.White;
            this.btn_Despedida.Location = new System.Drawing.Point(201, 122);
            this.btn_Despedida.Name = "btn_Despedida";
            this.btn_Despedida.Size = new System.Drawing.Size(168, 37);
            this.btn_Despedida.TabIndex = 2;
            this.btn_Despedida.Text = "Despedida";
            this.btn_Despedida.UseVisualStyleBackColor = false;
            this.btn_Despedida.Click += new System.EventHandler(this.btn_Despedida_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 240);
            this.Controls.Add(this.btn_Despedida);
            this.Controls.Add(this.lbl_Saludo);
            this.Controls.Add(this.btn_Saludo);
            this.Name = "Principal";
            this.Text = "Program 01";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Saludo;
        private System.Windows.Forms.Label lbl_Saludo;
        private System.Windows.Forms.Button btn_Despedida;
    }
}

