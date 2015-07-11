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

namespace BKI_QLTTQuocAnh.DanhMuc
{
    public partial class f102_danh_muc_hoc_phan_de : Form
    {
        public f102_danh_muc_hoc_phan_de()
        {
            InitializeComponent();
        }

        #region Public Interface


        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(US_DM_HOC_PHAN m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_hoc_phan = m_us;
            us_object_2_form();
            this.ShowDialog();
        }
        #endregion

        #region Members

        DataEntryFormMode m_e_form_mode;
        US_DM_HOC_PHAN m_us_dm_hoc_phan= new US_DM_HOC_PHAN();
        #endregion
        #region Private Methods
        private void save_data() {
            if (!is_check_validate_ok())
            {
                return;
            } 
            form_2_us_object();

            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_hoc_phan.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_hoc_phan.Update();
                    break;
             
                default:
                    break;
            }
            BaseMessages.MsgBox_Infor("Cập nhật dữ liệu thành công");
            this.Close();
        }

        private void form_2_us_object() {
          m_us_dm_hoc_phan.strMA_HOC_PHAN = m_txt_ma_hoc_phan.Text;
            m_us_dm_hoc_phan.strTEN_HOC_PHAN = m_txt_ma_hoc_phan.Text;
            if (m_txt_so_luong_mon_hoc_yeu_cau.Text.Trim() == "")
            {
                m_us_dm_hoc_phan.IsSO_LUONG_YEU_CAUNull();
            }
            else
            {
                m_us_dm_hoc_phan.dcSO_LUONG_YEU_CAU = CIPConvert.ToDecimal(m_txt_so_luong_mon_hoc_yeu_cau.Text.Trim());
            }
            if (chk_bat_buoc.Checked)
                m_us_dm_hoc_phan.strBAT_BUOC_YN = "Y";
            else m_us_dm_hoc_phan.strBAT_BUOC_YN = "N";

        }

        private void us_object_2_form() {
            m_txt_ma_hoc_phan.Text = m_us_dm_hoc_phan.strMA_HOC_PHAN;
            m_txt_ten_hoc_phan.Text = m_us_dm_hoc_phan.strTEN_HOC_PHAN;
            m_txt_so_luong_mon_hoc_yeu_cau.Text = m_us_dm_hoc_phan.dcSO_LUONG_YEU_CAU.ToString();
            if (m_us_dm_hoc_phan.strBAT_BUOC_YN == "Y") chk_bat_buoc.Checked = true;
            else chk_bat_buoc.Checked = false;
        }

        public void display_for_view(US_DM_HOC_PHAN m_us)
        {
            
            m_us_dm_hoc_phan = m_us;
            us_object_2_form();
            btn_luu.Enabled = false;
            this.ShowDialog();
        }

        private bool is_check_validate_ok()
        {

            return true;
        }

        #endregion
        #region Events
        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
           
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
                

            
        }
        #endregion

        private void btn_huy_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
        }





       
    }
}
