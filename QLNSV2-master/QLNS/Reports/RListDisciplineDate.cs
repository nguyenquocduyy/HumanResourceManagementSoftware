using Business.Transfer;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNS.Reports
{
    public partial class RListDisciplineDate : DevExpress.XtraReports.UI.XtraReport
    {
        public RListDisciplineDate()
        {
            InitializeComponent();
        }
        List<T_KyLuat> ls_Kyluat;
        public RListDisciplineDate(List<T_KyLuat> kyluat)
        {
            InitializeComponent();
            this.ls_Kyluat = kyluat;
            this.DataSource = ls_Kyluat;
            xrLThang.Text = (ls_Kyluat[0].createAt).Value.Month.ToString();
            xrLNam.Text = (ls_Kyluat[0].createAt).Value.Year.ToString();
            loadData();
        }

        public void loadData()
        {
            lbID.DataBindings.Add("Text", ls_Kyluat, "id");
            lbTenNV.DataBindings.Add("Text", ls_Kyluat, "nameStaff");
            lbNgay.DataBindings.Add("Text", ls_Kyluat, "createAt");
            lbLydo.DataBindings.Add("Text", ls_Kyluat, "reason");
            lbHinhthuc.DataBindings.Add("Text", ls_Kyluat, "formality");
        }
    }
}
