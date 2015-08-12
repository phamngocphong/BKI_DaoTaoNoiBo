using BKI_DTNB_WEB.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BKI_DTNB.DS;
using BKI_DTNB.US;
using BKI_DTNB.DS.CDBNames;
using IP.Core.IPCommon;
using BKI_DTNB;
using System.Data;
using System.Drawing;
using System.Text;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace BKI_DTNB_WEB.ChucNang
{
    public partial class F300_Chuong_trinh_khung : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            load_data_to_grid();
        }

        private void load_data_to_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetChuongTrinhKhung(v_ds, CIPConvert.ToDecimal(457));
            m_grv.DataSource = v_ds.Tables[0];
            m_grv.DataBind();

            //if (m_grv == 0)
            //{
            //    MessageBox.Show("Nhân viên này chưa có nghiệp vụ!");
            //}
        }
    }
}