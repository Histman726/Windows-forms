using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comunicacion_entre_formularios
{
    public partial class Form1 : Form
    {
        // Objeto global
        //# Form2 form2=null;
        Form2 form2=new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Creamos la instancia de Formulario 2
            form2 = new Form2(txtEnviar.Text);

            form2.Comentario = txtEnviar.Text;

            // Mostramos la forma
            form2.Show();
        }

        private void btnComentario_Click(object sender, EventArgs e)
        {
            form2.Comentario = txtEnviar.Text;
        }
    }
}
