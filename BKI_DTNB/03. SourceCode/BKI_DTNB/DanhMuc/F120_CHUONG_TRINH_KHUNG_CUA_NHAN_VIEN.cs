using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;

namespace BKI_DTNB.DanhMuc
{
    public partial class F120_CHUONG_TRINH_KHUNG_CUA_NHAN_VIEN : Form
    {
        public F120_CHUONG_TRINH_KHUNG_CUA_NHAN_VIEN()
        {
            InitializeComponent();
        }

        private void F120_CHUONG_TRINH_KHUNG_CUA_NHAN_VIEN_Load(object sender, EventArgs e)
        {
            load_data_to_combobox_ma_ten_nhan_vien();
        }

        private void load_data_to_combobox_ma_ten_nhan_vien()
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_ma_ten_nhan_vien, "ID", "TEN_NHAN_VIEN", WinFormControls.eTAT_CA.NO, "Select dmns.ID, dmns.Ma_nv+ ' - '+ dmns.Ho_dem+ ' '+ dmns.Ten as TEN_NHAN_VIEN from dm_nhan_su as dmns");
        }

        private void m_cmd_hien_thi_Click(object sender, EventArgs e)
        {
            load_data_to_grid();
        }

        private void load_data_to_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
        
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetChuongTrinhKhung(v_ds, CIPConvert.ToDecimal(m_cbo_ma_ten_nhan_vien.SelectedValue));
            m_grc.DataSource = v_ds.Tables[0];
        }
    }
}
