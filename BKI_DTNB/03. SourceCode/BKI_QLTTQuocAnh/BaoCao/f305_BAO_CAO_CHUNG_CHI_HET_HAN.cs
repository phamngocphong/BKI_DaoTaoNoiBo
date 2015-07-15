﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace BKI_QLTTQuocAnh.BaoCao
{
    public partial class f305_BAO_CAO_CHUNG_CHI_HET_HAN : Form
    {
        PivotGridField fieldIDNHANSU;
        PivotGridField fieldTenMonHoc;
        PivotGridField fieldTenNgach;
       
        public f305_BAO_CAO_CHUNG_CHI_HET_HAN()
        {
            InitializeComponent();
        }

        private void f305_BAO_CAO_CHUNG_CHI_HET_HAN_Load(object sender, EventArgs e)
        {
            init_pivot_grid();
        }
        public void init_pivot_grid()
        {
            fieldTenMonHoc = new PivotGridField("TEN_MON_HOC", PivotArea.RowArea);
            fieldTenMonHoc.Caption = "Tên môn học";
            fieldTenNgach = new PivotGridField("TEN_NGACH", PivotArea.ColumnArea);
            fieldTenNgach.Caption = "Tên ngạch";
            fieldIDNHANSU = new PivotGridField("ID_NHAN_SU", PivotArea.DataArea);
            fieldIDNHANSU.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;

            pivotGridControl1.Fields.AddRange(new PivotGridField[] { fieldIDNHANSU, fieldTenMonHoc, fieldTenNgach });
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
