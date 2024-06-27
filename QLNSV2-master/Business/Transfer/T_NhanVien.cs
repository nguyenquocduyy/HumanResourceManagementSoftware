using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;

namespace Business.Transfer
{
    public class T_NhanVien
    {
        public int id { get; set; }
        public string nameStaff { get; set; }
        public Nullable<bool> gender { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public string phone { get; set; }
        public string identify { get; set; }
        public string address { get; set; }
        public byte[] image { get; set; }
        public Nullable<int> idRoom { get; set; }
        public Nullable<int> idPosition { get; set; }
        public Nullable<int> idLever { get; set; }
        public Nullable<int> idNation { get; set; }
        public Nullable<bool> maritalStatus { get; set; }
        public Nullable<bool> status { get; set; }
        public string bankNumber { get; set; }
        public string nameDepartment { get; set; }
        public string namePosition { get; set; }
        public string nameLever { get; set; }
        public string nameNation { get; set; }
    }
}
