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
using IP.Core.IPCommon;
using DevExpress.XtraGrid.Views.Grid;

namespace BKI_DTNB.NghiepVu
{
    public partial class F301_Tao_lop : Form
    {
        decimal m_dc_id_mon_hoc;
        decimal m_dc_so_hoc_vien;

        public F301_Tao_lop()
        {
            InitializeComponent();
            WinFormControls.DTNB_ControlFormat(this);
        }

        public decimal Display(decimal ip_dc_so_hoc_vien, decimal ip_dc_id_mon_hoc, ref decimal op_dc_id_version_mon, ref decimal op_dc_diem_qua_mon)
        {
            m_dc_id_mon_hoc = ip_dc_id_mon_hoc;
            m_dc_so_hoc_vien = ip_dc_so_hoc_vien;
            var v_mon_hoc = new US_DM_MON_HOC(ip_dc_id_mon_hoc);
            m_lbl_mon_hoc.Text = v_mon_hoc.strMA_MON_HOC + " - " + v_mon_hoc.strTEN_MON_HOC;
            m_lbl_so_luong_hoc_vien.Text = ip_dc_so_hoc_vien.ToString();
            WinFormControls.load_data_to_combobox_with_query(m_cbo_version, "ID", "MA_VERSION", WinFormControls.eTAT_CA.NO, "SELECT * FROM DM_VERSION_MON_HOC WHERE ID_MON_HOC=" + ip_dc_id_mon_hoc.ToString());
           
            this.ShowDialog();

            if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                op_dc_diem_qua_mon = CIPConvert.ToDecimal(m_txt_diem_qua_mon.Text);
                op_dc_id_version_mon = CIPConvert.ToDecimal(m_cbo_version.SelectedValue.ToString());
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
