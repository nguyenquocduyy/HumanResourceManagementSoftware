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
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace QLNS
{
    public partial class frmKyLuat : DevExpress.XtraEditors.XtraForm
    {
        public frmKyLuat()
        {
            InitializeComponent();
        }

        BusinessDiscipline disciplineB;
        BusinessStaff nhanVienB;
        List<T_KyLuat> ls_Kyluat;
        bool create;
        int id;

        private void frmKyLuat_Load(object sender, EventArgs e)
        {
            disciplineB = new BusinessDiscipline();
            nhanVienB = new BusinessStaff();
            IsDisableActions(true);
            LoadData();
            LoadCombo();
        }

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

        void LoadData()
        {
            gcDiscipline.DataSource = disciplineB.getListTransfer();
            IsDisableActions2(false);
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
                Discipline discipline = new Discipline();
                discipline.idStaff = int.Parse(lkNhanVien.EditValue.ToString());
                discipline.createAt = dtpkNgayKT.Value;
                discipline.formality = txtFormality.Text;
                discipline.reason = txtreason.Text;
                disciplineB.createDiscipline(discipline);
            }
            else
            {
                var kyluat = disciplineB.getItem(id);
                kyluat.idStaff = int.Parse(lkNhanVien.EditValue.ToString());
                kyluat.createAt = dtpkNgayKT.Value;
                kyluat.formality = txtFormality.Text;
                kyluat.reason = txtreason.Text;
                disciplineB.updateDiscipline(kyluat);
            }
        }

        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(false);
            emptyText();
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
                disciplineB.deleteDiscipline(id);
                LoadData();
                emptyText();
            }
        }

       

        private void barBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtFormality.Text == string.Empty || txtreason.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin và không được để trống.");
                return;
            }
            if (Regex.IsMatch(txtFormality.Text,@"[^\w\s]") || Regex.IsMatch(txtreason.Text, @"[^\w\s]"))
            {
                MessageBox.Show("Thông tin hình thức và lý do nhập vào không đượcc có ký tự đặc biệt.");
                return;
            }
            SavesData();
            LoadData();
            IsDisableActions(true);
            barBtnClose.Enabled = true;
        }

        private void barBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(true);
            IsDisableActions2(false);
            emptyText();
        }

        private void gvDiscipline_Click(object sender, EventArgs e)
        {
            id = int.Parse(gvDiscipline.GetFocusedRowCellValue("id").ToString());
            var discipline = disciplineB.getItem(id);
            txtFormality.Text = discipline.formality;
            txtreason.Text = discipline.reason;
            dtpkNgayKT.Value = discipline.createAt.Value;
            lkNhanVien.EditValue = discipline.idStaff;
            ls_Kyluat = disciplineB.getItemTransfer(id);
            IsDisableActions(true);
            barBtnClose.Enabled = true;
        }

        private void barBtnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ls_Kyluat = disciplineB.getItemTransfer(id);
            RDiscipline rRDiscipline = new RDiscipline(ls_Kyluat);
            rRDiscipline.ShowPreviewDialog();
        }

        void emptyText()
        {
            txtreason.Text = "";
            txtFormality.Text = "";
            lkNhanVien.EditValue = -1;
        }

        private void tbnPrintList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ls_Kyluat = disciplineB.getListTransfer();
            RListDiscipline rRDiscipline = new RListDiscipline(ls_Kyluat);
            rRDiscipline.ShowPreview();
        }

        private void btnInDSTheoDate_Click(object sender, EventArgs e)
        {
            
        }
    }
}