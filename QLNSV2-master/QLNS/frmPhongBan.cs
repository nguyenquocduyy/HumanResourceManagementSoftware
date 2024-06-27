using Business;
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
using System.Xml.Linq;

namespace QLNS
{
    public partial class frmPhongBan : DevExpress.XtraEditors.XtraForm
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }

        BusinessDepartment phongBanB;
        bool create;
        int id;

        private void PhongBan_Load(object sender, EventArgs e)
        {
            phongBanB = new BusinessDepartment();
            IsDisableActions(true);
            LoadData();
        }

        void LoadData()
        {
            gcPhongBan.DataSource = phongBanB.getList();
            isDisableActions2(false);
        }

        void IsDisableActions(bool kt)
        {
            BtnSave.Enabled = !kt;
            BtnClose.Enabled = !kt;
            BtnAdd.Enabled = kt;
            BtnEdit.Enabled = kt;
            BtnDelete.Enabled = kt;
            txtTenPhong.Enabled = !kt;
        }
        void isDisableActions2(bool kt)
        {
            BtnEdit.Enabled = kt;
            BtnDelete.Enabled = kt;
            BtnClose.Enabled = kt;
        }
        void SavesData()
        {
            if (create)
            {
                Department phongBan = new Department();
                phongBan.nameDepartment = txtTenPhong.Text;
                phongBanB.createDepartment(phongBan);
            }
            else
            {
                var phuCap = phongBanB.getItem(id);
                phuCap.nameDepartment = txtTenPhong.Text;
                phongBanB.updateDepartment(phuCap);
            }
        }

        private void BtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(false);
            emptyText();
            create = true;
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
                phongBanB.deleteDepartment(id);
                LoadData();
                emptyText();
            }
        }

        private void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SavesData();
            LoadData();
            IsDisableActions(true);
        }

        private void BtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(true);
            isDisableActions2(false);
            emptyText();
        }

        private void gvPhongBan_Click(object sender, EventArgs e)
        {
            id = int.Parse(gvPhongBan.GetFocusedRowCellValue("id").ToString());
            txtTenPhong.Text = gvPhongBan.GetFocusedRowCellValue("nameDepartment").ToString();
            IsDisableActions(true);
            BtnClose.Enabled = true;
        }

        void emptyText()
        {
            txtTenPhong.Text = string.Empty;
        }
    }
}