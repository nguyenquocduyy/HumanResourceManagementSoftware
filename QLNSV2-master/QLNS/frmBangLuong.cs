using Business;
using Business.Transfer;
using DataObject;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using QLNS.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLNS
{
    public partial class frmBangLuong : DevExpress.XtraEditors.XtraForm
    {
        BusinessBangLuong bangLuong;
        List<T_BangLuong> ls_Contract;
        int id;

        public frmBangLuong()
        {
            InitializeComponent();
            bangLuong = new BusinessBangLuong();
            cbYear.Text = DateTime.Now.Year.ToString();
            cbMonth.Text = DateTime.Now.Month.ToString();
            loadData();
            customMoneyView();
            txtName.Text = "";
        }

        void customMoneyView()
        {
            GridView gridView = gvBangLuong;
            GridColumn colCurrency = gridView.Columns["salary"];
            colCurrency.DisplayFormat.Format = new CultureInfo("vi-VN");
        }

        void loadData ()
        {
            gcBangLuong.DataSource = bangLuong.getListTransfer(int.Parse(cbYear.Text) * 100 + int.Parse(cbMonth.Text));
        }

        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!bangLuong.getListTransfer(int.Parse(cbYear.Text) * 100 + int.Parse(cbMonth.Text)).Any())
            {
                bangLuong.caculator(int.Parse(cbYear.Text) * 100 + int.Parse(cbMonth.Text));
                loadData();
            }
            else
            {
                MessageBox.Show("Bảng lương tháng này đã được tạo!", "Thong bao");
            }
        }

        private void gvBangLuong_Click(object sender, EventArgs e)
        {
            if (gvBangLuong.DataRowCount != 0)
            {
                id = int.Parse(gvBangLuong.GetFocusedRowCellValue("id").ToString());
                txtMaNV.Text = gvBangLuong.GetFocusedRowCellValue("idStaff").ToString();
            }
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string code = (int.Parse(cbYear.Text) * 100 + int.Parse(cbMonth.Text)).ToString();
            ls_Contract = bangLuong.getListTransfer(int.Parse(cbYear.Text) * 100 + int.Parse(cbMonth.Text));
            RStatiscalSalary rBoardSalary = new RStatiscalSalary(ls_Contract, code);
            rBoardSalary.ShowPreviewDialog();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bangLuong.deletePayroll(int.Parse(cbYear.Text) * 100 + int.Parse(cbMonth.Text));
                loadData();
            }
        }

        private void btnPrintPayroll_Click(object sender, EventArgs e)
        {
             int code = int.Parse(cbYear.Text) * 100 + int.Parse(cbMonth.Text);
             int manv = int.Parse(txtMaNV.Text);
             ls_Contract = bangLuong.getItemTransferPrint(code, manv);
             RPayroll rContract = new RPayroll(ls_Contract);
             rContract.ShowPreviewDialog();
        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "") 
                txtName.Text = bangLuong.textchange(int.Parse(txtMaNV.Text));
            else
                txtName.Text = "";
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            gcBangLuong.DataSource = bangLuong.getListTransfer(int.Parse(cbYear.Text) * 100 + int.Parse(cbMonth.Text));
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "")
                btnPrintPayroll.Enabled = true;
            else 
                btnPrintPayroll.Enabled = false;
        }

        private void btnRenew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bangLuong.deletePayroll(int.Parse(cbYear.Text) * 100 + int.Parse(cbMonth.Text));
            bangLuong = new BusinessBangLuong();
            bangLuong.caculator(int.Parse(cbYear.Text) * 100 + int.Parse(cbMonth.Text));
            loadData();
        }
    }
}