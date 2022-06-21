namespace Textbox_para_numeros
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
            this.lbl_Numeros = new System.Windows.Forms.Label();
            this.txt_Numeros = new System.Windows.Forms.TextBox();
            this.txt_Numero2 = new System.Windows.Forms.TextBox();
            this.lbl_Numero2 = new System.Windows.Forms.Label();
            this.btn_Suma = new System.Windows.Forms.Button();
            this.lbl_Res = new System.Windows.Forms.Label();
            this.btn_Restar = new System.Windows.Forms.Button();
            this.btn_Div = new System.Windows.Forms.Button();
            this.btn_Multi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Numeros
            // 
            this.lbl_Numeros.AutoSize = true;
            this.lbl_Numeros.Location = new System.Drawing.Point(31, 23);
            this.lbl_Numeros.Name = "lbl_Numeros";
            this.lbl_Numeros.Size = new System.Drawing.Size(68, 16);
            this.lbl_Numeros.TabIndex = 0;
            this.lbl_Numeros.Text = "Numero 1:";
            // 
            // txt_Numeros
            // 
            this.txt_Numeros.Location = new System.Drawing.Point(105, 20);
            this.txt_Numeros.Name = "txt_Numeros";
            this.txt_Numeros.Size = new System.Drawing.Size(195, 22);
            this.txt_Numeros.TabIndex = 1;
            this.txt_Numeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Numero2
            // 
            this.txt_Numero2.Location = new System.Drawing.Point(105, 67);
            this.txt_Numero2.Name = "txt_Numero2";
            this.txt_Numero2.Size = new System.Drawing.Size(195, 22);
            this.txt_Numero2.TabIndex = 3;
            this.txt_Numero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Numero2
            // 
            this.lbl_Numero2.AutoSize = true;
            this.lbl_Numero2.Location = new System.Drawing.Point(31, 70);
            this.lbl_Numero2.Name = "lbl_Numero2";
            this.lbl_Numero2.Size = new System.Drawing.Size(68, 16);
            this.lbl_Numero2.TabIndex = 2;
            this.lbl_Numero2.Text = "Numero 2:";
            // 
            // btn_Suma
            // 
            this.btn_Suma.Location = new System.Drawing.Point(361, 36);
            this.btn_Suma.Name = "btn_Suma";
            this.btn_Suma.Size = new System.Drawing.Size(95, 40);
            this.btn_Suma.TabIndex = 4;
            this.btn_Suma.Text = "Sumar";
            this.btn_Suma.UseVisualStyleBackColor = true;
            this.btn_Suma.Click += new System.EventHandler(this.btn_Suma_Click);
            // 
            // lbl_Res
            // 
            this.lbl_Res.AutoSize = true;
            this.lbl_Res.Location = new System.Drawing.Point(153, 120);
            this.lbl_Res.Name = "lbl_Res";
            this.lbl_Res.Size = new System.Drawing.Size(44, 16);
            this.lbl_Res.TabIndex = 5;
            this.lbl_Res.Text = "label1";
            // 
            // btn_Restar
            // 
            this.btn_Restar.Location = new System.Drawing.Point(361, 96);
            this.btn_Restar.Name = "btn_Restar";
            this.btn_Restar.Size = new System.Drawing.Size(95, 40);
            this.btn_Restar.TabIndex = 6;
            this.btn_Restar.Text = "Restar";
            this.btn_Restar.UseVisualStyleBackColor = true;
            this.btn_Restar.Click += new System.EventHandler(this.btn_Restar_Click);
            // 
            // btn_Div
            // 
            this.btn_Div.Location = new System.Drawing.Point(500, 96);
            this.btn_Div.Name = "btn_Div";
            this.btn_Div.Size = new System.Drawing.Size(95, 40);
            this.btn_Div.TabIndex = 8;
            this.btn_Div.Text = "Dividir";
            this.btn_Div.UseVisualStyleBackColor = true;
            this.btn_Div.Click += new System.EventHandler(this.btn_Div_Click);
            // 
            // btn_Multi
            // 
            this.btn_Multi.Location = new System.Drawing.Point(500, 36);
            this.btn_Multi.Name = "btn_Multi";
            this.btn_Multi.Size = new System.Drawing.Size(95, 40);
            this.btn_Multi.TabIndex = 7;
            this.btn_Multi.Text = "Multiplicar";
            this.btn_Multi.UseVisualStyleBackColor = true;
            this.btn_Multi.Click += new System.EventHandler(this.btn_Multi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 201);
            this.Controls.Add(this.btn_Div);
            this.Controls.Add(this.btn_Multi);
            this.Controls.Add(this.btn_Restar);
            this.Controls.Add(this.lbl_Res);
            this.Controls.Add(this.btn_Suma);
            this.Controls.Add(this.txt_Numero2);
            this.Controls.Add(this.lbl_Numero2);
            this.Controls.Add(this.txt_Numeros);
            this.Controls.Add(this.lbl_Numeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Numeros;
        private System.Windows.Forms.TextBox txt_Numeros;
        private System.Windows.Forms.TextBox txt_Numero2;
        private System.Windows.Forms.Label lbl_Numero2;
        private System.Windows.Forms.Button btn_Suma;
        private System.Windows.Forms.Label lbl_Res;
        private System.Windows.Forms.Button btn_Restar;
        private System.Windows.Forms.Button btn_Div;
        private System.Windows.Forms.Button btn_Multi;
    }
}

