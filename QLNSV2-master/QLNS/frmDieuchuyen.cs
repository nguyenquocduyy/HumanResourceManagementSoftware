using Business;
using Business.Transfer;
using DataObject;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using QLNS.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace QLNS
{
    public partial class frmDieuchuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmDieuchuyen()
        {
            InitializeComponent();
        }
        BusinessStaff nhanVienB;
        BusinessDieuChuyen dieuchuyenB;
        BusinessDepartment phongBanB;
        bool create;
        int id;
        List<T_DieuChuyen> lsDC;
        void isDisableActions(bool kt)
        {
            btnAdd.Enabled = kt;
            btnEdit.Enabled = kt;
            btnDelete.Enabled = kt;
            btnSave.Enabled = !kt;
            btnClose.Enabled = !kt;
            txtSo.Enabled = !kt;
            txtGhichu.Enabled = !kt;
            txtLydo.Enabled = !kt;
            dtpkDay.Enabled = !kt;
            lkNhanVien.Enabled = !kt;
            cbPhongMoi.Enabled = !kt;
        }
        void emptyText()
        {
            txtSo.Text = string.Empty;
            txtGhichu.Text = string.Empty;
            txtLydo.Text = string.Empty;
            lkNhanVien.EditValue = -1;
            cbPhongMoi.SelectedIndex = -1;
            dtpkDay.Value = DateTime.Now;
        }
        void LoadData()
        {
            gcDieuChuyen.DataSource = dieuchuyenB.getListTransfer();
        }
        void isDisableActions2(bool x)
        {
            btnEdit.Enabled = x;
            btnDelete.Enabled = x;
            btnClose.Enabled = x;
        }
        void LoadCombo()
        {
            lkNhanVien.Properties.DataSource = nhanVienB.getListTransfer();
            lkNhanVien.Properties.ValueMember = "id";
            lkNhanVien.Properties.DisplayMember = "nameStaff";

            cbPhongMoi.DataSource = phongBanB.getList();
            cbPhongMoi.ValueMember = "id";
            cbPhongMoi.DisplayMember = "nameDepartment";

            /*cbPhongCu.DataSource = dieuchuyenB.getListTransfer();
            cbPhongMoi.ValueMember = "id";
            cbPhongMoi.DisplayMember = "nameDepartment";*/
        }
        void SavesData()
        {
            DieuChuyen dc;
            if (create)
            {
                dc = new DieuChuyen();
                dc.SoDC = txtSo.Text;
                dc.Lydo = txtLydo.Text;
                dc.Ghichu = txtGhichu.Text;
                dc.createDay = dtpkDay.Value;
                dc.idStaff = int.Parse(lkNhanVien.EditValue.ToString());
                dc.idRoom = nhanVienB.getItem(int.Parse(lkNhanVien.EditValue.ToString())).idRoom;
                dc.idRoom2 = int.Parse(cbPhongMoi.SelectedValue.ToString());
                dieuchuyenB.createDC(dc);
            }
            else
            {
                dc = dieuchuyenB.getItem(id);
                dc.SoDC = txtSo.Text;
                dc.Lydo = txtLydo.Text;
                dc.createDay = dtpkDay.Value;
                dc.Ghichu = txtGhichu.Text;
                dc.idStaff = int.Parse(lkNhanVien.EditValue.ToString());
                dc.idRoom2 = int.Parse(cbPhongMoi.SelectedValue.ToString());
                dieuchuyenB.updateDC(dc);
            }
            var nv = nhanVienB.getItem(dc.idStaff.Value);
            nv.idRoom = dc.idRoom2;
            nhanVienB.updateStaff(nv);

        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            create = true;
            isDisableActions(false);
            emptyText();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isDisableActions(false);
            create = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSo.Text) || string.IsNullOrEmpty(txtGhichu.Text) || string.IsNullOrEmpty(txtLydo.Text) || lkNhanVien.EditValue == null || cbPhongMoi.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin và không được để trống");
                return;
            }
            if (Regex.IsMatch(txtSo.Text, @"[^\w\s]") ||Regex.IsMatch(txtGhichu.Text, @"[^\w\s]") || Regex.IsMatch(txtLydo.Text, @"[^\w\s]"))
            {
                MessageBox.Show("Nội dung số điều chuyển, lý do và ghi chú không được có ký tự đặc biệt");
                return;
            }
            if (create)
            {
                if (dieuchuyenB.IsCheckSoDC(txtSo.Text))
                {
                    MessageBox.Show("Mã số điều chuyển đã bị trùng. Nhập số khác");
                    return;
                }           
            }
            else
            {
                if (dieuchuyenB.IsCheckSoDC(txtSo.Text, id))
                {
                    MessageBox.Show("Mã số điều chuyển đã tồn tại. Nhập số khác");
                    return;
                }
            }
            int idPhongHT = (int)nhanVienB.getItem(int.Parse(lkNhanVien.EditValue.ToString())).idRoom;
            int idPhongMoi = int.Parse(cbPhongMoi.SelectedValue.ToString());
            if (idPhongHT == idPhongMoi)
            {
                MessageBox.Show("Phòng mới không được trùng với phòng ban hiện tại. Vui lòng chọn phòng khác.");
                return;
            }

            SavesData();
            LoadData();
            isDisableActions(true);
            emptyText();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isDisableActions(true);
            emptyText();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dieuchuyenB.deleteDC(id);
                LoadData();
                emptyText();
            }
        }

        private void gvDieuChuyen_Click(object sender, EventArgs e)
        {
            id = int.Parse(gvDieuChuyen.GetFocusedRowCellValue("id").ToString());
            var dc = dieuchuyenB.getItem(id);
            txtSo.Text = dc.SoDC;
            txtGhichu.Text = dc.Ghichu;
            txtLydo.Text = dc.Lydo;
            dtpkDay.Value = dc.createDay.Value;
            lkNhanVien.EditValue = dc.idStaff;
            cbPhongMoi.SelectedValue = dc.idRoom2;
            isDisableActions(true);
            btnClose.Enabled = true;
        }

        private void frmDieuchuyen_Load(object sender, EventArgs e)
        {
            nhanVienB = new BusinessStaff();
            phongBanB = new BusinessDepartment();
            dieuchuyenB = new BusinessDieuChuyen();
            LoadCombo();
            LoadData();
            isDisableActions(true);

        }

        private void dtpkDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lsDC = dieuchuyenB.getListTransfer();
            RDSDieuChuyen rDieuchuyen = new RDSDieuChuyen(lsDC);
            rDieuchuyen.ShowPreviewDialog();
        }
    }
}