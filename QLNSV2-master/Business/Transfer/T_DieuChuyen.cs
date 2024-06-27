using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Transfer
{
    public class T_DieuChuyen
    {
        public int id { get; set; }
        public Nullable<int> idStaff { get; set; }
        public string SoDC { get; set; }
        public string nameStaff { get; set; }
        public Nullable<System.DateTime> createDay { get; set; }
        public string Lydo { get; set; }
        public string Ghichu { get; set; }
        public Nullable<int> idRoom { get; set; }
        public Nullable<int> idRoom2 { get; set; }
        public string nameDepartment { get; set; }
        public string nameDepartment2 { get; set; }
    }
}
