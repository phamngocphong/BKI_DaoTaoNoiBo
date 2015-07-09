using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.US;
using IP.Core.IPSystemAdmin;

namespace BKI_QLTTQuocAnh.HeThong {
    public partial class f306_HT_USER_GROUP_DE : Form {
        public f306_HT_USER_GROUP_DE() {
            InitializeComponent();
            format_control();
        }

        #region PublicInterface
        public void display_for_insert() {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        ////public void display_for_update(US_HT_USER_GROUP i_us)
        //{
        //    m_us = i_us;
        //    us_obj_2_form();
        //    this.ShowDialog();
        //}    
        public void display_for_update(US_HT_USER_GROUP i_us) {
            m_us = i_us;
            us_obj_2_form();
            this.ShowDialog();
        }
        #endregion

        #region Member
        DataEntryFormMode m_e_form_mode;
        US_HT_USER_GROUP m_us = new US_HT_USER_GROUP();
        DS_HT_USER_GROUP m_ds = new DS_HT_USER_GROUP();
        #endregion

        #region PrivateMethod
        private void save_data() {
            if(!check_validate())
                return;
            form_2_us_object();
            switch(m_e_form_mode) {
                case DataEntryFormMode.InsertDataState:
                    m_us.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us.Update();
                    break;
            }
            BaseMessages.MsgBox_Infor("Đã cập nhật thành công!");
            this.Close();
        }

        private void form_2_us_object() {
            m_us.strDESCRIPTION = m_txt_mo_ta.Text;
            m_us.strUSER_GROUP_NAME = m_txt_ten_nhom.Text;
        }

        private bool check_validate() {
            if(!CValidateTextBox.IsValid(
            m_txt_ten_nhom
            , DataType.StringType
            , allowNull.NO
            , true))
                return false;
            return true;
        }

        private void format_control() {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            m_cmd_exit.Visible = false;
        }

        private void us_obj_2_form() {
            m_txt_ten_nhom.Text = m_us.strUSER_GROUP_NAME;
            m_txt_mo_ta.Text = m_us.strDESCRIPTION;
        }
        #endregion

        #region Events
        private void m_cmd_exit_Click(object sender, EventArgs e) {
            try {
                this.Close();
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_save_Click(object sender, EventArgs e) {
            try {
                save_data();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_ten_nhom_Click(object sender, EventArgs e) {
            m_lbl_mess.Text = "";
        }

        private void m_txt_mo_ta_Click(object sender, EventArgs e) {
            if(m_txt_ten_nhom.Text == "") {
                m_lbl_mess.Text = "Bạn chưa nhập tên nhóm!!!";
            }
        }
        #endregion


    }
}
