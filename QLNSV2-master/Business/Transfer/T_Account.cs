using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;

namespace Business.Transfer
{
    public class T_Account
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int idStaff { get; set; }
        public string nameStaff { get; set; }
    }
}
