namespace BKI_QLTTQuocAnh.BaoCao
{
    partial class F303_Ket_qua_dao_tao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F303_Ket_qua_dao_tao));
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.m_dat = new System.Windows.Forms.DateTimePicker();
            this.m_cmd_hien_thi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 53);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(744, 321);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.CellDoubleClick += new DevExpress.XtraPivotGrid.PivotCellEventHandler(this.pivotGridControl1_CellDoubleClick);
            // 
            // m_dat
            // 
            this.m_dat.Location = new System.Drawing.Point(87, 13);
            this.m_dat.Name = "m_dat";
            this.m_dat.Size = new System.Drawing.Size(200, 20);
            this.m_dat.TabIndex = 1;
            // 
            // m_cmd_hien_thi
            // 
            this.m_cmd_hien_thi.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_hien_thi.Image")));
            this.m_cmd_hien_thi.Location = new System.Drawing.Point(430, 13);
            this.m_cmd_hien_thi.Name = "m_cmd_hien_thi";
            this.m_cmd_hien_thi.Size = new System.Drawing.Size(93, 34);
            this.m_cmd_hien_thi.TabIndex = 2;
            this.m_cmd_hien_thi.Text = "Hiển thị";
            this.m_cmd_hien_thi.Click += new System.EventHandler(this.m_cmd_hien_thi_Click);
            // 
            // F303_Ket_qua_dao_tao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 374);
            this.Controls.Add(this.m_cmd_hien_thi);
            this.Controls.Add(this.m_dat);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "F303_Ket_qua_dao_tao";
            this.Text = "F303_Ket_qua_dao_tao";
            this.Load += new System.EventHandler(this.F303_Ket_qua_dao_tao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.DateTimePicker m_dat;
        private DevExpress.XtraEditors.SimpleButton m_cmd_hien_thi;
    }
}