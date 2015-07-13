using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DanhMuc;
using IP.Core.IPCommon;

namespace BKI_QLTTQuocAnh.DanhMuc
{
    public partial class f109_danh_muc_dai_de : Form
    {
        public f109_danh_muc_dai_de()
        {
            InitializeComponent();
        }
        #region Public Interface
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_DM_DAI m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_dai = m_us;
            us_obj_2_form();
            this.ShowDialog();

        }
        public void display_for_view(US_DM_DAI m_us)
        {
            m_us_dm_dai = m_us;
            us_obj_2_form();
            m_cmd_save.Enabled = false;//Không cho click vào button save
            this.ShowDialog();
        }
        #endregion 
        #region Members 
        DataEntryFormMode m_e_form_mode;
        US_DM_DAI m_us_dm_dai = new US_DM_DAI();
        #endregion
        #region Private Methods
        private void form_2_us_obj()
        {
            m_us_dm_dai.strMA_DAI = m_txt_ma_dai.Text;
            m_us_dm_dai.strTEN_DAI = m_txt_ten_dai.Text;
        }
        private void us_obj_2_form() 
        {
            m_txt_ma_dai.Text = m_us_dm_dai.strMA_DAI;
            m_txt_ten_dai.Text = m_us_dm_dai.strTEN_DAI;
            
        }
        private void save_data(object sender, EventArgs e) 
        {
            form_2_us_obj();
            switch(m_e_form_mode)
            {//Kiểm tra phương thức là Insert hay Update
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_dai.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_dai.Update();
                    break;
            }
            BaseMessages.MsgBox_Infor("Đã cập nhật thành công");
            this.Close();
        }
        #endregion 
        #region Events
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
        #endregion 

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void save_data() 
        {
            try
            {

            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
