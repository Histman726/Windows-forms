using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_DataProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int? ObtenerID()
        {
            try
            {
                return int.Parse(dtgvPersonas.Rows[dtgvPersonas.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        public void Refrescar()
        {
            DataTable dt = CRUD.Refrescar();
            dtgvPersonas.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            FrmPersonas frm2 = new FrmPersonas();
            frm2.ShowDialog();
            Refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = ObtenerID();
            if (id != null)
            {
                FrmPersonas frm2 = new FrmPersonas(id);
                frm2.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = ObtenerID();
            if (id != null)
            {
                var mes = MessageBox.Show("Estas seguro de eliminar", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mes == DialogResult.Yes)
                {
                    CRUD.Elimininar((int)id);
                    Refrescar();
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar un registro nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
