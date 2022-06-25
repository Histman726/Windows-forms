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
            if (pbrTrabajo.Value < 100)
            {
                pbrTrabajo.Value++;
                lblValor.Text = conteo.ToString();
            }
            else if (pbrTrabajo.Value == 100)
                tmrPrueba.Enabled = false;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            tmrPrueba.Enabled = true;
            tmrPrueba.Start();
            pbrTrabajo.Value = 0;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            tmrPrueba.Enabled = false;
            tmrPrueba.Stop();
            tbrIntervalo.Value = tbrIntervalo.Minimum;
            lblIntervalo.Text = tbrIntervalo.Value.ToString();
            tmrPrueba.Interval = tbrIntervalo.Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrPrueba.Enabled = false;
        }

        private void tbrIntervalo_Scroll(object sender, EventArgs e)
        {
            lblIntervalo.Text = tbrIntervalo.Value.ToString();
            tmrPrueba.Interval = tbrIntervalo.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblIntervalo.Text = tbrIntervalo.Value.ToString();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 100000; i++)
            {
                // El proceso
                if (i % 1000 == 0)
                    pbrTrabajo.PerformStep();
            }
        }
    }
}
