using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Transfer
{
    public class T_PhuCap
    {
        public int id { get; set; }
        public Nullable<int> idStaff { get; set; }
        public Nullable<int> idAllowance { get; set; }
        public Nullable<double> money { get; set; }
        public string nameStaff { get; set; }
        public string nameType { get; set; }
    }
}
