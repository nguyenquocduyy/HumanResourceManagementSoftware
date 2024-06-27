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
using System.Xml.Linq;

namespace QLNS
{
    public partial class frmPhuCap : DevExpress.XtraEditors.XtraForm
    {
        public frmPhuCap()
        {
            InitializeComponent();
        }

        BusinessAllowance phuCapB;
        bool create;
        int id;

        private void frmPhuCap_Load(object sender, EventArgs e)
        {
            phuCapB = new BusinessAllowance();
            IsDisableActions(true);
            LoadData();
        }

        void LoadData()
        {
            gcPhucap.DataSource = phuCapB.getList();
            IsDisableActions2(false);
        }

        void IsDisableActions(bool kt)
        {
            btnSave.Enabled = !kt;
            btnClose.Enabled = !kt;
            btnAdd.Enabled = kt;
            btnEdit.Enabled = kt;
            btnDetele.Enabled = kt;
            txtName.Enabled = !kt;
            txtSoTien.Enabled = !kt;
            //txtDescription.Enabled = !kt;
        }

        void IsDisableActions2(bool kt)
        {
            btnEdit.Enabled = kt;
            btnDetele.Enabled = kt;
            btnClose.Enabled = kt;
        }

        void SavesData()
        {
            if (create)
            {
                Allowance phuCap = new Allowance();
                phuCap.nameAllowance = txtName.Text;
                //phuCap.description = txtDescription.Text;
                phuCap.money = float.Parse(txtSoTien.Text);
                phuCapB.createAllowance(phuCap);
            }
            else
            {
                var phuCap = phuCapB.getItem(id);
                phuCap.nameAllowance = txtName.Text;
                //phuCap.description = txtDescription.Text;
                phuCap.money = int.Parse(txtSoTien.Text);
                phuCapB.updateAllowance(phuCap);
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SavesData();
            LoadData();
            IsDisableActions(true);
            btnClose.Enabled = true;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(false);
            emptyText();
            create = true;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(false);
            create = false;
        }

        private void btnDetele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                phuCapB.deleteAllowance(id);
                LoadData();
                emptyText();
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(true);
            IsDisableActions2(false);
            emptyText();
        }

        private void gvPhucap_Click(object sender, EventArgs e)
        {
            id = int.Parse(gvPhucap.GetFocusedRowCellValue("id").ToString());
            var pc = phuCapB.getItem(id);
            txtName.Text = pc.nameAllowance.ToString();
            //txtDescription.Text = pc.description.ToString();
            txtSoTien.Text = pc.money.ToString();
            IsDisableActions(true);
            btnClose.Enabled = true;
        }

        void emptyText()
        {
            txtName.Text = string.Empty;
            txtSoTien.Text = "0";
            //txtDescription.Text = string.Empty;
        }
    }
}