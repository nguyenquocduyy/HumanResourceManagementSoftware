using Business.Transfer;
using DataObject;
using DevExpress.Schedule;
using DevExpress.XtraCharts;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNS.Reports
{
    public partial class RPayroll : DevExpress.XtraReports.UI.XtraReport
    {
        public RPayroll()
        {
            InitializeComponent();
        }
        List<T_BangLuong> contract;
        public RPayroll(List<T_BangLuong> hd)
        {
            InitializeComponent();
            this.contract = hd;
            this.DataSource = this.contract;
            BindingData();
        }

        public void BindingData()
        {
            string title = contract[0].code.ToString();
            lblTitle.Text = "PHIẾU LƯƠNG THÁNG " + title.Substring(4) + "/" + title.Substring(0, 4);
            xrIdStaff.DataBindings.Add("Text", DataSource, "idStaff");
            xrName.DataBindings.Add("Text", DataSource, "nameStaff");
            xrDepartment.DataBindings.Add("Text", DataSource, "nameDepartment");
            xrtotalDayOfMonth.DataBindings.Add("Text", DataSource, "totalDayOfMonth");
            xrDayOff.DataBindings.Add("Text", DataSource, "dayOff");
            withofleave.DataBindings.Add("Text", DataSource, "withofleave");
            xrAllowance.DataBindings.Add("Text", DataSource, "allowance");
            xrPosition.DataBindings.Add("Text", DataSource, "namePosition");
            xrSTK.DataBindings.Add("Text", DataSource, "bankNumber");
            xrBasicSalary.DataBindings.Add("Text", DataSource, "basicSalary");
            xrOTCount.DataBindings.Add("Text", DataSource, "overTime");
            var salary = contract[0].salary;
            xrSalary.Text = Math.Round((double)salary, 0).ToString();
            var totalSalaryAllowance = contract[0].allowance + contract[0].totalSalary;
            xrTotalSalary.Text = totalSalaryAllowance.ToString();
            var workDay = contract[0].totalDayOfMonth - contract[0].withofleave;
            xrWordDay.Text = workDay.ToString();
            double basicSalary = (double)contract[0].basicSalary;
            xrInsurance.Text = (basicSalary * 0.105).ToString();
            caculator.Text = (contract[0].totalSalary - basicSalary).ToString();
            double salaryOneDay = (double)totalSalaryAllowance / (double)contract[0].totalDayOfMonth;
            double salaryNoOT = salaryOneDay * (double)workDay;
            double otSalary = (double)salary + (basicSalary * 0.105) - salaryNoOT;
            xrOverTime.Text = Math.Round((double)otSalary, 0).ToString();
        }
    }
}
