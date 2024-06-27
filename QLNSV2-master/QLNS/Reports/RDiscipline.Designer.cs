namespace QLNS.Reports
{
    partial class RDiscipline
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RDiscipline));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrReasion = new DevExpress.XtraReports.UI.XRLabel();
            this.xrFomaly = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrName,
            this.xrReasion,
            this.xrFomaly,
            this.xrRichText1});
            this.Detail.HeightF = 810.5F;
            this.Detail.Name = "Detail";
            // 
            // xrName
            // 
            this.xrName.Font = new DevExpress.Drawing.DXFont("Times New Roman", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrName.LocationFloat = new DevExpress.Utils.PointFloat(100F, 272.2222F);
            this.xrName.Multiline = true;
            this.xrName.Name = "xrName";
            this.xrName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrName.SizeF = new System.Drawing.SizeF(144.4444F, 23F);
            this.xrName.StylePriority.UseFont = false;
            this.xrName.Text = "xrName";
            // 
            // xrReasion
            // 
            this.xrReasion.Font = new DevExpress.Drawing.DXFont("times New Roman", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrReasion.LocationFloat = new DevExpress.Utils.PointFloat(35.00002F, 342.6389F);
            this.xrReasion.Multiline = true;
            this.xrReasion.Name = "xrReasion";
            this.xrReasion.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrReasion.SizeF = new System.Drawing.SizeF(605F, 23F);
            this.xrReasion.StylePriority.UseFont = false;
            this.xrReasion.Text = "xrName";
            // 
            // xrFomaly
            // 
            this.xrFomaly.Font = new DevExpress.Drawing.DXFont("times New Roman", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrFomaly.LocationFloat = new DevExpress.Utils.PointFloat(35.00002F, 413.0556F);
            this.xrFomaly.Multiline = true;
            this.xrFomaly.Name = "xrFomaly";
            this.xrFomaly.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrFomaly.SizeF = new System.Drawing.SizeF(605F, 22.99997F);
            this.xrFomaly.StylePriority.UseFont = false;
            this.xrFomaly.Text = "xrName";
            // 
            // xrRichText1
            // 
            this.xrRichText1.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(650F, 810.5F);
            // 
            // RDiscipline
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Version = "22.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrName;
        private DevExpress.XtraReports.UI.XRLabel xrReasion;
        private DevExpress.XtraReports.UI.XRLabel xrFomaly;
        private DevExpress.XtraReports.UI.XRRichText xrRichText1;
    }
}
