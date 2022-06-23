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
    public partial class Form2 : Form
    {
        // Propiedades para enviar la informacion
        private string mensaje;
        private string contenido;
        public Form2()
        {
            InitializeComponent();
        }
        // Propiedades del tipo get para el envio de informacion
        public string Mensaje { get { return mensaje; } }
        public string Contenido { get { return contenido; } }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Recepcion del texto introducido en los textbox
            mensaje=txtMensaje.Text;
            contenido=txtContenido.Text;
            this.Close();
        }
    }
}
