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
    public partial class Form2 : Form
    {
        private string comentario;
        public Form2(string men)
        {
            InitializeComponent();
            //* Siempre colocar abajo del metodo Inicialize
            lblEnviado.Text = men;
        }
        public Form2()
        {
            InitializeComponent();
            lblEnviado.Text = "";
        }
        public string Comentario
        {
            set { 
                comentario = value;
                lblComentario.Text = comentario;
            }
        }
    }
}
