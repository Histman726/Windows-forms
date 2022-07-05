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
            if(txtName.Text!="" && nudAge.Value != 0)
            {
                PersonasTableAdapter ta = new PersonasTableAdapter();
                if (ID == null)
                {
                    ta.Add(txtName.Text, (int)nudAge.Value);
                }
                else
                {
                    ta.Edit(txtName.Text, (int)nudAge.Value, (int)ID);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pueden insertar campos vacios","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void FrmPersonas_Load(object sender, EventArgs e)
        {
            if (ID != null)
            {
                PersonasTableAdapter ta = new PersonasTableAdapter();
                DataSet1.PersonasDataTable dt= ta.GetDataByID((int)ID);
                DataSet1.PersonasRow row = (DataSet1.PersonasRow)dt.Rows[0];
                txtName.Text = row.name;
                nudAge.Value = row.age;
            }
        }
    }
}
