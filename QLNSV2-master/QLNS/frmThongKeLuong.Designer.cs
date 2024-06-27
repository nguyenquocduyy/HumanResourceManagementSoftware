namespace QLNS
{
    partial class frmThongKeLuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeLuong));
            this.salary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.withofleave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dayOff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wordDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameStaff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idStaff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvBangLuong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.allowance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcBangLuong = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnShow = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBangLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salary
            // 
            this.salary.Caption = "Thực nhận";
            this.salary.DisplayFormat.FormatString = "c0";
            this.salary.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.salary.FieldName = "salary";
            this.salary.MinWidth = 30;
            this.salary.Name = "salary";
            this.salary.Visible = true;
            this.salary.VisibleIndex = 7;
            this.salary.Width = 112;
            // 
            // withofleave
            // 
            this.withofleave.Caption = "Nghỉ không lương";
            this.withofleave.FieldName = "withofleave";
            this.withofleave.MinWidth = 30;
            this.withofleave.Name = "withofleave";
            this.withofleave.Visible = true;
            this.withofleave.VisibleIndex = 5;
            this.withofleave.Width = 112;
            // 
            // dayOff
            // 
            this.dayOff.Caption = "Nghỉ có lương";
            this.dayOff.FieldName = "dayOff";
            this.dayOff.MinWidth = 30;
            this.dayOff.Name = "dayOff";
            this.dayOff.Visible = true;
            this.dayOff.VisibleIndex = 4;
            this.dayOff.Width = 112;
            // 
            // wordDay
            // 
            this.wordDay.Caption = "Ngày công thực";
            this.wordDay.FieldName = "wordDay";
            this.wordDay.MinWidth = 30;
            this.wordDay.Name = "wordDay";
            this.wordDay.Visible = true;
            this.wordDay.VisibleIndex = 3;
            this.wordDay.Width = 112;
            // 
            // nameStaff
            // 
            this.nameStaff.Caption = "Họ tên";
            this.nameStaff.FieldName = "nameStaff";
            this.nameStaff.MinWidth = 30;
            this.nameStaff.Name = "nameStaff";
            this.nameStaff.Visible = true;
            this.nameStaff.VisibleIndex = 2;
            this.nameStaff.Width = 112;
            // 
            // idStaff
            // 
            this.idStaff.Caption = "Mã NV";
            this.idStaff.FieldName = "idStaff";
            this.idStaff.MinWidth = 30;
            this.idStaff.Name = "idStaff";
            this.idStaff.Visible = true;
            this.idStaff.VisibleIndex = 1;
            this.idStaff.Width = 112;
            // 
            // code
            // 
            this.code.Caption = "Mã kỳ công";
            this.code.FieldName = "code";
            this.code.MaxWidth = 300;
            this.code.MinWidth = 300;
            this.code.Name = "code";
            this.code.Visible = true;
            this.code.VisibleIndex = 0;
            this.code.Width = 300;
            // 
            // idS
            // 
            this.idS.Caption = "id";
            this.idS.FieldName = "id";
            this.idS.MinWidth = 30;
            this.idS.Name = "idS";
            this.idS.Width = 112;
            // 
            // gvBangLuong
            // 
            this.gvBangLuong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idS,
            this.code,
            this.idStaff,
            this.nameStaff,
            this.wordDay,
            this.dayOff,
            this.withofleave,
            this.allowance,
            this.salary});
            this.gvBangLuong.DetailHeight = 349;
            this.gvBangLuong.GridControl = this.gcBangLuong;
            this.gvBangLuong.Name = "gvBangLuong";
            this.gvBangLuong.OptionsBehavior.Editable = false;
            this.gvBangLuong.OptionsView.ShowGroupPanel = false;
            // 
            // allowance
            // 
            this.allowance.Caption = "Tổng phụ cấp";
            this.allowance.FieldName = "allowance";
            this.allowance.MinWidth = 30;
            this.allowance.Name = "allowance";
            this.allowance.Visible = true;
            this.allowance.VisibleIndex = 6;
            // 
            // gcBangLuong
            // 
            this.gcBangLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBangLuong.Location = new System.Drawing.Point(0, 0);
            this.gcBangLuong.MainView = this.gvBangLuong;
            this.gcBangLuong.MenuManager = this.barManager1;
            this.gcBangLuong.Name = "gcBangLuong";
            this.gcBangLuong.Size = new System.Drawing.Size(2011, 736);
            this.gcBangLuong.TabIndex = 1;
            this.gcBangLuong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBangLuong});
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnAdd,
            this.btnPrint,
            this.btnDelete});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barBtnAdd
            // 
            this.barBtnAdd.Caption = "Tạo báo cáo";
            this.barBtnAdd.Id = 0;
            this.barBtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAdd.ImageOptions.Image")));
            this.barBtnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnAdd.ImageOptions.LargeImage")));
            this.barBtnAdd.Name = "barBtnAdd";
            this.barBtnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAdd_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "In";
            this.btnPrint.Id = 6;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.LargeImage")));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 8;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(2011, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1024);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(2011, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 990);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2011, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 990);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 34);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnShow);
            this.splitContainer1.Panel1.Controls.Add(this.cbMonth);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.cbYear);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcBangLuong);
            this.splitContainer1.Size = new System.Drawing.Size(2011, 990);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 5;
            // 
            // cbMonth
            // 
            this.cbMonth.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMonth.Location = new System.Drawing.Point(131, 102);
            this.cbMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(227, 43);
            this.cbMonth.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(43, 111);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 29);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Tháng";
            // 
            // cbYear
            // 
            this.cbYear.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027"});
            this.cbYear.Location = new System.Drawing.Point(131, 47);
            this.cbYear.Margin = new System.Windows.Forms.Padding(4);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(227, 43);
            this.cbYear.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(61, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 29);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Năm";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(388, 80);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(112, 34);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Xem";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmThongKeLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2011, 1044);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmThongKeLuong";
            this.Text = "Thống kê bảng lương";
            ((System.ComponentModel.ISupportInitialize)(this.gvBangLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBangLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn salary;
        private DevExpress.XtraGrid.Columns.GridColumn withofleave;
        private DevExpress.XtraGrid.Columns.GridColumn dayOff;
        private DevExpress.XtraGrid.Columns.GridColumn wordDay;
        private DevExpress.XtraGrid.Columns.GridColumn nameStaff;
        private DevExpress.XtraGrid.Columns.GridColumn idStaff;
        private DevExpress.XtraGrid.Columns.GridColumn code;
        private DevExpress.XtraGrid.Columns.GridColumn idS;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBangLuong;
        private DevExpress.XtraGrid.Columns.GridColumn allowance;
        private DevExpress.XtraGrid.GridControl gcBangLuong;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnAdd;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cbMonth;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cbYear;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraEditors.SimpleButton btnShow;
    }
}