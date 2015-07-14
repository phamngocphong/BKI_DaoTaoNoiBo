using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_QLTTQuocAnh.NghiepVu
{
    public partial class F206_Nhan_vien_lop_hoc : Form
    {
        public F206_Nhan_vien_lop_hoc()
        {
            InitializeComponent();
        }

        private void F206_Nhan_vien_lop_hoc_Load(object sender, EventArgs e)
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_ds.EnforceConstraints = false;
            v_us.FillDatasetWithTableName(v_ds, "V_GD_HOC_VIEN_LOP_HOC");
            m_grc.DataSource = v_ds.Tables[0];
        }
    }
}
