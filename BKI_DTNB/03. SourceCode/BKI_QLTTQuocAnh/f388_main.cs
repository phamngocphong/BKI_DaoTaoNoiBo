using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using IP.Core.IPCommon;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.HeThong;
using BKI_QLTTQuocAnh.NghiepVu;
using IP.Core.IPSystemAdmin;
using BKI_QLTTQuocAnh.DanhMuc;
using BKI_QLTTQuocAnh.BaoCao;
namespace BKI_QLTTQuocAnh
{
    public partial class f388_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public f388_main()
        {
            InitializeComponent();
          
            MdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            ribbon.SelectedPage = ribbonPage3;
        }
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

        #region Private Methods
       
       
        private bool IsExistFormName(Form ip_frm)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == ip_frm.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        private bool IsExistFormText(Form ip_frm)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Text == ip_frm.Text)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        #endregion

        ///
        ///Events
        ///
        ///
        private void set_define_events()
        {
            //Nghiệp vụ
          
            
         
            //Hệ thống
            m_cmd_thoat.ItemClick += m_cmd_thoat_ItemClick;
            m_cmd_phan_quyen_nhom.ItemClick += m_cmd_phan_quyen_nhom_ItemClick;
            m_cmd_nhom_nguoi_su_dung.ItemClick += m_cmd_nhom_nguoi_su_dung_ItemClick;
            m_cmd_doi_mat_khau.ItemClick += m_cmd_doi_mat_khau_ItemClick;
            m_cmd_nguoi_sd.ItemClick += m_cmd_nguoi_sd_ItemClick;
            m_cmd_backup_restore.ItemClick += m_cmd_backup_restore_ItemClick;
           
          
           
        }

       

        void m_cmd_backup_restore_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                BackupDB v_frm = new BackupDB();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

       

      

        void m_cmd_nguoi_sd_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f999_ht_nguoi_su_dung v_frm = new f999_ht_nguoi_su_dung();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_doi_mat_khau_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f308_DOI_MAT_KHAU_NGUOI_SD v_frm = new f308_DOI_MAT_KHAU_NGUOI_SD();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nhom_nguoi_su_dung_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f306_HT_USER_GROUP v_frm = new f306_HT_USER_GROUP();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_phan_quyen_nhom_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f995_ht_phan_quyen_cho_nhom v_frm = new f995_ht_phan_quyen_cho_nhom();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_thoat_ItemClick(object sender, ItemClickEventArgs e)
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

        private void m_cmd_dm_hs_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frm_DM_HOC_PHAN v_f = new frm_DM_HOC_PHAN();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

      

      
        private void m_cmd_tai_chinh_hs_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //F301_BC_NV_CHUA_HOAN_THANH_CHUONG_TRINH_HOC v_f = new F301_BC_NV_CHUA_HOAN_THANH_CHUONG_TRINH_HOC();
                //v_f.MdiParent = this;
                //v_f.Show();
                F303_Ket_qua_dao_tao v_f = new F303_Ket_qua_dao_tao();
                v_f.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frm_V_GD_LOP_MON v_f = new frm_V_GD_LOP_MON();
                v_f.MdiParent = this;
                v_f.Show();

            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void m_cmd_ngach_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f108_danh_muc_ngach v_f = new f108_danh_muc_ngach();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
           
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            try
            {
                f109_danh_muc_dai v_f = new f109_danh_muc_dai();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
           
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f110_danh_muc_hoc_phan_mon_hoc v_f = new f110_danh_muc_hoc_phan_mon_hoc();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f103_danh_muc_ngach_phong v_f = new f103_danh_muc_ngach_phong();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f104_danh_muc_phong_dai v_f = new f104_danh_muc_phong_dai();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void m_cmd_phong_hoc_phan_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f105_danh_muc_phong_hoc_phan v_f = new f105_danh_muc_phong_hoc_phan();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void m_cmd_dai_hoc_phan_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f106_danh_muc_dai_hoc_phan v_f = new f106_danh_muc_dai_hoc_phan();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void m_cmd_nhap_hoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            F206_Nhan_vien_lop_hoc v_f = new F206_Nhan_vien_lop_hoc();
            v_f.MdiParent = this;
            v_f.Show();
        }

        private void m_cmd_mon_Hoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f110_danh_muc_hoc_phan_mon_hoc v_f = new f110_danh_muc_hoc_phan_mon_hoc();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
        }
    }
}