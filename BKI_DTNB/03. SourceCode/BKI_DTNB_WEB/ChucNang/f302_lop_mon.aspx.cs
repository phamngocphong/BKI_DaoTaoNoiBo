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
using BKI_DTNB_WEB.Account;
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

        protected void m_grv_CustomButtonCallback(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs e)
        {
            var z = e.VisibleIndex.ToString();
            DataRow v_datarow = m_grv.GetDataRow(Int16.Parse(z));
            decimal id_lop_mon = CIPConvert.ToDecimal(v_datarow["ID"].ToString());
            if (check_lop_mon_is_valid())
            {
                decimal id_nhan_vien = CIPConvert.ToDecimal(Account.Person.ID_USER.ToString());
                US_GD_DIEM v_us = new US_GD_DIEM();
                v_us.dcID_LOP_MON = id_lop_mon;
                v_us.dcID_NHAN_VIEN = id_nhan_vien;
                v_us.strQUA_MON = "N";
                v_us.strHOC_XONG_YN = "N";
                v_us.strDA_XOA = "N";
                v_us.datNGAY_LAP = DateTime.Now.Date;
                v_us.datNGAY_SUA = DateTime.Now.Date;
                
                v_us.Insert();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Thông báo", "alert('Đăng kí thành công!')", true);
            }
        }

        private bool check_lop_mon_is_valid()
        {
            return true;
        }
    }
}