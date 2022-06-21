namespace Radiobutton_y_Groupbox
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
            this.txt_A = new System.Windows.Forms.TextBox();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gpb_Operaciones = new System.Windows.Forms.GroupBox();
            this.rdb_Sumar = new System.Windows.Forms.RadioButton();
            this.rdb_Restar = new System.Windows.Forms.RadioButton();
            this.rdb_Div = new System.Windows.Forms.RadioButton();
            this.rdb_Multi = new System.Windows.Forms.RadioButton();
            this.gpb_Operaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(36, 26);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(167, 22);
            this.txt_A.TabIndex = 0;
            this.txt_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(36, 76);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(167, 22);
            this.txt_B.TabIndex = 1;
            this.txt_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(238, 46);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(88, 39);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gpb_Operaciones
            // 
            this.gpb_Operaciones.Controls.Add(this.rdb_Div);
            this.gpb_Operaciones.Controls.Add(this.rdb_Multi);
            this.gpb_Operaciones.Controls.Add(this.rdb_Restar);
            this.gpb_Operaciones.Controls.Add(this.rdb_Sumar);
            this.gpb_Operaciones.Location = new System.Drawing.Point(22, 128);
            this.gpb_Operaciones.Name = "gpb_Operaciones";
            this.gpb_Operaciones.Size = new System.Drawing.Size(286, 125);
            this.gpb_Operaciones.TabIndex = 3;
            this.gpb_Operaciones.TabStop = false;
            this.gpb_Operaciones.Text = "Operaciones";
            // 
            // rdb_Sumar
            // 
            this.rdb_Sumar.AutoSize = true;
            this.rdb_Sumar.Location = new System.Drawing.Point(14, 32);
            this.rdb_Sumar.Name = "rdb_Sumar";
            this.rdb_Sumar.Size = new System.Drawing.Size(67, 20);
            this.rdb_Sumar.TabIndex = 0;
            this.rdb_Sumar.TabStop = true;
            this.rdb_Sumar.Text = "Sumar";
            this.rdb_Sumar.UseVisualStyleBackColor = true;
            // 
            // rdb_Restar
            // 
            this.rdb_Restar.AutoSize = true;
            this.rdb_Restar.Location = new System.Drawing.Point(14, 73);
            this.rdb_Restar.Name = "rdb_Restar";
            this.rdb_Restar.Size = new System.Drawing.Size(68, 20);
            this.rdb_Restar.TabIndex = 1;
            this.rdb_Restar.TabStop = true;
            this.rdb_Restar.Text = "Restar";
            this.rdb_Restar.UseVisualStyleBackColor = true;
            // 
            // rdb_Div
            // 
            this.rdb_Div.AutoSize = true;
            this.rdb_Div.Location = new System.Drawing.Point(159, 73);
            this.rdb_Div.Name = "rdb_Div";
            this.rdb_Div.Size = new System.Drawing.Size(76, 20);
            this.rdb_Div.TabIndex = 3;
            this.rdb_Div.TabStop = true;
            this.rdb_Div.Text = "Division";
            this.rdb_Div.UseVisualStyleBackColor = true;
            // 
            // rdb_Multi
            // 
            this.rdb_Multi.AutoSize = true;
            this.rdb_Multi.Location = new System.Drawing.Point(159, 32);
            this.rdb_Multi.Name = "rdb_Multi";
            this.rdb_Multi.Size = new System.Drawing.Size(88, 20);
            this.rdb_Multi.TabIndex = 2;
            this.rdb_Multi.TabStop = true;
            this.rdb_Multi.Text = "Multiplicar";
            this.rdb_Multi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 272);
            this.Controls.Add(this.gpb_Operaciones);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txt_B);
            this.Controls.Add(this.txt_A);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpb_Operaciones.ResumeLayout(false);
            this.gpb_Operaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gpb_Operaciones;
        private System.Windows.Forms.RadioButton rdb_Div;
        private System.Windows.Forms.RadioButton rdb_Multi;
        private System.Windows.Forms.RadioButton rdb_Restar;
        private System.Windows.Forms.RadioButton rdb_Sumar;
    }
}

