using Business;
using Business.Transfer;
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
    public partial class frmConfig : DevExpress.XtraEditors.XtraForm
    {
        BussinessConfig config;
        public frmConfig()
        {
            InitializeComponent();
            config = new BussinessConfig();
            getListConfig();
        }

        private void getListConfig()
        {
            List<T_Config> lisConfig = config.listConfig();
            var nameProgram = lisConfig[0].nameProgram;
            var nameManufactory = lisConfig[0].nameManufactory;
            var basicSalary = lisConfig[0].basicSalary;
            txtnameProgram.Text = nameProgram;
            txtnameManufactory.Text = nameManufactory;
            txtbasicSalary.Text = basicSalary.ToString();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var nameProgram = txtnameProgram.Text ;
            var nameManufactory = txtnameManufactory.Text;
            var basicSalary = float.Parse(txtbasicSalary.Text) ;
            bool res = config.UpdeteTableSystemCTL(nameProgram, nameManufactory, basicSalary);
            if (res)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}