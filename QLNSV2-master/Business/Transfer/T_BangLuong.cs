using DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Transfer
{
    public class T_BangLuong
    {
        public int id { get; set; }
        public int code { get; set; }
        public Nullable<int> idStaff { get; set; }
        public Nullable<double> wordDay { get; set; }
        public Nullable<double> dayOff { get; set; }
        public Nullable<double> withofleave { get; set; }
        public Nullable<double> salary { get; set; }
        public Nullable<double> allowance { get; set; }

        public Nullable<double> overTime {  get; set; }

        public virtual Staff Staff { get; set; }

        public string nameStaff { get; set; }
        public Nullable<int> totalDayOfMonth { get; set; }

        public Nullable<double> totalSalary { get; set; }


        public string namePosition { get; set; }

        public string bankNumber { get; set; }

        public string nameDepartment { get; set; }

        public Nullable<double> basicSalary { get; set; }


    }
}
