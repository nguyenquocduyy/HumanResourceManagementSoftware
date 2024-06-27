using Business.Transfer;
using Business;
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
using DataObject;
using QLNS.Reports;
using DevExpress.XtraReports.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace QLNS
{
    public partial class frmKhenThuong : DevExpress.XtraEditors.XtraForm
    {
        public frmKhenThuong()
        {
            InitializeComponent();
        }

        BusinessReward rewardB;
        BusinessStaff nhanVienB;
        List<T_KhenThuong> ls_KhenThuong;
        bool create;
        int id;

        void IsDisableActions(bool kt)
        {
            barBtnSave.Enabled = !kt;
            barBtnClose.Enabled = !kt;
            barBtnAdd.Enabled = kt;
            barBtnEdit.Enabled = kt;
            barBtnDelete.Enabled = kt;
            barBtnPrint.Enabled = kt;
            lkNhanVien.Enabled = !kt;
            txtFormality.Enabled = !kt;
            txtreason.Enabled = !kt;
            dtpkNgayKT.Enabled = !kt;

        }

        void IsDisableActions2(bool kt)
        {
            barBtnClose.Enabled = kt;
            barBtnEdit.Enabled = kt;
            barBtnDelete.Enabled = kt;
            barBtnPrint.Enabled = kt;
        }

        private void frmKhenThuong_Load(object sender, EventArgs e)
        {
            rewardB = new BusinessReward();
            nhanVienB = new BusinessStaff();
            IsDisableActions(true);
            LoadData();
            LoadCombo();
        }

        void LoadData()
        {
            gcReward.DataSource = rewardB.getListTransfer();
        }

        void LoadCombo()
        {
            lkNhanVien.Properties.DataSource = nhanVienB.getList();
            lkNhanVien.Properties.ValueMember = "id";
            lkNhanVien.Properties.DisplayMember = "nameStaff";
        }

        void SavesData()
        {
            if (create)
            {
                Reward reward = new Reward();
                reward.idStaff = int.Parse(lkNhanVien.EditValue.ToString());
                reward.formality = txtFormality.Text;
                reward.createAt = dtpkNgayKT.Value;
                reward.reason = txtreason.Text;
                rewardB.createReward(reward);
            }
            else
            {
                var khenthuong = rewardB.getItem(id);
                khenthuong.idStaff = int.Parse(lkNhanVien.EditValue.ToString());
                khenthuong.formality = txtFormality.Text;
                khenthuong.createAt = dtpkNgayKT.Value;
                khenthuong.reason = txtreason.Text;
                rewardB.updateReward(khenthuong);
            }
        }

        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(false);
            emptyText();
            create = true;
        }

        void emptyText()
        {
            txtreason.Text = "";
            txtFormality.Text = "";
            lkNhanVien.EditValue = -1;
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
                rewardB.deleteReward(id);
                LoadData();
                emptyText();
            }
        }

        private void barBtnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ls_KhenThuong = rewardB.getItemTransfer(id);
            RReward rReward = new RReward(ls_KhenThuong);
            rReward.ShowPreviewDialog();
        }

        private void barBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtFormality.Text == string.Empty || txtreason.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin và không được để trống.");
                return;
            }
            if (Regex.IsMatch(txtFormality.Text, @"[^\w\s]") || Regex.IsMatch(txtreason.Text, @"[^\w\s]"))
            {
                MessageBox.Show("Thông tin hình thức và lý do nhập vào không đượcc có ký tự đặc biệt.");
                return;
            }
            SavesData();
            LoadData();
            IsDisableActions(true);
            barBtnClose.Enabled = true;
            emptyText();
        }

        private void barBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(true);
            IsDisableActions2(false);
            emptyText();
        }

        private void gvReward_Click(object sender, EventArgs e)
        {
            id = int.Parse(gvReward.GetFocusedRowCellValue("id").ToString());
            var reward = rewardB.getItem(id);
            txtFormality.Text = reward.formality;
            txtreason.Text = reward.reason;
            dtpkNgayKT.Value = reward.createAt.Value;
            lkNhanVien.EditValue = reward.idStaff;
            ls_KhenThuong = rewardB.getItemTransfer(id);
            IsDisableActions(true);
            barBtnClose.Enabled = true;
        }

        private void btnPrintList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ls_KhenThuong = rewardB.getListTransfer();
            RListReward dskhenthuong = new RListReward(ls_KhenThuong);
            dskhenthuong.ShowPreview();
        }

        private void btnInDSTheoDate_Click(object sender, EventArgs e)
        {
            
        }
    }
}