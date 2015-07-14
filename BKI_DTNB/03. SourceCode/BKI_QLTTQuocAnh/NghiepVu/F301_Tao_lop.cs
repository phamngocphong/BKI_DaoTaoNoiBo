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
using DevExpress.XtraGrid.Views.Grid;

namespace BKI_QLTTQuocAnh.NghiepVu
{
    public partial class F301_Tao_lop : Form
    {
        decimal m_dc_id_mon_hoc;
        decimal m_dc_so_hoc_vien;

        public F301_Tao_lop()
        {
            InitializeComponent();
        }

        public decimal Display(decimal ip_dc_so_hoc_vien, decimal ip_dc_id_mon_hoc)
        {
            m_dc_id_mon_hoc = ip_dc_id_mon_hoc;
            m_dc_so_hoc_vien = ip_dc_so_hoc_vien;
            var v_mon_hoc = new US_DM_MON_HOC(ip_dc_id_mon_hoc);
            m_lbl_mon_hoc.Text = v_mon_hoc.strMA_MON_HOC + " - " + v_mon_hoc.strTEN_MON_HOC;
            m_lbl_so_luong_hoc_vien.Text = ip_dc_so_hoc_vien.ToString();
            this.ShowDialog();
            if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                return CIPConvert.ToDecimal(m_txt_so_hoc_vien_1_lop.Text);    
            }
            else
            {
                return -1;
            }
            
        }

        private void m_cmd_tao_lop_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }            
        }

        private void m_cmd_huy_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
