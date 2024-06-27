using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;

namespace Business.Transfer
{
    public class T_Config
    {
        public string nameProgram;
        public string nameManufactory;
        public double basicSalary;

        public T_Config(String nameProgram, String nameManufactory, double basicSalary)
        {
            this.nameProgram = nameProgram;
            this.nameManufactory = nameManufactory;
            this.basicSalary = basicSalary;
            
        }

        public T_Config(DataRow row)
        {
            this.nameProgram = (String)row["nameProgram"];
            this.nameManufactory = (String)row["nameManufactory"];
            this.basicSalary = (Double)row["basicSalary"];
        }


    }
}
