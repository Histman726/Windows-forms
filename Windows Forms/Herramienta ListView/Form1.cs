using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Herramienta_ListView
{
    public partial class Form1 : Form
    {
        ListViewGroup frutas = new ListViewGroup("Frutas", HorizontalAlignment.Center);
        ListViewGroup carnes = new ListViewGroup("Carnes", HorizontalAlignment.Center);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cremos un ImageList
            ImageList misImagenes=new ImageList();
            misImagenes.ImageSize = new Size(200,200);

            // Obteniendo listado de imagenes
            string[] images = Directory.GetFiles(@"C:\Users\monic\Documents\personal\Windows forms\Windows Forms\Herramienta ListView\bin\Debug\Imagenes");

            // Cargamos los archivos
            try
            {
                foreach(string image in images)
                    misImagenes.Images.Add(Image.FromFile(image));
            }catch
            {
                MessageBox.Show("No se han podido cargar los archivos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            lstvAlimentos.SmallImageList = misImagenes;

            // Frutas
            lstvAlimentos.Items.Add(new ListViewItem("Manzana",1,frutas));
            lstvAlimentos.Items.Add(new ListViewItem("Pera",3,frutas));
            lstvAlimentos.Items.Add(new ListViewItem("Sandia",4,frutas));
            lstvAlimentos.Items.Add(new ListViewItem("Melon",2,frutas));
            lstvAlimentos.Items.Add(new ListViewItem("Ciruela",0,frutas));

            // Carnes
            lstvAlimentos.Items.Add(new ListViewItem("Pollo",carnes));
            lstvAlimentos.Items.Add(new ListViewItem("Bistek",carnes));

            // Adicionar grupos
            lstvAlimentos.Groups.Add(carnes);
            lstvAlimentos.Groups.Add(frutas);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (rdbCarnes.Checked)
            {
                lstvAlimentos.Items.Add(new ListViewItem(txtAlimento.Text,carnes));
            }
            else if (rdbFrutas.Checked)
            {
                lstvAlimentos.Items.Add(new ListViewItem(txtAlimento.Text, frutas));
            }
            txtAlimento.Clear();
        }

        private void lstvAlimentos_MouseClick(object sender, MouseEventArgs e)
        {
            lblInfo.Text = lstvAlimentos.SelectedItems[0].SubItems[0].Text;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstvAlimentos.Items.Clear();
            lblInfo.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lstvAlimentos.SelectedItems[0].SubItems[0].Text=txtAlimento.Text;
            lstvAlimentos.SelectedItems[0].ImageIndex =Convert.ToInt32( txtImagenes.Text);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lstvAlimentos.Items.RemoveAt(lstvAlimentos.SelectedIndices[0]);
        }
    }
}
