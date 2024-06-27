using Business.Transfer;
using DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessRole
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();

        public Role getItem(int id)
        {
            return database.Roles.FirstOrDefault(x => x.id == id);
        }

        public List<Role> getList()
        {
            return database.Roles.ToList();
        }

        public Role createRole(Role role)
        {
            try
            {
                database.Roles.Add(role);
                database.SaveChanges();
                return role;
            }
            catch
            {
                throw;
            }
        }

        public Role updateRole(Role role)
        {
            try
            {
                database.SaveChanges();
                return role;
            }
            catch
            {
                throw;
            }
        }

        public void deleteRole(int id)
        {
            try
            {
                var ro = database.Roles.FirstOrDefault(x => x.id == id);
                database.Roles.Remove(ro);
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
