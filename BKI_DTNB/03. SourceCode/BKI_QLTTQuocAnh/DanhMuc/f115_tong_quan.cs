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
    public partial class f115_tong_quan : Form
    {
        public f115_tong_quan()
        {
            InitializeComponent();
        }

        private void f115_tong_quan_Load(object sender, EventArgs e)
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithTableName(v_ds, "V_TONG_QUAN");
            m_grc.DataSource = v_ds.Tables[0];
        }
    }
}
