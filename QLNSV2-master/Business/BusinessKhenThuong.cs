using Business.Transfer;
using DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessReward
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();

        public Reward getItem(int id)
        {
            return database.Rewards.FirstOrDefault(x => x.id == id);
        }
        public List<T_KhenThuong> getItemTransfer(int id)
        {
            var lsNV = database.Rewards.Where(x => x.id == id).ToList();
            List<T_KhenThuong> lsHDT = new List<T_KhenThuong>();
            T_KhenThuong HDT;
            foreach (var item in lsNV)
            {
                HDT = new T_KhenThuong();
                HDT.id = item.id;
                HDT.reason = item.reason;
                HDT.formality = item.formality;
                HDT.createAt = item.createAt;/*"Từ ngày" + item.createAt.Value.ToString("dd/MM/yyyy").Substring(0,2) +"tháng" + item.createAt.Value.ToString("dd/MM/yyyy").Substring(0, 2)+ "năm" + item.createAt.Value.ToString("dd /MM/yyyy").Substring(0,2)*/
                HDT.idStaff = item.idStaff;
                var nv = database.Staffs.FirstOrDefault(rs => rs.id == item.idStaff);
                HDT.nameStaff = nv.nameStaff;

                lsHDT.Add(HDT);
            }
            return lsHDT;
        }
        public List<Reward> getList()
        {
            return database.Rewards.ToList();
        }

        public List<T_KhenThuong> getListTransfer()
        {
            var lsNV = database.Rewards.ToList();
            List<T_KhenThuong> lsHDT = new List<T_KhenThuong>();
            T_KhenThuong HDT;
            foreach (var item in lsNV)
            {
                HDT = new T_KhenThuong();
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
        public List<T_KhenThuong> getListDate(int thang, int nam)
        {
            var lsNV = database.Rewards.Where(x => x.createAt.Value.Month == thang && x.createAt.Value.Year == nam).ToList();
            List<T_KhenThuong> lsHDT = new List<T_KhenThuong>();
            T_KhenThuong HDT;
            foreach (var item in lsNV)
            {
                HDT = new T_KhenThuong();
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

        public Reward createReward(Reward bh)
        {
            try
            {
                database.Rewards.Add(bh);
                database.SaveChanges();
                return bh;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Reward updateReward(Reward bh)
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

        public void deleteReward(int id)
        {
            try
            {
                var bh = database.Rewards.FirstOrDefault(x => x.id == id);
                database.Rewards.Remove(bh);
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
