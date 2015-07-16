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
    public partial class f111_danh_muc_nghiep_vu : Form
    {
        public f111_danh_muc_nghiep_vu()
        {
            InitializeComponent();
        }

        private void f111_danh_muc_nghiep_vu_Load(object sender, EventArgs e)
        {
            load_data_2_grid();
        }
        private void load_data_2_grid()
        {//Hiển thị khi mới load form

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "DM_NGHIEP_VU");
            m_grc.DataSource = v_ds.Tables[0];
        }
		
    }
}
