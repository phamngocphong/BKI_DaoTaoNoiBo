using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IP.Core.IPCommon;
using BKI_DTNB.DS;
using BKI_DTNB.DS.CDBNames;
using BKI_DTNB.US;
using BKI_DTNB;
using System.Data;

namespace BKI_DTNB_WEB.ChucNang
{
    public partial class f302_lop_mon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
            
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();//Khai báo US
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillLopMonChoNhanVien(v_ds, CIPConvert.ToDecimal(457));
            m_grv.DataSource = v_ds.Tables[0];
            m_grv.DataBind();
        }
    }
}