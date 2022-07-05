using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CRUD_Dataset__Dataprovider__Entity_Framework.DataSet1TableAdapters;

namespace CRUD_Dataset__Dataprovider__Entity_Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Metodo para hacer select a la tabla
        private void Refrescar()
        {
            PersonasTableAdapter ta=new PersonasTableAdapter();
            DataSet1.PersonasDataTable dt = ta.GetData();
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
            FrmPersonas frm2=new FrmPersonas();
            frm2.ShowDialog();
            Refrescar();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = ObtenerID();
            if(id!= null)
            {
                FrmPersonas frm2=new FrmPersonas(id);
                frm2.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = ObtenerID();
            if (id != null)
            {
                var mes= MessageBox.Show("Estas seguro de eliminar", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mes == DialogResult.Yes)
                {
                    PersonasTableAdapter ta = new PersonasTableAdapter();
                    DataSet1.PersonasDataTable dt = ta.GetDataByID((int)id);
                    DataSet1.PersonasRow row = (DataSet1.PersonasRow)dt.Rows[0];
                    MessageBox.Show("El elemento " + row.name + " se eliminó correctamente");
                    ta.Remove((int)id);
                    Refrescar();
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar un registro nulo","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
