using DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessLever
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();

        public Lever getItem(int id)
        {
            return database.Levers.FirstOrDefault(x => x.id == id);
        }

        public List<Lever> getList()
        {
            return database.Levers.ToList();
        }


        public Lever createLever(Lever pc)
        {
            try
            {
                database.Levers.Add(pc);
                database.SaveChanges();
                return pc;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Lever updateLever(Lever dt)
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

        public void deleteLever(int id)
        {
            try
            {
                var cv = database.Levers.FirstOrDefault(x => x.id == id);
                database.Levers.Remove(cv);
                database.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
