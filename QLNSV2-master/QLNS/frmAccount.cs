using Business;
using Business.Transfer;
using DataObject;
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

namespace QLNS
{
    public partial class frmAccount : DevExpress.XtraEditors.XtraForm
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        BusinessAccount accountB;
        BusinessStaff nhanVienB;
        BusinessRole roleB;
        int id;
        bool create;

        private void frmAccount_Load(object sender, EventArgs e)
        {
            accountB = new BusinessAccount();
            nhanVienB = new BusinessStaff();
            roleB = new BusinessRole();
            IsDisableActions(true);
            LoadData();
            LoadCombo();
        }

        void LoadCombo()
        {
            lkNhanVien.Properties.DataSource = nhanVienB.getList();
            lkNhanVien.Properties.ValueMember = "id";
            lkNhanVien.Properties.DisplayMember = "nameStaff";

            lkRole.Properties.DataSource = roleB.getList();
            lkRole.Properties.ValueMember = "id";
            lkRole.Properties.DisplayMember = "name";
        }

        public void LoadData()
        {
            gcAccount.DataSource = accountB.getListTransfer();
            isDisableActions2(false);
        }

        void IsDisableActions(bool kt)
        {
            BtnSave.Enabled = !kt;
            BtnClose.Enabled = !kt;
            BtnAdd.Enabled = kt;
            btnUpdate.Enabled = kt;
            BtnResetPass.Enabled = kt;
            BtnDelete.Enabled = kt;
            txtUsername.Enabled = !kt;
            lkNhanVien.Enabled = !kt;
            lkRole.Enabled = !kt;
        }

        void isDisableActions2(bool kt)
        {
            BtnResetPass.Enabled = kt;
            BtnDelete.Enabled = kt;
            btnUpdate.Enabled = kt;
            BtnClose.Enabled = kt;
        }

        private void gvAccount_Click(object sender, EventArgs e)
        {
            id = int.Parse(gvAccount.GetFocusedRowCellValue("id").ToString());
            var bh = accountB.getItemById(id);
            txtUsername.Text = bh.username.ToString();
            lkNhanVien.EditValue = bh.idStaff;
            lkRole.EditValue = bh?.idRole;
            IsDisableActions(true);
            BtnClose.Enabled = true;
        }


        void SavesData()
        {
            if (create)
            {
                Account ac = new Account();
                ac.username = txtUsername.Text;
                ac.password = "12345678";
                ac.idStaff = int.Parse(lkNhanVien.EditValue.ToString());
                ac.idRole = int.Parse(lkRole.EditValue.ToString());
                accountB.createAccount(ac);
            }
            else
            {
                var ac = accountB.getItemById(id);
                ac.username = txtUsername.Text;
                ac.idStaff = int.Parse(lkNhanVien.EditValue.ToString());
                ac.idRole = int.Parse(lkRole.EditValue.ToString());
                accountB.updateAccount(ac);
            }
        }

        private void BtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            create = true;
            IsDisableActions(false);
            resetText();
        }

        private void BtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                accountB.deleteAccount(id);
                LoadData();
                resetText();
            }
        }

        private void BtnResetPass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Reset mật khẩu thành công?", "Thông báo");
            var ac = accountB.getItemById(id);
            ac.password = "12345678";
            accountB.updateAccount(ac);
        }

        private void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SavesData();
            LoadData();
            IsDisableActions(true);
            BtnClose.Enabled = true;
        }

        private void BtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(true);
            isDisableActions2(false);
            resetText();
        }

        void resetText()
        {
            txtUsername.Text = string.Empty;
            lkNhanVien.EditValue = -1;
            lkRole.EditValue = -1;
        }

        private void BtnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            create = false;
            IsDisableActions(false);
        }
    }
}