using Business.Transfer;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNS.Reports
{
    public partial class RDSNhanVienNghiViec : DevExpress.XtraReports.UI.XtraReport
    {
        public RDSNhanVienNghiViec()
        {
            InitializeComponent();
        }
        List<T_NhanVien> ls_NhanVien;
        public RDSNhanVienNghiViec(List<T_NhanVien> nhanvien)
        {
            InitializeComponent();
            this.ls_NhanVien = nhanvien;
            this.DataSource = ls_NhanVien;
            loadData();
        }
        public void loadData()
        {
            lbID.DataBindings.Add("Text", ls_NhanVien, "id");
            lbHoTen.DataBindings.Add("Text", ls_NhanVien, "nameStaff");
            lbGioiTinh.DataBindings.Add("Text", ls_NhanVien, "gender");
            lbNgaySinh.DataBindings.Add("Text", ls_NhanVien, "birthday");
            lbCCCD.DataBindings.Add("Text", ls_NhanVien, "identify");
            lbDienThoai.DataBindings.Add("Text", ls_NhanVien, "phone");
            lbDiaChi.DataBindings.Add("Text", ls_NhanVien, "address");
            lbDanToc.DataBindings.Add("Text", ls_NhanVien, "nameNation");
            lbPhongban.DataBindings.Add("Text", ls_NhanVien, "nameDepartment");
            lbTrinhdo.DataBindings.Add("Text", ls_NhanVien, "nameLever");
            lbChucvu.DataBindings.Add("Text", ls_NhanVien, "namePosition");
        }
    }
}
