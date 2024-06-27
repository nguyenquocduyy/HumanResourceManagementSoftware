using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;

namespace Business
{
    public class BusinessPosition
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();

        public Position getItem(int id)
        {
            return database.Positions.SingleOrDefault(x => x.id == id);
        }

        public List<Position> getList()
        {
            return database.Positions.ToList();
        }


        public Position createPosition(Position cv)
        {
            try
            {
                database.Positions.Add(cv);
                database.SaveChanges();
                return cv;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Position updatePosition(Position dt)
        {
            try
            {
                //var _dt = database.Positions.SingleOrDefault(x => x.id == dt.id);
                //_dt.namePosition = dt.namePosition;
                database.SaveChanges();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void deletePosition(int id)
        {
            try
            {
                var dt = database.Positions.FirstOrDefault(x => x.id == id);
                if (dt != null)
                {
                    database.Positions.Remove(dt);
                    database.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }

    }
}
