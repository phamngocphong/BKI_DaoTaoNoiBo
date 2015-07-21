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
    public partial class f208_gd_lop_mon : Form
    {
        public f208_gd_lop_mon()
        {
            InitializeComponent();
        }

        private void f208_gd_lop_mon_Load(object sender, EventArgs e)
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();//Khai báo US
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithTableName(v_ds, "V_GD_LOP_MON");
            m_grc.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            Insert_to_form();
        }

        private void Insert_to_form()
        {
            F208_gd_lop_mon_de v_f = new F208_gd_lop_mon_de();
          
            v_f.Insert_form();
            load_data_2_grid();
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                F208_gd_lop_mon_de v_f = new F208_gd_lop_mon_de();
               // var m_row = m_grv.SelectedRowsCount - 1;
                var v_data_row = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                US_GD_LOP_MON v_us = new US_GD_LOP_MON(CIPConvert.ToDecimal(v_data_row["ID"].ToString()));
                v_f.Update_form(v_us);
                load_data_2_grid();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
          
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            var v_data_row = m_grv.GetDataRow(m_grv.FocusedRowHandle);
            US_GD_LOP_MON v_us = new US_GD_LOP_MON(CIPConvert.ToDecimal(v_data_row["ID"].ToString()));
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                v_us.Delete();
            }
          
            load_data_2_grid();
        }
    }
}
