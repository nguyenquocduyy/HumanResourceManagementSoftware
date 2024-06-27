using Business.Transfer;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNS.Reports
{
    public partial class RDiscipline : DevExpress.XtraReports.UI.XtraReport
    {
        public RDiscipline()
        {
            InitializeComponent();
        }

        List<T_KyLuat> t_KyLuat;

        public RDiscipline(List<T_KyLuat> t_KyLuats)
        {
            InitializeComponent();
            this.t_KyLuat = t_KyLuats;
            this.DataSource = this.t_KyLuat;
            LoadData();
        }

        void LoadData()
        {
            xrName.Text = t_KyLuat[0].nameStaff;
            xrReasion.Text = t_KyLuat[0].reason;
            xrFomaly.Text = t_KyLuat[0].formality;
        }

    }
}
