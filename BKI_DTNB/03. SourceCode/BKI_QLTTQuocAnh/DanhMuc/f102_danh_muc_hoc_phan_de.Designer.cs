namespace BKI_QLTTQuocAnh.DanhMuc
{
    partial class f102_danh_muc_hoc_phan_de
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_txt_ma_hoc_phan = new System.Windows.Forms.TextBox();
            this.m_txt_so_luong_mon_hoc_yeu_cau = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.chk_bat_buoc = new System.Windows.Forms.CheckBox();
            this.m_txt_ten_hoc_phan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên học phần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng môn học yêu cầu ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bắt buộc";
            // 
            // m_txt_ma_hoc_phan
            // 
            this.m_txt_ma_hoc_phan.Location = new System.Drawing.Point(182, 22);
            this.m_txt_ma_hoc_phan.Name = "m_txt_ma_hoc_phan";
            this.m_txt_ma_hoc_phan.Size = new System.Drawing.Size(163, 20);
            this.m_txt_ma_hoc_phan.TabIndex = 4;
            // 
            // m_txt_so_luong_mon_hoc_yeu_cau
            // 
            this.m_txt_so_luong_mon_hoc_yeu_cau.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_txt_so_luong_mon_hoc_yeu_cau.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.m_txt_so_luong_mon_hoc_yeu_cau.Location = new System.Drawing.Point(182, 121);
            this.m_txt_so_luong_mon_hoc_yeu_cau.Name = "m_txt_so_luong_mon_hoc_yeu_cau";
            this.m_txt_so_luong_mon_hoc_yeu_cau.Size = new System.Drawing.Size(163, 20);
            this.m_txt_so_luong_mon_hoc_yeu_cau.TabIndex = 6;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(52, 220);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 8;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(235, 220);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_huy.TabIndex = 9;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // chk_bat_buoc
            // 
            this.chk_bat_buoc.AutoSize = true;
            this.chk_bat_buoc.Location = new System.Drawing.Point(182, 167);
            this.chk_bat_buoc.Name = "chk_bat_buoc";
            this.chk_bat_buoc.Size = new System.Drawing.Size(15, 14);
            this.chk_bat_buoc.TabIndex = 10;
            this.chk_bat_buoc.UseVisualStyleBackColor = true;
            // 
            // m_txt_ten_hoc_phan
            // 
            this.m_txt_ten_hoc_phan.Location = new System.Drawing.Point(182, 68);
            this.m_txt_ten_hoc_phan.Name = "m_txt_ten_hoc_phan";
            this.m_txt_ten_hoc_phan.Size = new System.Drawing.Size(163, 20);
            this.m_txt_ten_hoc_phan.TabIndex = 11;
            // 
            // f102_danh_muc_hoc_phan_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 262);
            this.Controls.Add(this.m_txt_ten_hoc_phan);
            this.Controls.Add(this.chk_bat_buoc);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.m_txt_ma_hoc_phan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_txt_so_luong_mon_hoc_yeu_cau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "f102_danh_muc_hoc_phan_de";
            this.Text = "f102_danh_muc_hoc_phan_de";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_txt_ma_hoc_phan;
        private System.Windows.Forms.TextBox m_txt_so_luong_mon_hoc_yeu_cau;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.CheckBox chk_bat_buoc;
        private System.Windows.Forms.TextBox m_txt_ten_hoc_phan;
    }
}