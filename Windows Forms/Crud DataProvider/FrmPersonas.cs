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
    public partial class FrmPersonas : Form
    {
        private int? ID;
        public FrmPersonas(int? iD=null)
        {
            InitializeComponent();
            ID = iD;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && nudAge.Value != 0)
            {
                if (ID == null)
                {
                    CRUD.Guardar(txtName.Text,(int)nudAge.Value);
                }
                else
                {
                    CRUD.Actualizar(txtName.Text, (int)nudAge.Value, (int)ID);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pueden insertar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmPersonas_Load(object sender, EventArgs e)
        {
            if(ID != null)
            {
                CRUD.SelectID((int)ID,out string name,out decimal age);
                txtName.Text = name;
                nudAge.Value = age;
            }
        }
    }
}
