using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.US;

namespace BKI_QLTTQuocAnh.NghiepVu
{
    public partial class F209_gd_chung_chi_de : Form
    {
        decimal m_dc_id_gd_chung_chi = -1;
        decimal m_dc_id_gd_diem = -1;
        decimal m_dc_id_mon_hoc = -1;
        DataEntryFormMode m_e_form_mode;
        US_V_GD_CHUNG_CHI m_us = new US_V_GD_CHUNG_CHI();
        US_GD_CHUNG_CHI m_us_gd_chung_chi = new US_GD_CHUNG_CHI();
        public F209_gd_chung_chi_de()
        {
            InitializeComponent();
        }
        public void form_to_us()
        {
          
            m_us_gd_chung_chi.datNGAY_BAT_DAU = m_dat_thoi_gian_bat_dau.Value;
            m_us_gd_chung_chi.datNGAY_KET_THUC = m_dat_thoi_gian_ket_thuc.Value;
            m_us_gd_chung_chi.datNGAY_LAP = DateTime.Now.Date;
            m_us_gd_chung_chi.datNGAY_SUA = DateTime.Now.Date;
            m_us_gd_chung_chi.strNGUOI_LAP = "admin";
            m_us_gd_chung_chi.IsNGUOI_SUANull();
            m_us_gd_chung_chi.strDA_XOA = "N";
            m_us_gd_chung_chi.dcID = m_dc_id_gd_chung_chi;
            m_us_gd_chung_chi.dcID_GD_DIEM = m_dc_id_gd_diem;
            m_us_gd_chung_chi.strSO_CHUNG_CHI = m_txt_so_chung_chi.Text;
           
        }

        public void us_to_form(US_V_GD_CHUNG_CHI ip_us)
        {
            m_us = ip_us;
            m_txt_ma_nhan_vien.Text = m_us.strMA_NV;
            m_txt_ten_nhan_vien.Text = m_us.strHO_TEN;
            m_txt_ten_mon_hoc.Text = m_us.strTEN_MON_HOC;
            m_txt_ma_version.Text = m_us.strMA_VERSION;
            m_dat_thoi_gian_bat_dau.Value = m_us.datNGAY_BAT_DAU;
            m_dat_thoi_gian_ket_thuc.Value = m_us.datNGAY_KET_THUC;
            m_txt_trang_thai.Text = m_us.strTRANG_THAI;
            m_dc_id_gd_chung_chi = m_us.dcID;
            m_dc_id_gd_diem = m_us.dcID_GD_DIEM;
            m_txt_so_chung_chi.Text = m_us.strSO_CHUNG_CHI;
           
        }
        internal void Update_form(US_V_GD_CHUNG_CHI ip_us)
        {
            us_to_form(ip_us);
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            this.ShowDialog();
        }

        private void savedata()
        {
            form_to_us();
            m_us_gd_chung_chi.Update();
            MessageBox.Show("Lưu chứng chỉ thành công!");
        }

        private void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                savedata();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
        }
        private void m_cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
