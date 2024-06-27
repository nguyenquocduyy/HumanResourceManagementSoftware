using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Common
{
    public class Instance
    {
        //Khai báo 1 biến Sqlconnection
        private static Instance instance;
        private String ConSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=QL_NHANSU;Integrated Security=True";

        public static Instance InstanceLo
        {
            get { if (instance == null) instance = new Instance(); return Instance.instance; }
            private set { Instance.instance = value; }
        }

        private Instance() { }

        public DataTable ExecuteQuery(String Query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection Conn = new SqlConnection(ConSTR))
            {
                Conn.Open();
                SqlCommand command = new SqlCommand(Query, Conn);
                if (parameter != null)
                {
                    int i = 0;
                    String[] listPara = Query.Split(' ');
                    foreach (String item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                Conn.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(String Query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection Conn = new SqlConnection(ConSTR))
            {
                Conn.Open();
                SqlCommand command = new SqlCommand(Query, Conn);
                if (parameter != null)
                {
                    int i = 0;
                    String[] listPara = Query.Split(' ');
                    foreach (String item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
            }
            return data;
        }

        public object ExecuteScalar(String Query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection Conn = new SqlConnection(ConSTR))
            {
                Conn.Open();
                SqlCommand command = new SqlCommand(Query, Conn);
                if (parameter != null)
                {
                    int i = 0;
                    String[] listPara = Query.Split(' ');
                    foreach (String item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
            }
            return data;
        }


    }
}
