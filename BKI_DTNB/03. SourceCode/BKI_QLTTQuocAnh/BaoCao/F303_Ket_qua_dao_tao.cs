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
        PivotGridField fieldChucVu;
        PivotGridField fieldDonVi;
        PivotGridField fieldLoaiCV;
        PivotGridField fieldID;
        PivotGridField fieldIDNhanVien;

        public F303_Ket_qua_dao_tao()
        {
            InitializeComponent();
        }

        private void F303_Ket_qua_dao_tao_Load(object sender, EventArgs e)
        {
            init_pivot_grid();
            load_data_to_pivot_grid();
        }

        private void init_pivot_grid()
        {
            fieldChucVu = new PivotGridField("ID_CHUC_VU", PivotArea.RowArea);
            fieldChucVu.Caption = "ID CHUC VU";
            fieldDonVi = new PivotGridField("ID_DON_VI", PivotArea.RowArea);
            fieldDonVi.Caption = "ID DON VI";
            fieldLoaiCV = new PivotGridField("ID_LOAI_CV", PivotArea.RowArea);
            fieldLoaiCV.Caption = "ID LOAI CV";
            fieldID = new PivotGridField("ID", PivotArea.DataArea);
            fieldID.Caption = "ID";
            fieldID.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            fieldIDNhanVien = new PivotGridField("ID_NHAN_SU", PivotArea.RowArea);
            fieldIDNhanVien.Caption = "ID NHAN SU";
            pivotGridControl1.Fields.AddRange(new PivotGridField[] { fieldChucVu, fieldDonVi, fieldLoaiCV, fieldID, fieldIDNhanVien });
        }

        private void load_data_to_pivot_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetGDChiTietChucVu(v_ds);
            pivotGridControl1.DataSource = v_ds.Tables[0];
        }
    }
}
