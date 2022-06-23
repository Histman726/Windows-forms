using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cominucacion_entre_formas_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForma2_Click(object sender, EventArgs e)
        {
            //Creacion de una instancia de formulario 2
            Form2 form2 = new Form2();

            form2.ShowDialog();

            // Mostrar el texto guarda en las propiedades del formulario 2
            lblMensaje.Text=form2.Mensaje;
            lblContenido.Text=form2.Contenido;
        }
    }
}
