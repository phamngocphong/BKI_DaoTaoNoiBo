namespace BKI_DTNB.NghiepVu
{
    partial class F206_Nhan_vien_lop_mon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F206_Nhan_vien_lop_mon));
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.m_grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_lop_hoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_id_nhan_vien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_nv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ho_ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_mon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_trung_tam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_exit = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_email = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_refresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(0, 0);
            this.m_grc.MainView = this.m_grv;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(852, 392);
            this.m_grc.TabIndex = 0;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv});
            // 
            // m_grv
            // 
            this.m_grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_id,
            this.c_ma_lop_hoc,
            this.c_id_nhan_vien,
            this.c_ma_nv,
            this.c_ho_ten,
            this.c_ten_mon,
            this.c_ma_trung_tam,
            this.gridColumn1,
            this.gridColumn2});
            this.m_grv.GridControl = this.m_grc;
            this.m_grv.GroupCount = 2;
            this.m_grv.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "MA_NV", null, "(Count={0})")});
            this.m_grv.Name = "m_grv";
            this.m_grv.OptionsSelection.MultiSelect = true;
            this.m_grv.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.m_grv.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.c_ten_mon, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.c_ma_lop_hoc, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.m_grv.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.m_grv_PopupMenuShowing);
            // 
            // c_id
            // 
            this.c_id.Caption = "ID";
            this.c_id.FieldName = "ID";
            this.c_id.Name = "c_id";
            // 
            // c_ma_lop_hoc
            // 
            this.c_ma_lop_hoc.Caption = "MÃ LỚP HỌC";
            this.c_ma_lop_hoc.FieldName = "MA_LOP_HOC";
            this.c_ma_lop_hoc.Name = "c_ma_lop_hoc";
            this.c_ma_lop_hoc.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.c_ma_lop_hoc.Visible = true;
            this.c_ma_lop_hoc.VisibleIndex = 1;
            // 
            // c_id_nhan_vien
            // 
            this.c_id_nhan_vien.Caption = "ID NHÂN VIÊN";
            this.c_id_nhan_vien.FieldName = "ID_NHAN_VIEN";
            this.c_id_nhan_vien.Name = "c_id_nhan_vien";
            // 
            // c_ma_nv
            // 
            this.c_ma_nv.Caption = "MÃ NHÂN VIÊN";
            this.c_ma_nv.FieldName = "MA_NV";
            this.c_ma_nv.Name = "c_ma_nv";
            this.c_ma_nv.Visible = true;
            this.c_ma_nv.VisibleIndex = 1;
            this.c_ma_nv.Width = 83;
            // 
            // c_ho_ten
            // 
            this.c_ho_ten.Caption = "HỌ ĐỆM";
            this.c_ho_ten.FieldName = "HO_DEM";
            this.c_ho_ten.Name = "c_ho_ten";
            this.c_ho_ten.Visible = true;
            this.c_ho_ten.VisibleIndex = 2;
            // 
            // c_ten_mon
            // 
            this.c_ten_mon.Caption = "TÊN MÔN";
            this.c_ten_mon.FieldName = "TEN_MON_HOC";
            this.c_ten_mon.Name = "c_ten_mon";
            this.c_ten_mon.Visible = true;
            this.c_ten_mon.VisibleIndex = 2;
            // 
            // c_ma_trung_tam
            // 
            this.c_ma_trung_tam.Caption = "MÃ TRUNG TÂM";
            this.c_ma_trung_tam.FieldName = "MA_TRUNG_TAM";
            this.c_ma_trung_tam.Name = "c_ma_trung_tam";
            this.c_ma_trung_tam.Visible = true;
            this.c_ma_trung_tam.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "TÊN";
            this.gridColumn1.FieldName = "TEN";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID MÔN HỌC";
            this.gridColumn2.FieldName = "ID_MON_HOC";
            this.gridColumn2.Name = "gridColumn2";
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_refresh);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_email);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 346);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(852, 46);
            this.m_pnl_out_place_dm.TabIndex = 20;
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_exit.Image")));
            this.m_cmd_exit.Location = new System.Drawing.Point(767, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(81, 38);
            this.m_cmd_exit.TabIndex = 19;
            this.m_cmd_exit.Text = "Thoát";
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_delete.Image")));
            this.m_cmd_delete.Location = new System.Drawing.Point(682, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(85, 38);
            this.m_cmd_delete.TabIndex = 20;
            this.m_cmd_delete.Text = "Xóa";
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_insert.Image")));
            this.m_cmd_insert.Location = new System.Drawing.Point(500, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(182, 38);
            this.m_cmd_insert.TabIndex = 21;
            this.m_cmd_insert.Text = "Thêm nhân viên cho lớp môn";
            // 
            // m_cmd_email
            // 
            this.m_cmd_email.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_email.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_email.Image")));
            this.m_cmd_email.Location = new System.Drawing.Point(389, 4);
            this.m_cmd_email.Name = "m_cmd_email";
            this.m_cmd_email.Size = new System.Drawing.Size(111, 38);
            this.m_cmd_email.TabIndex = 22;
            this.m_cmd_email.Text = "Gửi email";
            // 
            // m_cmd_refresh
            // 
            this.m_cmd_refresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_refresh.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_refresh.Image")));
            this.m_cmd_refresh.Location = new System.Drawing.Point(254, 4);
            this.m_cmd_refresh.Name = "m_cmd_refresh";
            this.m_cmd_refresh.Size = new System.Drawing.Size(135, 38);
            this.m_cmd_refresh.TabIndex = 23;
            this.m_cmd_refresh.Text = "Load lại trang";
            // 
            // F206_Nhan_vien_lop_mon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 392);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.m_grc);
            this.Name = "F206_Nhan_vien_lop_mon";
            this.Text = "F206 - Nhân viên lớp môn";
            this.Load += new System.EventHandler(this.F206_Nhan_vien_lop_hoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv;
        private DevExpress.XtraGrid.Columns.GridColumn c_id;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_lop_hoc;
        private DevExpress.XtraGrid.Columns.GridColumn c_id_nhan_vien;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_nv;
        private DevExpress.XtraGrid.Columns.GridColumn c_ho_ten;
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_mon;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_trung_tam;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_exit;
        private DevExpress.XtraEditors.SimpleButton m_cmd_refresh;
        private DevExpress.XtraEditors.SimpleButton m_cmd_email;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;
    }
}