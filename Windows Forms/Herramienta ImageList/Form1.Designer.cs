namespace Herramienta_ImageList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imlFotos = new System.Windows.Forms.ImageList(this.components);
            this.lblFoto = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imlFotos
            // 
            this.imlFotos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlFotos.ImageStream")));
            this.imlFotos.TransparentColor = System.Drawing.Color.Transparent;
            this.imlFotos.Images.SetKeyName(0, "Rectangle 1.png");
            this.imlFotos.Images.SetKeyName(1, "Rectangle 2.png");
            this.imlFotos.Images.SetKeyName(2, "Rectangle 3.png");
            this.imlFotos.Images.SetKeyName(3, "Rectangle 4.png");
            this.imlFotos.Images.SetKeyName(4, "Rectangle 5.png");
            this.imlFotos.Images.SetKeyName(5, "Rectangle 6.png");
            this.imlFotos.Images.SetKeyName(6, "Rectangle 7.png");
            this.imlFotos.Images.SetKeyName(7, "Rectangle 8.png");
            // 
            // lblFoto
            // 
            this.lblFoto.ImageIndex = 0;
            this.lblFoto.ImageList = this.imlFotos;
            this.lblFoto.Location = new System.Drawing.Point(34, 27);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(100, 100);
            this.lblFoto.TabIndex = 0;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(208, 27);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 1;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(423, 383);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.lblFoto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imlFotos;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnCambiar;
    }
}

