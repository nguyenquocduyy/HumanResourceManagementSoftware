using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;

namespace Business
{
    public class BusinessNation
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();

        public Nation getItem(int id)
        {
            return database.Nations.FirstOrDefault(x => x.id == id);
        }

        public List<Nation> getList()
        {
            return database.Nations.ToList();
        }


        public Nation createNation(Nation dt)
        {
            try
            {
                database.Nations.Add(dt);
                database.SaveChanges();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Nation updateNation(Nation dt)
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

        public void deleteNation(int id)
        {
            try
            {
                var dt = database.Nations.FirstOrDefault(x => x.id == id);
                database.Nations.Remove(dt);
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }

    }
}
