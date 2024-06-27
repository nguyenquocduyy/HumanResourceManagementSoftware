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

namespace QLNS
{
    public partial class frmRoles : DevExpress.XtraEditors.XtraForm
    {
        public frmRoles()
        {
            InitializeComponent();
        }

        BusinessRole phanquyenB;
        int id;
        bool create;

        private void frmRoles_Load(object sender, EventArgs e)
        {
            phanquyenB = new BusinessRole();
            IsDisableActions(true);
            LoadData();
        }

        void LoadData()
        {
            gcPhanQuyen.DataSource = phanquyenB.getList();
            IsDisableActions2(false);
        }

        void SavesData()
        {
            if (create)
            {
                Role pq = new Role();
                pq.name = txtName.Text;
                phanquyenB.createRole(pq);
            }
            else
            {
                var pq = phanquyenB.getItem(id);
                pq.name = txtName.Text;
                phanquyenB.updateRole(pq);
            }
        }

        void IsDisableActions(bool kt)
        {
            btnAdd.Enabled = kt;
            btnEdit.Enabled = kt;
            btnDetele.Enabled = kt;
            btnSave.Enabled = !kt;
            btnClose.Enabled = !kt;
            txtName.Enabled = !kt;
        }

        void IsDisableActions2(bool kt)
        {
            btnEdit.Enabled = kt;
            btnDetele.Enabled = kt;
            btnClose.Enabled = kt;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            create = true;
            emptyText();
            IsDisableActions(false);
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            create = false;
            IsDisableActions(false);
        }

        private void btnDetele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Ban co muon xoa khong", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                phanquyenB.deleteRole(id);
                LoadData();
                emptyText();
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SavesData();
            LoadData();
            IsDisableActions(true);
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            emptyText();
            IsDisableActions(true);
            IsDisableActions2(false);
        }

        private void gvPhanQuyen_Click(object sender, EventArgs e)
        {
            id = int.Parse(gvPhanQuyen.GetFocusedRowCellValue("id").ToString());
            var pq = phanquyenB.getItem(id);
            txtName.Text = pq.name.ToString();
            IsDisableActions(true);
            btnClose.Enabled = true;
        }

        void emptyText()
        {
            txtName.Text = "";
        }
    }
}