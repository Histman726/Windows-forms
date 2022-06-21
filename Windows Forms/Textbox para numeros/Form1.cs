using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textbox_para_numeros
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        double res = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_Res.Text = "";
            txt_Numeros.Text = "0";
            txt_Numero2.Text = "0";
        }

        private void btn_Suma_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txt_Numeros.Text);
            b = Convert.ToDouble(txt_Numero2.Text);
            res = a + b;
            lbl_Res.Text = res.ToString();
        }

        private void btn_Restar_Click(object sender, EventArgs e)
        {
            a=Convert.ToDouble(txt_Numeros.Text);
            b=Convert.ToDouble(txt_Numero2.Text);
            res=a - b;
            lbl_Res.Text=res.ToString();
        }

        private void btn_Multi_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txt_Numeros.Text);
            b = Convert.ToDouble(txt_Numero2.Text);
            res = a * b;
            lbl_Res.Text = res.ToString();
        }

        private void btn_Div_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txt_Numeros.Text);
            b = Convert.ToDouble(txt_Numero2.Text);
            res = a / b;
            lbl_Res.Text = res.ToString();
        }
    }
}
