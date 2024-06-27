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
    public partial class frmTrinhDo : DevExpress.XtraEditors.XtraForm
    {
        public frmTrinhDo()
        {
            InitializeComponent();
        }

        BusinessLever leverB;
        bool create;
        int id;

        private void frmTrinhDo_Load(object sender, EventArgs e)
        {
            leverB = new BusinessLever();
            IsDisableActions(true);
            LoadData();
        }

        void LoadData()
        {
            gcTrinhdo.DataSource = leverB.getList();
            isDisableActions2(false);
        }

        void IsDisableActions(bool kt)
        {
            btnSave.Enabled = !kt;
            btnClose.Enabled = !kt;
            btnAdd.Enabled = kt;
            btnEdit.Enabled = kt;
            btnDelete.Enabled = kt;
            txtName.Enabled = !kt;
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
                Lever lever = new Lever();
                lever.nameLever = txtName.Text;
                leverB.createLever(lever);
            }
            else
            {
                var lever = leverB.getItem(id);
                lever.nameLever = txtName.Text;
                leverB.updateLever(lever);
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
                leverB.deleteLever(id);
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

        private void gvTrinhdo_Click(object sender, EventArgs e)
        {
            id = int.Parse(gvTrinhdo.GetFocusedRowCellValue("id").ToString());
            txtName.Text = gvTrinhdo.GetFocusedRowCellValue("nameLever").ToString();
            IsDisableActions(true);
            btnClose.Enabled = true;
        }

        void emptyText()
        {
            txtName.Text = string.Empty;
        }
    }
}