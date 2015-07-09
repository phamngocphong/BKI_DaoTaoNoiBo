using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

namespace BKI_QLTTQuocAnh.HeThong
{
    public partial class f992_phan_quyen_he_thong_de : Form
    {
        public f992_phan_quyen_he_thong_de()
        {
            InitializeComponent();
            format_control();
        }

        private void format_control() {
            CControlFormat.setFormStyle(this, new CAppContext_201());
        }

        US_HT_PHAN_QUYEN_HE_THONG m_us = new US_HT_PHAN_QUYEN_HE_THONG();
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(US_HT_PHAN_QUYEN_HE_THONG ip_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_obj_2_form(ip_us);
            m_us = ip_us;
            this.ShowDialog();
        }

        private void us_obj_2_form(US_HT_PHAN_QUYEN_HE_THONG ip_us)
        {
            m_txt_ghi_chu.Text = ip_us.strGHI_CHU;
            m_txt_ma_phan_quyen.Text = ip_us.strMA_PHAN_QUYEN;
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private bool check_validate_data_is_ok() {
            if(!CValidateTextBox.IsValid(
                m_txt_ma_phan_quyen
                , DataType.StringType
                , allowNull.NO
                , true))
                return false;
            return true;
        }

        private void save_data()
        {
            if (!check_validate_data_is_ok())
            {
                return;
            }
            form_2_us_obj();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us.Update();
                    break;
            }
            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhật");
            this.Close();
        }

        private void form_2_us_obj()
        {           
            m_us.strGHI_CHU = m_txt_ghi_chu.Text;
            m_us.strMA_PHAN_QUYEN = m_txt_ma_phan_quyen.Text;
        }

        
    }
}
