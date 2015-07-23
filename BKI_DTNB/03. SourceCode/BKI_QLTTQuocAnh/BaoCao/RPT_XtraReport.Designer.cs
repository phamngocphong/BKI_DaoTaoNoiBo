namespace BKI_QLTTQuocAnh.BaoCao
{
    partial class RPT_XtraReport
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.iP_tieu_de_bao_cao = new DevExpress.XtraReports.UI.XRLabel();
            this.iP_trung_tam = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 20F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.iP_tieu_de_bao_cao,
            this.iP_trung_tam});
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // iP_tieu_de_bao_cao
            // 
            this.iP_tieu_de_bao_cao.LocationFloat = new DevExpress.Utils.PointFloat(0F, 37.5F);
            this.iP_tieu_de_bao_cao.Name = "iP_tieu_de_bao_cao";
            this.iP_tieu_de_bao_cao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.iP_tieu_de_bao_cao.SizeF = new System.Drawing.SizeF(650F, 25F);
            this.iP_tieu_de_bao_cao.StylePriority.UseBackColor = false;
            this.iP_tieu_de_bao_cao.StylePriority.UseTextAlignment = false;
            this.iP_tieu_de_bao_cao.Text = "iP_tieu_de_bao_cao";
            this.iP_tieu_de_bao_cao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // iP_trung_tam
            // 
            this.iP_trung_tam.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.iP_trung_tam.Name = "iP_trung_tam";
            this.iP_trung_tam.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.iP_trung_tam.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.iP_trung_tam.StylePriority.UseTextAlignment = false;
            this.iP_trung_tam.Text = "iP_trung_tam";
            this.iP_trung_tam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.HeightF = 100F;
            this.PageHeader.Name = "PageHeader";
            // 
            // RPT_XtraReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader});
            this.Version = "14.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel iP_tieu_de_bao_cao;
        private DevExpress.XtraReports.UI.XRLabel iP_trung_tam;
    }
}
