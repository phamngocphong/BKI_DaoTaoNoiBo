using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;

namespace BKI_QLTTQuocAnh.NghiepVu
{
    public partial class F301_Assign : Form
    {
        public F301_Assign()
        {
            InitializeComponent();
        }

        decimal m_dc_id_lop_mon;
        decimal m_dc_id_mon_hoc;
        bool m_b_trang_thai;

        public void Display(decimal ip_dc_id_lop_mon, decimal ip_dc_id_mon_hoc)
        {
            m_b_trang_thai = true;
            m_dc_id_lop_mon = ip_dc_id_lop_mon;
            m_dc_id_mon_hoc = ip_dc_id_mon_hoc;
            this.ShowDialog();
        }

        private void F301_Assign_Load(object sender, EventArgs e)
        {
            //if (m_cbo_lop_mon.Items.Count == 0)
            //{
            //    MessageBox.Show("Chưa có lớp học nào cho môn học này. Vui lòng thêm lớp học mới!");
            //    this.Close();
            //}
            //else
            //{
                WinFormControls.load_data_to_combobox("GD_LOP_MON", "ID", "MA_LOP_HOC", " WHERE ID_VERSION_MON_HOC IN (SELECT ID FROM DM_VERSION_MON_HOC WHERE ID_MON_HOC = " + m_dc_id_mon_hoc.ToString() + ")", WinFormControls.eTAT_CA.NO, m_cbo_lop_mon);
                if (m_b_trang_thai)
                {
                    m_cbo_lop_mon.SelectedValue = m_dc_id_lop_mon;
                    m_cbo_lop_mon.Enabled = false;
                }
            //}
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        internal void Display(decimal ip_dc_id_mon_hoc, ref decimal ip_dc_id_lop_mon)
        {
            m_b_trang_thai = false;
            m_dc_id_mon_hoc = ip_dc_id_mon_hoc;
            this.ShowDialog();
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                ip_dc_id_lop_mon = CIPConvert.ToDecimal(m_cbo_lop_mon.SelectedValue.ToString());
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
