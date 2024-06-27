using Business;
using DataObject;
using DevExpress.Drawing.Internal.Fonts.Interop;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
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
    public partial class frmBangCongChiTiet : DevExpress.XtraEditors.XtraForm
    {
        public frmBangCongChiTiet()
        {
            InitializeComponent();
        }

        BusinessBangCongChiTiet BusinessBangCongChiTiet;
        BangCongBusiness BangCongBusiness;
        BoardSalaryDe salaryDe;
        BusinessStaff staff;
        
        public int code;
        public int year;
        public int month;

        private void frmBangCongChiTiet_Load(object sender, EventArgs e)
        {
            cbYear.Text = year.ToString();
            cbMonth.Text = month.ToString();
            BusinessBangCongChiTiet = new BusinessBangCongChiTiet();
            BangCongBusiness = new BangCongBusiness();
            
            staff = new BusinessStaff();
            gcBangCongChiTiet.DataSource = BusinessBangCongChiTiet.getList(code);
            gvBangCongChiTiet.OptionsBehavior.Editable = false;
            CustomView(int.Parse(cbMonth.Text), int.Parse(cbYear.Text));

        }

        public void loadData ()
        {
            BusinessBangCongChiTiet = new BusinessBangCongChiTiet();
            gcBangCongChiTiet.DataSource = BusinessBangCongChiTiet.getList(int.Parse(cbYear.Text) * 100 + int.Parse(cbMonth.Text));
            CustomView(int.Parse(cbMonth.Text), int.Parse(cbYear.Text));
            gvBangCongChiTiet.OptionsBehavior.Editable = false;
        }

        private async void barBtnAdd_ItemClickAsync(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (BangCongBusiness.checkData(int.Parse(cbYear.Text) * 100 + int.Parse(cbMonth.Text)) == false)
            {
                SplashScreenManager.ShowForm(typeof(frmLoading), true, true);
                await Task.Delay(1500);
                List<Staff> lsNhanVien = staff.getList();
                BusinessBangCongChiTiet.phatSinhboardSalaryDe(int.Parse(cbMonth.Text), int.Parse(cbYear.Text));
                var bc = BangCongBusiness.getItem(int.Parse(cbYear.Text) * 100 + int.Parse(cbMonth.Text));
                bc.status = true;
                BangCongBusiness.updateBoardSalary(bc);
                SplashScreenManager.CloseForm();
            }
            else
            {
                MessageBox.Show("Kỳ công đã được phát sinh");
            }
            loadData();
        }

        private void btnShow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }

        private void btnPrints_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<BoardSalaryDe> lts = BusinessBangCongChiTiet.getList(code);
            RBoardSalary rBoardSalary = new RBoardSalary(lts , code.ToString());
            rBoardSalary.ShowPreviewDialog();
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }

        private void barBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private int GetDayNumber(int thang, int nam)
        {
            int dayNumber = 0;
            switch (thang)
            {
                case 2:
                    dayNumber = (nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0 ? 29 : 28;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    dayNumber = 30;
                    break;

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dayNumber = 31;
                    break;
            }

            return dayNumber;
        }

        private void CustomView(int thang, int nam)
        {
            //gvBangCongChiTiet.RestoreLayoutFromXml(Application.StartupPath + @"\BangCong_Layout.xml");
            int i;
            //foreach (GridColumn gridColumn in gvBangCongChiTiet.Columns)
            //{
            //    if (gridColumn.FieldName == "nameStaff") continue;

            //    RepositoryItemTextEdit textEdit = new RepositoryItemTextEdit();
            //    textEdit.Mask.MaskType = MaskType.RegEx;
            //    textEdit.Mask.EditMask = @"\p{Lu}+";
            //    gridColumn.ColumnEdit = textEdit;
            //}

            for (i = 1; i <= GetDayNumber(thang, nam); i++)
            {
                DateTime newDate = new DateTime(nam, thang, i);

                GridColumn column = new GridColumn();
                column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                string fieldName = "D" + i;
                switch (newDate.DayOfWeek.ToString())
                {
                    case "Monday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Hai " + Environment.NewLine + "Ngày " +i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                       
                        break;

                    case "Tuesday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Ba " + Environment.NewLine + "Ngày " + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        
                        break;

                    case "Wednesday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Tư " + Environment.NewLine + "Ngày " + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        
                        break;
                    case "Thursday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Năm " + Environment.NewLine + "Ngày  " + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        
                        break;
                    case "Friday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Sáu " + Environment.NewLine + "Ngày " + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                       
                        break;
                    case "Saturday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T.Bảy " + Environment.NewLine + "Ngày " + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Red;
                        column.AppearanceHeader.BackColor = Color.Violet;
                        column.AppearanceHeader.BackColor2 = Color.Violet;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Khaki;
                        column.OptionsColumn.AllowFocus = true;
                        
                        break;
                    case "Sunday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "CN " + Environment.NewLine + "Ngày " + i;
                        column.OptionsColumn.AllowEdit = false;
                        column.AppearanceHeader.ForeColor = Color.Red;
                        column.AppearanceHeader.BackColor = Color.GreenYellow;
                        column.AppearanceHeader.BackColor2 = Color.GreenYellow;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Orange;
                        
                        break;
                }
            }

            while (i <= 31)
            {
                gvBangCongChiTiet.Columns[i + 1].Visible = false;
                i++;
            }

        }

        private void menuChamCong_Click(object sender, EventArgs e)
        {
            frmChamCong frmChamCong = new frmChamCong();
            frmChamCong.code = code;
            frmChamCong.idStaff = int.Parse(gvBangCongChiTiet.GetFocusedRowCellValue("idStaff").ToString());
            frmChamCong.nameStaff = gvBangCongChiTiet.GetFocusedRowCellValue("nameStaff").ToString();
            frmChamCong.ngay = gvBangCongChiTiet.FocusedColumn.FieldName.ToString();
            frmChamCong.ShowDialog();
        }

        private void gvBangCongChiTiet_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                
                var gridView = (GridView)sender;
                var hitInfo = gridView.CalcHitInfo(e.Location);
                if (hitInfo.InRow || hitInfo.InRowCell)
                {
                    gridView.FocusedRowHandle = hitInfo.RowHandle;
                    contextMenuStrip1.Show(gcBangCongChiTiet, e.Location);
                }
            }
        }

        private void gvBangCongChiTiet_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.CellValue == null)
            {
            }
            else
            {
                if (e.CellValue.ToString() == "0")
                {
                    e.Appearance.BackColor = Color.OrangeRed;
                    e.Appearance.ForeColor = Color.White;

                }
                if (e.CellValue.ToString() == "VR")
                {
                    e.Appearance.BackColor = Color.DarkGreen;
                    e.Appearance.ForeColor = Color.White;
                }

                if (e.CellValue.ToString() == "NP")
                {
                    e.Appearance.BackColor = Color.LightBlue;
                }

                if (e.CellValue.ToString() == "0.5")
                {
                    e.Appearance.BackColor = Color.YellowGreen;
                    e.Appearance.ForeColor = Color.White;
                }
                if (e.CellValue.ToString() == "LCN")
                {
                    e.Appearance.BackColor = Color.Purple;
                    e.Appearance.ForeColor = Color.White;
                }
                if (e.CellValue.ToString() == "NL")
                {
                    e.Appearance.BackColor = Color.Purple;
                    e.Appearance.ForeColor = Color.White;
                }
                if (e.CellValue.ToString() == "NCN")
                {
                    e.Appearance.BackColor = Color.Purple;
                    e.Appearance.ForeColor = Color.White;
                }
                if (e.CellValue.ToString() == "NNL")
                {
                    e.Appearance.BackColor = Color.Purple;
                    e.Appearance.ForeColor = Color.White;
                }
            }
        }

        private void gcBangCongChiTiet_Click(object sender, EventArgs e)
        {

        }
    }
}