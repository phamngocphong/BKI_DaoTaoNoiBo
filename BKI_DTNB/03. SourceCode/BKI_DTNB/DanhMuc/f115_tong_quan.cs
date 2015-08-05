using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_DTNB.DanhMuc
{
    public partial class f115_tong_quan : Form
    {
        public f115_tong_quan()
        {
            InitializeComponent();
        }

        DataSet m_ds;
        private void f115_tong_quan_Load(object sender, EventArgs e)
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            m_ds = new DataSet();
            m_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithTableName(m_ds, "V_TONG_QUAN");
            m_grc.DataSource = m_ds.Tables[0];
        }

        private void m_grv_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("&In báo cáo",new EventHandler(ReportClick)));
        }

        private void ReportClick(object sender, EventArgs e)
        {
            ArrayList v_arr_list = new ArrayList();
            v_arr_list.Add(new iParameter("iP_tieu_de_bao_cao", "BAO CAO DANH MUC MON HOC"));
            v_arr_list.Add(new iParameter("iP_trung_tam", "TO HOP GIAO DUC TOPICA"));
            v_arr_list.Add(new iParameter("iP_date_time", "Hà Nội, ngày 23 tháng 7 năm 2015"));
            BKI_DTNB.BaoCao.RPT_XtraReport v_xr = new BKI_DTNB.BaoCao.RPT_XtraReport(m_ds, m_grv, v_arr_list, System.Drawing.Printing.PaperKind.A4, true);
            ReportPrintTool v_xrpt = new ReportPrintTool(v_xr);
            v_xrpt.ShowPreview();
        }
    }
}
