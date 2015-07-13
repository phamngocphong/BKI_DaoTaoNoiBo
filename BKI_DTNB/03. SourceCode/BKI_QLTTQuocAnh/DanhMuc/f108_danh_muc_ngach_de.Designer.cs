namespace BKI_QLTTQuocAnh.DanhMuc
{
    partial class f108_danh_muc_ngach_de
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f108_danh_muc_ngach_de));
            this.m_cmd_luu = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_huy = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.m_txt_ma_ngach = new DevExpress.XtraEditors.TextEdit();
            this.m_txt_ten_ngach = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_ma_ngach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_ten_ngach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_cmd_luu
            // 
            this.m_cmd_luu.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_luu.Image")));
            this.m_cmd_luu.Location = new System.Drawing.Point(64, 8);
            this.m_cmd_luu.Name = "m_cmd_luu";
            this.m_cmd_luu.Size = new System.Drawing.Size(75, 32);
            this.m_cmd_luu.TabIndex = 1;
            this.m_cmd_luu.Text = "Lưu";
            this.m_cmd_luu.Click += new System.EventHandler(this.m_cmd_luu_Click);
            // 
            // m_cmd_huy
            // 
            this.m_cmd_huy.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_huy.Image")));
            this.m_cmd_huy.Location = new System.Drawing.Point(226, 8);
            this.m_cmd_huy.Name = "m_cmd_huy";
            this.m_cmd_huy.Size = new System.Drawing.Size(75, 32);
            this.m_cmd_huy.TabIndex = 2;
            this.m_cmd_huy.Text = "Hủy";
            this.m_cmd_huy.Click += new System.EventHandler(this.m_cmd_huy_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_huy);
            this.panelControl1.Controls.Add(this.m_cmd_luu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 196);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(361, 52);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Top;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã ngạch";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 132);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên ngạch";
            // 
            // m_txt_ma_ngach
            // 
            this.m_txt_ma_ngach.Location = new System.Drawing.Point(109, 69);
            this.m_txt_ma_ngach.Name = "m_txt_ma_ngach";
            this.m_txt_ma_ngach.Size = new System.Drawing.Size(230, 20);
            this.m_txt_ma_ngach.TabIndex = 2;
            // 
            // m_txt_ten_ngach
            // 
            this.m_txt_ten_ngach.Location = new System.Drawing.Point(109, 129);
            this.m_txt_ten_ngach.Name = "m_txt_ten_ngach";
            this.m_txt_ten_ngach.Size = new System.Drawing.Size(230, 20);
            this.m_txt_ten_ngach.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.m_txt_ten_ngach);
            this.groupControl1.Controls.Add(this.m_txt_ma_ngach);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(361, 248);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "CHI TIẾT NGẠCH";
            // 
            // f108_danh_muc_ngach_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 248);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f108_danh_muc_ngach_de";
            this.Text = "f108_danh_muc_ngach_de";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_ma_ngach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_ten_ngach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton m_cmd_luu;
        private DevExpress.XtraEditors.SimpleButton m_cmd_huy;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit m_txt_ma_ngach;
        private DevExpress.XtraEditors.TextEdit m_txt_ten_ngach;
        private DevExpress.XtraEditors.GroupControl groupControl1;

    }
}