using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;

namespace Business
{
    public class BusinessDepartment
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();

        public Department getItem(int id)
        {
            return database.Departments.FirstOrDefault(x => x.id == id);
        }

        public List<Department> getList()
        {
            return database.Departments.ToList();
        }


        public Department createDepartment(Department pb)
        {
            try
            {
                database.Departments.Add(pb);
                database.SaveChanges();
                return pb;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Department updateDepartment(Department dt)
        {
            try
            {
                database.SaveChanges();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void deleteDepartment(int id)
        {
            try
            {
                var dt = database.Departments.FirstOrDefault(x => x.id == id);
                database.Departments.Remove(dt);
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }

    }
}
