namespace BKI_QLTTQuocAnh.NghiepVu
{
    partial class F207_Nhap_diem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F207_Nhap_diem));
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.m_grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_ten_nhan_vien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_mon_hoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_hoc_xong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_qua_mon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_lop_hoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(0, 0);
            this.m_grc.MainView = this.m_grv;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(769, 322);
            this.m_grc.TabIndex = 0;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv});
            // 
            // m_grv
            // 
            this.m_grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_ten_nhan_vien,
            this.c_ma_mon_hoc,
            this.c_hoc_xong,
            this.c_qua_mon,
            this.c_ma_lop_hoc});
            this.m_grv.GridControl = this.m_grc;
            this.m_grv.GroupCount = 3;
            this.m_grv.Name = "m_grv";
            this.m_grv.OptionsSelection.MultiSelect = true;
            this.m_grv.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.m_grv.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.c_ma_mon_hoc, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.c_ma_lop_hoc, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.c_hoc_xong, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // c_ten_nhan_vien
            // 
            this.c_ten_nhan_vien.Caption = "Tên nhân viên";
            this.c_ten_nhan_vien.FieldName = "TEN_NHAN_VIEN";
            this.c_ten_nhan_vien.Name = "c_ten_nhan_vien";
            this.c_ten_nhan_vien.Visible = true;
            this.c_ten_nhan_vien.VisibleIndex = 1;
            this.c_ten_nhan_vien.Width = 83;
            // 
            // c_ma_mon_hoc
            // 
            this.c_ma_mon_hoc.Caption = "Mã môn học";
            this.c_ma_mon_hoc.FieldName = "TEN_MON_HOC";
            this.c_ma_mon_hoc.Name = "c_ma_mon_hoc";
            this.c_ma_mon_hoc.Visible = true;
            this.c_ma_mon_hoc.VisibleIndex = 1;
            // 
            // c_hoc_xong
            // 
            this.c_hoc_xong.Caption = "Trạng thái";
            this.c_hoc_xong.FieldName = "TRANG_THAI_HOC_XONG";
            this.c_hoc_xong.Name = "c_hoc_xong";
            this.c_hoc_xong.Visible = true;
            this.c_hoc_xong.VisibleIndex = 1;
            // 
            // c_qua_mon
            // 
            this.c_qua_mon.Caption = "Kết quả";
            this.c_qua_mon.FieldName = "TEN";
            this.c_qua_mon.Name = "c_qua_mon";
            this.c_qua_mon.Visible = true;
            this.c_qua_mon.VisibleIndex = 2;
            // 
            // c_ma_lop_hoc
            // 
            this.c_ma_lop_hoc.Caption = "Mã lớp môn";
            this.c_ma_lop_hoc.FieldName = "MA_LOP_HOC";
            this.c_ma_lop_hoc.Name = "c_ma_lop_hoc";
            this.c_ma_lop_hoc.Visible = true;
            this.c_ma_lop_hoc.VisibleIndex = 3;
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 369);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(769, 36);
            this.m_pnl_out_place_dm.TabIndex = 20;
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 3;
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(589, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Nhập điểm";
            this.m_cmd_update.Click += new System.EventHandler(this.m_cmd_update_Click);
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(677, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 47);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 322);
            this.panel2.TabIndex = 22;
            // 
            // F207_Nhap_diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 405);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "F207_Nhap_diem";
            this.Text = "F207_Nhap_diem";
            this.Load += new System.EventHandler(this.F207_Nhap_diem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv;
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_nhan_vien;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_mon_hoc;
        private DevExpress.XtraGrid.Columns.GridColumn c_hoc_xong;
        private DevExpress.XtraGrid.Columns.GridColumn c_qua_mon;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_lop_hoc;
    }
}