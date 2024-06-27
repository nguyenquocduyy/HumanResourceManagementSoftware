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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLNS
{
    public partial class frmNangLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmNangLuong()
        {
            InitializeComponent();
        }
        BusinessStaff nhanVienB;
        BusinessNangLuong nangLuongB;
        BusinessContract hopDongB;
        bool create;
        int id;
        void isDisableActions(bool kt)
        {
            btnAdd.Enabled = kt;
            btnEdit.Enabled = kt;
            btnDelete.Enabled = kt;
            btnSave.Enabled = !kt;
            btnClose.Enabled = !kt;
            txtSo.Enabled = !kt;
            txtNhanVien.Enabled = !kt;
            dtpkNgayKy.Enabled = !kt;
            dtpkNgayLen.Enabled = !kt;
            lkHopDong.Enabled = !kt;
            txtGhiChu.Enabled = !kt;
        }
        void emptyText()
        {
            txtSo.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            txtNhanVien.Text = string.Empty;
            lkHopDong.EditValue = -1;
            dtpkNgayKy.Value = DateTime.Now;
            dtpkNgayLen.Value = DateTime.Now;
            spLuongMoi.EditValue = string.Empty;
            spLuongHT.EditValue = string.Empty;
        }
        void customMoneyView()
        {
            GridView gridView = gvNangLuong;
            GridColumn colCurrency = gridView.Columns["LuongMoi"];
            colCurrency.DisplayFormat.Format = new CultureInfo("vi-VN");
            GridColumn colCurrency1 = gridView.Columns["LuongHienTai"];
            colCurrency1.DisplayFormat.Format = new CultureInfo("vi-VN");
        }
        private void NangLuong_Load(object sender, EventArgs e)
        {
            nhanVienB = new BusinessStaff();
            hopDongB = new BusinessContract();
            nangLuongB = new BusinessNangLuong();
            LoadCombo();
            LoadData();
            customMoneyView();
            isDisableActions(true);
            splitContainer1.Panel1Collapsed = false;
            spLuongHT.Enabled = false;
        }
        void LoadCombo()
        {
            lkHopDong.Properties.DataSource = hopDongB.getListTransfer();
            lkHopDong.Properties.ValueMember = "id";
            lkHopDong.Properties.DisplayMember = "id";

        }
        void SavesData()
        {
            NangLuong nl;
            if (create)
            {
                nl = new NangLuong();
                nl.SoQD = txtSo.Text;
                nl.GhiChu = txtGhiChu.Text;
                nl.idContract = int.Parse(lkHopDong.EditValue.ToString());
                nl.signDay = dtpkNgayKy.Value;
                nl.upDay = dtpkNgayLen.Value;
                nl.idStaff = hopDongB.getItem(int.Parse(lkHopDong.EditValue.ToString())).idStaff;
                nl.LuongHienTai = (double)hopDongB.getItem(int.Parse(lkHopDong.EditValue.ToString())).salary;
                nl.LuongMoi = double.Parse(spLuongMoi.EditValue.ToString());
                nangLuongB.createNangLuong(nl);
            }
            else
            {
                nl = nangLuongB.getItem(id);
                nl.SoQD = txtSo.Text;
                nl.idContract = int.Parse(lkHopDong.EditValue.ToString());
                nl.GhiChu = txtGhiChu.Text;
                nl.signDay = dtpkNgayKy.Value;
                nl.upDay = dtpkNgayLen.Value;
                nl.idStaff = hopDongB.getItem(int.Parse(lkHopDong.EditValue.ToString())).idStaff;
                nl.LuongHienTai = (double)hopDongB.getItem(int.Parse(lkHopDong.EditValue.ToString())).salary;
                nl.LuongMoi = double.Parse(spLuongMoi.EditValue.ToString());
                nangLuongB.updateNangLuong(nl);
            }
            var hd = hopDongB.getItem(int.Parse(lkHopDong.EditValue.ToString()));
            hd.salary = double.Parse(spLuongMoi.EditValue.ToString());
            hopDongB.updateContract(hd);
        }
        void LoadData()
        {
            gcNangLuong.DataSource = nangLuongB.getListTransfer();
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

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nangLuongB.deleteNangLuong(id);
                LoadData();
                emptyText();
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSo.Text) || string.IsNullOrEmpty(txtGhiChu.Text) || spLuongMoi.Text == null ||  lkHopDong.EditValue==null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin và không được để trống");
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

        private void gvNangLuong_Click(object sender, EventArgs e)
        {
            id = int.Parse(gvNangLuong.GetFocusedRowCellValue("id").ToString());
            var dc = nangLuongB.getItem(id);
            txtSo.Text = dc.SoQD;
            txtGhiChu.Text = dc.GhiChu;
            dtpkNgayKy.Value = dc.signDay.Value;
            dtpkNgayLen.Value = dc.upDay.Value;
            lkHopDong.EditValue = dc.idContract;
            spLuongHT.EditValue = dc.LuongHienTai;
            spLuongMoi.EditValue = dc.LuongMoi;
            txtNhanVien.Text = gvNangLuong.GetFocusedRowCellValue("nameStaff").ToString();
            isDisableActions(true);
            btnClose.Enabled = true;
            spLuongMoi.Enabled = true;
        }

        private void txtNhanVien_TextChanged(object sender, EventArgs e)
        {
           /*var hdt = hopDongB.getItemTransfer(int.Parse(lkHopDong.EditValue.ToString()));
            if (hdt.Count != null)
            {
                txtNhanVien.Text = hdt[0].idStaff + "-" + hdt[0].nameStaff;
            }*/
        }
    }
}