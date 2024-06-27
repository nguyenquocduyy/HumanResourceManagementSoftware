using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Common
{
    public class InstanceSql
    {
        //Khai báo 1 biến Sqlconnection
        static SqlConnection con = new SqlConnection(); //Hàm tạo kết nối
        public static void taoketNoi()
        {
            //Cấu trúc chuỗi kết nối đến CSDL SQLServer
            con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QL_NHANSU;Integrated Security=True;TrustServerCertificate=True";
            try
            {
                con.Open();//Mở kết nối đến CSDL
            }
            catch (Exception)
            {
                throw;
            }
        }
        //hàm đóng kết nối
        public static void dongketNoi()
        {
            con.Close();
        }
        
        public static DataTable getData(string query) {
        
            taoketNoi();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(tb);
            dongketNoi(); 
            return tb;
         }


        public static DataSet getDataSet(string query)
        {
            taoketNoi();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da); DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public static void execQuery(string qr)
        {
            taoketNoi();
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dongketNoi();
        }


    }
}
