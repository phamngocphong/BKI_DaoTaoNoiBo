namespace BKI_QLTTQuocAnh.NghiepVu
{
    partial class F206_Nhan_vien_lop_hoc
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
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.m_grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_lop_hoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_id_nhan_vien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_nv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ho_ten = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            this.SuspendLayout();
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(0, 0);
            this.m_grc.MainView = this.m_grv;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(635, 306);
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
            this.c_ho_ten});
            this.m_grv.GridControl = this.m_grc;
            this.m_grv.GroupCount = 1;
            this.m_grv.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "MA_NV", null, "(Count={0})")});
            this.m_grv.Name = "m_grv";
            this.m_grv.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.c_ma_lop_hoc, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // c_id
            // 
            this.c_id.Caption = "ID";
            this.c_id.FieldName = "ID";
            this.c_id.Name = "c_id";
            // 
            // c_ma_lop_hoc
            // 
            this.c_ma_lop_hoc.Caption = "Mã lớp học";
            this.c_ma_lop_hoc.FieldName = "MA_LOP_HOC";
            this.c_ma_lop_hoc.Name = "c_ma_lop_hoc";
            this.c_ma_lop_hoc.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.c_ma_lop_hoc.Visible = true;
            this.c_ma_lop_hoc.VisibleIndex = 0;
            // 
            // c_id_nhan_vien
            // 
            this.c_id_nhan_vien.Caption = "ID nhân viên";
            this.c_id_nhan_vien.FieldName = "ID_NHAN_VIEN";
            this.c_id_nhan_vien.Name = "c_id_nhan_vien";
            // 
            // c_ma_nv
            // 
            this.c_ma_nv.Caption = "Mã nhân viên";
            this.c_ma_nv.FieldName = "MA_NV";
            this.c_ma_nv.Name = "c_ma_nv";
            this.c_ma_nv.Visible = true;
            this.c_ma_nv.VisibleIndex = 0;
            // 
            // c_ho_ten
            // 
            this.c_ho_ten.Caption = "Họ tên";
            this.c_ho_ten.FieldName = "HO_TEN";
            this.c_ho_ten.Name = "c_ho_ten";
            this.c_ho_ten.Visible = true;
            this.c_ho_ten.VisibleIndex = 1;
            // 
            // F206_Nhan_vien_lop_hoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 306);
            this.Controls.Add(this.m_grc);
            this.Name = "F206_Nhan_vien_lop_hoc";
            this.Text = "F206_Nhan_vien_lop_hoc";
            this.Load += new System.EventHandler(this.F206_Nhan_vien_lop_hoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
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
    }
}