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
using IP.Core.IPCommon;
using BKI_QLTTQuocAnh.BaoCao;
using DevExpress.XtraGrid;
using DevExpress.XtraPivotGrid;
namespace BKI_QLTTQuocAnh.BaoCao
{
    public partial class F305_bao_cao_chung_chi_het_han_de : Form
    {
        public GridControl v_grc;
        public F305_bao_cao_chung_chi_het_han_de()
        {
            InitializeComponent();
        }

        private void F305_bao_cao_chung_chi_het_han_de_Load(object sender, EventArgs e)
        {
            //US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //DataSet v_ds = new DataSet();
            //DataTable v_dt = new DataTable();
            //v_ds.Tables.Add(v_dt);
            //v_ds.EnforceConstraints = false;
            //v_us.FillDatasetChungChiHetHan(v_ds, );
            //m_grc.DataSource = v_ds.Tables[0];
            v_grc = m_grc;
            
        }

        public void display(PivotDrillDownDataSource ip_ds) 
        {
            m_grc.DataSource = ip_ds;
            this.ShowDialog();
        }
    }
}
