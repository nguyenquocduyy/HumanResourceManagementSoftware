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
    public class BusinessNangLuong
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();

        public NangLuong getItem(int id)//trả về một đt Staff dựa trên id 
        {
            return database.NangLuongs.FirstOrDefault(x => x.id == id);
        }

        public List<NangLuong> getList()//trả về một danh sách bảng Staff 
        {
            return database.NangLuongs.ToList();
        }     
        public List<T_NangLuong> getListTransfer()
        {
            var lsNV = database.NangLuongs.ToList();
            List<T_NangLuong> lsNVT = new List<T_NangLuong>();
            T_NangLuong NVT;
            foreach (var item in lsNV)
            {
                NVT = new T_NangLuong();
                NVT.id = item.id;
                NVT.signDay = item.signDay;
                NVT.SoQD = item.SoQD;
                NVT.upDay = item.upDay;
                NVT.GhiChu = item.GhiChu;
                NVT.LuongHienTai = item.LuongHienTai;
                NVT.LuongMoi = item.LuongMoi;
                NVT.idStaff = item.idStaff;
                NVT.idContract = item.idContract;
   
                var nv = database.Staffs.FirstOrDefault(rs => rs.id == item.idStaff);
                NVT.nameStaff = nv.nameStaff;
                lsNVT.Add(NVT);
            }
            return lsNVT;
        }     
        //tạo mới một đt Staff
        public NangLuong createNangLuong(NangLuong dt)
        {
            try
            {
                database.NangLuongs.Add(dt);
                database.SaveChanges();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public NangLuong updateNangLuong(NangLuong dt)
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

        public void deleteNangLuong(int id)
        {
            try
            {
                var dt = database.NangLuongs.FirstOrDefault(x => x.id == id);
                database.NangLuongs.Remove(dt);
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
