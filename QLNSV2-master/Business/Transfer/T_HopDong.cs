using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Transfer
{
    public class T_HopDong
    {
        public int id { get; set; }
        public Nullable<System.DateTime> signDay { get; set; }
        public string mainContent { get; set; }
        public Nullable<int> signCount { get; set; }
        public Nullable<System.DateTime> startDay { get; set; }
        public Nullable<System.DateTime> endDay { get; set; }
        public string limitation { get; set; }
        public string coSalary { get; set; }
        public Nullable<int> idStaff { get; set; }

        public string contractNumber { get; set; }

        public string nameStaff { get; set; }

        public double salary { get; set; }

        public string address { get; set; }

        public string birthday { get; set; }

        public Nullable<bool> gender { get; set; }

        public string phone { get; set; }
        public string identify { get; set; }

    }
}
