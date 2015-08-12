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
using DevExpress.XtraGrid.Views.Grid;

namespace BKI_DTNB.NghiepVu
{
    public partial class F206_Nhan_vien_lop_mon : Form
    {
        decimal m_dc_id_lop_mon = -1;

        public F206_Nhan_vien_lop_mon()
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
                 decimal v_count =CIPConvert.ToDecimal(m_grv.SelectedRowsCount.ToString());
                 if (v_count == 0)
                 {
                     MessageBox.Show("Bạn phải chọn lớp môn để thực hiện tác vụ này!");
                 }
                 else
                 {
                     DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Cảnh báo", MessageBoxButtons.YesNo);
                     if (dialogResult == DialogResult.Yes)
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
                 }
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
                decimal v_selected_row_count = GetSelectedRows(m_grv).Count;
                if (v_selected_row_count == 0)
                {
                    MessageBox.Show("Bạn phải chọn lớp môn để thực hiện tác vụ này!");
                }
                else if (v_selected_row_count > 1)
                {
                    MessageBox.Show("Bạn chỉ được chọn 1 lớp môn để thực hiện tác vụ này!");
                }
                else
                {
                    var v_dr = m_grv.GetDataRow(m_grv.GetSelectedRows()[0]);
                    decimal v_dc_id_mon_hoc = CIPConvert.ToDecimal(v_dr["ID_MON_HOC"].ToString());
                    decimal v_dc_id_lop_mon = CIPConvert.ToDecimal(v_dr["ID_LOP_MON"].ToString());
                    F301_BC_NV_CHUA_HOAN_THANH_CHUONG_TRINH_HOC v_f = new F301_BC_NV_CHUA_HOAN_THANH_CHUONG_TRINH_HOC();
                    v_f.display(v_dc_id_lop_mon, v_dc_id_mon_hoc);
                    load_data_2_grid();
                }
            }
            catch (Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);

            }
            ;
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void m_grv_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            // Check whether a row is right-clicked.
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                int rowHandle = e.HitInfo.RowHandle;
                // Delete existing menu items, if any.
                e.Menu.Items.Clear();
                e.Menu.Items.Add(WinFormControls.CreateRowSubMenu(view, rowHandle));
            }
        }

        private List<int> GetSelectedRows(GridView view)
        {
            List<int> v_lst = new List<int>();
            int[] rows = m_grv.GetSelectedRows();
            for (int i = 0; i < rows.Length; i++)
                if (!m_grv.IsGroupRow(rows[i]))
                {
                    v_lst.Add(rows[i]);
                }
            return v_lst;
        }

        private void m_cmd_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.Refresh();
            }
            catch (Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);

            }
        }
    }
}
