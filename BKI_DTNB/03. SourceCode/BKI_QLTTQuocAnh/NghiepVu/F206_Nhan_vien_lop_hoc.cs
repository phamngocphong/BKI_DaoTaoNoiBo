using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLTTQuocAnh.US;
using IP.Core.IPCommon;

namespace BKI_QLTTQuocAnh.NghiepVu
{
    public partial class F206_Nhan_vien_lop_hoc : Form
    {
        decimal m_dc_id_lop_mon = -1;

        public F206_Nhan_vien_lop_hoc()
        {
            InitializeComponent();
        }

        private void F206_Nhan_vien_lop_hoc_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_ds.EnforceConstraints = false;
            v_us.FillDatasetWithTableName(v_ds, "V_GD_HOC_VIEN_LOP_HOC where id_lop_mon = " + m_dc_id_lop_mon.ToString() + " or " + m_dc_id_lop_mon.ToString() + " = -1");
            m_grc.DataSource = v_ds.Tables[0];
        }

        public void display(decimal ip_dc_id_lop_mon)
        {
            this.Show();
            load_data_2_grid();
            m_grv.ActiveFilterString = "[ID_LOP_MON] = " + ip_dc_id_lop_mon.ToString();
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < m_grv.SelectedRowsCount; i++)
                {
                    var v_dr = m_grv.GetDataRow(m_grv.GetSelectedRows()[i]);
                    US_GD_DIEM v_us = new US_GD_DIEM(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                    v_us.strDA_XOA = "Y";
                    v_us.Update();
                }
                MessageBox.Show("Đã xóa " + m_grv.SelectedRowsCount.ToString() + " học viên.");
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                var v_dr = m_grv.GetDataRow(m_grv.GetSelectedRows()[0]);
                F301_BC_NV_CHUA_HOAN_THANH_CHUONG_TRINH_HOC v_f = new F301_BC_NV_CHUA_HOAN_THANH_CHUONG_TRINH_HOC();
                v_f.ShowDialog();
                load_data_2_grid();
            }
            catch (Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);

            }
            ;
        }
    }
}
