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
    public partial class DienBienLuong : DevExpress.XtraEditors.XtraForm
    {
        public DienBienLuong()
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

        }
        void emptyText()
        {
/*            txtSo.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            txtNhanVien.Text = string.Empty;
            lkHopDong.EditValue = -1;
            dtpkNgayKy.Value = DateTime.Now;
            dtpkNgayLen.Value = DateTime.Now;
            spLuongMoi.EditValue = string.Empty;
            spLuongHT.EditValue = string.Empty;*/
        }
        private void DienBienLuong_Load(object sender, EventArgs e)
        {

        }
    }
}