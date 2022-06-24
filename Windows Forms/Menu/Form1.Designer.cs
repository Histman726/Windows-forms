namespace Menu
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
            this.Menu_Principal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSumar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuResta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMulti = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDiv = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.txtA = new System.Windows.Forms.TextBox();
            this.cmnuTxtA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menu_Context_Borrar = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Context_Aleatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.tspOperaciones = new System.Windows.Forms.ToolStrip();
            this.tspBtnResta = new System.Windows.Forms.ToolStripButton();
            this.tspBtnSuma = new System.Windows.Forms.ToolStripButton();
            this.tspBtnMulti = new System.Windows.Forms.ToolStripButton();
            this.tspBtnDiv = new System.Windows.Forms.ToolStripButton();
            this.Menu_Principal.SuspendLayout();
            this.cmnuTxtA.SuspendLayout();
            this.tspOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Principal
            // 
            this.Menu_Principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.Menu_Principal.Location = new System.Drawing.Point(0, 0);
            this.Menu_Principal.Name = "Menu_Principal";
            this.Menu_Principal.Size = new System.Drawing.Size(396, 28);
            this.Menu_Principal.TabIndex = 0;
            this.Menu_Principal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // MenuSalir
            // 
            this.MenuSalir.AutoToolTip = true;
            this.MenuSalir.Name = "MenuSalir";
            this.MenuSalir.Size = new System.Drawing.Size(121, 26);
            this.MenuSalir.Text = "Salir";
            this.MenuSalir.ToolTipText = "Quitar la aplicacion";
            this.MenuSalir.Click += new System.EventHandler(this.MenuSalir_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSumar,
            this.MenuResta,
            this.MenuMulti,
            this.MenuDiv,
            this.toolStripSeparator1,
            this.habilitarToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // MenuSumar
            // 
            this.MenuSumar.Name = "MenuSumar";
            this.MenuSumar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.MenuSumar.Size = new System.Drawing.Size(224, 26);
            this.MenuSumar.Text = "Suma";
            this.MenuSumar.Click += new System.EventHandler(this.MenuSumar_Click);
            // 
            // MenuResta
            // 
            this.MenuResta.Name = "MenuResta";
            this.MenuResta.Size = new System.Drawing.Size(224, 26);
            this.MenuResta.Text = "Resta";
            this.MenuResta.Click += new System.EventHandler(this.MenuResta_Click);
            // 
            // MenuMulti
            // 
            this.MenuMulti.Name = "MenuMulti";
            this.MenuMulti.Size = new System.Drawing.Size(224, 26);
            this.MenuMulti.Text = "Multi";
            this.MenuMulti.Click += new System.EventHandler(this.MenuMulti_Click);
            // 
            // MenuDiv
            // 
            this.MenuDiv.Name = "MenuDiv";
            this.MenuDiv.Size = new System.Drawing.Size(224, 26);
            this.MenuDiv.Text = "Division";
            this.MenuDiv.Click += new System.EventHandler(this.MenuDiv_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.Checked = true;
            this.habilitarToolStripMenuItem.CheckOnClick = true;
            this.habilitarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.habilitarToolStripMenuItem.Text = "Habilitar";
            this.habilitarToolStripMenuItem.CheckedChanged += new System.EventHandler(this.habilitarToolStripMenuItem_CheckedChanged);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAcerca});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // MenuAcerca
            // 
            this.MenuAcerca.Name = "MenuAcerca";
            this.MenuAcerca.Size = new System.Drawing.Size(167, 26);
            this.MenuAcerca.Text = "Acerca de...";
            this.MenuAcerca.Click += new System.EventHandler(this.MenuAcerca_Click);
            // 
            // txtA
            // 
            this.txtA.ContextMenuStrip = this.cmnuTxtA;
            this.txtA.Location = new System.Drawing.Point(45, 76);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(178, 22);
            this.txtA.TabIndex = 1;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmnuTxtA
            // 
            this.cmnuTxtA.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnuTxtA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Context_Borrar,
            this.Menu_Context_Aleatorio});
            this.cmnuTxtA.Name = "MenuContextual";
            this.cmnuTxtA.Size = new System.Drawing.Size(141, 52);
            // 
            // Menu_Context_Borrar
            // 
            this.Menu_Context_Borrar.Name = "Menu_Context_Borrar";
            this.Menu_Context_Borrar.Size = new System.Drawing.Size(140, 24);
            this.Menu_Context_Borrar.Text = "Borrar";
            this.Menu_Context_Borrar.Click += new System.EventHandler(this.Menu_Context_Borrar_Click);
            // 
            // Menu_Context_Aleatorio
            // 
            this.Menu_Context_Aleatorio.Name = "Menu_Context_Aleatorio";
            this.Menu_Context_Aleatorio.Size = new System.Drawing.Size(140, 24);
            this.Menu_Context_Aleatorio.Text = "Aleatorio";
            this.Menu_Context_Aleatorio.Click += new System.EventHandler(this.Menu_Context_Aleatorio_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(45, 119);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(178, 22);
            this.txtB.TabIndex = 2;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(243, 82);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(44, 16);
            this.lblRes.TabIndex = 3;
            this.lblRes.Text = "label1";
            // 
            // tspOperaciones
            // 
            this.tspOperaciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tspOperaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspBtnSuma,
            this.tspBtnResta,
            this.tspBtnMulti,
            this.tspBtnDiv});
            this.tspOperaciones.Location = new System.Drawing.Point(0, 28);
            this.tspOperaciones.Name = "tspOperaciones";
            this.tspOperaciones.Size = new System.Drawing.Size(396, 27);
            this.tspOperaciones.TabIndex = 4;
            this.tspOperaciones.Text = "toolStrip1";
            // 
            // tspBtnResta
            // 
            this.tspBtnResta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspBtnResta.Image = ((System.Drawing.Image)(resources.GetObject("tspBtnResta.Image")));
            this.tspBtnResta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspBtnResta.Name = "tspBtnResta";
            this.tspBtnResta.Size = new System.Drawing.Size(29, 24);
            this.tspBtnResta.Text = "Resta";
            this.tspBtnResta.Click += new System.EventHandler(this.MenuResta_Click);
            // 
            // tspBtnSuma
            // 
            this.tspBtnSuma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspBtnSuma.Image = ((System.Drawing.Image)(resources.GetObject("tspBtnSuma.Image")));
            this.tspBtnSuma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspBtnSuma.Name = "tspBtnSuma";
            this.tspBtnSuma.Size = new System.Drawing.Size(29, 24);
            this.tspBtnSuma.Text = "Suma";
            this.tspBtnSuma.Click += new System.EventHandler(this.MenuSumar_Click);
            // 
            // tspBtnMulti
            // 
            this.tspBtnMulti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspBtnMulti.Image = ((System.Drawing.Image)(resources.GetObject("tspBtnMulti.Image")));
            this.tspBtnMulti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspBtnMulti.Name = "tspBtnMulti";
            this.tspBtnMulti.Size = new System.Drawing.Size(29, 24);
            this.tspBtnMulti.Text = "Multiplicacion";
            this.tspBtnMulti.Click += new System.EventHandler(this.MenuMulti_Click);
            // 
            // tspBtnDiv
            // 
            this.tspBtnDiv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspBtnDiv.Image = ((System.Drawing.Image)(resources.GetObject("tspBtnDiv.Image")));
            this.tspBtnDiv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspBtnDiv.Name = "tspBtnDiv";
            this.tspBtnDiv.Size = new System.Drawing.Size(29, 24);
            this.tspBtnDiv.Text = "Division";
            this.tspBtnDiv.Click += new System.EventHandler(this.MenuDiv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 367);
            this.Controls.Add(this.tspOperaciones);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.Menu_Principal);
            this.MainMenuStrip = this.Menu_Principal;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Menu_Principal.ResumeLayout(false);
            this.Menu_Principal.PerformLayout();
            this.cmnuTxtA.ResumeLayout(false);
            this.tspOperaciones.ResumeLayout(false);
            this.tspOperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_Principal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuSalir;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuSumar;
        private System.Windows.Forms.ToolStripMenuItem MenuResta;
        private System.Windows.Forms.ToolStripMenuItem MenuMulti;
        private System.Windows.Forms.ToolStripMenuItem MenuDiv;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAcerca;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmnuTxtA;
        private System.Windows.Forms.ToolStripMenuItem Menu_Context_Borrar;
        private System.Windows.Forms.ToolStripMenuItem Menu_Context_Aleatorio;
        private System.Windows.Forms.ToolStrip tspOperaciones;
        private System.Windows.Forms.ToolStripButton tspBtnResta;
        private System.Windows.Forms.ToolStripButton tspBtnSuma;
        private System.Windows.Forms.ToolStripButton tspBtnMulti;
        private System.Windows.Forms.ToolStripButton tspBtnDiv;
    }
}

