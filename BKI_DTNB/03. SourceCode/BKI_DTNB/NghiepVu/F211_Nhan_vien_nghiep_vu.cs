using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;

namespace BKI_DTNB.NghiepVu
{
    public partial class F211_Nhan_vien_nghiep_vu : Form
    {
        public F211_Nhan_vien_nghiep_vu()
        {
            InitializeComponent();
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                F211_Nhan_vien_nghiep_vu_de v_f = new F211_Nhan_vien_nghiep_vu_de();
                v_f.displayForInsertNghiepVuChuan();
                if (v_f.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    load_data_2_grid();   
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void load_data_2_grid()
        {
            throw new NotImplementedException();
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
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

        private void m_cmd_insert_nghiep_vu_them_Click(object sender, EventArgs e)
        {
            try
            {
                F211_Nhan_vien_nghiep_vu_de v_f = new F211_Nhan_vien_nghiep_vu_de();
                v_f.displayForInsertNghiepVuNgoai();
                if (v_f.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
