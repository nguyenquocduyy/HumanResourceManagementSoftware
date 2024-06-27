using Business.Transfer;
using DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessDiscipline
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();

        public Discipline getItem(int id)
        {
            return database.Disciplines.FirstOrDefault(x => x.id == id);
        }
        public List<Discipline> getList()
        {
            return database.Disciplines.ToList();
        }
        public List<T_KyLuat> getItemTransfer(int id)
        {
            var lsNV = database.Disciplines.Where(x => x.id == id).ToList();
            List<T_KyLuat> lsHDT = new List<T_KyLuat>();
            T_KyLuat HDT;
            foreach (var item in lsNV)
            {
                HDT = new T_KyLuat();
                HDT.id = item.id;
                HDT.reason = item.reason;
                HDT.formality = item.formality;
                HDT.createAt = item.createAt;
                HDT.idStaff = item.idStaff;
                var nv = database.Staffs.FirstOrDefault(rs => rs.id == item.idStaff);
                HDT.nameStaff = nv.nameStaff;

                lsHDT.Add(HDT);
            }
            return lsHDT;
        }
        public List<T_KyLuat> getListTransfer()
        {
            var lsNV = database.Disciplines.ToList();
            List<T_KyLuat> lsHDT = new List<T_KyLuat>();
            T_KyLuat HDT;
            foreach (var item in lsNV)
            {
                HDT = new T_KyLuat();
                HDT.id = item.id;
                HDT.reason = item.reason;
                HDT.formality = item.formality;
                HDT.createAt = item.createAt;
                HDT.idStaff = item.idStaff;
                var nv = database.Staffs.FirstOrDefault(rs => rs.id == item.idStaff);
                HDT.nameStaff = nv.nameStaff;

                lsHDT.Add(HDT);
            }
            return lsHDT;
        }
        public List<T_KyLuat> getListDate(int thang, int nam)
        {
            var lsNV = database.Disciplines.Where(x => x.createAt.Value.Month == thang && x.createAt.Value.Year == nam).ToList();
            List<T_KyLuat> lsHDT = new List<T_KyLuat>();
            T_KyLuat HDT;
            foreach (var item in lsNV)
            {
                HDT = new T_KyLuat();
                HDT.id = item.id;
                HDT.reason = item.reason;
                HDT.formality = item.formality;
                HDT.createAt = item.createAt;
                HDT.idStaff = item.idStaff;
                var nv = database.Staffs.FirstOrDefault(rs => rs.id == item.idStaff);
                HDT.nameStaff = nv.nameStaff;

                lsHDT.Add(HDT);
            }
            return lsHDT;
        }

        public Discipline createDiscipline(Discipline bh)
        {
            try
            {
                database.Disciplines.Add(bh);
                database.SaveChanges();
                return bh;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Discipline updateDiscipline(Discipline bh)
        {
            try
            {
                database.SaveChanges();
                return bh;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void deleteDiscipline(int id)
        {
            try
            {
                var bh = database.Disciplines.FirstOrDefault(x => x.id == id);
                database.Disciplines.Remove(bh);
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
