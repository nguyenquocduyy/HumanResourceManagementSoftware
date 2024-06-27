using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Transfer
{
    public class T_BaoHiem
    {
        public int id { get; set; }
        public Nullable<int> idStaff { get; set; }
        public Nullable<int> idType { get; set; }
        public Nullable<System.DateTime> paymentDate { get; set; }
        public Nullable<decimal> coverageAmount { get; set; }
        public string insuranceCode { get; set; }
        public string place { get; set; }
        public Nullable<int> idEvent { get; set; }

        public string nameStaff { get; set; }
        public string nameType { get; set; }
    }
}
