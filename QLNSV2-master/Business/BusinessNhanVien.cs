using Business.Transfer;
using DataObject;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessStaff
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();

        public Staff getItem(int id)//trả về một đt Staff dựa trên id 
        {
            return database.Staffs.FirstOrDefault(x => x.id == id);
        }

        public List<Staff> getList()//trả về một danh sách bảng Staff 
        {
            return database.Staffs.ToList();
        }

        public List<T_NhanVien> getListTransfer()
        {
            var lsNV = database.Staffs.ToList();
            List<T_NhanVien> lsNVT = new List<T_NhanVien>();
            T_NhanVien NVT;
            foreach (var item in lsNV)
            {           
                NVT = new T_NhanVien();
                NVT.id = item.id;
                NVT.nameStaff = item.nameStaff;
                NVT.gender = item.gender;
                NVT.address = item.address;
                NVT.identify = item.identify;
                NVT.phone = item.phone;
                NVT.image = item.image;
                NVT.birthday = item.birthday;
                NVT.status = item.status;
                NVT.maritalStatus = item.maritalStatus;
                NVT.bankNumber = item.bankNumber;
                NVT.idPosition = item.idPosition;
                NVT.idLever = item.idLever;
                NVT.idNation = item.idNation;
                NVT.idRoom = item.idRoom;
                
                var pb = database.Departments.FirstOrDefault(rs => rs.id == item.idRoom);
                NVT.nameDepartment = pb?.nameDepartment ?? "";
                var cv = database.Positions.FirstOrDefault(rs => rs.id == item.idPosition);
                NVT.namePosition = cv?.namePosition ?? "";
                var td = database.Levers.FirstOrDefault(rs => rs.id == item.idLever);
                NVT.nameLever = td?.nameLever ?? "";
                var dt = database.Nations.FirstOrDefault(rs => rs.id == item.idNation);
                NVT.nameNation = dt?.nameNation ?? "";

                lsNVT.Add(NVT);
            }
            return lsNVT;
        }
        public bool IsCheckCCCD(string cccd, int? id = null)
        {
            if (id.HasValue)
            {
                return database.Staffs.Any(x => x.identify == cccd && x.id != id.Value);
            }
            else
            {
                return database.Staffs.Any(s => s.identify == cccd);
            }
        }
        //in danh sách nhân viên thôi việc
        public List<T_NhanVien> getListStaffStop()
        {
            var lsNV = database.Staffs.Where(s => s.status == false).ToList(); 
            List<T_NhanVien> lsNVT = new List<T_NhanVien>();
            T_NhanVien NVT;
            foreach (var item in lsNV)
            {
                NVT = new T_NhanVien();
                NVT.id = item.id;
                NVT.nameStaff = item.nameStaff;
                NVT.gender = item.gender;
                NVT.address = item.address;
                NVT.identify = item.identify;
                NVT.phone = item.phone;
                NVT.image = item.image;
                NVT.birthday = item.birthday;
                NVT.status = item.status;
                NVT.maritalStatus = item.maritalStatus;
                NVT.idPosition = item.idPosition;
                NVT.idLever = item.idLever;
                NVT.idNation = item.idNation;
                NVT.idRoom = item.idRoom;

                var pb = database.Departments.FirstOrDefault(rs => rs.id == item.idRoom);
                NVT.nameDepartment = pb?.nameDepartment ?? "";
                var cv = database.Positions.FirstOrDefault(rs => rs.id == item.idPosition);
                NVT.namePosition = cv?.namePosition ?? "";
                var td = database.Levers.FirstOrDefault(rs => rs.id == item.idLever);
                NVT.nameLever = td?.nameLever ?? "";
                var dt = database.Nations.FirstOrDefault(rs => rs.id == item.idNation);
                NVT.nameNation = dt?.nameNation ?? "";

                lsNVT.Add(NVT);
            }
            return lsNVT;
        }
        //tạo mới một đt Staff
        public Staff createStaff(Staff dt)
        {
            try
            {
                database.Staffs.Add(dt);
                database.SaveChanges();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Staff updateStaff(Staff dt)
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

        public void deleteStaff(int id)
        {
            try
            {
                var dt = database.Staffs.FirstOrDefault(x => x.id == id);
                database.Staffs.Remove(dt);
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }


    }
}
