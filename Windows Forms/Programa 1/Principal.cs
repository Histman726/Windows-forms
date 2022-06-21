using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        // Handler y nombre del evento
        private void btn_Saludo_Click(object sender, EventArgs e)
        {
            lbl_Saludo.Text = "Hola Mundo";
        }
    }
}
