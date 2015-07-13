using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using BKI_QLTTQuocAnh.US;
namespace BKI_QLTTQuocAnh.DanhMuc
{
    public partial class f108_danh_muc_ngach_de : DevExpress.XtraEditors.XtraForm
    {
        public f108_danh_muc_ngach_de()
        {
            InitializeComponent();
        }
        #region Public Interface
        #endregion
        #region Private Methods
        private void form_2_us_object() {
            m_us_dm_ngach.strMA_NGACH = m_txt_ma_ngach.Text;
            m_us_dm_ngach.strTEN_NGACH = m_txt_ten_ngach.Text;
        }

        private void us_object_2_form() {
            m_txt_ma_ngach.Text = m_us_dm_ngach.strMA_NGACH;
            m_txt_ten_ngach.Text = m_us_dm_ngach.strTEN_NGACH;
        }

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_DM_NGACH m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_ngach = m_us;
            us_object_2_form();
            this.ShowDialog();
        }

        public void display_for_view(US_DM_NGACH m_us)
        {

            m_us_dm_ngach = m_us;
            us_object_2_form();
            m_cmd_luu.Enabled = false;
            this.ShowDialog();
        }

        private bool is_check_validate_ok()
        {

            return true;
        }

        private void save_data()
        {
            if (!is_check_validate_ok())
            {
                return;
            }
            form_2_us_object();

            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_ngach.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_ngach.Update();
                    break;

                default:
                    break;
            }
            BaseMessages.MsgBox_Infor("Cập nhật dữ liệu thành công");
            this.Close();
        }
        #endregion
        #region Members
            DataEntryFormMode m_e_form_mode;
            US_DM_NGACH m_us_dm_ngach = new US_DM_NGACH();
            #endregion

            private void m_cmd_luu_Click(object sender, EventArgs e)
            {
                save_data();
            }

            private void m_cmd_huy_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        #region Events
        
        #endregion



            
    }
}