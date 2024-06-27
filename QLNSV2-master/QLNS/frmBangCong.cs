using Business;
using DataObject;
using DevExpress.XtraEditors;
using QLNS.Common;
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
    public partial class frmBangCong : DevExpress.XtraEditors.XtraForm
    {
        public frmBangCong()
        {
            InitializeComponent();
        }
        BangCongBusiness BoasalaryB;
        bool create;
        int id;

        private void frmBangCong_Load(object sender, EventArgs e)
        {
            BoasalaryB = new BangCongBusiness();
            IsDisableActions(true);
            LoadData();
        }

        void LoadData()
        {
            cbYear.Text = DateTime.Now.Year.ToString();
            cbMonth.Text = DateTime.Now.Month.ToString();
            gcBangCong.DataSource = BoasalaryB.getList();
            IsDisableActions2(false);
        }

        void IsDisableActions(bool kt)
        {
            barBtnSave.Enabled = !kt;
            barBtnClose.Enabled = !kt;
            barBtnAdd.Enabled = kt;
            barBtnEdit.Enabled = kt;
            barBtnDelete.Enabled = kt;
            cbYear.Enabled = !kt;
            cbMonth.Enabled = !kt;
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
                BoardSalary typeSalary = new BoardSalary();
                typeSalary.code = int.Parse(cbYear.Text) * 100 + int.Parse(cbMonth.Text);
                typeSalary.year = int.Parse(cbYear.Text);
                typeSalary.month = int.Parse(cbMonth.Text);
                typeSalary.@lock = cbLock.Checked;
                typeSalary.wordDayOfMonth = Common.commonFunction.GetDayNumber(int.Parse(cbMonth.Text),int.Parse(cbYear.Text));
                typeSalary.wordDay = DateTime.Now;
                BoasalaryB.createBoardSalary(typeSalary);
            }
            else
            {
                BoardSalary typeSalary = new BoardSalary();
                typeSalary.code = int.Parse(cbYear.Text) * 100 + int.Parse(cbMonth.Text);
                typeSalary.year = int.Parse(cbYear.Text);
                typeSalary.month = int.Parse(cbMonth.Text);
                typeSalary.@lock = cbLock.Checked;
                typeSalary.wordDayOfMonth = Common.commonFunction.GetDayNumber(int.Parse(cbMonth.Text), int.Parse(cbYear.Text));
                BoasalaryB.updateBoardSalary(typeSalary);
            }
        }


        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(false);
           
            create = true;
            cbYear.Text = DateTime.Now.Year.ToString();
            cbMonth.Text = DateTime.Now.Month.ToString();
            cbLock.Checked = false;
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
                BoasalaryB.deleteBoardSalary(id);
                LoadData();
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
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gvBangCong_Click(object sender, EventArgs e)
        {
            id = int.Parse(gvBangCong.GetFocusedRowCellValue("code").ToString());
            cbYear.Text = gvBangCong.GetFocusedRowCellValue("year").ToString();
            cbMonth.Text = gvBangCong.GetFocusedRowCellValue("month").ToString();
            cbLock.Checked = bool.Parse(gvBangCong.GetFocusedRowCellValue("lock").ToString());
            IsDisableActions(true);
            barBtnClose.Enabled = true;
        }

        private void btnShow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBangCongChiTiet frmBangCongChiTiet = new frmBangCongChiTiet();
            frmBangCongChiTiet.code = id;
            frmBangCongChiTiet.year = int.Parse(cbYear.Text);
            frmBangCongChiTiet.month = int.Parse(cbMonth.Text);
            this.Hide();
            frmBangCongChiTiet.ShowDialog();
            this.Show();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}