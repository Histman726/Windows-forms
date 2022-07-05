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
    public partial class FrmPeople : Form
    {
        private int? ID;
        private People p;
        public FrmPeople(int? iD=null)
        {
            InitializeComponent();
            ID = iD;
            if(ID != null)
                CargarDatos();
        }
        private void CargarDatos()
        {
            using(CRUDWFEntities db=new CRUDWFEntities())
            {
                p = new People();
                p = db.People.Find(ID);
                txtName.Text = p.nombre;
                txtCorreo.Text = p.correo;
                dtpFecha.Value=p.fecha;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using(CRUDWFEntities db=new CRUDWFEntities())
            {
                if(ID==null)
                    p = new People();
                p.nombre = txtName.Text;
                p.correo = txtCorreo.Text;
                p.fecha = dtpFecha.Value;
                if (ID == null)
                    db.People.Add(p);
                else
                {
                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
