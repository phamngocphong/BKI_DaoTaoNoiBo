using DevExpress.XtraPivotGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;

namespace BKI_QLTTQuocAnh.BaoCao
{
    public partial class F303_Ket_qua_dao_tao : Form
    {
        PivotGridField fieldIDNHANSU;
        PivotGridField fieldTenMonHoc;
        PivotGridField fieldTenTrangThai;
        PivotGridField fieldKhuVuc;
        PivotGridField fieldTrungTam;
        PivotGridField fieldNghiepVu;

        public F303_Ket_qua_dao_tao()
        {
            InitializeComponent();
        }

        private void F303_Ket_qua_dao_tao_Load(object sender, EventArgs e)
        {
            init_pivot_grid();
          
        }

        private void init_pivot_grid()
        {
            //fieldMaNV = new PivotGridField("MA_NV", PivotArea.RowArea);
            //fieldMaNV.Caption = "MA_NHAN_VIEN";
            //fieldKhuVuc = new PivotGridField("TEN", PivotArea.RowArea);
            //fieldKhuVuc.Caption = "Khu vực";
            //fieldKhuVuc.AreaIndex = 0;

            fieldTrungTam = new PivotGridField("TEN_PHONG", PivotArea.RowArea);
            fieldTrungTam.Caption = "Tên trung tâm";
            //fieldNgach.AreaIndex = 1;

            //fieldNghiepVu = new PivotGridField("TEN_NGHIEP_VU", PivotArea.RowArea);
            //fieldNghiepVu.Caption = "Tên nghiệp vụ";
            //fieldNghiepVu.AreaIndex = 2;


            fieldTenMonHoc = new PivotGridField("TEN_MON_HOC", PivotArea.RowArea);
            fieldTenMonHoc.Caption = "Tên môn học";
            fieldTenMonHoc.AreaIndex = 3;

            fieldTenTrangThai = new PivotGridField("TEN", PivotArea.ColumnArea);
            fieldTenTrangThai.Caption = "Trạng thái";

            fieldIDNHANSU = new PivotGridField("ID_NHAN_SU",PivotArea.DataArea);
            fieldIDNHANSU.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            fieldIDNHANSU.Caption = "Nhân viên";

            pivotGridControl1.Fields.AddRange(new PivotGridField[] { fieldIDNHANSU, fieldTenMonHoc, fieldTenTrangThai });
        }

        private void load_data_to_pivot_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_ds.EnforceConstraints = false;
            v_us.FillDatasetGDChiTietChucVu(v_ds, m_dat.Value);
            pivotGridControl1.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_hien_thi_Click(object sender, EventArgs e)
        {
            load_data_to_pivot_grid();
        }

        private void pivotGridControl1_CellDoubleClick(object sender, PivotCellEventArgs e)
        {
            Form v_f = new Form();
            DataGrid v_dg = new DataGrid();
            v_f.Controls.Add(v_dg);
            v_dg.Dock = DockStyle.Fill;
            v_dg.DataSource = e.CreateDrillDownDataSource();
            v_f.ShowDialog();
            v_f.Dispose();
        }

        private void pivotGridControl1_FieldValueDisplayText(object sender, PivotFieldDisplayTextEventArgs e)
        {

            if (e.ValueType == DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal)
                if (e.DisplayText == "Grand Total")
                    e.DisplayText = "Tổng";
                else
                    e.DisplayText = e.DataField.SummaryType.ToString();
        }
    }
}
