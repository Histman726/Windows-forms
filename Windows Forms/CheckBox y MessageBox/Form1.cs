using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_y_MessageBox
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int total=0;
            if (chk_List.Checked)
                total += 250;

            if (chk_Mouse.Checked)
                total += 120;

            if (chk_Teclado.Checked)
                total += 75;

            MessageBox.Show("El resultado es: " + total.ToString(),"Resultado",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void chk_List_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_List.Checked)
                lblRes.Text = "Monitor";
            else
                lblRes.Text = "";
        }
    }
}
