namespace BKI_QLTTQuocAnh.DanhMuc
{
    partial class f109_danh_muc_dai_de
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f109_danh_muc_dai_de));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.m_txt_ten_dai = new System.Windows.Forms.TextBox();
            this.m_txt_ma_dai = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.m_cmd_save = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_huy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.m_txt_ten_dai);
            this.groupControl1.Controls.Add(this.m_txt_ma_dai);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(359, 207);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "CHI TIẾT ĐAI";
            // 
            // m_txt_ten_dai
            // 
            this.m_txt_ten_dai.Location = new System.Drawing.Point(100, 129);
            this.m_txt_ten_dai.Name = "m_txt_ten_dai";
            this.m_txt_ten_dai.Size = new System.Drawing.Size(226, 20);
            this.m_txt_ten_dai.TabIndex = 3;
            // 
            // m_txt_ma_dai
            // 
            this.m_txt_ma_dai.Location = new System.Drawing.Point(100, 82);
            this.m_txt_ma_dai.Name = "m_txt_ma_dai";
            this.m_txt_ma_dai.Size = new System.Drawing.Size(226, 20);
            this.m_txt_ma_dai.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 132);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên đai";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 82);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã đai";
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_save.Image")));
            this.m_cmd_save.Location = new System.Drawing.Point(76, 243);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(84, 35);
            this.m_cmd_save.TabIndex = 4;
            this.m_cmd_save.Text = "LƯU";
            this.m_cmd_save.Click += new System.EventHandler(this.save_data);
            // 
            // m_cmd_huy
            // 
            this.m_cmd_huy.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_huy.Image")));
            this.m_cmd_huy.Location = new System.Drawing.Point(206, 243);
            this.m_cmd_huy.Name = "m_cmd_huy";
            this.m_cmd_huy.Size = new System.Drawing.Size(88, 36);
            this.m_cmd_huy.TabIndex = 5;
            this.m_cmd_huy.Text = "HỦY";
            this.m_cmd_huy.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // f109_danh_muc_dai_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 302);
            this.Controls.Add(this.m_cmd_save);
            this.Controls.Add(this.m_cmd_huy);
            this.Controls.Add(this.groupControl1);
            this.Name = "f109_danh_muc_dai_de";
            this.Text = "F101 - Chi tiết danh mục đai";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox m_txt_ten_dai;
        private System.Windows.Forms.TextBox m_txt_ma_dai;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_save;
        private DevExpress.XtraEditors.SimpleButton m_cmd_huy;
    }
}