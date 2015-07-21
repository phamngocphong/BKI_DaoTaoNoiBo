using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;
namespace BKI_QLTTQuocAnh.NghiepVu
{
    public partial class F208_gd_lop_mon_de : Form
    {
        decimal m_dc_id_mon_hoc = -1;
        DataEntryFormMode m_e_form_mode;
        US_GD_LOP_MON m_us = new US_GD_LOP_MON();
        public F208_gd_lop_mon_de()
        {
            InitializeComponent();

        }

        private void F208_gd_lop_mon_de_Load(object sender, EventArgs e)
        {
            load_data_2_cbo();
        }

        private void load_data_2_cbo()
        {
            WinFormControls.load_data_to_combobox("DM_MON_HOC", "ID", "MA_MON_HOC", "", WinFormControls.eTAT_CA.NO, m_cbo_ma_ten_mon_hoc);
        }

        public void m_cbo_ma_ten_mon_hoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_dc_id_mon_hoc = CIPConvert.ToDecimal(m_cbo_ma_ten_mon_hoc.SelectedValue.ToString());
            load_data_2_cbo_version();
        }

        private void load_data_2_cbo_version()
        {
            WinFormControls.load_data_to_combobox("DM_VERSION_MON_HOC", "ID", "MA_VERSION", " WHERE ID_MON_HOC=" + m_dc_id_mon_hoc.ToString(), WinFormControls.eTAT_CA.NO, m_cbo_version);
        }
        public void form_to_us()
        {

            m_us.strMA_LOP_HOC = m_txt_ma_lop.Text;
            m_us.datTHOI_GIAN = m_dat_thoi_gian.Value;
            m_us.dcDIEM_QUA_MON = CIPConvert.ToDecimal(m_txt_diem_qua_mon.Text);
            m_us.datNGAY_LAP = DateTime.Now.Date;
            m_us.datNGAY_SUA = DateTime.Now.Date;
            m_us.strDIA_DIEM = m_txt_dia_diem.Text;
            m_us.strNGUOI_LAP = "admin";
            m_us.IsNGUOI_SUANull();
            m_us.dcSO_LUONG = CIPConvert.ToDecimal(m_txt_so_luong.Text);
            m_us.strDA_XOA = "N";
            m_us.dcID_VERSION_MON_HOC = CIPConvert.ToDecimal(m_cbo_version.SelectedValue.ToString());
        }

        public void us_to_form(US_GD_LOP_MON ip_us)
        {

            m_us = ip_us;
            m_txt_ma_lop.Text = m_us.strMA_LOP_HOC;
            m_dat_thoi_gian.Value = m_us.datTHOI_GIAN;
            m_txt_diem_qua_mon.Text = m_us.dcDIEM_QUA_MON.ToString();
            m_txt_dia_diem.Text = m_us.strDIA_DIEM;
            m_txt_so_luong.Text = m_us.dcSO_LUONG.ToString();
            m_cbo_version.SelectedValue = m_us.dcID_VERSION_MON_HOC;
        }



        internal void Insert_form()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }



        internal void Update_form(US_GD_LOP_MON ip_us)
        {
            us_to_form(ip_us);
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            this.ShowDialog();
        }

        private void savedata()
        {
            form_to_us();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us.Update();
                    break;
                default:
                    break;

                    
            }
            MessageBox.Show("Lưu lớp môn thành công!");
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
    }
}
