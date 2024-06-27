using Business.Transfer;
using DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessPhuCapNhanVien
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();

        public StaffJoinAllowance getItem(int id)
        {
            return database.StaffJoinAllowances.FirstOrDefault(x => x.id == id);
        }

        public List<StaffJoinAllowance> getList()
        {
            return database.StaffJoinAllowances.ToList();
        }
        public List<T_PhuCap> getListTransfer()
        {          
            var lsBH = database.StaffJoinAllowances.ToList();
            List<T_PhuCap> ls_BHT = new List<T_PhuCap>();
            T_PhuCap BHT;
            foreach (var item in lsBH)
            {
                BHT = new T_PhuCap();
                BHT.id = item.id;
                BHT.idStaff = item.idStaff;
                var nv = database.Staffs.FirstOrDefault(rs => rs.id == item.idStaff);
                BHT.nameStaff = nv.nameStaff;
                BHT.idAllowance = item.idAllowance;
                var lbh = database.Allowances.FirstOrDefault(rs => rs.id == item.idAllowance);
                BHT.nameType = lbh.nameAllowance;
                BHT.money = lbh.money;
                ls_BHT.Add(BHT);
            }
            return ls_BHT;
        }
        public bool IsCheckNhanVien(int idNV, int idPC, int? idPCNV = null)
        {
            if (idPCNV.HasValue)
            {
                return database.StaffJoinAllowances.Any(x => x.idStaff == idNV && x.idAllowance == idPC && x.id != idPCNV.Value);
            }
            else
            {
                return database.StaffJoinAllowances.Any(x => x.idStaff == idNV && x.idAllowance == idPC);
            }
        }
        public StaffJoinAllowance createStaffAllowance(StaffJoinAllowance bh)
        {
            try
            {
                database.StaffJoinAllowances.Add(bh);
                database.SaveChanges();
                return bh;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public StaffJoinAllowance updateStaffAllowance(StaffJoinAllowance bh)
        {
            try
            {
                var bhd = database.StaffJoinAllowances.FirstOrDefault(x => x.id == bh.id);
                database.SaveChanges();
                return bh;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void deleteStaffAllowance(int id)
        {
            try
            {
                var bh = database.StaffJoinAllowances.FirstOrDefault(x => x.id == id);
                database.StaffJoinAllowances.Remove(bh);
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
