namespace BKI_QLTTQuocAnh.DanhMuc
{
    partial class f101_danh_muc_mon_hoc_de
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f101_danh_muc_mon_hoc_de));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.m_cmd_exit = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_save = new DevExpress.XtraEditors.SimpleButton();
            this.m_txt_don_vi_giang_day = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.m_txt_ma_mon_hoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.m_txt_ten_mon_hoc = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_don_vi_giang_day.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_ma_mon_hoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_ten_mon_hoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.m_cmd_exit);
            this.groupControl1.Controls.Add(this.m_cmd_save);
            this.groupControl1.Controls.Add(this.m_txt_don_vi_giang_day);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.m_txt_ma_mon_hoc);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.m_txt_ten_mon_hoc);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(379, 330);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "CHI TIẾT MÔN HỌC";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_exit.Image")));
            this.m_cmd_exit.Location = new System.Drawing.Point(207, 238);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(82, 38);
            this.m_cmd_exit.TabIndex = 7;
            this.m_cmd_exit.Text = "HỦY";
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_save.Image")));
            this.m_cmd_save.Location = new System.Drawing.Point(71, 238);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(82, 38);
            this.m_cmd_save.TabIndex = 6;
            this.m_cmd_save.Text = "LƯU";
            this.m_cmd_save.Click += new System.EventHandler(this.save_data);
            // 
            // m_txt_don_vi_giang_day
            // 
            this.m_txt_don_vi_giang_day.Location = new System.Drawing.Point(143, 157);
            this.m_txt_don_vi_giang_day.Name = "m_txt_don_vi_giang_day";
            this.m_txt_don_vi_giang_day.Size = new System.Drawing.Size(221, 20);
            this.m_txt_don_vi_giang_day.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 107);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên môn học";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã môn học";
            // 
            // m_txt_ma_mon_hoc
            // 
            this.m_txt_ma_mon_hoc.Location = new System.Drawing.Point(143, 59);
            this.m_txt_ma_mon_hoc.Name = "m_txt_ma_mon_hoc";
            this.m_txt_ma_mon_hoc.Size = new System.Drawing.Size(221, 20);
            this.m_txt_ma_mon_hoc.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 161);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(95, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Đơn vị giảng dạy";
            // 
            // m_txt_ten_mon_hoc
            // 
            this.m_txt_ten_mon_hoc.Location = new System.Drawing.Point(143, 106);
            this.m_txt_ten_mon_hoc.Name = "m_txt_ten_mon_hoc";
            this.m_txt_ten_mon_hoc.Size = new System.Drawing.Size(221, 20);
            this.m_txt_ten_mon_hoc.TabIndex = 5;
            // 
            // f101_danh_muc_mon_hoc_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 356);
            this.Controls.Add(this.groupControl1);
            this.Name = "f101_danh_muc_mon_hoc_de";
            this.Text = "F101 - CHI TIẾT MÔN HỌC";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_don_vi_giang_day.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_ma_mon_hoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_ten_mon_hoc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit m_txt_don_vi_giang_day;
        private DevExpress.XtraEditors.TextEdit m_txt_ma_mon_hoc;
        private DevExpress.XtraEditors.TextEdit m_txt_ten_mon_hoc;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_exit;
        private DevExpress.XtraEditors.SimpleButton m_cmd_save;
    }
}