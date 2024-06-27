using Business.Transfer;
using DataObject;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNS.Reports
{
    public partial class RReward : DevExpress.XtraReports.UI.XtraReport
    {
        public RReward()
        {
            InitializeComponent();
        }

        List<T_KhenThuong> t_KhenThuong;

        public RReward(List<T_KhenThuong> t_KhenThuongs)
        {
            InitializeComponent();
            this.t_KhenThuong = t_KhenThuongs;
            this.DataSource = this.t_KhenThuong;
            LoadData();
        }

        void LoadData()
        {
            xrIdStaff.Text = t_KhenThuong[0].idStaff.ToString();
            xrName.Text = t_KhenThuong[0].nameStaff;
            xrReasion.Text = t_KhenThuong[0].reason;
            xrFomaly.Text = t_KhenThuong[0].formality;
            xrDate.Text = " ngày "+t_KhenThuong[0].createAt.Value.ToString("dd/MM/yyyy").Substring(0,2)+ " tháng "+t_KhenThuong[0].createAt.Value.ToString("dd/MM/yyyy").Substring(3,2)+ " năm "+t_KhenThuong[0].createAt.Value.ToString("dd/MM/yyyy").Substring(6);
        }

    }
}
