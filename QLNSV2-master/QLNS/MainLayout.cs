using DataObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace QLNS
{
    public partial class MainLayout : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Account account;
        
        public MainLayout(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        bool HasAnyPermission(Account account, int[] codePers)
        {
            foreach (int codePer in codePers)
            {
                if (account.idRole == codePer)
                {
                    return true;
                }
            }
            return false;
        }

        void CallModal(Type type , int[] codePer)
        {
            if(HasAnyPermission(account, codePer))
            {
                var existingForm = MdiChildren.OfType<Form>().FirstOrDefault(f => f.GetType() == type);
                if (existingForm != null)
                {
                    existingForm.Activate();
                }
                else
                {
                    Form form = (Form)Activator.CreateInstance(type);
                    form.MdiParent = this;
                    form.Show();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản của bạn chưa được cấp quyền cho tính năng này vui lòng liên hệ với quản trị viên", "Thông báo");
            }
        }

        private void barbtnPhuCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1, 3, 5 };
            CallModal(typeof(frmPhuCap), permissions);
        }

        private void barbtnDanToc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1, 5 };
            CallModal(typeof(frmDanToc), permissions);
        }

        private void barBtnLevelEdu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1, 5 };
            CallModal(typeof(frmTrinhDo), permissions);
        }

        private void barBtnInsurance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1, 3, 5 };
            CallModal(typeof(frmBaoHiem), permissions);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1, 2, 5 };
            CallModal(typeof(frmHopDong), permissions);
        }

        private void barBtnPosition_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1, 5 };
            CallModal(typeof(frmChucvu), permissions);
        }

        private void barBtnApartment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1, 5 };
            CallModal(typeof(frmPhongBan), permissions);
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1, 2, 3, 4, 5 };
            CallModal(typeof(frmNhanVien), permissions);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1 };
            CallModal(typeof(frmAccount), permissions);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1 };
            CallModal(typeof(frmRoles), permissions);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChangePassword frmChangePassword  = new frmChangePassword(account);
            this.Hide();
            frmChangePassword.ShowDialog();
            this.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1, 5 };
            CallModal(typeof(frmKhenThuong), permissions);
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1, 2, 5 };
            CallModal(typeof(frmBangCong), permissions);
        }

        private void barButtonItem4_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1, 3, 5 };
            CallModal(typeof(frmBangLuong), permissions);
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1, 5 };
            CallModal(typeof(frmKyLuat), permissions);
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            frmLogin fLogin = new frmLogin();
            fLogin.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1 };
            CallModal(typeof(frmThongKeLuong), permissions);
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1 };
            if (HasAnyPermission(account, permissions))
            {
                frmConfig frmConfig = new frmConfig();
                
                this.Hide();
                frmConfig.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản của bạn chưa được cấp quyền cho tính năng này vui lòng liên hệ với quản trị viên", "Thông báo");
            }
            
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1, 3, 5 };
            CallModal(typeof(frmLoaiBaoHiem), permissions);
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1 };
            CallModal(typeof(frmThongkeKhenThuong), permissions);
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1 };
            CallModal(typeof(frmThongKeKyLuat), permissions);
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1 };
            CallModal(typeof(frmDieuchuyen), permissions);
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1 };
            CallModal(typeof(frmPhuCapNhanVien), permissions);
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] permissions = { 1 };
            CallModal(typeof(frmNangLuong), permissions);
        }
    }
}
