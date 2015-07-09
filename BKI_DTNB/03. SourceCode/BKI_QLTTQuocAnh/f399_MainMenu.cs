using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_QLTTQuocAnh;
using IP.Core.IPSystemAdmin;
using System.Security.Policy;
using BKI_QLTTQuocAnh.NghiepVu;
using BKI_QLTTQuocAnh.HeThong;
using GuiDev;
using DevExpress.XtraTab;

namespace Form_menu
{
    public partial class f399_MainMenu : DevComponents.DotNetBar.Office2007RibbonForm
    {
        TabAdd m_tab_add = new TabAdd();
        public f399_MainMenu()
        {
            InitializeComponent();
            format_controls();
            m_tab_add.setCloseButtonTab(xtraTabControl1, ClosePageButtonShowMode.InAllTabPageHeaders);
        }
        #region Members
        int trangthaiweb = 1;
        #endregion
        #region Public Interface
        public void display(ref IP.Core.IPCommon.IPConstants.HowUserWantTo_Exit_MainForm v_exitmode)
        {
            try
            {
                this.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }
        #endregion
        #region Private Method

        private void format_controls()
        {
            //CControlFormat.setFormStyle(this, new CAppContext_201());
            set_define_events();
            this.ShowInTaskbar = true;
            // m_cmd_dang_nhap.Enabled = false;
            //m_cmd_thong_tin.Enabled = false;
            //m_cmd_sao_luu.Enabled = false;
            //m_cmd_phuc_hoi.Enabled = false;
            //m_cmd_doi_mat_khau.Enabled = true;
            //m_cmd_nhat_ky_he_thong.Enabled = false;
            //m_cmd_mua_hang.Enabled = false;
            //m_cmd_nhap_hoc.Enabled = false;
            //m_cmd_nhap_tu_excel.Enabled = false;
            //m_cmd_tien_te.Enabled = false;
            //m_cmd_thue.Enabled = false;
            //m_cmd_tai_khoan.Enabled = false;
            //m_cmd_nha_cung_cap.Enabled = false;
            //m_cmd_nhap_so_du_dau.Enabled = false;
            // m_cmd_ma_vach.Enabled = false;
        }

        private void format_control_in_main_menu(
            string ip_str_control_name
            , IP.Core.IPCommon.IControlerControl ip_obj_controler
            , DevComponents.DotNetBar.RibbonControl ip_control ) {

            //    if (typeof(ip_control)== DevComponents.DotNetBar.RibbonBar) {

            //    }

            //foreach (DevComponents.DotNetBar.RibbonControl v_obj_ribbon_control  in ip_control.Controls){
            //    format_control_in_main_menu(
            //        v_obj_ribbon_control.Name
            //        , ip_obj_controler
            //        , v_obj_ribbon_control);
            //}
        }


        public void closeTabPage(EventArgs e)
        {
            m_tab_add.setCloseTabInEventCloseForm(xtraTabControl1, e);
        }
        #endregion
        // Event handlers
        private void set_define_events()
        {
            xtraTabControl1.CloseButtonClick += xtraTabControl1_CloseButtonClick;
            
        }

       


        public void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            closeTabPage(e);
        }

        private void m_cmd_phan_quyen_Click(object sender, EventArgs e)
        {
            try
            {
                f999_ht_nguoi_su_dung v_frm = new f999_ht_nguoi_su_dung();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);

            }
        }

        private void m_cmd_thoat_Click(object sender, EventArgs e)
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

        private void m_cmd_tu_dien_Click(object sender, EventArgs e)
        {
            try
            {
                f100_TuDien v_frm = new f100_TuDien();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nhom_nguoi_sd_Click(object sender, EventArgs e)
        {
            try
            {
                f306_HT_USER_GROUP v_frm = new f306_HT_USER_GROUP();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phan_quyen_cho_nhom_Click(object sender, EventArgs e)
        {
            try
            {
                f995_ht_phan_quyen_cho_nhom v_frm = new f995_ht_phan_quyen_cho_nhom();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phan_quyen_he_thong_Click(object sender, EventArgs e)
        {
            try
            {
                f993_phan_quyen_he_thong v_frm = new f993_phan_quyen_he_thong();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phan_quyen_chi_tiet_Click(object sender, EventArgs e)
        {
            try
            {
                f994_phan_quyen_detail v_frm = new f994_phan_quyen_detail();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
