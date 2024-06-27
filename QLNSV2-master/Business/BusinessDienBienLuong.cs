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
    public class BusinessDienBienLuong
    {
        QL_NHANSUEntities database = new QL_NHANSUEntities();
        public DienBienNangLuong getItem(int id)//trả về một đt Staff dựa trên id 
        {
            return database.DienBienNangLuongs.FirstOrDefault(x => x.id == id);
        }

        public List<DienBienNangLuong> getList()//trả về một danh sách bảng Staff 
        {
            return database.DienBienNangLuongs.ToList();
        }
        public List<T_DienBienLuong> getListTransfer()
        {
            var lsNV = database.DienBienNangLuongs.ToList();
            List<T_DienBienLuong> lsNVT = new List<T_DienBienLuong>();
            T_DienBienLuong NVT;
            foreach (var item in lsNV)
            {
                NVT = new T_DienBienLuong();
                NVT.id = item.id;
                NVT.idNangLuong = item.idNangLuong;
                var nv = database.NangLuongs.FirstOrDefault(rs => rs.id == item.idNangLuong);
                NVT.signDay = nv.signDay;
                lsNVT.Add(NVT);
            }
            return lsNVT;
        }
        public DienBienNangLuong createDienBienLuong(DienBienNangLuong dt)
        {
            try
            {
                database.DienBienNangLuongs.Add(dt);
                database.SaveChanges();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DienBienNangLuong updateDienBienLuong(DienBienNangLuong dt)
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

        public void deleteDienBienLuong(int id)
        {
            try
            {
                var dt = database.DienBienNangLuongs.FirstOrDefault(x => x.id == id);
                database.DienBienNangLuongs.Remove(dt);
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : " + ex.Message);
            }
        }
    }
}
