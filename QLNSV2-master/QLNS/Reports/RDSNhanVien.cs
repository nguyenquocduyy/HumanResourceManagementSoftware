using Business.Transfer;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNS.Reports
{
    public partial class RDSNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public RDSNhanVien()
        {
            InitializeComponent();
        }
        List<T_NhanVien> lsNV;
        public RDSNhanVien(List<T_NhanVien> ls_nhanvien)
        {
            InitializeComponent();
            this.lsNV = ls_nhanvien;
            this.DataSource = lsNV;
            loadData();
        }
        public void loadData()
        {
            lbID.DataBindings.Add("Text", lsNV, "id");
            lbHoTen.DataBindings.Add("Text", lsNV, "nameStaff");
            lbGioiTinh.DataBindings.Add("Text", lsNV, "gender");
            lbNgaySinh.DataBindings.Add("Text", lsNV, "birthday");
            lbCCCD.DataBindings.Add("Text", lsNV, "identify");
            lbDienThoai.DataBindings.Add("Text", lsNV, "phone");
            lbDiaChi.DataBindings.Add("Text", lsNV, "address");
            lbDanToc.DataBindings.Add("Text", lsNV, "nameNation");
            lbPhongban.DataBindings.Add("Text", lsNV, "nameDepartment");
            lbTrinhdo.DataBindings.Add("Text", lsNV, "nameLever");
            lbChucvu.DataBindings.Add("Text", lsNV, "namePosition");
        }
    }
}