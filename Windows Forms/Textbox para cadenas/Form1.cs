using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textbox_para_cadenas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_Res.Text = "";
        }

        private void btn_Saludo_Click(object sender, EventArgs e)
        {
            lbl_Res.Text=txt_Nombre.Text+" es el nombre, Hola!!!";
        }
    }
}
