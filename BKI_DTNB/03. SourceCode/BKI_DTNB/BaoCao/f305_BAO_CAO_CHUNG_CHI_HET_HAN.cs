using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;
using IP.Core.IPCommon;

namespace BKI_DTNB.BaoCao
{
    public partial class f305_BAO_CAO_CHUNG_CHI_HET_HAN : Form
    {
        PivotGridField fieldIDNHANVIEN;
        PivotGridField fieldTenMonHoc;
        PivotGridField fieldTenPhong;
        PivotGridField fieldChucVu;
        PivotGridField fieldTenKhuVuc;
       
        public f305_BAO_CAO_CHUNG_CHI_HET_HAN()
        {
            InitializeComponent();
            WinFormControls.DTNB_ControlFormat(this);
        }

        private void f305_BAO_CAO_CHUNG_CHI_HET_HAN_Load(object sender, EventArgs e)
        {
            init_pivot_grid();
        }
        public void init_pivot_grid()
        {
            fieldTenMonHoc = new PivotGridField("TEN_MON_HOC", PivotArea.RowArea);
            fieldTenMonHoc.Caption = "TÊN MÔN HỌC";
            fieldTenPhong = new PivotGridField("TEN_TRUNG_TAM", PivotArea.ColumnArea);
            fieldTenPhong.Caption = "TÊN TRUNG TÂM";
            fieldIDNHANVIEN = new PivotGridField("ID", PivotArea.DataArea);
            fieldIDNHANVIEN.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            fieldChucVu = new PivotGridField("CHUC_VU", PivotArea.RowArea);
            fieldChucVu.Caption = "CHỨC VỤ";
            //fieldTenKhuVuc = new PivotGridField("TEN", PivotArea.ColumnArea);
            //fieldTenKhuVuc.Caption = "Khu vực";

            pivotGridControl1.Fields.AddRange(new PivotGridField[] { fieldTenMonHoc, fieldTenPhong, fieldChucVu, fieldIDNHANVIEN });
        }

        private void load_data_to_pivot_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_ds.EnforceConstraints = false;
            v_us.FillDatasetChungChiHetHan(v_ds, m_dat.Value);
            pivotGridControl1.DataSource = v_ds.Tables[0];
            if (v_ds.Tables[0].Rows.Count==0)
            {
                MessageBox.Show("Không có chứng chỉ nào hết hạn đến thời điểm này!");
            }
        }

        private void m_cmd_hien_thi_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_to_pivot_grid();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
            
        }

        private void pivotGridControl1_CellDoubleClick(object sender, PivotCellEventArgs e)
        {
            //Form v_f = new Form();
            //DataGrid v_dg = new DataGrid();
            F305_bao_cao_chung_chi_het_han_de v_f1 = new F305_bao_cao_chung_chi_het_han_de();
            v_f1.display(e.CreateDrillDownDataSource());
            //v_f1.v_grc.DataSource = e.CreateDrillDownDataSource();
            //v_f.Controls.Add(v_dg);
            //v_dg.Dock = DockStyle.Fill;
            //v_dg.DataSource = e.CreateDrillDownDataSource();
            //v_f.Dispose();
            //v_f1.ShowDialog();
            //v_f1.Dispose();
        }

        private void m_cmd_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.Refresh();
            }
            catch (Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);

            }
        }
        //private void pivotGridControl1_FieldValueDisplayText(object sender, PivotFieldDisplayTextEventArgs e)
        //{

        //    if (e.ValueType == DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal)
        //        if (e.DisplayText == "Grand Total" || e.DisplayText=="Count")
        //            e.DisplayText = "Tổng";
        //        else
        //            e.DisplayText = e.DataField.SummaryType.ToString();
        //}
    }
}
