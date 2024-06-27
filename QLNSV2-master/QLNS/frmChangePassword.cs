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
    public partial class frmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        private Account account;
        public frmChangePassword(Account account)
        {
            InitializeComponent();
            this.account = account;
            LoadData(account.username);
        }

        BusinessAccount accountB;


        public void LoadData(string username)
        {
            txtUsername.Text = username;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            accountB = new BusinessAccount();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string passOld = txtPassOld.Text;
            string passNew = txtPasswordNews.Text;
            string passRe = txtPassRe.Text; ;
            if (accountB.getItem(username, passOld) != null)
            {
                if (passNew != passRe)
                {
                    MessageBox.Show("Mật khẩu nhập lại chưa khớp");
                    txtPassRe.Focus();
                }
                else
                {
                    accountB.changePass(username, passNew);
                    MessageBox.Show("Đã cập nhật mật khẩu mới");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ sai!");
                txtPassOld.Focus();
            }
        }
    }
}