using DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessInsurance_Type
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();

        public Insurance_Types getItem(int id)
        {
            return database.Insurance_Types.FirstOrDefault(x => x.id == id);
        }

        public List<Insurance_Types> getList()
        {
            return database.Insurance_Types.ToList();
        }

        public Insurance_Types createInsurance_Type(Insurance_Types lbh)
        {
            try
            {
                database.Insurance_Types.Add(lbh);
                database.SaveChanges();
                return lbh;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Insurance_Types updateInsurance_Type(Insurance_Types lbh)
        {
            try
            {
                database.SaveChanges();
                return lbh;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void deleteInsurance_Type(int id)
        {
            try
            {
                var bhd = database.Insurance_Types.FirstOrDefault(x => x.id == id);
                database.Insurance_Types.Remove(bhd);
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
