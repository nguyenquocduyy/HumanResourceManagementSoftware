using Business.Transfer;
using Business;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Globalization;
using DataObject;
using QLNS.Reports;
using DevExpress.XtraReports.UI;

namespace QLNS
{
    public partial class frmThongKeLuong : DevExpress.XtraEditors.XtraForm
    {

        BusinessBangLuong bangLuong;
        List<T_BangLuong> ls_Contract;
        int id;

        public frmThongKeLuong()
        {
            InitializeComponent();
            bangLuong = new BusinessBangLuong();
            cbYear.Text = DateTime.Now.Year.ToString();
            cbMonth.Text = DateTime.Now.Month.ToString();
            loadData();
            customMoneyView();

        }

        void customMoneyView()
        {
            GridView gridView = gvBangLuong;
            GridColumn colCurrency = gridView.Columns["salary"];
            colCurrency.DisplayFormat.Format = new CultureInfo("vi-VN");
        }

        void loadData()
        {
            gcBangLuong.DataSource = bangLuong.getListTransfer(int.Parse(cbYear.Text) * 100 + int.Parse(cbMonth.Text));
            
        }

        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ls_Contract = bangLuong.getListTransfer(int.Parse(cbYear.Text) * 100 + int.Parse(cbMonth.Text));

            RStatiscalSalary rBoardSalary = new RStatiscalSalary(ls_Contract, code.ToString());
            rBoardSalary.ShowPreviewDialog();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            gcBangLuong.DataSource = bangLuong.getListTransfer(int.Parse(cbYear.Text) * 100 + int.Parse(cbMonth.Text));
        }
    }
}