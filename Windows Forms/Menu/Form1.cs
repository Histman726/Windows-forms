using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        double a;
        double b;
        double r;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblRes.Text = "";
        }

        private void MenuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuAcerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejemplo para menu");
        }

        private void MenuSumar_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);

            r = a + b;
            lblRes.Text = r.ToString();

            // Datos inscritos en el StatusStrip
            tspLblValores.Text = "A= " + a + " B= " + b;
            tspLblOperacion.Text = "Suma";
            tspLblResultado.Text = "R= " + r;
        }

        private void MenuResta_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);

            r = a - b;
            lblRes.Text = r.ToString();

            // Datos inscritos en el StatusStrip
            tspLblValores.Text = "A= " + a + " B= " + b;
            tspLblOperacion.Text = "Resta";
            tspLblResultado.Text = "R= " + r;
        }

        private void MenuMulti_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);

            r = a * b;
            lblRes.Text = r.ToString();

            // Datos inscritos en el StatusStrip
            tspLblValores.Text = "A= " + a + " B= " + b;
            tspLblOperacion.Text = "Multiplicación";
            tspLblResultado.Text = "R= " + r;
        }

        private void MenuDiv_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);

            r = a / b;
            lblRes.Text = r.ToString();

            // Datos inscritos en el StatusStrip
            tspLblValores.Text = "A= " + a + " B= " + b;
            tspLblOperacion.Text = "Division";
            tspLblResultado.Text = "R= " + r;
        }

        private void habilitarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            txtA.Enabled = habilitarToolStripMenuItem.Checked;
            txtB.Enabled = habilitarToolStripMenuItem.Checked;
        }

        private void Menu_Context_Borrar_Click(object sender, EventArgs e)
        {
            txtA.Text = "0";
        }

        private void Menu_Context_Aleatorio_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            txtA.Text = r.Next(1,100).ToString();
        }
    }
}
