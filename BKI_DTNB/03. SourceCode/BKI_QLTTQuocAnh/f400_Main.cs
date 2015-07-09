using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using BKI_QLTTQuocAnh;
using BKI_QLTTQuocAnh.US;

using IP.Core.IPCommon;
using IP.Core.IPExcelReport;
using IP.Core.IPSystemAdmin;

namespace BKI_QLTTQuocAnh
{
    public partial class f400_Main : Form
    {
        public f400_Main()
        {
            InitializeComponent();
            format_controls();
        }

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
        }

        #endregion

        // Event handlers

        private void set_define_events()
        {
            this.m_menuitem_tudien.Click += new EventHandler(m_mnu_tu_dien_he_thong_Click);
            m_menuitem_nhapkho.Click += m_menuitem_nhapkho_Click;
            //this.m_menuitem_user.Click += new EventHandler(m_mnu_quan_ly_nguoi_su_dung_Click);
            //this.m_menuitem_thoat.Click += new EventHandler(m_menuitem_thoat_Click);
            //this.m_menuitem_qldonvi.Click += new EventHandler(m_menuitem_qldonvi_Click);
            //this.m_menu_dsnhansu.Click += new EventHandler(m_menu_dsnhansu_Click);
            //this.m_menuitem_traCuuNhanSuChung.Click += new EventHandler(m_menuitem_traCuuNhanSuChung_Click);
            //m_menuitem_nhan_su_theo_phong_ban.Click += new System.EventHandler(m_menuitem_nhan_su_theo_phong_ban_Click);
        }

        void m_menuitem_nhapkho_Click(object sender, EventArgs e)
        {
            try
            {
             
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menu_dsnhansu_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_mnu_quan_ly_nguoi_su_dung_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_mnu_tu_dien_he_thong_Click(object sender, EventArgs e)
        {
            try
            {
                IP.Core.IPSystemAdmin.f100_TuDien v_f100_td = new f100_TuDien();
                v_f100_td.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_thoat_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_user_Click(object sender, EventArgs e)
        {
            try
            {
                f999_ht_nguoi_su_dung frm = new f999_ht_nguoi_su_dung();
                frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_qlchucvu_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_menuitem_qldonvi_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_meuitem_ttduan_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_bcnhansu_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_qlquyetdinh_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_trangthailaodong_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_nhan_su_theo_phong_ban_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_hopdong_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_quatrinhlamviec_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void nhânSựTheoChứcVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_meuitem_nhansuduan_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_bcduan_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_traCuuNhanSuChung_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f400_Main_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_lbl_du_an_sap_kt_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void báoCáoHợpĐồngĐãHếtHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_lbl_thong_bao_hop_dong_sap_het_han_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_menuitem_hanghoa_Click(object sender, EventArgs e)
        {
            //f300_V_DM_HANG_HOA f300_v_dm_hang_hoa = new f300_V_DM_HANG_HOA();
            //f300_v_dm_hang_hoa.ShowDialog();
        }
        private void m_menuitem_donvitinh_Click(object sender, EventArgs e)
        {
           
        }
        private void m_menuitem_nhomhanghoa_Click(object sender, EventArgs e)
        {
            try
            {
                //f802_DM_NHOM_HANG f802 = new f802_DM_NHOM_HANG();
                //f802.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void loạiChứngTừToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //f500_DM_LOAI_CHUNG_TU f500 = new f500_DM_LOAI_CHUNG_TU();
            //f500.display();
        }
        private void m_menuitem_khohang_Click(object sender, EventArgs e)
        {
            //f110_DM_KHO frm = new f110_DM_KHO();
            
            
        }

        private void thuếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void m_menuitem_khachhang_Click(object sender, EventArgs e)
        {
            //f102_DM_KHACH_HANG f102_dm_khach_hang = new f102_DM_KHACH_HANG();
           // f102_dm_khach_hang.ShowDialog();
        }

        private void m_menuitem_nhanvien_Click(object sender, EventArgs e)
        {
        
        }



    }
}
