using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double costo = 0;
            StringBuilder cotizacion=new StringBuilder();

            cotizacion.AppendLine("Cotizacion realizada a: "+txtNombre.Text);

            // Obtener costo inicial
            costo=Convert.ToDouble(txtCosto.Text);

            // Verificar seguros
            if(rdbBasico.Checked)
            {
                costo += 500;
                cotizacion.AppendLine("Lleva seguro basico de $500");
            }
            else if (rdbExternos.Checked)
            {
                costo += 700;
                cotizacion.AppendLine("Lleva seguro a terceros de $700");
            }
            else if (rdbTotal.Checked)
            {
                costo += 1000;
                cotizacion.AppendLine("Lleva seguro total de $1000");
            }

            // Verificar equipamiento
            if (chkAire.Checked)
            {
                costo += 500;
                cotizacion.AppendLine("Con aire acondicionado de $500");
            }
            if (chkAudio.Checked)
            {
                costo += 700;
                cotizacion.AppendLine("Con un sistema de audio de $700");
            }

            //Mostramos el total
            cotizacion.AppendLine("El total a pagar: "+ costo);
            txtCotizacion.Text = cotizacion.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCosto.Text = "0";
        }

        private void rdbBasico_CheckedChanged(object sender, EventArgs e)
        {
            double costo = 500;
            txtCosto.Text = costo.ToString();
        }

        private void rdbExternos_CheckedChanged(object sender, EventArgs e)
        {
            double costo = 700;
            txtCosto.Text = costo.ToString();
        }

        private void rdbTotal_CheckedChanged(object sender, EventArgs e)
        {
            double costo = 1000;
            txtCosto.Text = costo.ToString();
        }

        private void chkAire_CheckedChanged(object sender, EventArgs e)
        {
            txtCosto.Clear();
            double costo = 500;
            txtCosto.Text = costo.ToString();
        }

        private void chkAudio_CheckedChanged(object sender, EventArgs e)
        {
            txtCosto.Clear();
            double costo = 500;
            txtCosto.Text = costo.ToString();
        }
    }
}
