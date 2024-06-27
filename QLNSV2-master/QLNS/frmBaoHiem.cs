using Business;
using Business.Transfer;
using DataObject;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmBaoHiem : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoHiem()
        {
            InitializeComponent();
        }

        BusinessInsurance baoHiemB;
        BusinessNhanVienView nhanVienB;
        bool create;
        int id;

        void isDisableActions(bool x)
        {
            btnAdd.Enabled = x;
            btnEdit.Enabled = x;
            btnDelete.Enabled = x;
            btnSave.Enabled = !x;
            btnClose.Enabled = !x;
            txtNumber.Enabled = !x;
            cbTypeInsurance.Enabled = !x;
            txtAddress.Enabled = !x;
            lkNhanVien.Enabled = !x;
        }

        void isDisableActions2(bool x)
        {
            btnEdit.Enabled = x;
            btnDelete.Enabled = x;
            btnClose.Enabled = x;
        }

        private void frmBaoHiem_Load(object sender, EventArgs e)
        {
            baoHiemB = new BusinessInsurance();
            nhanVienB = new BusinessNhanVienView();
            isDisableActions(true);
            isDisableActions2(false);
            LoadData();
            LoadCombo();
            customMoneyView();
        }

        void customMoneyView()
        {
            GridView gridView = gvBaoHiem;
            GridColumn colCurrency = gridView.Columns["coverageAmount"];
            colCurrency.DisplayFormat.Format = new CultureInfo("vi-VN");
        }

        void LoadData()
        {
            gcBaoHiem.DataSource = baoHiemB.getListTransfer();
        }

        void LoadCombo()
        {
            lkNhanVien.Properties.DataSource = nhanVienB.getList();
            lkNhanVien.Properties.ValueMember = "id";
            lkNhanVien.Properties.DisplayMember = "nameStaff";

            cbTypeInsurance.DataSource = baoHiemB.getListType();
            cbTypeInsurance.ValueMember = "id";
            cbTypeInsurance.DisplayMember = "typename";

            cbTypeInsurance.SelectedIndex = -1;
        }

        void SavesData()
        {
            if (create)
            {
                Insurance baoHiem = new Insurance();
                baoHiem.insuranceCode = txtNumber.Text;
                baoHiem.place = txtAddress.Text;
                baoHiem.idStaff = int.Parse(lkNhanVien.EditValue.ToString());
                //baoHiem.monthlySalary = txtInsuranceMoney.Text;
                //baoHiem.idType = int.Parse(cbTypeInsurance.SelectedValue.ToString());
                baoHiem.idType = (int?)cbTypeInsurance.SelectedValue;
                baoHiemB.createInsurance(baoHiem);
            }
            else
            {
                var baoHiem = baoHiemB.getItem(id);
                baoHiem.insuranceCode = txtNumber.Text;
                baoHiem.place = txtAddress.Text;
                baoHiem.idStaff = int.Parse(lkNhanVien.EditValue.ToString());
                //baoHiem.monthlySalary = txtInsuranceMoney.Text;
                //baoHiem.idType = int.Parse(cbTypeInsurance.SelectedValue.ToString());
                baoHiem.idType = (int?)cbTypeInsurance.SelectedValue;
                baoHiemB.updateInsurance(baoHiem);
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isDisableActions(false);
            emptyText();
            create = true;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isDisableActions(false);
            create = false;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baoHiemB.deleteInsurance(id);
                LoadData();
                emptyText();
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber.Text) || string.IsNullOrEmpty(txtAddress.Text) || lkNhanVien.EditValue == null || cbTypeInsurance.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin và không được để trống");
                return;
            }
            if (create)
            {
                if (baoHiemB.IsCheckNumber(txtNumber.Text))
                {
                    MessageBox.Show("Số bảo hiểm đã bị trùng. Vui lòng nhập số khác.");
                    return;
                }
            }
            else
            {
                if (baoHiemB.IsCheckNumber(txtNumber.Text, id))
                {
                    MessageBox.Show("Số bảo hiểm đã tồn tại. Vui lòng nhập số khác.");
                    return;
                }
            }
            int Staffid = int.Parse(lkNhanVien.EditValue.ToString());
            int Typeid = int.Parse(cbTypeInsurance.SelectedValue.ToString());
            if (create)
            {
                if (baoHiemB.IsCheckNhanVien(Staffid, Typeid))
                {
                    MessageBox.Show("Nhân viên đã có bảo hiểm này. Vui lòng chọn nhân viên khác.");
                    return;
                }
            }
            else
            {
                if (baoHiemB.IsCheckNhanVien(Staffid, Typeid, id))
                {
                    MessageBox.Show("Nhân viên đã có bảo hiểm này. Vui lòng chọn nhân viên khác..");
                    return;
                }
            }
            SavesData();
            LoadData();
            isDisableActions(true);
            emptyText();

        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isDisableActions(true);
            isDisableActions2(false);
            emptyText();
            /*splitContainer1.Panel1Collapsed = true;*/
        }

        private void gvBaoHiem_Click(object sender, EventArgs e)
        {
            id = int.Parse(gvBaoHiem.GetFocusedRowCellValue("id").ToString());
            var bh = baoHiemB.getItem(id);
            txtNumber.Text = bh.insuranceCode.ToString();
            txtAddress.Text = bh.place.ToString();
            cbTypeInsurance.SelectedValue = bh?.idType ?? -1;
            lkNhanVien.EditValue = bh.idStaff;
            isDisableActions(true);
            btnClose.Enabled = true;
        }

        void emptyText()
        {
            txtNumber.Text = string.Empty;
            txtAddress.Text = string.Empty;
            cbTypeInsurance.SelectedIndex = -1;
            lkNhanVien.EditValue = -1;
        }
    }
}