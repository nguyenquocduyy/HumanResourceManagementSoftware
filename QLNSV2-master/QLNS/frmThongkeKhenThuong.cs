using Business;
using Business.Transfer;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QLNS.Reports;
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
    public partial class frmThongkeKhenThuong : DevExpress.XtraEditors.XtraForm
    {
        public frmThongkeKhenThuong()
        {
            InitializeComponent();
            rewardB = new BusinessReward();
            LoadData();
            cbNam.Text = DateTime.Now.Year.ToString();
            cbThang.Text = DateTime.Now.Month.ToString();
        }
        BusinessReward rewardB;
        List<T_KhenThuong> ls_KhenThuong;
        private void frmThongkeKhenThuong_Load(object sender, EventArgs e)
        {
            
        }
        void LoadData()
        {
            gcReward.DataSource = rewardB.getListTransfer();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            gcReward.DataSource = rewardB.getListDate(int.Parse(cbThang.Text), int.Parse(cbNam.Text));
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbNam.SelectedItem == null || cbThang.SelectedItem == null)
            {
                MessageBox.Show("Cần chọn tháng và năm để in danh sách. Không được để trống");
                return;
            }
            ls_KhenThuong = rewardB.getListDate(int.Parse(cbThang.Text), int.Parse(cbNam.Text));
            RListRewardDate dskhenthuongDate = new RListRewardDate(ls_KhenThuong);
            dskhenthuongDate.ShowPreview();
        }
    }
}