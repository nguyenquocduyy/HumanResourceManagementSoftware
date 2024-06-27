using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Transfer
{
    public class T_NangLuong
    {
        public int id { get; set; }
        public string SoQD { get; set; }
        public Nullable<int> idStaff { get; set; }
        public string nameStaff { get; set; }
        public Nullable<int> idContract { get; set; }
        public Nullable<double> LuongHienTai { get; set; }
        public Nullable<double> LuongMoi { get; set; }
        public Nullable<System.DateTime> signDay { get; set; }
        public Nullable<System.DateTime> upDay { get; set; }
        public string GhiChu { get; set; }
    }
}
