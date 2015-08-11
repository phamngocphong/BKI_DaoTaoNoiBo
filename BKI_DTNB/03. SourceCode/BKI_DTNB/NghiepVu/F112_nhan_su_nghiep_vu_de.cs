using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_DTNB.US;
using BKI_DTNB.DS;
using BKI_DTNB.DS.CDBNames;
using IP.Core.IPCommon;

namespace BKI_DTNB.NghiepVu
{
    public partial class F112_nhan_su_nghiep_vu_de : Form
    {
        public decimal m_dc_id_nhan_vien_nghiep_vu;
        public decimal m_dc_id_nhan_vien;
        public decimal m_dc_id_nghiep_vu;
        public F112_nhan_su_nghiep_vu_de()
        {
            InitializeComponent();
            WinFormControls.DTNB_ControlFormat(this);
        }



        internal void display_for_insert(decimal ip_dc_id_nhan_vien, string ip_str_ma_nhan_vien,string ip_str_ho_dem, string ip_str_ten)
        { 
            m_dc_id_nhan_vien = ip_dc_id_nhan_vien;
            WinFormControls.load_data_to_combobox_with_query(m_cbo_nghiep_vu, "ID", "TEN_NGHIEP_VU", WinFormControls.eTAT_CA.NO, "SELECT ID, MA_NGHIEP_VU+' - '+ TEN_NGHIEP_VU AS TEN_NGHIEP_VU FROM DM_NGHIEP_VU ");
            WinFormControls.load_data_to_combobox_with_query(m_cbo_nhan_vien,"ID","TEN_NHAN_VIEN", WinFormControls.eTAT_CA.NO,"SELECT ID, MA_NV+' - '+ HO_DEM+' '+TEN AS TEN_NHAN_VIEN FROM DM_NHAN_SU");
            m_cbo_nhan_vien.SelectedValue = m_dc_id_nhan_vien;
            this.ShowDialog();
        }

        private void m_cmd_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                var v_us = new US_DM_NHAN_SU_NGHIEP_VU();
                try
                {
                    Cap_nhat_du_lieu_cho_us(v_us);
                    v_us.Insert();
                    MessageBox.Show("Lưu nghiệp vụ thành công!");
                    this.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
               

            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        public void Cap_nhat_du_lieu_cho_us(US_DM_NHAN_SU_NGHIEP_VU v_us)
        {
            v_us.dcID_NGHIEP_VU = CIPConvert.ToDecimal(m_cbo_nghiep_vu.SelectedValue.ToString());
            v_us.dcID_NHAN_SU = CIPConvert.ToDecimal(m_dc_id_nhan_vien.ToString());
            v_us.strDA_XOA_YN = "N";
            if (m_rdb_nghiep_vu_chinh.Checked)
            {
                v_us.strNGHIEP_VU_CHINH_YN = "Y";
                v_us.strNGHIEP_VU_HOC_THEM_YN = "N";
            }
            else if (m_rdb_nghiep_vu_phu.Checked)
            {
                v_us.strNGHIEP_VU_CHINH_YN = "N";
                v_us.strNGHIEP_VU_HOC_THEM_YN = "N";
            }
            else if (m_rdb_trung_tam_khac.Checked)
            {
                v_us.strNGHIEP_VU_CHINH_YN = "N";
                v_us.strNGHIEP_VU_HOC_THEM_YN = "Y";
            }
        }

     
      
      

    }
}
