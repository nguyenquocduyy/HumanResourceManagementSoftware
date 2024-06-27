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
    public partial class frmPhuCapNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmPhuCapNhanVien()
        {
            InitializeComponent();
        }
        BusinessPhuCapNhanVien phuCapNVB;
        BusinessNhanVienView nhanVienB;
        BusinessAllowance phuCapB;
        bool create;
        int id;

        void isDisableActions(bool x)
        {
            btnAdd.Enabled = x;
            btnEdit.Enabled = x;
            btnDelete.Enabled = x;
            btnSave.Enabled = !x;
            btnClose.Enabled = !x;
            cbAllowance.Enabled = !x;
            lkNhanVien.Enabled = !x;
        }

        void isDisableActions2(bool x)
        {
            btnEdit.Enabled = x;
            btnDelete.Enabled = x;
            btnClose.Enabled = x;
        }
        private void frmPhuCapNhanVien_Load(object sender, EventArgs e)
        {
            phuCapB = new BusinessAllowance();
            phuCapNVB = new BusinessPhuCapNhanVien();
            nhanVienB = new BusinessNhanVienView();
            isDisableActions(true);
            isDisableActions2(false);
            LoadData();
            LoadCombo();
        }
        void LoadData()
        {
            gcPhuCapNV.DataSource = phuCapNVB.getListTransfer();
        }

        void LoadCombo()
        {
            lkNhanVien.Properties.DataSource = nhanVienB.getList();
            lkNhanVien.Properties.ValueMember = "id";
            lkNhanVien.Properties.DisplayMember = "nameStaff";

            cbAllowance.DataSource = phuCapB.getList();
            cbAllowance.ValueMember = "id";
            cbAllowance.DisplayMember = "nameAllowance";

        }
        void SavesData()
        {
            if (create)
            {
                StaffJoinAllowance phucap = new StaffJoinAllowance();
                phucap.idStaff = int.Parse(lkNhanVien.EditValue.ToString());
                //baoHiem.monthlySalary = txtInsuranceMoney.Text;
                //baoHiem.idType = int.Parse(cbTypeInsurance.SelectedValue.ToString());
                phucap.idAllowance = (int?)cbAllowance.SelectedValue;
                phuCapNVB.createStaffAllowance(phucap);
            }
            else
            {
                var phucap = phuCapNVB.getItem(id);
                phucap.idStaff = int.Parse(lkNhanVien.EditValue.ToString());
                //baoHiem.monthlySalary = txtInsuranceMoney.Text;
                //baoHiem.idType = int.Parse(cbTypeInsurance.SelectedValue.ToString());
                phucap.idAllowance = (int?)cbAllowance.SelectedValue;
                phuCapNVB.updateStaffAllowance(phucap);
            }
        }
        void emptyText()
        {
            cbAllowance.SelectedIndex = -1;
            lkNhanVien.EditValue = -1;
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

        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ( lkNhanVien.EditValue == null || cbAllowance.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin và không được để trống");
                return;
            }           
            int Staffid = int.Parse(lkNhanVien.EditValue.ToString());
            int Typeid = int.Parse(cbAllowance.SelectedValue.ToString());
            if (create)
            {
                if (phuCapNVB.IsCheckNhanVien(Staffid, Typeid))
                {
                    MessageBox.Show("Nhân viên đã có phụ cấp này.");
                    return;
                }
            }
            else
            {
                if (phuCapNVB.IsCheckNhanVien(Staffid, Typeid, id))
                {
                    MessageBox.Show("Nhân viên đã có phụ cấp này.");
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
        }

        private void gcPhuCapNV_Click(object sender, EventArgs e)
        {
            
        }

        private void gvPhuCapNV_Click(object sender, EventArgs e)
        {
            id = int.Parse(gvPhuCapNV.GetFocusedRowCellValue("id").ToString());
            var bh = phuCapNVB.getItem(id);
            cbAllowance.SelectedValue = bh.idAllowance;
            lkNhanVien.EditValue = bh.idStaff;
            isDisableActions(true);
            btnClose.Enabled = true;
        }
    }
}