using IP.Core.IPSystemAdmin;
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
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using IP.Core.IPData;
using BKI_QLTTQuocAnh.DS.CDBNames;

namespace BKI_QLTTQuocAnh.HeThong
{
    public partial class f308_DOI_MAT_KHAU_NGUOI_SD : Form {
        public f308_DOI_MAT_KHAU_NGUOI_SD() {
            InitializeComponent();
            format_control();
            load_data_to_cbo_tai_khoan();
        }
        
        #region Public Interfaces
        public void display() {
            this.ShowDialog();
        }
        #endregion

        #region  Members
        US_HT_NGUOI_SU_DUNG m_us_ht_nguoi_su_dung = new US_HT_NGUOI_SU_DUNG();
        #endregion

        #region  Private Methods
        private void format_control() {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            set_define_events();              
        }
        private void load_data_to_cbo_tai_khoan() {
            DS_HT_NGUOI_SU_DUNG v_ds_ht_nguoi_su_dung = new DS_HT_NGUOI_SU_DUNG();
            m_us_ht_nguoi_su_dung.FillDataset(v_ds_ht_nguoi_su_dung);

            m_cbo_tai_khoan.DataSource = v_ds_ht_nguoi_su_dung.Tables[0];
            m_cbo_tai_khoan.DisplayMember = HT_NGUOI_SU_DUNG.TEN_TRUY_CAP;
            m_cbo_tai_khoan.ValueMember = HT_NGUOI_SU_DUNG.ID;
        }
        private bool check_validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_mat_khau_cu
                , DataType.StringType
                , allowNull.NO
                , true))
                return false;
            if(!CValidateTextBox.IsValid(m_txt_mat_khau_moi
                , DataType.StringType
                , allowNull.NO
                , true))
                return false;
            if(!CValidateTextBox.IsValid(m_txt_nhap_lai_mat_khau_moi
                , DataType.StringType
                , allowNull.NO
                , true))
                return false;
            return true;
        }
        private void save_data() {
            //Buoc 1: Check validate du lieu khong duoc de trong
            if(!check_validate_data_is_ok())
                return;

            //Buoc 2: Check mat khau cu co dung voi ten tai khoan khong?
            //Khong dung thi hien thong bao
            US_HT_NGUOI_SU_DUNG v_us_ht_nguoi_su_dung = new US_HT_NGUOI_SU_DUNG(CIPConvert.ToDecimal(m_cbo_tai_khoan.SelectedValue));

            if(CIPConvert.Deciphering(v_us_ht_nguoi_su_dung.strMAT_KHAU) != m_txt_mat_khau_cu.Text) {
                BaseMessages.MsgBox_Error("Mật khẩu cũ không đúng!");
                return;
            }
            //Buoc 3: Check mat khau cu va moi co trung nhau hay khong?
            if(m_txt_mat_khau_moi.Text != m_txt_nhap_lai_mat_khau_moi.Text) {
                BaseMessages.MsgBox_Error("Việc nhập lại mật khẩu mới chưa đúng!");
                return;
            }

            //Buoc 4: Luu
            try
            {
                v_us_ht_nguoi_su_dung.strMAT_KHAU = CIPConvert.Encoding(m_txt_mat_khau_moi.Text);

                v_us_ht_nguoi_su_dung.Update();
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
            //Buoc 5: Hien thong bao
            BaseMessages.MsgBox_Infor("Đã đổi mật khẩu thành công!");
            this.Close();
        }
        
        private void set_define_events() {
            m_cmd_exit.Click += m_cmd_exit_Click;
            m_cmd_save.Click += m_cmd_save_Click;
        }
        #endregion

        #region  Events
        private void m_cmd_exit_Click(object sender, EventArgs e) {
            try
            {
                this.Close();
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_save_Click(object sender, EventArgs e) {
            try
            {
                save_data();
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

    }
}
