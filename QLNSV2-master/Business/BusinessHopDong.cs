using Business.Transfer;
using DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessContract
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();

        public Contract getItem(int id)// trả về một đt Contract dưa vào id
        {
            return database.Contracts.FirstOrDefault(x => x.id == id);
        }

        public List<Contract> getList()//trả về ds sách các Contract
        {
            return database.Contracts.ToList();
        }

        public List<T_HopDong> getItemTransfer(int id)
        {
            var lsHD = database.Contracts.Where(x => x.id == id).ToList();
            List<T_HopDong> lsHDT = new List<T_HopDong>();
            T_HopDong HDT;
            foreach (var item in lsHD)
            {

                HDT = new T_HopDong();
                HDT.id = item.id;
                HDT.contractNumber = item.contractNumber;
                HDT.signDay = item.signDay;
                HDT.mainContent = item.mainContent;
                HDT.limitation = item.limitation;
                HDT.coSalary = item.coSalary;
                HDT.signCount = item.signCount;
                HDT.salary = (double)item.salary;
                HDT.startDay = item.startDay;
                HDT.endDay = item.endDay;

                var nv = database.Staffs.FirstOrDefault(rs => rs.id == item.idStaff);
                HDT.nameStaff = nv.nameStaff;
                HDT.phone = nv.phone;
                HDT.birthday = nv.birthday.Value.ToString("dd/MM/yyyy");
                HDT.address = nv.address;
                HDT.gender = nv.gender;
                HDT.identify = nv.identify;

                lsHDT.Add(HDT);
            }
            return lsHDT;
        }

        public List<T_HopDong> getListTransfer()
        {
            var lsNV = database.Contracts.ToList();
            List<T_HopDong> lsHDT = new List<T_HopDong>();
            T_HopDong HDT;
            foreach (var item in lsNV)
            {
                HDT = new T_HopDong();
                HDT.id = item.id;
                HDT.contractNumber = item.contractNumber;
                HDT.signDay = item.signDay;
                HDT.mainContent = item.mainContent;
                HDT.limitation = item.limitation;
                HDT.coSalary = item.coSalary;
                HDT.signCount = item.signCount;
                HDT.salary = (double)item.salary;
                HDT.startDay = item.startDay;
                HDT.endDay = item.endDay;

                var nv = database.Staffs.FirstOrDefault(rs => rs.id == item.idStaff);
                HDT.nameStaff = nv.nameStaff;
                HDT.phone = nv.phone;
                HDT.birthday = nv.birthday.Value.ToString("dd/MMyyyy");
                HDT.address = nv.address;
                HDT.gender = nv.gender;
                lsHDT.Add(HDT);
            }
            return lsHDT;
        }
        public List<T_HopDong> getListExprise()
        {
            var lsHD = database.Contracts.Where(x => x.endDay < DateTime.Now).ToList();
            List<T_HopDong> lsHDT = new List<T_HopDong>();
            T_HopDong HDT;
            foreach (var item in lsHD)
            {
                HDT = new T_HopDong();
                HDT.id = item.id;
                HDT.contractNumber = item.contractNumber;
                HDT.signDay = item.signDay;
                HDT.mainContent = item.mainContent;
                HDT.limitation = item.limitation;
                HDT.coSalary = item.coSalary;
                HDT.signCount = item.signCount;
                HDT.salary = (double)item.salary;
                HDT.startDay = item.startDay;
                HDT.endDay = item.endDay;

                var nv = database.Staffs.FirstOrDefault(rs => rs.id == item.idStaff);
                HDT.nameStaff = nv.nameStaff;
                HDT.phone = nv.phone;
                HDT.birthday = nv.birthday.Value.ToString("dd/MM/yyyy");
                HDT.address = nv.address;
                HDT.gender = nv.gender;
                HDT.identify = nv.identify;
                lsHDT.Add(HDT);
            }
            return lsHDT;
        }

        public bool IsCheckMaSo(string MaSo, int? idHD = null)
        {
            if (idHD.HasValue)
            {
                return database.Contracts.Any(x => x.contractNumber == MaSo && x.id != idHD.Value);
            }
            else
            {
                return database.Contracts.Any(x => x.contractNumber == MaSo);
            }

        }
        public bool IsCheckNhanVien(int idNV, string loaiHD, int? idContract = null)
        {
            if (idContract.HasValue)
            {
                return database.Contracts.Any(x => x.idStaff == idNV && x.limitation == loaiHD && x.id != idContract.Value);
            }
            else
            {
                return database.Contracts.Any(x => x.idStaff == idNV && x.limitation == loaiHD);
            }
        }
        public Contract createContract(Contract bh)
        {
            try
            {
                database.Contracts.Add(bh);
                database.SaveChanges();
                return bh;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Contract updateContract(Contract bh)
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

        public void deleteContract(int id)
        {
            try
            {
                var bh = database.Contracts.FirstOrDefault(x => x.id == id);
                database.Contracts.Remove(bh);
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
