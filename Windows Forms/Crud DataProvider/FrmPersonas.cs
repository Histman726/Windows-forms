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
                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BC85JKD\SQL;Initial Catalog=CRUDWF;Integrated Security=True"))
                    {
                        string sql = "Insert into Personas (name,age) values (@name,@age)";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@age", nudAge.Value);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BC85JKD\SQL;Initial Catalog=CRUDWF;Integrated Security=True"))
                    {
                        string sql = "Update Personas set name=@name, age=@age where id=@id";
                        SqlCommand cmd=new SqlCommand(sql, conn);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@age", nudAge.Value);
                        cmd.Parameters.AddWithValue("@id", (int)ID);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
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
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BC85JKD\SQL;Initial Catalog=CRUDWF;Integrated Security=True"))
                {
                    string sql = "select * from Personas where id=@id";
                    SqlCommand cmd = new SqlCommand(sql,con);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt=new DataTable();
                    adapter.Fill(dt);
                    txtName.Text = dt.Rows[0]["name"].ToString();
                    nudAge.Value = Convert.ToInt32(dt.Rows[0]["age"]);
                }
            }
        }
    }
}
