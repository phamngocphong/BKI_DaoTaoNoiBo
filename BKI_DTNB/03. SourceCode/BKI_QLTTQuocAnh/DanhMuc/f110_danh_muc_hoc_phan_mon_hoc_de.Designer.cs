namespace BKI_QLTTQuocAnh.DanhMuc
{
    partial class f110_danh_muc_hoc_phan_mon_hoc_de
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f110_danh_muc_hoc_phan_mon_hoc_de));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.m_cbo_ma_mon_hoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_ma_mon_hoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_mon_hoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_hoc_phan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_hoc_phan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_cmd_add = new DevExpress.XtraEditors.SimpleButton();
            this.m_cbo_ten_mon_hoc = new DevExpress.XtraEditors.ComboBoxEdit();
            this.m_cbo_ten_hoc_phan = new System.Windows.Forms.ComboBox();
            this.m_cbo_ma_hoc_phan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_cmd_luu = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_huy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_cbo_ten_mon_hoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên học phần";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.m_cbo_ma_mon_hoc);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.m_grc);
            this.groupControl1.Controls.Add(this.m_cmd_add);
            this.groupControl1.Controls.Add(this.m_cbo_ten_mon_hoc);
            this.groupControl1.Controls.Add(this.m_cbo_ten_hoc_phan);
            this.groupControl1.Controls.Add(this.m_cbo_ma_hoc_phan);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(711, 435);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "CHI TIẾT HỌC PHẦN/MÔN HỌC";
            // 
            // m_cbo_ma_mon_hoc
            // 
            this.m_cbo_ma_mon_hoc.FormattingEnabled = true;
            this.m_cbo_ma_mon_hoc.Location = new System.Drawing.Point(114, 105);
            this.m_cbo_ma_mon_hoc.Name = "m_cbo_ma_mon_hoc";
            this.m_cbo_ma_mon_hoc.Size = new System.Drawing.Size(148, 21);
            this.m_cbo_ma_mon_hoc.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã môn học";
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Location = new System.Drawing.Point(2, 194);
            this.m_grc.MainView = this.gridView1;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(707, 239);
            this.m_grc.TabIndex = 7;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_ma_mon_hoc,
            this.c_ten_mon_hoc,
            this.c_ma_hoc_phan,
            this.c_ten_hoc_phan});
            this.gridView1.GridControl = this.m_grc;
            this.gridView1.Name = "gridView1";
            // 
            // c_ma_mon_hoc
            // 
            this.c_ma_mon_hoc.Caption = "Mã môn học";
            this.c_ma_mon_hoc.FieldName = "MA_MON_HOC";
            this.c_ma_mon_hoc.Name = "c_ma_mon_hoc";
            this.c_ma_mon_hoc.Visible = true;
            this.c_ma_mon_hoc.VisibleIndex = 0;
            // 
            // c_ten_mon_hoc
            // 
            this.c_ten_mon_hoc.Caption = "Tên môn học";
            this.c_ten_mon_hoc.FieldName = "TEN_MON_HOC";
            this.c_ten_mon_hoc.Name = "c_ten_mon_hoc";
            this.c_ten_mon_hoc.Visible = true;
            this.c_ten_mon_hoc.VisibleIndex = 1;
            // 
            // c_ma_hoc_phan
            // 
            this.c_ma_hoc_phan.Caption = "Mã học phần";
            this.c_ma_hoc_phan.FieldName = "MA_HOC_PHAN";
            this.c_ma_hoc_phan.Name = "c_ma_hoc_phan";
            this.c_ma_hoc_phan.Visible = true;
            this.c_ma_hoc_phan.VisibleIndex = 2;
            // 
            // c_ten_hoc_phan
            // 
            this.c_ten_hoc_phan.Caption = "Tên học phần";
            this.c_ten_hoc_phan.FieldName = "TEN_HOC_PHAN";
            this.c_ten_hoc_phan.Name = "c_ten_hoc_phan";
            this.c_ten_hoc_phan.Visible = true;
            this.c_ten_hoc_phan.VisibleIndex = 3;
            // 
            // m_cmd_add
            // 
            this.m_cmd_add.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_add.Image")));
            this.m_cmd_add.Location = new System.Drawing.Point(249, 153);
            this.m_cmd_add.Name = "m_cmd_add";
            this.m_cmd_add.Size = new System.Drawing.Size(148, 35);
            this.m_cmd_add.TabIndex = 6;
            this.m_cmd_add.Text = "Thêm vào danh sách";
            // 
            // m_cbo_ten_mon_hoc
            // 
            this.m_cbo_ten_mon_hoc.Location = new System.Drawing.Point(407, 111);
            this.m_cbo_ten_mon_hoc.Name = "m_cbo_ten_mon_hoc";
            this.m_cbo_ten_mon_hoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_cbo_ten_mon_hoc.Size = new System.Drawing.Size(219, 20);
            this.m_cbo_ten_mon_hoc.TabIndex = 5;
            // 
            // m_cbo_ten_hoc_phan
            // 
            this.m_cbo_ten_hoc_phan.FormattingEnabled = true;
            this.m_cbo_ten_hoc_phan.Location = new System.Drawing.Point(407, 64);
            this.m_cbo_ten_hoc_phan.Name = "m_cbo_ten_hoc_phan";
            this.m_cbo_ten_hoc_phan.Size = new System.Drawing.Size(219, 21);
            this.m_cbo_ten_hoc_phan.TabIndex = 4;
            // 
            // m_cbo_ma_hoc_phan
            // 
            this.m_cbo_ma_hoc_phan.FormattingEnabled = true;
            this.m_cbo_ma_hoc_phan.Location = new System.Drawing.Point(114, 64);
            this.m_cbo_ma_hoc_phan.Name = "m_cbo_ma_hoc_phan";
            this.m_cbo_ma_hoc_phan.Size = new System.Drawing.Size(147, 21);
            this.m_cbo_ma_hoc_phan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên môn học";
            // 
            // m_cmd_luu
            // 
            this.m_cmd_luu.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_luu.Image")));
            this.m_cmd_luu.Location = new System.Drawing.Point(236, 451);
            this.m_cmd_luu.Name = "m_cmd_luu";
            this.m_cmd_luu.Size = new System.Drawing.Size(83, 36);
            this.m_cmd_luu.TabIndex = 3;
            this.m_cmd_luu.Text = "LƯU";
            // 
            // m_cmd_huy
            // 
            this.m_cmd_huy.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_huy.Image")));
            this.m_cmd_huy.Location = new System.Drawing.Point(406, 453);
            this.m_cmd_huy.Name = "m_cmd_huy";
            this.m_cmd_huy.Size = new System.Drawing.Size(79, 36);
            this.m_cmd_huy.TabIndex = 4;
            this.m_cmd_huy.Text = " HỦY";
            // 
            // f110_danh_muc_hoc_phan_mon_hoc_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 501);
            this.Controls.Add(this.m_cmd_huy);
            this.Controls.Add(this.m_cmd_luu);
            this.Controls.Add(this.groupControl1);
            this.Name = "f110_danh_muc_hoc_phan_mon_hoc_de";
            this.Text = "F110 - Chi tiết học phần/môn học";
            //this.Load += new System.EventHandler(this.f110_danh_muc_hoc_phan_mon_hoc_de_LOAD);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_cbo_ten_mon_hoc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox m_cbo_ma_mon_hoc;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_add;
        private DevExpress.XtraEditors.ComboBoxEdit m_cbo_ten_mon_hoc;
        private System.Windows.Forms.ComboBox m_cbo_ten_hoc_phan;
        private System.Windows.Forms.ComboBox m_cbo_ma_hoc_phan;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton m_cmd_luu;
        private DevExpress.XtraEditors.SimpleButton m_cmd_huy;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_mon_hoc;
        internal DevExpress.XtraGrid.Columns.GridColumn c_ma_mon_hoc;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_hoc_phan;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_hoc_phan;
    }
}