namespace BKI_QLTTQuocAnh.NghiepVu
{
    partial class BackupDB
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_cmd_disconnect = new System.Windows.Forms.Button();
            this.m_txt_pwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_txt_user_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cmd_connect = new System.Windows.Forms.Button();
            this.m_txt_data_source = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.m_cbo_db = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.m_txt_ten_file = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_cmd_backup = new System.Windows.Forms.Button();
            this.m_cmd_browse_backup = new System.Windows.Forms.Button();
            this.m_txt_location = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.m_cmd_restore = new System.Windows.Forms.Button();
            this.m_cmd_browse_restore = new System.Windows.Forms.Button();
            this.m_txt_backup_path = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_cmd_disconnect);
            this.groupBox1.Controls.Add(this.m_txt_pwd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.m_txt_user_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.m_cmd_connect);
            this.groupBox1.Controls.Add(this.m_txt_data_source);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 411);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Server Authentication";
            this.groupBox1.Visible = false;
            // 
            // m_cmd_disconnect
            // 
            this.m_cmd_disconnect.Location = new System.Drawing.Point(476, 49);
            this.m_cmd_disconnect.Name = "m_cmd_disconnect";
            this.m_cmd_disconnect.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_disconnect.TabIndex = 7;
            this.m_cmd_disconnect.Text = "Disconnect";
            this.m_cmd_disconnect.UseVisualStyleBackColor = true;
            // 
            // m_txt_pwd
            // 
            this.m_txt_pwd.Location = new System.Drawing.Point(356, 51);
            this.m_txt_pwd.Name = "m_txt_pwd";
            this.m_txt_pwd.Size = new System.Drawing.Size(99, 20);
            this.m_txt_pwd.TabIndex = 6;
            this.m_txt_pwd.Text = "sa";
            this.m_txt_pwd.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // m_txt_user_id
            // 
            this.m_txt_user_id.Location = new System.Drawing.Point(140, 51);
            this.m_txt_user_id.Name = "m_txt_user_id";
            this.m_txt_user_id.Size = new System.Drawing.Size(107, 20);
            this.m_txt_user_id.TabIndex = 4;
            this.m_txt_user_id.Text = "sa";
            this.m_txt_user_id.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User ID";
            // 
            // m_cmd_connect
            // 
            this.m_cmd_connect.Location = new System.Drawing.Point(476, 18);
            this.m_cmd_connect.Name = "m_cmd_connect";
            this.m_cmd_connect.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_connect.TabIndex = 2;
            this.m_cmd_connect.Text = "Connect";
            this.m_cmd_connect.UseVisualStyleBackColor = true;
            // 
            // m_txt_data_source
            // 
            this.m_txt_data_source.Location = new System.Drawing.Point(140, 20);
            this.m_txt_data_source.Name = "m_txt_data_source";
            this.m_txt_data_source.Size = new System.Drawing.Size(315, 20);
            this.m_txt_data_source.TabIndex = 1;
            this.m_txt_data_source.Text = ".\\sqlexpress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Source";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.m_cbo_db);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(12, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(587, 52);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Database Selection";
            this.groupBox3.Visible = false;
            // 
            // m_cbo_db
            // 
            this.m_cbo_db.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_db.FormattingEnabled = true;
            this.m_cbo_db.Location = new System.Drawing.Point(140, 20);
            this.m_cbo_db.Name = "m_cbo_db";
            this.m_cbo_db.Size = new System.Drawing.Size(236, 21);
            this.m_cbo_db.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Database";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.m_txt_ten_file);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.m_cmd_backup);
            this.groupBox4.Controls.Add(this.m_cmd_browse_backup);
            this.groupBox4.Controls.Add(this.m_txt_location);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(587, 88);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lưu trữ dữ liệu";
            // 
            // m_txt_ten_file
            // 
            this.m_txt_ten_file.Location = new System.Drawing.Point(140, 49);
            this.m_txt_ten_file.Name = "m_txt_ten_file";
            this.m_txt_ten_file.ReadOnly = true;
            this.m_txt_ten_file.Size = new System.Drawing.Size(315, 20);
            this.m_txt_ten_file.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên file (dạng *.bak)";
            // 
            // m_cmd_backup
            // 
            this.m_cmd_backup.Location = new System.Drawing.Point(476, 47);
            this.m_cmd_backup.Name = "m_cmd_backup";
            this.m_cmd_backup.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_backup.TabIndex = 5;
            this.m_cmd_backup.Text = "Lưu trữ";
            this.m_cmd_backup.UseVisualStyleBackColor = true;
            // 
            // m_cmd_browse_backup
            // 
            this.m_cmd_browse_backup.Location = new System.Drawing.Point(476, 17);
            this.m_cmd_browse_backup.Name = "m_cmd_browse_backup";
            this.m_cmd_browse_backup.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_browse_backup.TabIndex = 2;
            this.m_cmd_browse_backup.Text = "Browse";
            this.m_cmd_browse_backup.UseVisualStyleBackColor = true;
            // 
            // m_txt_location
            // 
            this.m_txt_location.Location = new System.Drawing.Point(140, 19);
            this.m_txt_location.Name = "m_txt_location";
            this.m_txt_location.Size = new System.Drawing.Size(315, 20);
            this.m_txt_location.TabIndex = 1;
            this.m_txt_location.Text = "D:\\DuLieuLuuTru\\Du lieu tai chinh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Địa chỉ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.m_cmd_restore);
            this.groupBox5.Controls.Add(this.m_cmd_browse_restore);
            this.groupBox5.Controls.Add(this.m_txt_backup_path);
            this.groupBox5.Controls.Add(this.Back);
            this.groupBox5.Location = new System.Drawing.Point(12, 106);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(587, 88);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hồi phục dữ liệu";
            // 
            // m_cmd_restore
            // 
            this.m_cmd_restore.Location = new System.Drawing.Point(476, 47);
            this.m_cmd_restore.Name = "m_cmd_restore";
            this.m_cmd_restore.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_restore.TabIndex = 3;
            this.m_cmd_restore.Text = "Hồi phục";
            this.m_cmd_restore.UseVisualStyleBackColor = true;
            // 
            // m_cmd_browse_restore
            // 
            this.m_cmd_browse_restore.Location = new System.Drawing.Point(476, 18);
            this.m_cmd_browse_restore.Name = "m_cmd_browse_restore";
            this.m_cmd_browse_restore.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_browse_restore.TabIndex = 2;
            this.m_cmd_browse_restore.Text = "Browse";
            this.m_cmd_browse_restore.UseVisualStyleBackColor = true;
            // 
            // m_txt_backup_path
            // 
            this.m_txt_backup_path.Location = new System.Drawing.Point(122, 20);
            this.m_txt_backup_path.Name = "m_txt_backup_path";
            this.m_txt_backup_path.Size = new System.Drawing.Size(315, 20);
            this.m_txt_backup_path.TabIndex = 1;
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Location = new System.Drawing.Point(22, 23);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(69, 13);
            this.Back.TabIndex = 0;
            this.Back.Text = "Backup Path";
            // 
            // BackupDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 517);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "BackupDB";
            this.Text = "Lưu trữ dữ liệu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button m_cmd_connect;
        private System.Windows.Forms.TextBox m_txt_data_source;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txt_user_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_txt_pwd;
        private System.Windows.Forms.Button m_cmd_disconnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox m_cbo_db;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button m_cmd_browse_backup;
        private System.Windows.Forms.TextBox m_txt_location;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button m_cmd_backup;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button m_cmd_restore;
        private System.Windows.Forms.Button m_cmd_browse_restore;
        private System.Windows.Forms.TextBox m_txt_backup_path;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.TextBox m_txt_ten_file;
        private System.Windows.Forms.Label label3;
    }
}