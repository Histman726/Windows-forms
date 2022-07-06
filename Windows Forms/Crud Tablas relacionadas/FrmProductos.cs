using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Tablas_relacionadas
{
    public partial class FrmProductos : Form
    {
        private int? id;
        private Productos p;
        public FrmProductos(int? id=null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
                CargarDatos();
        }
        private void ListarCategoria()
        {
            using(CRUDWFEntities1 db=new CRUDWFEntities1())
            {
                var lis = db.Categorias.ToList();
                if(lis.Count > 0)
                {
                    cmbCategorias.DataSource = lis;
                    cmbCategorias.DisplayMember = "nombre";
                    cmbCategorias.ValueMember = "id_Categorias";
                    if (cmbCategorias.Items.Count > 0)
                        cmbCategorias.SelectedIndex = -1;
                }
            }
        }
        private void CargarDatos()
        {
            using(CRUDWFEntities1 db= new CRUDWFEntities1())
            {
                p=new Productos();
                p = db.Productos.Find(id);
                Categorias c = new Categorias();
                c=db.Categorias.Find(p.cod_Categoria);
                txtNombre.Text = p.nom_Producto;
                txtDes.Text = p.descrip_Producto;
                cmbCategorias.SelectedText=c.nombre;
            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            ListarCategoria();
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using(CRUDWFEntities1 de=new CRUDWFEntities1())
            {
                if (id == null)
                    p = new Productos();
                p.nom_Producto = txtNombre.Text;
                p.descrip_Producto = txtDes.Text;
                p.cod_Categoria = (int)cmbCategorias.SelectedValue;
                if (id == null)
                    de.Productos.Add(p);
                else
                    de.Entry(p).State = System.Data.Entity.EntityState.Modified;
                de.SaveChanges();
                
                this.Close();
            }
        }
    }
}
