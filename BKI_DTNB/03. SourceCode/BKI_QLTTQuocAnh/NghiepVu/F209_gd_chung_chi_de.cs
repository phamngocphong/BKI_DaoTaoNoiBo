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
        US_V_GD_DIEM m_us_v_gd_diem = new US_V_GD_DIEM();
        bool v_trang_thai=true;
        public F209_gd_chung_chi_de()
        {
            InitializeComponent();
        }
        public void us_v_gd_diem_to_form(US_V_GD_DIEM v_us_gd_diem)
        {
            m_txt_ma_nhan_vien.Text = v_us_gd_diem.strMA_NV;
            m_txt_ten_nhan_vien.Text = v_us_gd_diem.strHO_TEN;
            m_txt_ten_mon_hoc.Text = v_us_gd_diem.strTEN_MON_HOC;
            m_txt_ma_version.Text = v_us_gd_diem.strMA_VERSION;
            m_dc_id_gd_diem = v_us_gd_diem.dcID;
            v_trang_thai = false;

        }
        public void form_to_us()
        {
          
            m_us_gd_chung_chi.datNGAY_BAT_DAU = m_dat_thoi_gian_bat_dau.Value;
            m_us_gd_chung_chi.datNGAY_KET_THUC = m_dat_thoi_gian_ket_thuc.Value;
            m_us_gd_chung_chi.datNGAY_LAP = m_dat_ngay_lap.Value;
            m_us_gd_chung_chi.datNGAY_SUA = DateTime.Now.Date;
            m_us_gd_chung_chi.strNGUOI_LAP = "admin";
            m_us_gd_chung_chi.IsNGUOI_SUANull();
            m_us_gd_chung_chi.strDA_XOA = "N";
        
            m_us_gd_chung_chi.dcID_GD_DIEM = m_dc_id_gd_diem;
            m_us_gd_chung_chi.strSO_CHUNG_CHI = m_txt_so_chung_chi.Text;
            if (v_trang_thai == true)
            {
                m_us_gd_chung_chi.dcID = m_dc_id_gd_chung_chi;
            }

           
        }

        public void us_to_form(US_V_GD_CHUNG_CHI ip_us)
        {
            m_us = ip_us;
            m_txt_ma_nhan_vien.Text = m_us.strMA_NV;
            m_txt_ten_nhan_vien.Text = m_us.strHO_TEN;
            m_txt_ten_mon_hoc.Text = m_us.strTEN_MON_HOC;
            m_txt_ma_version.Text = m_us.strMA_VERSION;
            m_dat_ngay_lap.Value = m_us.datNGAY_LAP;
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
            switch(m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_gd_chung_chi.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    try
                    {
                        m_us_gd_chung_chi.Update();
                        MessageBox.Show("Lưu chứng chỉ thành công!");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Chứng chỉ này đã tồn tại trong hệ thống.Vui lòng kiểm tra lại thông tin!");
                    }
                    break;
            }
   
        }

        private void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                savedata();
                this.Close();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
        }
        private void m_cmd_thoat_Click(object sender, EventArgs e)
        {
            v_trang_thai = true;
            this.Close();
            
        }

        internal void dislay_for_insert(US_V_GD_DIEM v_us)
        {
            us_v_gd_diem_to_form(v_us);
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            
            this.ShowDialog();
        }
    }
}
