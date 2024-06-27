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
    public partial class RStatiscalSalary : DevExpress.XtraReports.UI.XtraReport
    {
        public RStatiscalSalary()
        {
            InitializeComponent();
        }

        public string title = "";
        List<T_BangLuong> lsBoardSalaryDes;

        public RStatiscalSalary(List<T_BangLuong> lsBoardSalaryDes, string code)
        {
            InitializeComponent();
            this.lsBoardSalaryDes = lsBoardSalaryDes;
            this.DataSource = lsBoardSalaryDes;
            this.title = code;
            BindingData();
        }



        public void BindingData()
        {
            lblTitle.Text = "Bảng Lương Tháng " + title.Substring(4) + " Năm " + title.Substring(0, 4);
            xrCode.DataBindings.Add("Text", DataSource, "code");
            idStaff.DataBindings.Add("Text", DataSource, "idStaff");
            nameStaff.DataBindings.Add("Text", DataSource, "nameStaff");
            xrWordDay.DataBindings.Add("Text", DataSource, "wordDay");
            xrDayoff.DataBindings.Add("Text", DataSource, "dayOff");
            xrWithofleave.DataBindings.Add("Text", DataSource, "withofleave");
            xrTotalDayOfMonth.DataBindings.Add("Text", DataSource, "totalDayOfMonth");
            xrAllowance.DataBindings.Add("Text", DataSource, "allowance");
            xrOverTime.DataBindings.Add("Text", DataSource, "overTime");
            xrSalary.DataBindings.Add("Text", DataSource, "salary");
        }

    }
}
