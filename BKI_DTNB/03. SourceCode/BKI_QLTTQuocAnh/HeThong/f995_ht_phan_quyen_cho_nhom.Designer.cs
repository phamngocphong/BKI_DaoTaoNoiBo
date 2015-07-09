namespace BKI_QLTTQuocAnh.HeThong
{
    partial class f995_ht_phan_quyen_cho_nhom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f995_ht_phan_quyen_cho_nhom));
            this.label1 = new System.Windows.Forms.Label();
            this.m_cbo_user_group = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_lbox_quyen_chua_cap = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_lbox_quyen_da_cap = new System.Windows.Forms.ListBox();
            this.m_cmd_left_2_right = new SIS.Controls.Button.SiSButton();
            this.m_cmd_left_2_right_all = new SIS.Controls.Button.SiSButton();
            this.m_cmd_right_2_left = new SIS.Controls.Button.SiSButton();
            this.m_cmd_right_2_left_all = new SIS.Controls.Button.SiSButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_save = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn nhóm người sử dụng";
            // 
            // m_cbo_user_group
            // 
            this.m_cbo_user_group.FormattingEnabled = true;
            this.m_cbo_user_group.Location = new System.Drawing.Point(189, 12);
            this.m_cbo_user_group.Name = "m_cbo_user_group";
            this.m_cbo_user_group.Size = new System.Drawing.Size(178, 21);
            this.m_cbo_user_group.TabIndex = 1;
            this.m_cbo_user_group.SelectedIndexChanged += new System.EventHandler(this.m_cbo_user_group_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_lbox_quyen_chua_cap);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 238);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quyền chưa cấp";
            // 
            // m_lbox_quyen_chua_cap
            // 
            this.m_lbox_quyen_chua_cap.FormattingEnabled = true;
            this.m_lbox_quyen_chua_cap.Location = new System.Drawing.Point(6, 19);
            this.m_lbox_quyen_chua_cap.Name = "m_lbox_quyen_chua_cap";
            this.m_lbox_quyen_chua_cap.Size = new System.Drawing.Size(188, 212);
            this.m_lbox_quyen_chua_cap.TabIndex = 0;
            this.m_lbox_quyen_chua_cap.SelectedIndexChanged += new System.EventHandler(this.m_lbox_quyen_chua_cap_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_lbox_quyen_da_cap);
            this.groupBox2.Location = new System.Drawing.Point(324, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 239);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quyền đã cấp";
            // 
            // m_lbox_quyen_da_cap
            // 
            this.m_lbox_quyen_da_cap.FormattingEnabled = true;
            this.m_lbox_quyen_da_cap.Location = new System.Drawing.Point(6, 20);
            this.m_lbox_quyen_da_cap.Name = "m_lbox_quyen_da_cap";
            this.m_lbox_quyen_da_cap.Size = new System.Drawing.Size(188, 212);
            this.m_lbox_quyen_da_cap.TabIndex = 1;
            this.m_lbox_quyen_da_cap.SelectedIndexChanged += new System.EventHandler(this.m_lbox_quyen_da_cap_SelectedIndexChanged);
            // 
            // m_cmd_left_2_right
            // 
            this.m_cmd_left_2_right.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_left_2_right.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_left_2_right.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_left_2_right.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_left_2_right.ImageIndex = 10;
            this.m_cmd_left_2_right.Location = new System.Drawing.Point(231, 73);
            this.m_cmd_left_2_right.Name = "m_cmd_left_2_right";
            this.m_cmd_left_2_right.Size = new System.Drawing.Size(75, 28);
            this.m_cmd_left_2_right.TabIndex = 9;
            this.m_cmd_left_2_right.Text = ">";
            this.m_cmd_left_2_right.Click += new System.EventHandler(this.m_cmd_left_2_right_Click);
            // 
            // m_cmd_left_2_right_all
            // 
            this.m_cmd_left_2_right_all.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_left_2_right_all.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_left_2_right_all.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_left_2_right_all.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_left_2_right_all.ImageIndex = 10;
            this.m_cmd_left_2_right_all.Location = new System.Drawing.Point(231, 107);
            this.m_cmd_left_2_right_all.Name = "m_cmd_left_2_right_all";
            this.m_cmd_left_2_right_all.Size = new System.Drawing.Size(75, 28);
            this.m_cmd_left_2_right_all.TabIndex = 10;
            this.m_cmd_left_2_right_all.Text = ">>";
            this.m_cmd_left_2_right_all.Click += new System.EventHandler(this.m_cmd_left_2_right_all_Click);
            // 
            // m_cmd_right_2_left
            // 
            this.m_cmd_right_2_left.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_right_2_left.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_right_2_left.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_right_2_left.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_right_2_left.ImageIndex = 10;
            this.m_cmd_right_2_left.Location = new System.Drawing.Point(231, 223);
            this.m_cmd_right_2_left.Name = "m_cmd_right_2_left";
            this.m_cmd_right_2_left.Size = new System.Drawing.Size(75, 28);
            this.m_cmd_right_2_left.TabIndex = 11;
            this.m_cmd_right_2_left.Text = "<";
            this.m_cmd_right_2_left.Click += new System.EventHandler(this.m_cmd_right_2_left_Click);
            // 
            // m_cmd_right_2_left_all
            // 
            this.m_cmd_right_2_left_all.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_right_2_left_all.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_right_2_left_all.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_right_2_left_all.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_right_2_left_all.ImageIndex = 10;
            this.m_cmd_right_2_left_all.Location = new System.Drawing.Point(231, 257);
            this.m_cmd_right_2_left_all.Name = "m_cmd_right_2_left_all";
            this.m_cmd_right_2_left_all.Size = new System.Drawing.Size(75, 28);
            this.m_cmd_right_2_left_all.TabIndex = 12;
            this.m_cmd_right_2_left_all.Text = "<<";
            this.m_cmd_right_2_left_all.Click += new System.EventHandler(this.m_cmd_right_2_left_all_Click);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_save);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 298);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(536, 37);
            this.m_pnl_out_place_dm.TabIndex = 13;
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_save.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_save.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_save.ImageIndex = 10;
            this.m_cmd_save.ImageList = this.ImageList;
            this.m_cmd_save.Location = new System.Drawing.Point(356, 4);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(88, 29);
            this.m_cmd_save.TabIndex = 0;
            this.m_cmd_save.Text = "&Lưu";
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click);
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 11;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(444, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 29);
            this.m_cmd_exit.TabIndex = 1;
            this.m_cmd_exit.Text = "Trở về (Esc)";
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // f995_ht_phan_quyen_cho_nhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 335);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.m_cmd_right_2_left_all);
            this.Controls.Add(this.m_cmd_right_2_left);
            this.Controls.Add(this.m_cmd_left_2_right_all);
            this.Controls.Add(this.m_cmd_left_2_right);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_cbo_user_group);
            this.Controls.Add(this.label1);
            this.Name = "f995_ht_phan_quyen_cho_nhom";
            this.Text = "F995 - Phân quyền cho nhóm";
            this.Load += new System.EventHandler(this.f995_ht_phan_quyen_cho_nhom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox m_cbo_user_group;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox m_lbox_quyen_chua_cap;
        private System.Windows.Forms.ListBox m_lbox_quyen_da_cap;
        internal SIS.Controls.Button.SiSButton m_cmd_left_2_right;
        internal SIS.Controls.Button.SiSButton m_cmd_left_2_right_all;
        internal SIS.Controls.Button.SiSButton m_cmd_right_2_left;
        internal SIS.Controls.Button.SiSButton m_cmd_right_2_left_all;
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_save;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
    }
}