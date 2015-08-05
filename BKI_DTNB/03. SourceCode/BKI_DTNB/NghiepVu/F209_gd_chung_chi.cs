using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_DTNB.US;
using BKI_DTNB.DS;
namespace BKI_DTNB.NghiepVu
{
    public partial class F209_gd_chung_chi : Form
    {
        public F209_gd_chung_chi()
        {
            InitializeComponent();
        }

        private void F209_gd_chung_chi_Load(object sender, EventArgs e)
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
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();//Khai báo US
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithTableName(v_ds, "V_GD_CHUNG_CHI");
            m_grc.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            decimal v_selected_row = m_grv.SelectedRowsCount;
            if (v_selected_row == 0)
            {
                MessageBox.Show("Bạn phải chọn ít nhất 1 chứng chỉ để thực hiện tác vụ này!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn hủy chứng chỉ này không?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var v_data_row = m_grv.GetDataRow(m_grv.FocusedRowHandle);
                    US_GD_CHUNG_CHI v_us = new US_GD_CHUNG_CHI(CIPConvert.ToDecimal(v_data_row["ID"].ToString()));
                    v_us.strDA_XOA = "Y";
                    v_us.Update();
                    load_data_2_grid();
                }
            }

           
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_selected_row = m_grv.SelectedRowsCount;
                if (v_selected_row == 0)
                {
                    MessageBox.Show("Bạn phải chọn chứng chỉ để thực hiện tác vụ này!");
                }
                else if (v_selected_row > 1)
                {
                    MessageBox.Show("Bạn chỉ được chọn 1 chứng chỉ để thực hiện tác vụ này!");
                }
                else
                {
                    F209_gd_chung_chi_de v_f = new F209_gd_chung_chi_de();
                    // var m_row = m_grv.SelectedRowsCount - 1;
                    var v_data_row = m_grv.GetDataRow(m_grv.GetSelectedRows()[0]);
                    US_V_GD_CHUNG_CHI v_us = new US_V_GD_CHUNG_CHI(CIPConvert.ToDecimal(v_data_row["ID"].ToString()));
                    
                        v_f.Update_form(v_us);
                        load_data_2_grid();
        
                }
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
          
        }
      
    }
}
