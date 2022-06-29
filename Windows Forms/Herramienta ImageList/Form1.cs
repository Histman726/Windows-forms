using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herramienta_ImageList
{
    public partial class Form1 : Form
    {
        private int indice;
        public Form1()
        {
            InitializeComponent();
            indice = 0;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            indice++;

            if (indice > 7 || indice<0)
                indice = 0;
            
            lblFoto.ImageIndex = indice;
        }
    }
}
