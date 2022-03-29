using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QLGV_Winform
{
    class ControllerSQL
    {
        private SqlConnection conn = new SqlConnection(@"Server=.;Database=QL_GIAOVIEN;Integrated Security=true");
        // thuộc tính để lưu trữ mã GV
        public static string IdQuery = "";
        // hàm thực hiện lệnh Adapter in ra kết quả DataTable
        public DataTable adapterQueryDS(string query)
        {
            SqlDataAdapter adap = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        // hàm thực hiện lệnh Command SQL (DELETE)
        public void commandQuerySQL(string query, string alert)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(alert);
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
            cmd.Connection.Close();
        }
    }
}
