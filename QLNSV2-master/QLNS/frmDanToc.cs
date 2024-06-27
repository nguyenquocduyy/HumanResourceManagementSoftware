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
using Business;
using DataObject;
namespace QLNS
{
    public partial class frmDanToc : DevExpress.XtraEditors.XtraForm
    {

        public frmDanToc()
        {
            InitializeComponent();
        }

        BusinessNation nationB;
        bool create;
        int id;

        private void DanToc_Load(object sender, EventArgs e)
        {
            nationB = new BusinessNation();
            IsDisableActions(true);
            LoadData();
        }

        void LoadData()
        {
            gcDanToc.DataSource = nationB.getList();
            IsDisableActions2(false);
        }

        void IsDisableActions(bool kt)
        {
            barBtnSave.Enabled = !kt;
            barBtnClose.Enabled = !kt;
            barBtnAdd.Enabled = kt;
            barBtnEdit.Enabled = kt;
            barBtnDelete.Enabled = kt;
            txtName.Enabled = !kt;
        }

        void IsDisableActions2(bool kt)
        {
            barBtnEdit.Enabled = kt;
            barBtnDelete.Enabled = kt;
            barBtnClose.Enabled = kt;
        }

        void SavesData()
        {
            if (create)
            {
                Nation nation = new Nation();
                nation.nameNation = txtName.Text;
                nationB.createNation(nation);
            }
            else
            {
                var dantoc = nationB.getItem(id);
                dantoc.nameNation = txtName.Text;
                nationB.updateNation(dantoc);
            }
        }

        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(false);
            txtName.Text = string.Empty;
            create = true;
        }

        private void barBtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(false);
            create = false;
        }

        private void barBtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nationB.deleteNation(id);
                LoadData();
                txtName.Text = string.Empty;
            }
        }

        private void barBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SavesData();
            LoadData();
            IsDisableActions(true);
            barBtnClose.Enabled = true;
        }

        private void barBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(true);
            IsDisableActions2(false);
            txtName.Text = string.Empty;
        }

        private void gvDanToc_Click(object sender, EventArgs e)
        {
            id = int.Parse(gvDanToc.GetFocusedRowCellValue("id").ToString());
            txtName.Text = gvDanToc.GetFocusedRowCellValue("nameNation").ToString();
            IsDisableActions(true);
            barBtnClose.Enabled = true;
        }

    }
}