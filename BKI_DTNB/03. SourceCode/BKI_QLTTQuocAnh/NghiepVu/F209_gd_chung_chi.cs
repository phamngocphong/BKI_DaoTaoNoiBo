using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;

namespace BKI_QLTTQuocAnh.NghiepVu
{
    public partial class F209_gd_chung_chi : Form
    {
        public F209_gd_chung_chi()
        {
            InitializeComponent();
        }

        private void F209_gd_chung_chi_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();//Khai báo US
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithTableName(v_ds, "V_GD_CHUNG_CHI");
            m_grc.DataSource = v_ds.Tables[0];
        }
      
    }
}
