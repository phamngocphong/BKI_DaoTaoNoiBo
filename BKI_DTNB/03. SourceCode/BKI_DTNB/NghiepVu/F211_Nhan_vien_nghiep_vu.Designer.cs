namespace BKI_DTNB.NghiepVu
{
    partial class F211_Nhan_vien_nghiep_vu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F211_Nhan_vien_nghiep_vu));
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c_ma_nhan_vien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_ma_nv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_trung_tam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_chuc_vu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_cmd_insert_nghiep_vu_them = new SIS.Controls.Button.SiSButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(0, 0);
            this.m_grc.MainView = this.gridView1;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(753, 374);
            this.m_grc.TabIndex = 0;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_ma_nhan_vien,
            this.gridColumn2,
            this.c_ma_nv,
            this.c_trung_tam,
            this.c_chuc_vu});
            this.gridView1.GridControl = this.m_grc;
            this.gridView1.Name = "gridView1";
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert_nghiep_vu_them);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 374);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(753, 36);
            this.m_pnl_out_place_dm.TabIndex = 22;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 2;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(305, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(178, 28);
            this.m_cmd_insert.TabIndex = 12;
            this.m_cmd_insert.Text = "&Thêm nghiệp vụ";
            this.m_cmd_insert.Click += new System.EventHandler(this.m_cmd_insert_Click);
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.ImageList;
            this.m_cmd_delete.Location = new System.Drawing.Point(483, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(178, 28);
            this.m_cmd_delete.TabIndex = 14;
            this.m_cmd_delete.Text = "&Hủy nghiệp vụ của nhân sự";
            this.m_cmd_delete.Click += new System.EventHandler(this.m_cmd_delete_Click);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(661, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_grc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 374);
            this.panel1.TabIndex = 23;
            // 
            // c_ma_nhan_vien
            // 
            this.c_ma_nhan_vien.Caption = "Họ tên";
            this.c_ma_nhan_vien.Name = "c_ma_nhan_vien";
            this.c_ma_nhan_vien.Visible = true;
            this.c_ma_nhan_vien.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nghiệp vụ";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            // 
            // c_ma_nv
            // 
            this.c_ma_nv.Caption = "Mã nhân viên";
            this.c_ma_nv.Name = "c_ma_nv";
            this.c_ma_nv.Visible = true;
            this.c_ma_nv.VisibleIndex = 0;
            // 
            // c_trung_tam
            // 
            this.c_trung_tam.Caption = "Trung tâm";
            this.c_trung_tam.Name = "c_trung_tam";
            this.c_trung_tam.Visible = true;
            this.c_trung_tam.VisibleIndex = 2;
            // 
            // c_chuc_vu
            // 
            this.c_chuc_vu.Caption = "Chức vụ";
            this.c_chuc_vu.Name = "c_chuc_vu";
            this.c_chuc_vu.Visible = true;
            this.c_chuc_vu.VisibleIndex = 3;
            // 
            // m_cmd_insert_nghiep_vu_them
            // 
            this.m_cmd_insert_nghiep_vu_them.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert_nghiep_vu_them.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert_nghiep_vu_them.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert_nghiep_vu_them.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert_nghiep_vu_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert_nghiep_vu_them.ImageIndex = 2;
            this.m_cmd_insert_nghiep_vu_them.ImageList = this.ImageList;
            this.m_cmd_insert_nghiep_vu_them.Location = new System.Drawing.Point(127, 4);
            this.m_cmd_insert_nghiep_vu_them.Name = "m_cmd_insert_nghiep_vu_them";
            this.m_cmd_insert_nghiep_vu_them.Size = new System.Drawing.Size(178, 28);
            this.m_cmd_insert_nghiep_vu_them.TabIndex = 15;
            this.m_cmd_insert_nghiep_vu_them.Text = "&Thêm nghiệp vụ khác";
            this.m_cmd_insert_nghiep_vu_them.Click += new System.EventHandler(this.m_cmd_insert_nghiep_vu_them_Click);
            // 
            // F211_Nhan_vien_nghiep_vu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F211_Nhan_vien_nghiep_vu";
            this.Text = "F211_Nhan_vien_nghiep_vu";
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_nhan_vien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn c_ma_nv;
        private DevExpress.XtraGrid.Columns.GridColumn c_trung_tam;
        private DevExpress.XtraGrid.Columns.GridColumn c_chuc_vu;
        internal SIS.Controls.Button.SiSButton m_cmd_insert_nghiep_vu_them;
    }
}