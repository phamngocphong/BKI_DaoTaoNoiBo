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
using DevExpress.XtraGrid.Views.Grid;

namespace BKI_QLTTQuocAnh.NghiepVu
{
    public partial class F207_Nhap_diem : Form
    {
        public F207_Nhap_diem()
        {
            InitializeComponent();
        }

        private void F207_Nhap_diem_Load(object sender, EventArgs e)
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());

            v_us.FillDatasetWithTableName(v_ds, "V_GD_DIEM");
            m_grc.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                string v_da_hoc_xong = "";
                string v_da_qua_mon = "";
                F207_Nhap_diem_DE v_f = new F207_Nhap_diem_DE();
                v_f.display(ref v_da_hoc_xong, ref v_da_qua_mon);
                if (v_f.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    for (int i = 0; i < m_grv.SelectedRowsCount; i++)
                    {
                        var v_data_row = m_grv.GetDataRow(m_grv.GetSelectedRows()[i]);
                        US_GD_DIEM v_us = new US_GD_DIEM(CIPConvert.ToDecimal(v_data_row["ID"].ToString()));
                        v_us.strQUA_MON = v_da_qua_mon;
                        v_us.strHOC_XONG_YN = v_da_hoc_xong;
                        v_us.datNGAY_SUA = DateTime.Now.Date;
                        v_us.Update();
                    }
                    MessageBox.Show("Đã cập nhật thành công kết quả học cho " + m_grv.SelectedRowsCount.ToString() + " nhân viên");
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
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
                // Add a submenu with a single menu item.
                e.Menu.Items.Add(WinFormControls.CreateRowSubMenu(view, rowHandle));
            }
        }
    }
}