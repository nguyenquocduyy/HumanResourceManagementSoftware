using Business;
using Business.Transfer;
using DataObject;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using QLNS.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLNS
{
    public partial class frmHopDong : DevExpress.XtraEditors.XtraForm
    {
        public frmHopDong()
        {
            InitializeComponent();


        }
        BusinessContract contractB;
        BusinessNhanVienView staffB;
        BusinessAllowance businessAllowance;
        bool create;
        int id;
        List<T_HopDong> ls_Contract;


        private void frmHopDong_Load(object sender, EventArgs e)
        {
            contractB = new BusinessContract();
            staffB = new BusinessNhanVienView();
            businessAllowance = new BusinessAllowance();
            IsDisableActions(true);
            LoadData();
            LoadCombo();
            splitContainer1.Panel1Collapsed = true;
            customMoneyView();
            /*chkAllowance.ShowPopup();*/
            dtpkEndDay.Enabled = false;
            AddExpiredColumn();
            CbLoaiHD.SelectedIndex = 0;
        }

        void customMoneyView()
        {
            GridView gridView = gvHopDong;
            GridColumn colCurrency = gridView.Columns["salary"];
            colCurrency.DisplayFormat.Format = new CultureInfo("vi-VN");
        }

        void LoadData()
        {
            gcHopDong.DataSource = contractB.getListTransfer();
            IsDisableActions2(false);
        }

        void LoadCombo()
        {
            lkNhanVien.Properties.DataSource = staffB.getList();
            lkNhanVien.Properties.ValueMember = "id";
            lkNhanVien.Properties.DisplayMember = "nameStaff";

            /*chkAllowance.Properties.DataSource = businessAllowance.getList();
            chkAllowance.Properties.ValueMember = "id";
            chkAllowance.Properties.DisplayMember = "nameAllowance";*/
        }

        void IsDisableActions(bool kt)
        {
            BtnSave.Enabled = !kt;
            BtnClose.Enabled = !kt;
            BtnAdd.Enabled = kt;
            BtnEdit.Enabled = kt;
            BtnDelete.Enabled = kt;
            BtnPrint.Enabled = kt;
            txtMaHD.Enabled = !kt;
            CbLoaiHD.Enabled = !kt;
            spCountSign.Enabled = !kt;
            lkNhanVien.Enabled = !kt;
            txtSalary.Enabled = !kt;
            /*chkAllowance.Enabled = !kt;*/
            dtpkSignDay.Enabled = !kt;
            dtpkStartDay.Enabled = !kt;
            dtpkEndDay.Enabled = !kt;
        }

        void IsDisableActions2(bool kt)
        {
            BtnClose.Enabled = kt;
            BtnEdit.Enabled = kt;
            BtnDelete.Enabled = kt;
            BtnPrint.Enabled = kt;
        }

        void SavesData()
        {
            /*DateTime startDate = DateTime.Now;
            DateTime endDate = startDate.AddMonths(6);*/
            if (create)
            {
                /*var selectedValues = chkAllowance.Properties.GetItems().GetCheckedValues();

                foreach (var value in selectedValues)
                {
                    DataObject.StaffJoinAllowance staffJoinAllowance = new DataObject.StaffJoinAllowance();
                    staffJoinAllowance.idStaff = int.Parse(lkNhanVien.EditValue.ToString());
                    staffJoinAllowance.idAllowance = (int?)value;
                    businessAllowance.createAllowanceStaff(staffJoinAllowance);
                }*/
                DataObject.Contract contract = new DataObject.Contract();
                contract.contractNumber = txtMaHD.Text;
                contract.contractNumber = txtMaHD.Text;
                contract.signDay = dtpkSignDay.Value;
                contract.startDay = dtpkStartDay.Value;
                contract.endDay = dtpkEndDay.Value;
                //contract.mainContent = rxtNoiDung.RtfText;
                contract.signCount = int.Parse(spCountSign.Text);
                contract.limitation = CbLoaiHD.SelectedItem.ToString();
                contract.idStaff = int.Parse(lkNhanVien.EditValue.ToString());
                contract.salary = double.Parse(txtSalary.EditValue.ToString());
                contractB.createContract(contract);
            }
            else
            {
                /*var selectedValues = chkAllowance.Properties.GetItems().GetCheckedValues();

                foreach (var value in selectedValues)
                {
                    DataObject.StaffJoinAllowance pcnv = new DataObject.StaffJoinAllowance();
                    pcnv.idStaff = int.Parse(lkNhanVien.EditValue.ToString());
                    pcnv.idAllowance = (int?)value;
                    businessAllowance.updateAllowanceStaff(pcnv);
                }*/
                var contract = contractB.getItem(id);
                contract.contractNumber = txtMaHD.Text;
                contract.signDay = dtpkSignDay.Value;
                contract.startDay = dtpkStartDay.Value;
                contract.endDay = dtpkEndDay.Value;
                //contract.mainContent = rxtNoiDung.RtfText;
                contract.signCount = int.Parse(spCountSign.Text);
                contract.limitation = CbLoaiHD.SelectedItem.ToString();
                contract.idStaff = int.Parse(lkNhanVien.EditValue.ToString());
                contract.salary = double.Parse(txtSalary.EditValue.ToString());
                contractB.updateContract(contract);
            }
        }

        private void BtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(false);
            create = true;
            resetText();
            splitContainer1.Panel1Collapsed = false;
        }

        private void BtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(false);
            create = false;
        }

        private void BtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                contractB.deleteContract(id);
                LoadData();
                resetText();
            }
        }

        private void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text) || string.IsNullOrEmpty(txtSalary.Text) || spCountSign.Text == null || lkNhanVien.EditValue == null || CbLoaiHD.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin và không được để trống");
                return;
            }
            if (Regex.IsMatch(txtSalary.Text, "[^0-9]+"))
            {
                MessageBox.Show("Lương không được nhập chữ và ký tự đặc biệt");
                return;
            }
            if (create)
            {
                if (contractB.IsCheckMaSo(txtMaHD.Text))
                {
                    MessageBox.Show("Số hợp đồng đã bị trùng. Vui lòng nhập số khác.");
                    return;
                }
            }
            else
            {
                if (contractB.IsCheckMaSo(txtMaHD.Text, id))
                {
                    MessageBox.Show("Số hợp đồng đã bị trùng. Vui lòng nhập số khác.");
                    return;
                }
            }
            if (dtpkStartDay.Value < dtpkSignDay.Value)
            {
                MessageBox.Show("Ngày bắt đầu không thể nhỏ hơn ngày ký.");
                return;
            }
            SavesData();
            LoadData();
            IsDisableActions(true);
        }

        private void BtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(true);
            splitContainer1.Panel1Collapsed = true;
            IsDisableActions2(false);
            resetText();
        }

        private void gvHopDong_Click(object sender, EventArgs e)
        {
            id = int.Parse(gvHopDong.GetFocusedRowCellValue("id").ToString());
            var nv = contractB.getItem(id);

            /*var lsst = businessAllowance.getItemStaffAllowance((int)nv.idStaff);

            foreach (CheckedListBoxItem item in chkAllowance.Properties.Items)
            {
                item.CheckState = CheckState.Unchecked;
            }
            foreach (var allowance in lsst)
            {
                var item = chkAllowance.Properties.Items[allowance];

                if (item != null)
                {
                    item.CheckState = CheckState.Checked;
                }
            }*/

            txtMaHD.Text = nv.id.ToString();
            CbLoaiHD.SelectedItem = nv.limitation;
            spCountSign.Text = nv.signCount.ToString();
            lkNhanVien.EditValue = nv.idStaff;
            dtpkStartDay.Value = nv.startDay.Value;
            dtpkSignDay.Value = nv.signDay.Value;
            dtpkEndDay.Value = nv.endDay.Value;
            txtSalary.Text = nv.salary.ToString();
            ls_Contract = contractB.getItemTransfer(id);
            IsDisableActions(true);
            splitContainer1.Panel1Collapsed = false;
            BtnClose.Enabled = true;
        }

        private void BtnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ls_Contract = contractB.getItemTransfer(id);
            RContract rContract = new RContract(ls_Contract);
            rContract.ShowPreviewDialog();
        }

        void resetText()
        {
            txtMaHD.Text = string.Empty;
            lkNhanVien.EditValue = -1;
            spCountSign.EditValue = string.Empty;
            txtSalary.Text = string.Empty;
            dtpkSignDay.Value = DateTime.Now;
            dtpkStartDay.Value = DateTime.Now;
            dtpkEndDay.Value = DateTime.Now;
        }

        private void chkAllowance_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpkStartDay_ValueChanged(object sender, EventArgs e)
        {
            string thoihan = CbLoaiHD.SelectedItem.ToString();
            switch (thoihan)
            {
                case "6 tháng":
                    dtpkEndDay.Value = dtpkStartDay.Value.AddMonths(6);
                    break;
                case "1 năm":
                    dtpkEndDay.Value = dtpkStartDay.Value.AddYears(1);
                    break;
                case "2 năm":
                    dtpkEndDay.Value = dtpkStartDay.Value.AddYears(2);
                    break;
            }
        }
        void AddExpiredColumn()
        {
            GridView gridView = gvHopDong;
            GridColumn colExpired = new GridColumn
            {
                Caption = "Trạng thái hạn hợp đồng",
                FieldName = "IsExpired",
                Visible = true,
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Name = "colExpired"
            };
            gridView.Columns.Add(colExpired);
            gridView.CustomUnboundColumnData += gvHopDong_CustomUnboundColumnData;
        }

        private void gvHopDong_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "IsExpired" && e.IsGetData)
            {
                var contract = e.Row as T_HopDong;
                if (contract.endDay < DateTime.Now)
                {
                    e.Value = "Hết hạn";
                }
                else
                {
                    e.Value = "Chưa hết hạn";
                }
            }
        }

        private void btnGiaHan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnAdd.Enabled = false;
            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSave.Enabled = true;
            dtpkStartDay.Enabled = true;
            dtpkEndDay.Enabled = true;
            dtpkSignDay.Enabled = true;
            var contract = contractB.getItem(id);
            if (contract.endDay > DateTime.Now)
            {
                MessageBox.Show("Hợp đồng này chưa hết hạn");
                return;
            }
            create = false;
            dtpkSignDay.Value = DateTime.Now;
            spCountSign.Value = spCountSign.Value + 1;
            
        }
    }
}