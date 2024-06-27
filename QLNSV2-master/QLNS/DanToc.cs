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
using Business;
using DataObject;
namespace QLNS
{
    public partial class DanToc : DevExpress.XtraEditors.XtraForm
    {
        
        public DanToc()
        {
            
        }

        BusinessDanToc danToc;

        private void DanToc_Load(object sender, EventArgs e)
        {
            danToc = new BusinessDanToc();
            IsDisableActions(true);
            LoadData();
        }

        void LoadData()
        {
            
        }

        void IsDisableActions(bool kt)
        {
            
        }

        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(false);
        }

        private void barBtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(false);
        }

        private void barBtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(false);
        }

        private void barBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(true);
        }

        private void barBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(true);
        }
    }
}