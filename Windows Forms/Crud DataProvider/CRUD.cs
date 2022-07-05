using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Xml.Linq;
using System.Drawing;

namespace Crud_DataProvider
{
    public static class CRUD
    {
        private static string cn= ConfigurationManager.ConnectionStrings["CRUDCadena"].ToString();
        public static void Guardar(string name,int age)
        {
            using(SqlConnection conn = new SqlConnection(cn))
            {
                string sql = "Insert into Personas (name,age) values (@name,@age)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public static void Actualizar(string name, int age,int id)
        {
            using(SqlConnection conn = new SqlConnection(cn))
            {
                string sql = "Update Personas set name=@name, age=@age where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public static void SelectID(int id,out string name,out decimal age)
        {
            using(SqlConnection conn=new SqlConnection(cn))
            {
                string sql = "select * from Personas where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                name = dt.Rows[0]["name"].ToString();
                age = Convert.ToInt32(dt.Rows[0]["age"]);
            }
        }
        public static DataTable Refrescar()
        {
            using(SqlConnection conn= new SqlConnection(cn))
            {
                string query = "Select * from Personas";
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        public static void Elimininar(int id)
        {
            using(SqlConnection conn=new SqlConnection(cn))
            {
                string sql = "Delete from Personas where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id",id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
