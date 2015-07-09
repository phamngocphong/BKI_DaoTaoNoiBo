namespace BKI_QLTTQuocAnh.HeThong
{
    partial class f992_phan_quyen_he_thong_de
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
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_save = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.label1 = new System.Windows.Forms.Label();
            this.m_txt_ma_phan_quyen = new System.Windows.Forms.TextBox();
            this.m_txt_ghi_chu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_save);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 193);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(425, 39);
            this.m_pnl_out_place_dm.TabIndex = 7;
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_save.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_save.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_save.ImageIndex = 10;
            this.m_cmd_save.Location = new System.Drawing.Point(245, 4);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(88, 31);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(333, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 31);
            this.m_cmd_exit.TabIndex = 1;
            this.m_cmd_exit.Text = "Trở về (Esc)";
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã phân quyền";
            // 
            // m_txt_ma_phan_quyen
            // 
            this.m_txt_ma_phan_quyen.Location = new System.Drawing.Point(109, 31);
            this.m_txt_ma_phan_quyen.Name = "m_txt_ma_phan_quyen";
            this.m_txt_ma_phan_quyen.Size = new System.Drawing.Size(294, 20);
            this.m_txt_ma_phan_quyen.TabIndex = 9;
            // 
            // m_txt_ghi_chu
            // 
            this.m_txt_ghi_chu.Location = new System.Drawing.Point(109, 84);
            this.m_txt_ghi_chu.Multiline = true;
            this.m_txt_ghi_chu.Name = "m_txt_ghi_chu";
            this.m_txt_ghi_chu.Size = new System.Drawing.Size(294, 65);
            this.m_txt_ghi_chu.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ghi chú";
            // 
            // f992_phan_quyen_he_thong_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 232);
            this.Controls.Add(this.m_txt_ghi_chu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_txt_ma_phan_quyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f992_phan_quyen_he_thong_de";
            this.Text = "F992 - Cập nhật chi tiết phân quyền hệ thống";
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_save;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txt_ma_phan_quyen;
        private System.Windows.Forms.TextBox m_txt_ghi_chu;
        private System.Windows.Forms.Label label2;
    }
}