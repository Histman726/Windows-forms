using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_Datetime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            // Fecha aleatoria
            //DateTime fecha=new DateTime(2014,12,28);

            // Fecha actual
            //DateTime fecha = DateTime.Today;

            // Fecha de cercanas a la actual
            DateTime fecha = DateTime.Today.AddDays(2);

            //Formatos de la fecha 
            string formato = "MMM ddd ";//Formato de mes y dia de tres letras
            formato = "MMM ddd d";//Formato de mes y dia de tres letras mas el numero del dia
            formato = "MMM ddd d HH mm yyyy";//Formato de fecha completa


            lblFecha.Text=fecha.ToString(formato);
        }
    }
}
