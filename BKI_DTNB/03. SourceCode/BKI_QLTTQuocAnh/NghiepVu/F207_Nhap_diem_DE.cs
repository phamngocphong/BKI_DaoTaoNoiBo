using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLTTQuocAnh.US;

namespace BKI_QLTTQuocAnh.NghiepVu
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

        public void display(ref string v_da_hoc_xong,ref string v_da_qua_mon)
        {
            m_da_hoc_xong = v_da_hoc_xong;
            m_da_qua_mon = v_da_qua_mon;
            this.ShowDialog();
            v_da_qua_mon = m_da_qua_mon;
            v_da_hoc_xong = m_da_hoc_xong;
        }
    }
}
