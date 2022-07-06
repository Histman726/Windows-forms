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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Refrescar()
        {
            using(CRUDWFEntities1 crud = new CRUDWFEntities1())
            {
                var lis = from p in crud.Productos
                          join c in crud.Categorias
                          on p.cod_Categoria equals c.id_Categorias
                          select new {p.id_Productos,p.nom_Producto,p.descrip_Producto,c.nombre};
                dtgvProductos.DataSource= lis.ToList();
            }
        }
        private int? ObtenerID()
        {
            try
            {
                return int.Parse(dtgvProductos.Rows[dtgvProductos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmProductos pro = new FrmProductos();
            pro.ShowDialog();
            Refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id=ObtenerID();
            if (id != null)
            {
                FrmProductos pro = new FrmProductos(id);
                pro.ShowDialog();
                Refrescar();
            }
        }
    }
}
