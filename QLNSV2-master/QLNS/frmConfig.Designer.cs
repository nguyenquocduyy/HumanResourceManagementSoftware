namespace QLNS
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.txtnameProgram = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtbasicSalary = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtnameManufactory = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtnameProgram.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbasicSalary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnameManufactory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnameProgram
            // 
            this.txtnameProgram.Location = new System.Drawing.Point(68, 85);
            this.txtnameProgram.Name = "txtnameProgram";
            this.txtnameProgram.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtnameProgram.Properties.Appearance.Options.UseFont = true;
            this.txtnameProgram.Size = new System.Drawing.Size(340, 40);
            this.txtnameProgram.TabIndex = 21;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(36, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(215, 34);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Tên chương trình";
            // 
            // BtnSave
            // 
            this.BtnSave.AutoSize = true;
            this.BtnSave.AutoWidthInLayoutControl = true;
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(187, 412);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(40, 39);
            this.BtnSave.TabIndex = 19;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtbasicSalary
            // 
            this.txtbasicSalary.Location = new System.Drawing.Point(68, 310);
            this.txtbasicSalary.Name = "txtbasicSalary";
            this.txtbasicSalary.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtbasicSalary.Properties.Appearance.Options.UseFont = true;
            this.txtbasicSalary.Size = new System.Drawing.Size(340, 40);
            this.txtbasicSalary.TabIndex = 16;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(36, 269);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(171, 34);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Lương cơ bản";
            // 
            // txtnameManufactory
            // 
            this.txtnameManufactory.Location = new System.Drawing.Point(68, 203);
            this.txtnameManufactory.Name = "txtnameManufactory";
            this.txtnameManufactory.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtnameManufactory.Properties.Appearance.Options.UseFont = true;
            this.txtnameManufactory.Size = new System.Drawing.Size(340, 40);
            this.txtnameManufactory.TabIndex = 14;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(36, 151);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(147, 34);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Tên công ty";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 491);
            this.Controls.Add(this.txtnameProgram);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtbasicSalary);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtnameManufactory);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConfig";
            this.Text = "Quản lý hệ thống";
            ((System.ComponentModel.ISupportInitialize)(this.txtnameProgram.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbasicSalary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnameManufactory.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtnameProgram;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.TextEdit txtbasicSalary;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtnameManufactory;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}