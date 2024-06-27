namespace QLNS
{
    partial class frmBangCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangCong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnShow = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnClose = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbLock = new System.Windows.Forms.CheckBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcBangCong = new DevExpress.XtraGrid.GridControl();
            this.gvBangCong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.year = new DevExpress.XtraGrid.Columns.GridColumn();
            this.month = new DevExpress.XtraGrid.Columns.GridColumn();
            this.locktb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wordDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wordDayOfMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.codeCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.status = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBangCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangCong)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnAdd,
            this.barBtnEdit,
            this.barBtnDelete,
            this.barBtnSave,
            this.barBtnClose,
            this.btnPrint,
            this.btnShow});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnAdd, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnShow),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrint),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barBtnAdd
            // 
            this.barBtnAdd.Caption = "Thêm";
            this.barBtnAdd.Id = 0;
            this.barBtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAdd.ImageOptions.Image")));
            this.barBtnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnAdd.ImageOptions.LargeImage")));
            this.barBtnAdd.Name = "barBtnAdd";
            this.barBtnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAdd_ItemClick);
            // 
            // btnShow
            // 
            this.btnShow.Caption = "Xem bảng công";
            this.btnShow.Id = 7;
            this.btnShow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.ImageOptions.Image")));
            this.btnShow.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnShow.ImageOptions.LargeImage")));
            this.btnShow.Name = "btnShow";
            this.btnShow.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnShow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShow_ItemClick);
            // 
            // barBtnEdit
            // 
            this.barBtnEdit.Caption = "Sửa";
            this.barBtnEdit.Id = 1;
            this.barBtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnEdit.ImageOptions.Image")));
            this.barBtnEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnEdit.ImageOptions.LargeImage")));
            this.barBtnEdit.Name = "barBtnEdit";
            this.barBtnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEdit_ItemClick);
            // 
            // barBtnDelete
            // 
            this.barBtnDelete.Caption = "Xóa";
            this.barBtnDelete.Id = 2;
            this.barBtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDelete.ImageOptions.Image")));
            this.barBtnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDelete.ImageOptions.LargeImage")));
            this.barBtnDelete.Name = "barBtnDelete";
            this.barBtnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDelete_ItemClick);
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
            // barBtnSave
            // 
            this.barBtnSave.Caption = "Lưu";
            this.barBtnSave.Id = 3;
            this.barBtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSave.ImageOptions.Image")));
            this.barBtnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSave.ImageOptions.LargeImage")));
            this.barBtnSave.Name = "barBtnSave";
            this.barBtnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSave_ItemClick);
            // 
            // barBtnClose
            // 
            this.barBtnClose.Caption = "Đóng";
            this.barBtnClose.Id = 5;
            this.barBtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnClose.ImageOptions.Image")));
            this.barBtnClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnClose.ImageOptions.LargeImage")));
            this.barBtnClose.Name = "barBtnClose";
            this.barBtnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnClose_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1568, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 994);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1568, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 960);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1568, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 960);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 34);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbLock);
            this.splitContainer1.Panel1.Controls.Add(this.cbMonth);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.cbYear);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcBangCong);
            this.splitContainer1.Size = new System.Drawing.Size(1568, 960);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 5;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // cbLock
            // 
            this.cbLock.AutoSize = true;
            this.cbLock.Location = new System.Drawing.Point(698, 63);
            this.cbLock.Margin = new System.Windows.Forms.Padding(4);
            this.cbLock.Name = "cbLock";
            this.cbLock.Size = new System.Drawing.Size(70, 23);
            this.cbLock.TabIndex = 6;
            this.cbLock.Text = "Khóa";
            this.cbLock.UseVisualStyleBackColor = true;
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
            this.cbMonth.Location = new System.Drawing.Point(460, 48);
            this.cbMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(180, 43);
            this.cbMonth.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(374, 57);
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
            this.cbYear.Location = new System.Drawing.Point(117, 48);
            this.cbYear.Margin = new System.Windows.Forms.Padding(4);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(180, 43);
            this.cbYear.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(48, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 29);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Năm";
            // 
            // gcBangCong
            // 
            this.gcBangCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBangCong.Location = new System.Drawing.Point(0, 0);
            this.gcBangCong.MainView = this.gvBangCong;
            this.gcBangCong.MenuManager = this.barManager1;
            this.gcBangCong.Name = "gcBangCong";
            this.gcBangCong.Size = new System.Drawing.Size(1568, 787);
            this.gcBangCong.TabIndex = 0;
            this.gcBangCong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBangCong});
            // 
            // gvBangCong
            // 
            this.gvBangCong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.code,
            this.year,
            this.month,
            this.locktb,
            this.wordDay,
            this.wordDayOfMonth,
            this.codeCompany,
            this.status});
            this.gvBangCong.DetailHeight = 349;
            this.gvBangCong.GridControl = this.gcBangCong;
            this.gvBangCong.Name = "gvBangCong";
            this.gvBangCong.OptionsBehavior.Editable = false;
            this.gvBangCong.OptionsView.ShowGroupPanel = false;
            this.gvBangCong.Click += new System.EventHandler(this.gvBangCong_Click);
            // 
            // code
            // 
            this.code.Caption = "Mã kỳ công";
            this.code.FieldName = "code";
            this.code.MaxWidth = 300;
            this.code.MinWidth = 300;
            this.code.Name = "code";
            this.code.Visible = true;
            this.code.VisibleIndex = 1;
            this.code.Width = 300;
            // 
            // year
            // 
            this.year.Caption = "Năm";
            this.year.FieldName = "year";
            this.year.MinWidth = 30;
            this.year.Name = "year";
            this.year.Visible = true;
            this.year.VisibleIndex = 0;
            this.year.Width = 112;
            // 
            // month
            // 
            this.month.Caption = "Tháng";
            this.month.FieldName = "month";
            this.month.MinWidth = 30;
            this.month.Name = "month";
            this.month.Visible = true;
            this.month.VisibleIndex = 2;
            this.month.Width = 112;
            // 
            // locktb
            // 
            this.locktb.Caption = "Khóa";
            this.locktb.FieldName = "lock";
            this.locktb.MinWidth = 30;
            this.locktb.Name = "locktb";
            this.locktb.Visible = true;
            this.locktb.VisibleIndex = 3;
            this.locktb.Width = 112;
            // 
            // wordDay
            // 
            this.wordDay.Caption = "Ngày tính công";
            this.wordDay.FieldName = "wordDay";
            this.wordDay.MinWidth = 30;
            this.wordDay.Name = "wordDay";
            this.wordDay.Visible = true;
            this.wordDay.VisibleIndex = 4;
            this.wordDay.Width = 112;
            // 
            // wordDayOfMonth
            // 
            this.wordDayOfMonth.Caption = "Ngày công";
            this.wordDayOfMonth.FieldName = "wordDayOfMonth";
            this.wordDayOfMonth.MinWidth = 30;
            this.wordDayOfMonth.Name = "wordDayOfMonth";
            this.wordDayOfMonth.Visible = true;
            this.wordDayOfMonth.VisibleIndex = 5;
            this.wordDayOfMonth.Width = 112;
            // 
            // codeCompany
            // 
            this.codeCompany.Caption = "Mã công ty";
            this.codeCompany.FieldName = "codeCompany";
            this.codeCompany.MinWidth = 30;
            this.codeCompany.Name = "codeCompany";
            this.codeCompany.Width = 112;
            // 
            // status
            // 
            this.status.Caption = "Trạng thái";
            this.status.FieldName = "status";
            this.status.MinWidth = 30;
            this.status.Name = "status";
            this.status.Visible = true;
            this.status.VisibleIndex = 6;
            this.status.Width = 112;
            // 
            // frmBangCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 1014);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBangCong";
            this.Text = "Bảng công";
            this.Load += new System.EventHandler(this.frmBangCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBangCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barBtnAdd;
        private DevExpress.XtraBars.BarButtonItem barBtnEdit;
        private DevExpress.XtraBars.BarButtonItem barBtnDelete;
        private DevExpress.XtraBars.BarButtonItem barBtnSave;
        private DevExpress.XtraBars.BarButtonItem barBtnClose;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcBangCong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBangCong;
        private DevExpress.XtraGrid.Columns.GridColumn code;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.CheckBox cbLock;
        private System.Windows.Forms.ComboBox cbMonth;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn year;
        private DevExpress.XtraGrid.Columns.GridColumn month;
        private DevExpress.XtraGrid.Columns.GridColumn locktb;
        private DevExpress.XtraGrid.Columns.GridColumn wordDay;
        private DevExpress.XtraGrid.Columns.GridColumn wordDayOfMonth;
        private DevExpress.XtraGrid.Columns.GridColumn codeCompany;
        private DevExpress.XtraGrid.Columns.GridColumn status;
        private DevExpress.XtraBars.BarButtonItem btnShow;
    }
}