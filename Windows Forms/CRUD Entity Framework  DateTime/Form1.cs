using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Entity_Framework__DateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        private void Refrescar()
        {
            using (CRUDWFEntities db = new CRUDWFEntities())
            {
                var lst = from p in db.People
                          select p;
                dtgvPersonas.DataSource = lst.ToList();
            }
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmPeople frmPeople = new FrmPeople();
            frmPeople.ShowDialog();
            Refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id=ObtenerID();
            if (id != null)
            {
                FrmPeople people=new FrmPeople(id);
                people.ShowDialog();
                Refrescar();
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = ObtenerID();
            if (id != null)
            {
                using(CRUDWFEntities db=new CRUDWFEntities())
                {
                    People p = db.People.Find(id);
                    db.People.Remove(p);
                    db.SaveChanges();
                }
                Refrescar();
            }
        }
    }
}
