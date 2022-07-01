﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herramienta_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewGroup frutas=new ListViewGroup("Frutas",HorizontalAlignment.Center);
            ListViewGroup carnes=new ListViewGroup("Carnes",HorizontalAlignment.Center);

            // Frutas
            lstvAlimentos.Items.Add(new ListViewItem("Manzana",frutas));
            lstvAlimentos.Items.Add(new ListViewItem("Pera",frutas));
            lstvAlimentos.Items.Add(new ListViewItem("Sandia",frutas));
            lstvAlimentos.Items.Add(new ListViewItem("Melon",frutas));
            lstvAlimentos.Items.Add(new ListViewItem("Ciruela",frutas));

            // Carnes
            lstvAlimentos.Items.Add(new ListViewItem("Pollo",carnes));
            lstvAlimentos.Items.Add(new ListViewItem("Bistek",carnes));

            // Adicionar grupos
            lstvAlimentos.Groups.Add(carnes);
            lstvAlimentos.Groups.Add(frutas);
        }
    }
}
