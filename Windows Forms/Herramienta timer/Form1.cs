using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herramienta_timer
{
    public partial class Form1 : Form
    {
        private int conteo;
        public Form1()
        {
            InitializeComponent();
            conteo = 0;
        }

        // La herramienta Timer maneja el tiempo con milisegundos
        private void tmrPrueba_Tick(object sender, EventArgs e)
        {
            conteo++;
            lblValor.Text = conteo.ToString();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            tmrPrueba.Enabled = true;
            tmrPrueba.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            tmrPrueba.Enabled = false;
            tmrPrueba.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrPrueba.Enabled = false;
        }
    }
}
