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
    public partial class frmLoaiBaoHiem : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiBaoHiem()
        {
            InitializeComponent();
        }
        BusinessInsurance_Type loaiBaoHiemB;
        bool create;
        int id;
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(false);
            create = true;
            splitContainer1.Panel1Collapsed = false;
            ressetBox();
        }
        void LoadData()
        {
            gcLoaiBaoHiem.DataSource = loaiBaoHiemB.getList();

        }

        void IsDisableActions(bool kt)
        {
            btnSave.Enabled = !kt;
            btnClose.Enabled = !kt;
            btnAdd.Enabled = kt;
            btnEdit.Enabled = kt;
            btnDelete.Enabled = kt;
            spTienDong.Enabled = !kt;

        }
        void SavesData()
        {
            if (string.IsNullOrEmpty(txtloaibaohiem.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            if (create)
            {
                Insurance_Types baoHiem = new Insurance_Types();
                baoHiem.typename = txtloaibaohiem.Text;
                baoHiem.coverageAmount = decimal.Parse(spTienDong.EditValue.ToString());
                loaiBaoHiemB.createInsurance_Type(baoHiem);
            }
            else
            {
                var baoHiem = loaiBaoHiemB.getItem(id);
                baoHiem.typename = txtloaibaohiem.Text;
                baoHiem.coverageAmount = decimal.Parse(spTienDong.EditValue.ToString());
                loaiBaoHiemB.updateInsurance_Type(baoHiem);
            }
        }
        public void ressetBox()
        {
            spTienDong.Text = string.Empty;
            txtloaibaohiem.Text = string.Empty;

        }
        private void frmLoaiBaoHiem_Load(object sender, EventArgs e)
        {
            create = false;
            loaiBaoHiemB = new BusinessInsurance_Type();
            IsDisableActions(true);
            LoadData();
            splitContainer1.Panel1Collapsed = true;
            txtloaibaohiem.Enabled = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(false);
            create = false;
            splitContainer1.Panel1Collapsed = false;
            ressetBox();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loaiBaoHiemB.deleteInsurance_Type(id);
                LoadData();
                ressetBox();
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SavesData();
            LoadData();
            create = false;
            IsDisableActions(true);
            splitContainer1.Panel1Collapsed = true;
            ressetBox();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(true);
            splitContainer1.Panel1Collapsed = false;
            ressetBox();
        }

        private void gvLoaiBaoHiem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            id = int.Parse(gvLoaiBaoHiem.GetFocusedRowCellValue("id").ToString());
            var bh = loaiBaoHiemB.getItem(id);
            spTienDong.Text = bh.coverageAmount.ToString();
            txtloaibaohiem.Text = bh.typename.ToString();
        }
    }
}