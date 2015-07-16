using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_QLTTQuocAnh.DanhMuc
{
    public partial class f110_danh_muc_nghiep_vu_mon_hoc : Form
    {
        public f110_danh_muc_nghiep_vu_mon_hoc()
        {
            InitializeComponent();
        }
        private void f110_danh_muc_nghiep_vu_mon_hoc_Load(object sender, EventArgs e)
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_NGHIEP_VU_MON_HOC");
            m_grc.DataSource = v_ds.Tables[0];
        }

       
    }
}
