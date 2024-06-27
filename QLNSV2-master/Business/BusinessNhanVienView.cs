using DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessNhanVienView
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();

        public ViewNVcb getItem(int id)
        {
            return database.ViewNVcbs.FirstOrDefault(x => x.id == id);
        }

        public List<ViewNVcb> getList()
        {
            return database.ViewNVcbs.ToList();
        }
    }
}
