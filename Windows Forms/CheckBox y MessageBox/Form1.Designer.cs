namespace CheckBox_y_MessageBox
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
            this.chk_List = new System.Windows.Forms.CheckBox();
            this.chk_Teclado = new System.Windows.Forms.CheckBox();
            this.chk_Mouse = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chk_List
            // 
            this.chk_List.AutoSize = true;
            this.chk_List.Location = new System.Drawing.Point(46, 48);
            this.chk_List.Name = "chk_List";
            this.chk_List.Size = new System.Drawing.Size(104, 20);
            this.chk_List.TabIndex = 0;
            this.chk_List.Text = "Monitor $250";
            this.chk_List.UseVisualStyleBackColor = true;
            this.chk_List.CheckedChanged += new System.EventHandler(this.chk_List_CheckedChanged);
            // 
            // chk_Teclado
            // 
            this.chk_Teclado.AutoSize = true;
            this.chk_Teclado.Location = new System.Drawing.Point(46, 89);
            this.chk_Teclado.Name = "chk_Teclado";
            this.chk_Teclado.Size = new System.Drawing.Size(104, 20);
            this.chk_Teclado.TabIndex = 1;
            this.chk_Teclado.Text = "Teclado $75";
            this.chk_Teclado.UseVisualStyleBackColor = true;
            // 
            // chk_Mouse
            // 
            this.chk_Mouse.AutoSize = true;
            this.chk_Mouse.Location = new System.Drawing.Point(46, 126);
            this.chk_Mouse.Name = "chk_Mouse";
            this.chk_Mouse.Size = new System.Drawing.Size(101, 20);
            this.chk_Mouse.TabIndex = 2;
            this.chk_Mouse.Text = "Mouse $120";
            this.chk_Mouse.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(214, 48);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(116, 61);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(107, 176);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(44, 16);
            this.lblRes.TabIndex = 4;
            this.lblRes.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 320);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.chk_Mouse);
            this.Controls.Add(this.chk_Teclado);
            this.Controls.Add(this.chk_List);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_List;
        private System.Windows.Forms.CheckBox chk_Teclado;
        private System.Windows.Forms.CheckBox chk_Mouse;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblRes;
    }
}

