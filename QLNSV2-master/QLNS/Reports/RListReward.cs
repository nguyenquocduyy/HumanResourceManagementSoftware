using Business.Transfer;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNS.Reports
{
    public partial class RListReward : DevExpress.XtraReports.UI.XtraReport
    {
        public RListReward()
        {
            InitializeComponent();
        }
        List<T_KhenThuong> ls_KhenThuong;
        public RListReward(List<T_KhenThuong> khenthuong)
        {
            InitializeComponent();
            this.ls_KhenThuong = khenthuong;
            this.DataSource = ls_KhenThuong;
            loadData();
        }
        public void loadData()
        {
            lbID.DataBindings.Add("Text", ls_KhenThuong, "id");
            lbTenNV.DataBindings.Add("Text", ls_KhenThuong, "nameStaff");
            lbNgay.DataBindings.Add("Text", ls_KhenThuong, "createAt");
            lbLydo.DataBindings.Add("Text", ls_KhenThuong, "reason");
            lbHinhthuc.DataBindings.Add("Text", ls_KhenThuong, "formality");
        }
    }
}
