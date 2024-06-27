namespace QLNS
{
    partial class frmChamCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamCong));
            this.btnCheckInOut = new DevExpress.XtraEditors.SimpleButton();
            this.calDateTime = new System.Windows.Forms.MonthCalendar();
            this.rdStatus = new DevExpress.XtraEditors.GroupControl();
            this.rdgStatus = new DevExpress.XtraEditors.RadioGroup();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.rdStatus)).BeginInit();
            this.rdStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgStatus.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckInOut
            // 
            this.btnCheckInOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckInOut.ImageOptions.Image")));
            this.btnCheckInOut.Location = new System.Drawing.Point(540, 174);
            this.btnCheckInOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckInOut.Name = "btnCheckInOut";
            this.btnCheckInOut.Size = new System.Drawing.Size(132, 48);
            this.btnCheckInOut.TabIndex = 0;
            this.btnCheckInOut.Text = "Chấm công";
            this.btnCheckInOut.Click += new System.EventHandler(this.btnCheckInOut_Click);
            // 
            // calDateTime
            // 
            this.calDateTime.Location = new System.Drawing.Point(21, 22);
            this.calDateTime.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.calDateTime.Name = "calDateTime";
            this.calDateTime.TabIndex = 1;
            this.calDateTime.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calDateTime_DateSelected);
            // 
            // rdStatus
            // 
            this.rdStatus.Controls.Add(this.rdgStatus);
            this.rdStatus.Location = new System.Drawing.Point(300, 22);
            this.rdStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdStatus.Name = "rdStatus";
            this.rdStatus.Size = new System.Drawing.Size(624, 128);
            this.rdStatus.TabIndex = 2;
            this.rdStatus.Text = "Chấm công";
            this.rdStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.rdStatus_Paint);
            // 
            // rdgStatus
            // 
            this.rdgStatus.Location = new System.Drawing.Point(6, 32);
            this.rdgStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdgStatus.Name = "rdgStatus";
            this.rdgStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("NP", "Nghỉ phép"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("0", "Nghỉ không lương"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("VR", "Việc riêng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("0.5", "Nửa ngày"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("8", "Cả ngày"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("NL", "Ngày lễ"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("NNL", "Nửa NL"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CN", "CN"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("LCN", "Làm CN"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("NCN", "Nửa CN"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("9", "Tăng ca 1h"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("10", "Tăng ca 2h"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("11", "Tăng ca 3h"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("12", "Tăng ca 4h")});
            this.rdgStatus.Size = new System.Drawing.Size(612, 87);
            this.rdgStatus.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.labelControl12);
            this.groupBox1.Controls.Add(this.labelControl11);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(21, 236);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(897, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chú ý";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.labelControl12.Appearance.Options.UseBackColor = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(257, 95);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(151, 17);
            this.labelControl12.TabIndex = 8;
            this.labelControl12.Text = "NCN : Làm nửa ngày CN";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.labelControl11.Appearance.Options.UseBackColor = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(257, 71);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(136, 17);
            this.labelControl11.TabIndex = 7;
            this.labelControl11.Text = "NNL :Làm nửa ngày lễ";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.labelControl10.Appearance.Options.UseBackColor = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(642, 95);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(91, 16);
            this.labelControl10.TabIndex = 6;
            this.labelControl10.Text = "12 : Tăng ca 4h";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.labelControl9.Appearance.Options.UseBackColor = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(642, 72);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(91, 16);
            this.labelControl9.TabIndex = 5;
            this.labelControl9.Text = "11 : Tăng ca 3h";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.labelControl8.Appearance.Options.UseBackColor = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(642, 25);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(84, 16);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "9 : Tăng ca 1h";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.labelControl7.Appearance.Options.UseBackColor = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(642, 48);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(91, 16);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "10 : Tăng ca 2h";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.labelControl6.Appearance.Options.UseBackColor = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(257, 48);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(123, 17);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "LCN : Làm chủ nhật";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.labelControl5.Appearance.Options.UseBackColor = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(257, 25);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(74, 17);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "NL : Ngày lễ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.labelControl4.Appearance.Options.UseBackColor = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(7, 95);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(123, 17);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "0.5 : Nghỉ nửa ngày";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(7, 71);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(130, 17);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "0 : Nghỉ không lương";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 48);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(207, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "VR : Nghỉ việc riêng (Cưới hỏi , ...)";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(7, 25);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "NP : Nghỉ phép";
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdStatus);
            this.Controls.Add(this.calDateTime);
            this.Controls.Add(this.btnCheckInOut);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chấm công";
            this.Load += new System.EventHandler(this.frmChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rdStatus)).EndInit();
            this.rdStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgStatus.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCheckInOut;
        private System.Windows.Forms.MonthCalendar calDateTime;
        private DevExpress.XtraEditors.GroupControl rdStatus;
        private DevExpress.XtraEditors.RadioGroup rdgStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
    }
}