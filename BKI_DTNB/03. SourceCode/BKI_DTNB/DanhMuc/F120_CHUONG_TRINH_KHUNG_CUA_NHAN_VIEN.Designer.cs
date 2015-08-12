namespace BKI_DTNB.DanhMuc
{
    partial class F120_CHUONG_TRINH_KHUNG_CUA_NHAN_VIEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F120_CHUONG_TRINH_KHUNG_CUA_NHAN_VIEN));
            this.m_cmd_hien_thi = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.m_search_lookup_edit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.m_grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_search_lookup_edit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_cmd_hien_thi
            // 
            this.m_cmd_hien_thi.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_hien_thi.Image")));
            this.m_cmd_hien_thi.Location = new System.Drawing.Point(370, 12);
            this.m_cmd_hien_thi.Name = "m_cmd_hien_thi";
            this.m_cmd_hien_thi.Size = new System.Drawing.Size(107, 39);
            this.m_cmd_hien_thi.TabIndex = 2;
            this.m_cmd_hien_thi.Text = "Hiển thị";
            this.m_cmd_hien_thi.Click += new System.EventHandler(this.m_cmd_hien_thi_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.m_search_lookup_edit);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.m_cmd_hien_thi);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(831, 65);
            this.panelControl2.TabIndex = 3;
            // 
            // m_search_lookup_edit
            // 
            this.m_search_lookup_edit.EditValue = "Nhập thông tin cần tìm kiếm";
            this.m_search_lookup_edit.Location = new System.Drawing.Point(105, 22);
            this.m_search_lookup_edit.Name = "m_search_lookup_edit";
            this.m_search_lookup_edit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_search_lookup_edit.Properties.DisplayMember = "HO_TEN";
            this.m_search_lookup_edit.Properties.ValueMember = "ID";
            this.m_search_lookup_edit.Properties.View = this.searchLookUpEdit1View;
            this.m_search_lookup_edit.Size = new System.Drawing.Size(231, 20);
            this.m_search_lookup_edit.TabIndex = 5;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn12,
            this.gridColumn13});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "MÃ NHÂN VIÊN";
            this.gridColumn12.FieldName = "MA_NV";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "HỌ TÊN";
            this.gridColumn13.FieldName = "HO_TEN";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tên nhân viên";
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_grc.Location = new System.Drawing.Point(2, 2);
            this.m_grc.MainView = this.m_grv;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(827, 386);
            this.m_grc.TabIndex = 0;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv,
            this.gridView1});
            // 
            // m_grv
            // 
            this.m_grv.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.m_grv.Appearance.FixedLine.BackColor = System.Drawing.Color.Maroon;
            this.m_grv.Appearance.FixedLine.BackColor2 = System.Drawing.Color.Maroon;
            this.m_grv.Appearance.FixedLine.BorderColor = System.Drawing.Color.Maroon;
            this.m_grv.Appearance.FixedLine.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_grv.Appearance.FixedLine.ForeColor = System.Drawing.Color.White;
            this.m_grv.Appearance.FixedLine.Options.UseBackColor = true;
            this.m_grv.Appearance.FixedLine.Options.UseBorderColor = true;
            this.m_grv.Appearance.FixedLine.Options.UseFont = true;
            this.m_grv.Appearance.FixedLine.Options.UseForeColor = true;
            this.m_grv.Appearance.GroupPanel.BackColor = System.Drawing.Color.Maroon;
            this.m_grv.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.Maroon;
            this.m_grv.Appearance.GroupPanel.BorderColor = System.Drawing.Color.Maroon;
            this.m_grv.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_grv.Appearance.GroupPanel.Options.UseBackColor = true;
            this.m_grv.Appearance.GroupPanel.Options.UseBorderColor = true;
            this.m_grv.Appearance.GroupPanel.Options.UseFont = true;
            this.m_grv.Appearance.GroupPanel.Options.UseForeColor = true;
            this.m_grv.Appearance.Row.ForeColor = System.Drawing.Color.Maroon;
            this.m_grv.Appearance.Row.Options.UseForeColor = true;
            this.m_grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.m_grv.GridControl = this.m_grc;
            this.m_grv.GroupCount = 5;
            this.m_grv.Name = "m_grv";
            this.m_grv.OptionsView.EnableAppearanceEvenRow = true;
            this.m_grv.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn4, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn3, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn5, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn6, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.m_grv.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.m_grv_PopupMenuShowing);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "TÊN NHÂN VIÊN";
            this.gridColumn2.FieldName = "TEN_NHAN_VIEN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "TRUNG TÂM";
            this.gridColumn3.FieldName = "MA_TRUNG_TAM";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 83;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "NGẠCH";
            this.gridColumn4.FieldName = "MA_NGACH";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "CHỨC VỤ";
            this.gridColumn5.FieldName = "CHUC_VU";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 104;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "NGHIỆP VỤ";
            this.gridColumn6.FieldName = "TEN_NGHIEP_VU";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 125;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "ĐIỂM CHUYÊN CẦN";
            this.gridColumn7.FieldName = "DIEM_CHUYEN_CAN";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "ĐIỂM KIỂM TRA";
            this.gridColumn8.FieldName = "DIEM_KIEM_TRA";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "ĐIỂM THI";
            this.gridColumn9.FieldName = "DIEM_THI";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "TRẠNG THÁI";
            this.gridColumn10.FieldName = "TEN";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "MÔN HỌC";
            this.gridColumn11.FieldName = "TEN_MON_HOC";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            this.gridColumn11.Width = 146;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.m_grc;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_grc);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 65);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(831, 390);
            this.panelControl1.TabIndex = 4;
            // 
            // F120_CHUONG_TRINH_KHUNG_CUA_NHAN_VIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 455);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "F120_CHUONG_TRINH_KHUNG_CUA_NHAN_VIEN";
            this.Text = "F120 - Chương trình khung của nhân viên";
            this.Load += new System.EventHandler(this.F120_CHUONG_TRINH_KHUNG_CUA_NHAN_VIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_search_lookup_edit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton m_cmd_hien_thi;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit m_search_lookup_edit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}