using Business.Transfer;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Import.WordML;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNS.Reports
{
    public partial class RContract : DevExpress.XtraReports.UI.XtraReport
    {
        public RContract()
        {
            InitializeComponent();
        }
        List<T_HopDong> contract;
        public RContract(List<T_HopDong> hd)
        {
            InitializeComponent();
            this.contract = hd;
            this.DataSource = this.contract;
            LoadData();
        }

        void LoadData()
        {
            xrLLuong.Text = (contract[0].salary - 5100000).ToString();
            xrLThoihan.Text = (contract[0].limitation).ToString();
            xrLNgayBD.Text = (contract[0].startDay).Value.ToString("dd/MM/yyyy");
            xrLNgayKT.Text = (contract[0].endDay).Value.ToString("dd/MM/yyyy");
        }



    }
}
