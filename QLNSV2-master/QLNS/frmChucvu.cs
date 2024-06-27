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
using static DevExpress.XtraBars.Docking2010.Views.BaseRegistrator;

namespace QLNS
{
    public partial class frmChucvu : DevExpress.XtraEditors.XtraForm
    {
        public frmChucvu()
        {
            InitializeComponent();
        }

        BusinessPosition chucVuB;
        bool create;
        int id;
        private void frmChucvu_Load(object sender, EventArgs e)
        {
            chucVuB = new BusinessPosition();
            IsDisableActions(true);
            LoadData();
        }

        void LoadData()
        {
            gcChucVu.DataSource = chucVuB.getList();
            isDisableActions2(false);
        }

        void IsDisableActions(bool kt)
        {
            btnSave.Enabled = !kt;
            btnClose.Enabled = !kt;
            btnAdd.Enabled = kt;
            btnEdit.Enabled = kt;
            btnDelete.Enabled = kt;
            txtTenChucVu.Enabled = !kt;
        }

        void isDisableActions2(bool kt)
        {
            btnEdit.Enabled = kt;
            btnDelete.Enabled = kt;
            btnClose.Enabled = kt;
        }

        void SavesData()
        {
            if (create)
            {
                Position position = new Position();
                position.namePosition = txtTenChucVu.Text;
                chucVuB.createPosition(position);
            }
            else
            {
                var position = chucVuB.getItem(id);
                position.namePosition = txtTenChucVu.Text;
                chucVuB.updatePosition(position);
            }
        }


        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(false);
            emptyText();
            create = true;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(false);
            create = false;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                chucVuB.deletePosition(id);
                LoadData();
                emptyText();
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SavesData();
            LoadData();
            IsDisableActions(true);
            btnClose.Enabled = true;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(true);
            isDisableActions2(false);
            emptyText();
        }

        void emptyText()
        {
            txtTenChucVu.Text = string.Empty;
        }

        private void gvChucVu_Click(object sender, EventArgs e)
        {
            id = int.Parse(gvChucVu.GetFocusedRowCellValue("id").ToString());
            txtTenChucVu.Text = gvChucVu.GetFocusedRowCellValue("namePosition").ToString();
            IsDisableActions(true);
            btnClose.Enabled = true;
        }
    }
}