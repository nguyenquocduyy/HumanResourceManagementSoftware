using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;

namespace Business.Transfer
{
    public class T_KyLuat
    {


        public int id { get; set; }
        public string formality { get; set; }
        public Nullable<System.DateTime> createAt { get; set; }
        public Nullable<int> idStaff { get; set; }
        public string reason { get; set; }

        public string nameStaff { get; set; }
    }
}
