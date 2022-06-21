using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiobutton_y_Groupbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_A.Text = "0";
            txt_B.Text = "0";
            rdb_Div.Checked = false;
            rdb_Multi.Checked = false;
            rdb_Restar.Checked = false;
            rdb_Sumar.Checked = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dynamic r = 0;
            double a = 0;
            double b = 0;
            a = Convert.ToDouble(txt_A.Text);
            b=Convert.ToDouble(txt_B.Text);

            if (rdb_Sumar.Checked)
                r = a + b;
            else if (rdb_Restar.Checked)
                r = a - b;
            else if (rdb_Multi.Checked)
                r = a * b;
            else if (rdb_Div.Checked)
                r = a / b;
            else
                r = "Por favor seleccione alguna operacion";
            MessageBox.Show(r.ToString(), "Resultado",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
