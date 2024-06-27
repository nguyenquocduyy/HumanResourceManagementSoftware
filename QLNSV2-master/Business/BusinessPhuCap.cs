using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
namespace Business
{
    public class BusinessAllowance
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();

        public Allowance getItem(int id)
        {
            return database.Allowances.FirstOrDefault(x => x.id == id);
        }

        public List<Allowance> getList()
        {
            return database.Allowances.ToList();
        }

        public List<int?> getItemStaffAllowance(int id)
        {
            return database.StaffJoinAllowances.Where(x => x.idStaff == id).Select(x => x.idAllowance).ToList();
        }

        public Allowance createAllowance(Allowance pc)
        {
            try
            {
                database.Allowances.Add(pc);
                database.SaveChanges();
                return pc;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void createAllowanceStaff(StaffJoinAllowance pc)
        {
            try
            {
                database.StaffJoinAllowances.Add(pc);
                database.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Allowance updateAllowance(Allowance dt)
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
        public StaffJoinAllowance updateAllowanceStaff(StaffJoinAllowance pc)
        {
            try
            {
                database.SaveChanges();
                return pc;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void deleteAllowance(int id)
        {
            try
            {
                var cv = database.Allowances.FirstOrDefault(x => x.id == id);
                database.Allowances.Remove(cv);
                database.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
