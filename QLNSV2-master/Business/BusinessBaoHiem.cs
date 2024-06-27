using Business.Transfer;
using DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessInsurance
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();

        public Insurance getItem(int id)
        {
            return database.Insurances.FirstOrDefault(x => x.id == id);
        }

        public List<Insurance> getList()
        {
            return database.Insurances.ToList();
        }

        public List<Insurance_Types> getListType()
        {
            return database.Insurance_Types.ToList();
        }

        public List<T_BaoHiem> getListTransfer()
        {
            /* var lsBHT = database.Insurances
                 .Select(item => new T_BaoHiem
                 {
                     id = item.id,
                     idStaff = item.idStaff,
                     idType = item.idType,
                     insuranceCode = item.insuranceCode,

                     place = item.place,
                     coverageAmount = database.Insurance_Types.FirstOrDefault(rs => rs.id == item.idType).coverageAmount,
                     nameStaff = database.Staffs.FirstOrDefault(rs => rs.id == item.idStaff).nameStaff,
                     nameType = database.Insurance_Types.FirstOrDefault(rs => rs.id == item.idType).typename
                 })
                 .ToList();

             return lsBHT;*/
            var lsBH = database.Insurances.ToList();
            List<T_BaoHiem> ls_BHT = new List<T_BaoHiem>();
            T_BaoHiem BHT;
            foreach (var item in lsBH)
            {
                BHT = new T_BaoHiem();
                BHT.id = item.id;
                BHT.idStaff = item.idStaff;
                BHT.idType = item.idType;
                BHT.insuranceCode = item.insuranceCode;
                BHT.place = item.place;
                var nv = database.Staffs.FirstOrDefault(rs => rs.id == item.idStaff);
                BHT.nameStaff = nv.nameStaff;
                var lbh = database.Insurance_Types.FirstOrDefault(rs => rs.id == item.idType);
                BHT.nameType = lbh.typename;
                BHT.coverageAmount = lbh.coverageAmount;
                ls_BHT.Add(BHT);
            }
            return ls_BHT;
        }

        public bool IsCheckNumber(string number, int? idInsurance = null)
        {
            if (idInsurance.HasValue)
            {
                return database.Insurances.Any(x => x.insuranceCode == number && x.id != idInsurance.Value);
            }
            else
            {
                return database.Insurances.Any(x => x.insuranceCode == number);
            }
        }

        public bool IsCheckNhanVien(int idNV, int idTyeBH, int? idInsurance = null)
        {
            if (idInsurance.HasValue)
            {
                return database.Insurances.Any(x => x.idStaff == idNV && x.idType == idTyeBH && x.id != idInsurance.Value);
            }
            else
            {
                return database.Insurances.Any(x => x.idStaff == idNV && x.idType == idTyeBH);
            }
        }
        public Insurance createInsurance(Insurance bh)
        {
            try
            {
                database.Insurances.Add(bh);
                database.SaveChanges();
                return bh;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Insurance updateInsurance(Insurance bh)
        {
            try
            {
                var bhd = database.Insurances.FirstOrDefault(x => x.id == bh.id);
                database.SaveChanges();
                return bh;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void deleteInsurance(int id)
        {
            try
            {
                var bh = database.Insurances.FirstOrDefault(x => x.id == id);
                database.Insurances.Remove(bh);
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
