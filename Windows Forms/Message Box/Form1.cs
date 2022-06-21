using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Message_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblRes.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Cuadros de mensaje

            //? Mensaje
            //# MessageBox.Show("Hola a todos");

            //? Mensaje con titulo
            //# MessageBox.Show("Hola a todos", "Mi mensaje");

            //? Mensaje con titulo y botones
            //# MessageBox.Show("Probando botones", "Pruebas", MessageBoxButtons.AbortRetryIgnore);
            // Si se necesita saber que boton presiono el usuario se hace de la siguiente manera 
            /*DialogResult res = MessageBox.Show("Probando botones", "Pruebas", MessageBoxButtons.AbortRetryIgnore);
                                        if (res == DialogResult.Abort)
                                            lblRes.Text = "Omitir";
                                        else if (res == DialogResult.Retry)
                                            lblRes.Text = "Reintento";
                                        else if (res == DialogResult.Ignore)
                                            lblRes.Text = "Ignorar";*/

            //? Mensaje con titulo, botones e icono
            MessageBox.Show("Probando botones", "Pruebas", MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Exclamation);
        }
    }
}
