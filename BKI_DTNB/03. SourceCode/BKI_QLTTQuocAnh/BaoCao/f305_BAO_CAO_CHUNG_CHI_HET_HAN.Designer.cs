namespace BKI_QLTTQuocAnh.BaoCao
{
    partial class f305_BAO_CAO_CHUNG_CHI_HET_HAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f305_BAO_CAO_CHUNG_CHI_HET_HAN));
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.m_dat = new System.Windows.Forms.DateTimePicker();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_hien_thi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 50);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(483, 212);
            this.pivotGridControl1.TabIndex = 5;
            this.pivotGridControl1.FieldValueDisplayText += new DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(this.pivotGridControl1_FieldValueDisplayText);
            this.pivotGridControl1.CellDoubleClick += new DevExpress.XtraPivotGrid.PivotCellEventHandler(this.pivotGridControl1_CellDoubleClick);
            // 
            // m_dat
            // 
            this.m_dat.Location = new System.Drawing.Point(18, 8);
            this.m_dat.Name = "m_dat";
            this.m_dat.Size = new System.Drawing.Size(200, 20);
            this.m_dat.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_dat);
            this.panelControl1.Controls.Add(this.m_cmd_hien_thi);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(483, 50);
            this.panelControl1.TabIndex = 4;
            // 
            // m_cmd_hien_thi
            // 
            this.m_cmd_hien_thi.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_hien_thi.Image")));
            this.m_cmd_hien_thi.Location = new System.Drawing.Point(271, 5);
            this.m_cmd_hien_thi.Name = "m_cmd_hien_thi";
            this.m_cmd_hien_thi.Size = new System.Drawing.Size(104, 32);
            this.m_cmd_hien_thi.TabIndex = 1;
            this.m_cmd_hien_thi.Text = "Hiển thị";
            this.m_cmd_hien_thi.Click += new System.EventHandler(this.m_cmd_hien_thi_Click);
            // 
            // f305_BAO_CAO_CHUNG_CHI_HET_HAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 262);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "f305_BAO_CAO_CHUNG_CHI_HET_HAN";
            this.Text = "f305_BAO_CAO_CHUNG_CHI_HET_HAN";
            this.Load += new System.EventHandler(this.f305_BAO_CAO_CHUNG_CHI_HET_HAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.DateTimePicker m_dat;
        private DevExpress.XtraEditors.SimpleButton m_cmd_hien_thi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}