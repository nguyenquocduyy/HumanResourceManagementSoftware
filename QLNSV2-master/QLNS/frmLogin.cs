using Business;
using DataObject;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();

        }

        BusinessAccount accountB;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            accountB = new BusinessAccount();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (accountB.getItem(username, password) != null)
            {
                var account = accountB.getItem(username, password);
                MainLayout fMain = new MainLayout(account);
                this.Hide();
                fMain.ShowDialog();
                accountB = new BusinessAccount();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }

        }

    }
}