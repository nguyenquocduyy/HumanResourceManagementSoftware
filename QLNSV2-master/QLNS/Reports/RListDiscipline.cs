using Business.Transfer;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNS.Reports
{
    public partial class RListDiscipline : DevExpress.XtraReports.UI.XtraReport
    {
        public RListDiscipline()
        {
            InitializeComponent();
        }
        List<T_KyLuat> ls_Kyluat;
        public RListDiscipline(List<T_KyLuat> kyluat)
        {
            InitializeComponent();
            this.ls_Kyluat = kyluat;
            this.DataSource = ls_Kyluat;
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
