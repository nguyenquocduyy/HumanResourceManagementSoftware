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
    public class BusinessDieuChuyen
    {

        QL_NHANSUEntities database = new QL_NHANSUEntities();

        public DieuChuyen getItem(int id)//trả về một đt Staff dựa trên id 
        {
            return database.DieuChuyens.FirstOrDefault(x => x.id == id);
        }

        public List<DieuChuyen> getList()//trả về một danh sách bảng Staff 
        {
            return database.DieuChuyens.ToList();
        }

        public List<T_DieuChuyen> getListTransfer()
        {
            var lsNV = database.DieuChuyens.ToList();
            List<T_DieuChuyen> lsNVT = new List<T_DieuChuyen>();
            T_DieuChuyen NVT;
            foreach (var item in lsNV)
            {
                NVT = new T_DieuChuyen();
                NVT.id = item.id;
                NVT.SoDC = item.SoDC;
                NVT.createDay = item.createDay;
                NVT.Ghichu = item.Ghichu;
                NVT.Lydo = item.Lydo;
                NVT.idStaff = item.idStaff;
                var nv = database.Staffs.FirstOrDefault(rs => rs.id == item.idStaff);
                NVT.nameStaff = nv.nameStaff;
                NVT.idRoom = item.idRoom;
                NVT.idRoom2 = item.idRoom2;

                var pb = database.Departments.FirstOrDefault(rs => rs.id == item.idRoom);
                NVT.nameDepartment = pb.nameDepartment;
                
                var pb2 = database.Departments.FirstOrDefault(rs => rs.id == item.idRoom2);
                NVT.nameDepartment2= pb2.nameDepartment;
                lsNVT.Add(NVT);
            }
            return lsNVT;
        }     
        public bool IsCheckSoDC(string MaSoDC, int? idDC=null)
        {
            if (idDC.HasValue)
            {
                return database.DieuChuyens.Any(x => x.SoDC == MaSoDC && x.id != idDC.Value);
            }
            else
            {
                return database.DieuChuyens.Any(x => x.SoDC == MaSoDC);
            }

        }
        //tạo mới một đt Staff
        public DieuChuyen createDC(DieuChuyen dt)
        {
            try
            {
                database.DieuChuyens.Add(dt);
                database.SaveChanges();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DieuChuyen updateDC(DieuChuyen dt)
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

        public void deleteDC(int id)
        {
            try
            {
                var dt = database.DieuChuyens.FirstOrDefault(x => x.id == id);
                database.DieuChuyens.Remove(dt);
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }

}
