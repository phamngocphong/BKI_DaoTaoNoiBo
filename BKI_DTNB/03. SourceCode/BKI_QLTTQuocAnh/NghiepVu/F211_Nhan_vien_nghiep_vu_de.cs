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
    public partial class F211_Nhan_vien_nghiep_vu_de : Form
    {
        bool m_b_nghiep_vu_chuan = true;
        public F211_Nhan_vien_nghiep_vu_de()
        {
            InitializeComponent();
        }

        public void displayForInsertNghiepVuChuan()
        {
            m_b_nghiep_vu_chuan = true;
            load_data_2_cbo();
        }

        private void load_data_2_cbo()
        {
            load_data_2_cbo_nhan_vien();
        }

        public void displayForInsertNghiepVuNgoai()
        {
            m_b_nghiep_vu_chuan = false;
            load_data_2_cbo();
        }

        private void load_data_2_cbo_nhan_vien()
        {
            WinFormControls.load_data_to_combobox("dm_nhan_su", "id", "ho_dem + ' ' + ten", "", WinFormControls.eTAT_CA.NO, m_cbo_nhan_su);
        }

        private void m_cbo_nhan_su_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_b_nghiep_vu_chuan)
            {
                WinFormControls.load_data_to_combobox("v_dm_nhan_su_nghiep_vu", "id_nghiep_vu", "ten_nghiep_vu", " where id_nhan_su = " + m_cbo_nhan_su.SelectedValue.ToString(), WinFormControls.eTAT_CA.NO, m_cbo_nghiep_vu);
            }
            else
            {
                WinFormControls.load_data_to_combobox("DM_NGHIEP_VU", "id", "ma_nghiep_vu + ' - ' + ten_nghiep_vu", "", WinFormControls.eTAT_CA.NO, m_cbo_nghiep_vu);
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
