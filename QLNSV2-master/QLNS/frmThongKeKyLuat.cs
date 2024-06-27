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
    public partial class frmThongKeKyLuat : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKeKyLuat()
        {
            InitializeComponent();
            disciplineB = new BusinessDiscipline();
            LoadData();
            cbNam.Text = DateTime.Now.Year.ToString();
            cbThang.Text = DateTime.Now.Month.ToString();
        }

        BusinessDiscipline disciplineB;
        List<T_KyLuat> ls_Kyluat;
        void LoadData()
        {
            gcReward.DataSource = disciplineB.getListTransfer();
        }
        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbNam.SelectedItem == null || cbThang.SelectedItem == null)
            {
                MessageBox.Show("Cần chọn tháng và năm để in danh sách. Không được để trống");
                return;
            }
            ls_Kyluat = disciplineB.getListDate(int.Parse(cbThang.Text), int.Parse(cbNam.Text));
            RListDisciplineDate dskhenthuongDate = new RListDisciplineDate(ls_Kyluat);
            dskhenthuongDate.ShowPreview();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            gcReward.DataSource = disciplineB.getListDate(int.Parse(cbThang.Text), int.Parse(cbNam.Text));
        }
    }
}