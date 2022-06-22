namespace Practica_1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.rdbBasico = new System.Windows.Forms.RadioButton();
            this.rdbExternos = new System.Windows.Forms.RadioButton();
            this.rdbTotal = new System.Windows.Forms.RadioButton();
            this.gpbSeguros = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAudio = new System.Windows.Forms.CheckBox();
            this.chkAire = new System.Windows.Forms.CheckBox();
            this.lblEquipar = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtCotizacion = new System.Windows.Forms.TextBox();
            this.gpbSeguros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(146, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(75, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Location = new System.Drawing.Point(33, 36);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(51, 16);
            this.lblSeguro.TabIndex = 2;
            this.lblSeguro.Text = "Seguro";
            // 
            // rdbBasico
            // 
            this.rdbBasico.AutoSize = true;
            this.rdbBasico.Location = new System.Drawing.Point(90, 36);
            this.rdbBasico.Name = "rdbBasico";
            this.rdbBasico.Size = new System.Drawing.Size(70, 20);
            this.rdbBasico.TabIndex = 3;
            this.rdbBasico.TabStop = true;
            this.rdbBasico.Text = "Basico";
            this.rdbBasico.UseVisualStyleBackColor = true;
            this.rdbBasico.CheckedChanged += new System.EventHandler(this.rdbBasico_CheckedChanged);
            // 
            // rdbExternos
            // 
            this.rdbExternos.AutoSize = true;
            this.rdbExternos.Location = new System.Drawing.Point(90, 63);
            this.rdbExternos.Name = "rdbExternos";
            this.rdbExternos.Size = new System.Drawing.Size(91, 20);
            this.rdbExternos.TabIndex = 4;
            this.rdbExternos.TabStop = true;
            this.rdbExternos.Text = "A externos";
            this.rdbExternos.UseVisualStyleBackColor = true;
            this.rdbExternos.CheckedChanged += new System.EventHandler(this.rdbExternos_CheckedChanged);
            // 
            // rdbTotal
            // 
            this.rdbTotal.AutoSize = true;
            this.rdbTotal.Location = new System.Drawing.Point(90, 90);
            this.rdbTotal.Name = "rdbTotal";
            this.rdbTotal.Size = new System.Drawing.Size(59, 20);
            this.rdbTotal.TabIndex = 5;
            this.rdbTotal.TabStop = true;
            this.rdbTotal.Text = "Total";
            this.rdbTotal.UseVisualStyleBackColor = true;
            this.rdbTotal.CheckedChanged += new System.EventHandler(this.rdbTotal_CheckedChanged);
            // 
            // gpbSeguros
            // 
            this.gpbSeguros.Controls.Add(this.lblSeguro);
            this.gpbSeguros.Controls.Add(this.rdbTotal);
            this.gpbSeguros.Controls.Add(this.rdbBasico);
            this.gpbSeguros.Controls.Add(this.rdbExternos);
            this.gpbSeguros.Location = new System.Drawing.Point(10, 108);
            this.gpbSeguros.Name = "gpbSeguros";
            this.gpbSeguros.Size = new System.Drawing.Size(368, 145);
            this.gpbSeguros.TabIndex = 6;
            this.gpbSeguros.TabStop = false;
            this.gpbSeguros.Text = "Seguro a seleccionar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAudio);
            this.groupBox1.Controls.Add(this.chkAire);
            this.groupBox1.Controls.Add(this.lblEquipar);
            this.groupBox1.Location = new System.Drawing.Point(403, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 138);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipamiento";
            // 
            // chkAudio
            // 
            this.chkAudio.AutoSize = true;
            this.chkAudio.Location = new System.Drawing.Point(93, 56);
            this.chkAudio.Name = "chkAudio";
            this.chkAudio.Size = new System.Drawing.Size(134, 20);
            this.chkAudio.TabIndex = 2;
            this.chkAudio.Text = "Sistema de audio";
            this.chkAudio.UseVisualStyleBackColor = true;
            this.chkAudio.CheckedChanged += new System.EventHandler(this.chkAudio_CheckedChanged);
            // 
            // chkAire
            // 
            this.chkAire.AutoSize = true;
            this.chkAire.Location = new System.Drawing.Point(93, 25);
            this.chkAire.Name = "chkAire";
            this.chkAire.Size = new System.Drawing.Size(146, 20);
            this.chkAire.TabIndex = 1;
            this.chkAire.Text = "Aire acondicionado";
            this.chkAire.UseVisualStyleBackColor = true;
            this.chkAire.CheckedChanged += new System.EventHandler(this.chkAire_CheckedChanged);
            // 
            // lblEquipar
            // 
            this.lblEquipar.AutoSize = true;
            this.lblEquipar.Location = new System.Drawing.Point(16, 29);
            this.lblEquipar.Name = "lblEquipar";
            this.lblEquipar.Size = new System.Drawing.Size(54, 16);
            this.lblEquipar.TabIndex = 0;
            this.lblEquipar.Text = "Equipar";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(75, 277);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(42, 16);
            this.lblCosto.TabIndex = 8;
            this.lblCosto.Text = "Costo";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(146, 277);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(232, 22);
            this.txtCosto.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(435, 277);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtCotizacion
            // 
            this.txtCotizacion.Location = new System.Drawing.Point(46, 326);
            this.txtCotizacion.Multiline = true;
            this.txtCotizacion.Name = "txtCotizacion";
            this.txtCotizacion.Size = new System.Drawing.Size(687, 164);
            this.txtCotizacion.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 522);
            this.Controls.Add(this.txtCotizacion);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbSeguros);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbSeguros.ResumeLayout(false);
            this.gpbSeguros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.RadioButton rdbBasico;
        private System.Windows.Forms.RadioButton rdbExternos;
        private System.Windows.Forms.RadioButton rdbTotal;
        private System.Windows.Forms.GroupBox gpbSeguros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAudio;
        private System.Windows.Forms.CheckBox chkAire;
        private System.Windows.Forms.Label lblEquipar;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtCotizacion;
    }
}

