namespace QLNS
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassRe = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPasswordNews = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassOld = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassRe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordNews.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassOld.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.txtPassRe);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.txtPasswordNews);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txtPassOld);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 636);
            this.panel1.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(48, 114);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Size = new System.Drawing.Size(340, 40);
            this.txtUsername.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(16, 61);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(122, 34);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Tài khoản";
            // 
            // BtnSave
            // 
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(180, 538);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(45, 54);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtPassRe
            // 
            this.txtPassRe.Location = new System.Drawing.Point(48, 455);
            this.txtPassRe.Name = "txtPassRe";
            this.txtPassRe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtPassRe.Properties.Appearance.Options.UseFont = true;
            this.txtPassRe.Properties.PasswordChar = '*';
            this.txtPassRe.Size = new System.Drawing.Size(340, 40);
            this.txtPassRe.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(16, 415);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 34);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Nhập lại";
            // 
            // txtPasswordNews
            // 
            this.txtPasswordNews.Location = new System.Drawing.Point(48, 339);
            this.txtPasswordNews.Name = "txtPasswordNews";
            this.txtPasswordNews.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtPasswordNews.Properties.Appearance.Options.UseFont = true;
            this.txtPasswordNews.Properties.PasswordChar = '*';
            this.txtPasswordNews.Size = new System.Drawing.Size(340, 40);
            this.txtPasswordNews.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(16, 298);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(171, 34);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Mật khẩu mới";
            // 
            // txtPassOld
            // 
            this.txtPassOld.Location = new System.Drawing.Point(48, 232);
            this.txtPassOld.Name = "txtPassOld";
            this.txtPassOld.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtPassOld.Properties.Appearance.Options.UseFont = true;
            this.txtPassOld.Properties.PasswordChar = '*';
            this.txtPassOld.Size = new System.Drawing.Size(340, 40);
            this.txtPassOld.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 180);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(154, 34);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Mật khẩu cũ";
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 636);
            this.Controls.Add(this.panel1);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassRe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordNews.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassOld.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtPassRe;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPasswordNews;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPassOld;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}