using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_DTNB.US;
using IP.Core.IPCommon;

namespace BKI_DTNB.NghiepVu
{
    public partial class F207_Nhap_diem_DE : Form
    {
        public F207_Nhap_diem_DE()
        {
            InitializeComponent();
        }

        string m_da_hoc_xong = "";
        string m_da_qua_mon = "";

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            if (m_cb_hoc_xong_yn.Checked)
            {
                m_da_hoc_xong = "Y";
            }
            else
            {
                m_da_hoc_xong = "N";
            }

            if (m_cb_qua_mon.Checked)
            {
                m_da_qua_mon = "Y";
            }
            else
            {
                m_da_qua_mon = "N";
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        public void display(ref string v_da_hoc_xong, ref string v_da_qua_mon, ref decimal diem_chuyen_can, ref decimal diem_giua_ky, ref decimal diem_cuoi_ky)
        {
            m_da_hoc_xong = v_da_hoc_xong;
            m_da_qua_mon = v_da_qua_mon;
            this.ShowDialog();
            v_da_qua_mon = m_da_qua_mon;
            v_da_hoc_xong = m_da_hoc_xong;
            //if(m_txt_chuyen_can.Text=="") 
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                diem_chuyen_can = CIPConvert.ToDecimal(m_txt_chuyen_can.Text);
                diem_giua_ky = CIPConvert.ToDecimal(m_txt_giua_ky.Text);
                diem_cuoi_ky = CIPConvert.ToDecimal(m_txt_cuoi_ky.Text);
            }
        }
    }
}
