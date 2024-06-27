using Business.Transfer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BussinessConfig
    {

        public List<T_Config> listConfig()
        {
            List<T_Config> lsConfig = new List<T_Config>();
            String Query = "SELECT * FROM dbo.SystemCTL";
            DataTable data = Common.Instance.InstanceLo.ExecuteQuery(Query);

            foreach (DataRow item in data.Rows)
            {
                T_Config Config = new T_Config(item);
                lsConfig.Add(Config);
            }
            return lsConfig;
        }
        public bool InsertSystemCTL(String nameProgram, String nameManufactory, float basicSalary)
        {
            
            String Query = String.Format("INSERT dbo.SystemCTL(nameProgram,nameManufactory,basicSalary)VALUES( N'{0}',N'{1}','{2}')"
                , nameProgram, nameManufactory, basicSalary);
            int result = Common.Instance.InstanceLo.ExecuteNonQuery(Query);
            return result > 0;
        }

        public Boolean UpdeteTableSystemCTL(String nameProgram, String nameManufactory, float basicSalary)
        {
            String Query = String.Format("UPDATE dbo.SystemCTL SET " +
                "nameProgram = N'{0}',nameManufactory = N'{1}',basicSalary = '{2}'", nameProgram, nameManufactory, basicSalary);
            int result = Common.Instance.InstanceLo.ExecuteNonQuery(Query);
            return result > 0;
        }
    }
}
