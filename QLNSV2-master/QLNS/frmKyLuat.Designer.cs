namespace QLNS
{
    partial class frmKyLuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKyLuat));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.tbnPrintList = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnClose = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpkNgayKT = new System.Windows.Forms.DateTimePicker();
            this.txtFormality = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtreason = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lkNhanVien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameStaff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDiscipline = new DevExpress.XtraGrid.GridControl();
            this.gvDiscipline = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.formality = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.createAt = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormality.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtreason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiscipline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiscipline)).BeginInit();
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
            this.barBtnPrint,
            this.barBtnSave,
            this.barBtnClose,
            this.tbnPrintList});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnPrint),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbnPrintList, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnClose)});
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
            this.barBtnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAdd_ItemClick);
            // 
            // barBtnEdit
            // 
            this.barBtnEdit.Caption = "Sửa";
            this.barBtnEdit.Id = 1;
            this.barBtnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnEdit.ImageOptions.Image")));
            this.barBtnEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnEdit.ImageOptions.LargeImage")));
            this.barBtnEdit.Name = "barBtnEdit";
            this.barBtnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEdit_ItemClick);
            // 
            // barBtnDelete
            // 
            this.barBtnDelete.Caption = "Xóa";
            this.barBtnDelete.Id = 2;
            this.barBtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDelete.ImageOptions.Image")));
            this.barBtnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDelete.ImageOptions.LargeImage")));
            this.barBtnDelete.Name = "barBtnDelete";
            this.barBtnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDelete_ItemClick);
            // 
            // barBtnSave
            // 
            this.barBtnSave.Caption = "Lưu";
            this.barBtnSave.Id = 4;
            this.barBtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSave.ImageOptions.Image")));
            this.barBtnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSave.ImageOptions.LargeImage")));
            this.barBtnSave.Name = "barBtnSave";
            this.barBtnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSave_ItemClick);
            // 
            // barBtnPrint
            // 
            this.barBtnPrint.Caption = "In";
            this.barBtnPrint.Id = 3;
            this.barBtnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnPrint.ImageOptions.Image")));
            this.barBtnPrint.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnPrint.ImageOptions.LargeImage")));
            this.barBtnPrint.Name = "barBtnPrint";
            this.barBtnPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPrint_ItemClick);
            // 
            // tbnPrintList
            // 
            this.tbnPrintList.Caption = "In danh sách";
            this.tbnPrintList.Id = 6;
            this.tbnPrintList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tbnPrintList.ImageOptions.Image")));
            this.tbnPrintList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("tbnPrintList.ImageOptions.LargeImage")));
            this.tbnPrintList.Name = "tbnPrintList";
            this.tbnPrintList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbnPrintList_ItemClick);
            // 
            // barBtnClose
            // 
            this.barBtnClose.Caption = "Đóng";
            this.barBtnClose.Id = 5;
            this.barBtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnClose.ImageOptions.Image")));
            this.barBtnClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnClose.ImageOptions.LargeImage")));
            this.barBtnClose.Name = "barBtnClose";
            this.barBtnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1448, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 872);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1448, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 842);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1448, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 842);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.dtpkNgayKT);
            this.splitContainer1.Panel1.Controls.Add(this.txtFormality);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.txtreason);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.lkNhanVien);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDiscipline);
            this.splitContainer1.Size = new System.Drawing.Size(1448, 842);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(419, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(218, 33);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Ngày khen thưởng";
            // 
            // dtpkNgayKT
            // 
            this.dtpkNgayKT.CalendarFont = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayKT.CustomFormat = "yyyy-MM-dd";
            this.dtpkNgayKT.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayKT.Location = new System.Drawing.Point(437, 80);
            this.dtpkNgayKT.Name = "dtpkNgayKT";
            this.dtpkNgayKT.Size = new System.Drawing.Size(270, 35);
            this.dtpkNgayKT.TabIndex = 22;
            // 
            // txtFormality
            // 
            this.txtFormality.Location = new System.Drawing.Point(437, 180);
            this.txtFormality.Name = "txtFormality";
            this.txtFormality.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFormality.Properties.Appearance.Options.UseFont = true;
            this.txtFormality.Size = new System.Drawing.Size(315, 38);
            this.txtFormality.TabIndex = 14;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(419, 141);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(200, 33);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Hình thức kỷ luật";
            // 
            // txtreason
            // 
            this.txtreason.Location = new System.Drawing.Point(50, 178);
            this.txtreason.Name = "txtreason";
            this.txtreason.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtreason.Properties.Appearance.Options.UseFont = true;
            this.txtreason.Size = new System.Drawing.Size(315, 38);
            this.txtreason.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(31, 141);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 31);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Lý do";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(31, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(117, 31);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Nhân viên";
            // 
            // lkNhanVien
            // 
            this.lkNhanVien.EditValue = "";
            this.lkNhanVien.Location = new System.Drawing.Point(50, 79);
            this.lkNhanVien.Name = "lkNhanVien";
            this.lkNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lkNhanVien.Properties.Appearance.Options.UseFont = true;
            this.lkNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNhanVien.Properties.PopupView = this.searchLookUpEdit1View;
            this.lkNhanVien.Size = new System.Drawing.Size(252, 38);
            this.lkNhanVien.TabIndex = 9;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameStaff});
            this.searchLookUpEdit1View.DetailHeight = 431;
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // nameStaff
            // 
            this.nameStaff.Caption = "Nhân viên";
            this.nameStaff.FieldName = "nameStaff";
            this.nameStaff.MinWidth = 16;
            this.nameStaff.Name = "nameStaff";
            this.nameStaff.Visible = true;
            this.nameStaff.VisibleIndex = 0;
            this.nameStaff.Width = 87;
            // 
            // gcDiscipline
            // 
            this.gcDiscipline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDiscipline.Location = new System.Drawing.Point(0, 0);
            this.gcDiscipline.MainView = this.gvDiscipline;
            this.gcDiscipline.MenuManager = this.barManager1;
            this.gcDiscipline.Name = "gcDiscipline";
            this.gcDiscipline.Size = new System.Drawing.Size(1448, 511);
            this.gcDiscipline.TabIndex = 0;
            this.gcDiscipline.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDiscipline});
            // 
            // gvDiscipline
            // 
            this.gvDiscipline.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.name,
            this.reason,
            this.formality,
            this.colid,
            this.createAt});
            this.gvDiscipline.DetailHeight = 431;
            this.gvDiscipline.GridControl = this.gcDiscipline;
            this.gvDiscipline.Name = "gvDiscipline";
            this.gvDiscipline.OptionsBehavior.Editable = false;
            this.gvDiscipline.OptionsView.ShowGroupPanel = false;
            this.gvDiscipline.Click += new System.EventHandler(this.gvDiscipline_Click);
            // 
            // name
            // 
            this.name.Caption = "Nhân viên";
            this.name.FieldName = "nameStaff";
            this.name.MinWidth = 23;
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 1;
            this.name.Width = 156;
            // 
            // reason
            // 
            this.reason.Caption = "Lý do";
            this.reason.FieldName = "reason";
            this.reason.MinWidth = 23;
            this.reason.Name = "reason";
            this.reason.Visible = true;
            this.reason.VisibleIndex = 3;
            this.reason.Width = 156;
            // 
            // formality
            // 
            this.formality.Caption = "Hình thức";
            this.formality.FieldName = "formality";
            this.formality.MinWidth = 23;
            this.formality.Name = "formality";
            this.formality.Visible = true;
            this.formality.VisibleIndex = 4;
            this.formality.Width = 156;
            // 
            // colid
            // 
            this.colid.Caption = "Mã";
            this.colid.FieldName = "id";
            this.colid.MinWidth = 25;
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 48;
            // 
            // createAt
            // 
            this.createAt.Caption = "Ngày";
            this.createAt.FieldName = "createAt";
            this.createAt.MinWidth = 25;
            this.createAt.Name = "createAt";
            this.createAt.Visible = true;
            this.createAt.VisibleIndex = 2;
            this.createAt.Width = 109;
            // 
            // frmKyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 892);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmKyLuat";
            this.Text = "Kỷ luật";
            this.Load += new System.EventHandler(this.frmKyLuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFormality.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtreason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiscipline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiscipline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gcDiscipline;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDiscipline;
        private DevExpress.XtraEditors.TextEdit txtFormality;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtreason;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit lkNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn nameStaff;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn reason;
        private DevExpress.XtraGrid.Columns.GridColumn formality;
        private DevExpress.XtraBars.BarButtonItem barBtnAdd;
        private DevExpress.XtraBars.BarButtonItem barBtnEdit;
        private DevExpress.XtraBars.BarButtonItem barBtnDelete;
        private DevExpress.XtraBars.BarButtonItem barBtnPrint;
        private DevExpress.XtraBars.BarButtonItem barBtnSave;
        private DevExpress.XtraBars.BarButtonItem barBtnClose;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dtpkNgayKT;
        private DevExpress.XtraBars.BarButtonItem tbnPrintList;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn createAt;
    }
}