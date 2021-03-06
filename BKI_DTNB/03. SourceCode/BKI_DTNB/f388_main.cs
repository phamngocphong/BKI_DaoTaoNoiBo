﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using IP.Core.IPCommon;
using BKI_DTNB.DS;
using BKI_DTNB.US;
using BKI_DTNB.HeThong;
using BKI_DTNB.NghiepVu;
using IP.Core.IPSystemAdmin;
using BKI_DTNB.DanhMuc;
using BKI_DTNB.BaoCao;
namespace BKI_DTNB
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
                //frm_DM_HOC_PHAN v_f = new frm_DM_HOC_PHAN();
                //v_f.MdiParent = this;
                //v_f.Show();
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
                F301_BC_NV_CHUA_HOAN_THANH_CHUONG_TRINH_HOC v_f = new F301_BC_NV_CHUA_HOAN_THANH_CHUONG_TRINH_HOC();
                v_f.MdiParent = this;
                v_f.Show();
                
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_lop_mon_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f208_gd_lop_mon v_f = new f208_gd_lop_mon();
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
                //f108_danh_muc_ngach v_f = new f108_danh_muc_ngach();
                //v_f.MdiParent = this;
                //v_f.Show();
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
                //f109_danh_muc_dai v_f = new f109_danh_muc_dai();
                //v_f.MdiParent = this;
                //v_f.Show();
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
                //f110_danh_muc_nghiep_vu_mon_hoc v_f = new f110_danh_muc_nghiep_vu_mon_hoc();
                //v_f.MdiParent = this;
                //v_f.Show();
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
                //f103_danh_muc_nghiep_vu_phong v_f = new f103_danh_muc_nghiep_vu_phong();
                //v_f.MdiParent = this;
                //v_f.Show();
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
                //f104_danh_muc_ngach_ngach_con v_f = new f104_danh_muc_ngach_ngach_con();
                //v_f.MdiParent = this;
                //v_f.Show();
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
                //f106_danh_muc_dai_hoc_phan v_f = new f106_danh_muc_dai_hoc_phan();
                //v_f.MdiParent = this;
                //v_f.Show();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void m_cmd_nhap_hoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            F206_Nhan_vien_lop_mon v_f = new F206_Nhan_vien_lop_mon();
            v_f.MdiParent = this;
            v_f.Show();
        }

        private void m_cmd_mon_hoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //f101_danh_muc_mon_hoc v_f = new f101_danh_muc_mon_hoc();
                //v_f.MdiParent = this;
                //v_f.Show();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void m_tinh_hinh_dao_tao_ItemClick(object sender, ItemClickEventArgs e)
        {
            F303_Ket_qua_dao_tao v_f = new F303_Ket_qua_dao_tao();
            v_f.MdiParent = this;
            v_f.Show();
        }

        private void m_cmd_thuc_thu_nv_ItemClick(object sender, ItemClickEventArgs e)
        {
            f305_BAO_CAO_CHUNG_CHI_HET_HAN v_f = new f305_BAO_CAO_CHUNG_CHI_HET_HAN();
            v_f.MdiParent = this;
            v_f.Show();
        }

        private void m_cmd_nghi_hoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            F207_Nhap_diem v_f = new F207_Nhap_diem();
            v_f.MdiParent = this;
            v_f.Show();
        }


        private void m_cmd_nghiep_vu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string v_str_path = "";
                F210_Nhap_diem_xlsx_de v_f_de = new F210_Nhap_diem_xlsx_de();
                
                v_f_de.display(ref v_str_path);
                if (v_f_de.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    F210_Nhap_diem_xlsx v_f = new F210_Nhap_diem_xlsx();
                    v_f.MdiParent = this;
                    v_f.display(v_str_path);
                }
                //f111_danh_muc_nghiep_vu v_f = new f111_danh_muc_nghiep_vu();
                //v_f.MdiParent = this;
                //v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_ngach_nghiep_vu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //f112_danh_muc_ngach_nghiep_vu v_f = new f112_danh_muc_ngach_nghiep_vu();
                //v_f.MdiParent = this;
                //v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tong_quan_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f115_tong_quan v_f = new f115_tong_quan();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void m_cmd_chung_chi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                F209_gd_chung_chi  v_f= new F209_gd_chung_chi();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f388_main_Load(object sender, EventArgs e)
        {

        }

        private void m_cmd_nhan_vien_nghiep_vu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                F112_nhan_su_nghiep_vu v_f = new F112_nhan_su_nghiep_vu();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void m_cmd_nhap_chung_chi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string v_str_path = "";
                F210_Nhap_diem_xlsx_de v_f_de = new F210_Nhap_diem_xlsx_de();

                v_f_de.display(ref v_str_path);
                if (v_f_de.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    F114_Nhap_chung_chi v_f = new F114_Nhap_chung_chi();
                    v_f.MdiParent = this;
                    v_f.display(v_str_path);
                }
                //f111_danh_muc_nghiep_vu v_f = new f111_danh_muc_nghiep_vu();
                //v_f.MdiParent = this;
                //v_f.Show();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_chuong_trinh_khung_ItemClick(object sender, ItemClickEventArgs e)
        {
            F120_CHUONG_TRINH_KHUNG_CUA_NHAN_VIEN v_f = new F120_CHUONG_TRINH_KHUNG_CUA_NHAN_VIEN();
            v_f.MdiParent = this;
            v_f.Show();
        }

        private void m_cmd_mail_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Mail.sendEmail("thaiph.bkhn@gmail.com", "thai14101992", "thaiph@bkindex.com", "", "");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}