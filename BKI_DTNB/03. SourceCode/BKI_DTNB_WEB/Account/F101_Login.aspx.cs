using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BKI_DTNB_WEB.ChucNang;

namespace BKI_DTNB_WEB.Account
{
    public partial class F101_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void m_cmd_Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ChucNang/F300_Chuong_trinh_khung.aspx");
        }
    }
}