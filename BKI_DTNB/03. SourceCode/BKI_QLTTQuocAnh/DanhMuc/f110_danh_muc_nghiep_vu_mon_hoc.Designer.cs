namespace BKI_QLTTQuocAnh.DanhMuc
{
    partial class f110_danh_muc_nghiep_vu_mon_hoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f110_danh_muc_nghiep_vu_mon_hoc));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_ten_mon_hoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_hoc_phan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ten_hoc_phan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.m_grc);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(711, 477);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "CHI TIẾT NGHIỆP VỤ/MÔN HỌC";
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(2, 40);
            this.m_grc.MainView = this.gridView1;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(707, 435);
            this.m_grc.TabIndex = 7;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_ten_mon_hoc,
            this.c_ma_hoc_phan,
            this.c_ten_hoc_phan,
            this.gridColumn1});
            this.gridView1.GridControl = this.m_grc;
            this.gridView1.Name = "gridView1";
            this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing);
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData);
            // 
            // c_ten_mon_hoc
            // 
            this.c_ten_mon_hoc.Caption = "Tên nghiệp vụ";
            this.c_ten_mon_hoc.FieldName = "TEN_NGHIEP_VU";
            this.c_ten_mon_hoc.Name = "c_ten_mon_hoc";
            this.c_ten_mon_hoc.Visible = true;
            this.c_ten_mon_hoc.VisibleIndex = 1;
            // 
            // c_ma_hoc_phan
            // 
            this.c_ma_hoc_phan.Caption = "Mã môn học";
            this.c_ma_hoc_phan.FieldName = "MA_MON_HOC";
            this.c_ma_hoc_phan.Name = "c_ma_hoc_phan";
            this.c_ma_hoc_phan.Visible = true;
            this.c_ma_hoc_phan.VisibleIndex = 2;
            // 
            // c_ten_hoc_phan
            // 
            this.c_ten_hoc_phan.Caption = "Tên môn học";
            this.c_ten_hoc_phan.FieldName = "TEN_MON_HOC";
            this.c_ten_hoc_phan.Name = "c_ten_hoc_phan";
            this.c_ten_hoc_phan.Visible = true;
            this.c_ten_hoc_phan.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // f110_danh_muc_nghiep_vu_mon_hoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 501);
            this.Controls.Add(this.groupControl1);
            this.Name = "f110_danh_muc_nghiep_vu_mon_hoc";
            this.Text = "F110 - Chi tiết nghiệp vụ/môn học";
            this.Load += new System.EventHandler(this.f110_danh_muc_nghiep_vu_mon_hoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_mon_hoc;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_hoc_phan;
        private DevExpress.XtraGrid.Columns.GridColumn c_ten_hoc_phan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}