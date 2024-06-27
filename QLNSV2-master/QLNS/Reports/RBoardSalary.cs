﻿using DataObject;
using DevExpress.XtraCharts;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNS.Reports
{
    public partial class RBoardSalary : DevExpress.XtraReports.UI.XtraReport
    {
        public RBoardSalary()
        {
            InitializeComponent();
        }

        public string title = "";
        List<BoardSalaryDe> lsBoardSalaryDes;

        public RBoardSalary(List<BoardSalaryDe> lsBoardSalaryDes , string code)
        {
            InitializeComponent();
            this.lsBoardSalaryDes = lsBoardSalaryDes;
            this.DataSource = lsBoardSalaryDes;
            this.title = code;
            BindingData();
        }



        public void BindingData()
        {
            lblTitle.Text = "Bảng công tháng " + title.Substring(4) + " năm " + title.Substring(0,4);
            idStaff.DataBindings.Add("Text", DataSource, "idStaff");
            nameStaff.DataBindings.Add("Text", DataSource, "nameStaff");
            D1.DataBindings.Add("Text", DataSource, "D1");
            D2.DataBindings.Add("Text", DataSource, "D2");
            D3.DataBindings.Add("Text", DataSource, "D3");
            D4.DataBindings.Add("Text", DataSource, "D4");
            D5.DataBindings.Add("Text", DataSource, "D5");
            D6.DataBindings.Add("Text", DataSource, "D6");
            D7.DataBindings.Add("Text", DataSource, "D7");
            D8.DataBindings.Add("Text", DataSource, "D8");
            D9.DataBindings.Add("Text", DataSource, "D9");
            D10.DataBindings.Add("Text", DataSource, "D10");
            D11.DataBindings.Add("Text", DataSource, "D11");
            D12.DataBindings.Add("Text", DataSource, "D12");
            D13.DataBindings.Add("Text", DataSource, "D13");
            D14.DataBindings.Add("Text", DataSource, "D14");
            D15.DataBindings.Add("Text", DataSource, "D15");
            D16.DataBindings.Add("Text", DataSource, "D16");
            D17.DataBindings.Add("Text", DataSource, "D17");
            D18.DataBindings.Add("Text", DataSource, "D18");
            D19.DataBindings.Add("Text", DataSource, "D19");
            D20.DataBindings.Add("Text", DataSource, "D20");
            D21.DataBindings.Add("Text", DataSource, "D21");
            D22.DataBindings.Add("Text", DataSource, "D22");
            D23.DataBindings.Add("Text", DataSource, "D23");
            D24.DataBindings.Add("Text", DataSource, "D24");
            D25.DataBindings.Add("Text", DataSource, "D25");
            D26.DataBindings.Add("Text", DataSource, "D26");
            D27.DataBindings.Add("Text", DataSource, "D27");
            D28.DataBindings.Add("Text", DataSource, "D28");
            D29.DataBindings.Add("Text", DataSource, "D29");
            D30.DataBindings.Add("Text", DataSource, "D30");
            D31.DataBindings.Add("Text", DataSource, "D31");
            wordDay.DataBindings.Add("Text", DataSource, "wordDay");
            dayOff.DataBindings.Add("Text", DataSource, "dayOff");
            withoutLeave.DataBindings.Add("Text", DataSource, "withoutLeave");
            totalWordDay.DataBindings.Add("Text", DataSource, "totalWordDay");

        }
    }

}
