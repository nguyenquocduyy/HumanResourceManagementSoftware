using Business.Transfer;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNS.Reports
{
    public partial class RDSDieuChuyen : DevExpress.XtraReports.UI.XtraReport
    {
        public RDSDieuChuyen()
        {
            InitializeComponent();
        }
        List<T_DieuChuyen> lsDC;
        public RDSDieuChuyen(List<T_DieuChuyen> dieuchuyen)
        {
            InitializeComponent();
            this.lsDC = dieuchuyen;
            this.DataSource = lsDC;
            loadData();
        }
        public void loadData()
        {
            lbMa.DataBindings.Add("Text", lsDC, "id");
            lbSo.DataBindings.Add("Text", lsDC, "SoDC");
            lbTenNV.DataBindings.Add("Text", lsDC, "nameStaff");
            lbNgayKy.DataBindings.Add("Text", lsDC, "createDay");
            lbPhongHT.DataBindings.Add("Text", lsDC, "nameDepartment");
            lbPhongMoi.DataBindings.Add("Text", lsDC, "nameDepartment2");
            lbLydo.DataBindings.Add("Text", lsDC, "Lydo");
            lbGhichu.DataBindings.Add("Text", lsDC, "Ghichu");
        }
    }
}
