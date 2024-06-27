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
    public partial class frmChamCong : DevExpress.XtraEditors.XtraForm
    {
        public frmChamCong()
        {
            InitializeComponent();
        }

        public int idStaff;
        public string nameStaff;
        public int code;
        public string ngay;
        public int cldDay;
        BusinessBangCongChiTiet businessBangCongChiTiet;
        frmBangCongChiTiet frmBangCongCT = (frmBangCongChiTiet)Application.OpenForms["frmBangCongChiTiet"];
        
        private void frmChamCong_Load(object sender, EventArgs e)
        {
            businessBangCongChiTiet = new BusinessBangCongChiTiet();
            
            string nam = code.ToString().Substring(0, 4);
            string thang = code.ToString().Substring(4);
            string ngayd = ngay.Substring(1);
            DateTime _d = DateTime.Parse(nam + "-" + thang + "-" + ngayd);
            calDateTime.SetDate(_d);
        }

        private void btnCheckInOut_Click(object sender, EventArgs e)
        {
            string valueChamCong = rdgStatus.Properties.Items[rdgStatus.SelectedIndex].Value.ToString();
            string fildName = "D" + cldDay.ToString();
            var kcct = businessBangCongChiTiet.getItem(code , idStaff);
            if(calDateTime.SelectionRange.Start.Year*100+calDateTime.SelectionRange.End.Month != code)
            {
                MessageBox.Show("Bạn đang chọn sai bảng công vui lòng chọn đúng","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Common.InstanceSql.execQuery("UPDATE BoardSalaryDes SET " + fildName+"='"+valueChamCong + "' WHERE code="+code+" AND idStaff="+idStaff);
            frmBangCongCT.loadData();

        }

        private void calDateTime_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        private void rdStatus_Paint(object sender, PaintEventArgs e)
        {
            cldDay = calDateTime.SelectionRange.Start.Day;
        }

        private void rdgStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}