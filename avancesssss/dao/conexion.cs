using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avancesssss.dao
{
    internal class conexion
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public conexion()
        {
            try
            {
                conn = new SqlConnection("Data Source=PC08-LAB302;Initial Catalog=DESKTOP-8LBQ1KA\\MSSQLSERVER04;Integrated Security=True");
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public DataTable consulta(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
