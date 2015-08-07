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
using DevExpress.Utils.Menu;
using BKI_DTNB.DS;
using BKI_DTNB.DS.CDBNames;
namespace BKI_DTNB.NghiepVu
{
    public partial class f208_gd_lop_mon : Form
    {
        public bool m_trang_thai_insert= true;
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
            m_grv.ExpandAllGroups();
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            Insert_to_form(m_trang_thai_insert);
        }

        private void Insert_to_form(bool ip_trang_thai)
        {
            F208_gd_lop_mon_de v_f = new F208_gd_lop_mon_de();

            v_f.Insert_form(ip_trang_thai);
            load_data_2_grid();
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_count =CIPConvert.ToDecimal(m_grv.SelectedRowsCount);
                if (v_count==0)
                {
                    MessageBox.Show("Bạn phải chọn 1 lớp môn để thực hiện tác vụ này!");
                }

                else if (v_count > 1)
                {
                    MessageBox.Show("Bạn chỉ được chọn duy nhất 1 lớp môn để thực hiện tác vụ này!");
                }
                else
                {
                  var v_data_row = m_grv.GetDataRow(m_grv.GetSelectedRows()[0]);
                  Update_row_change(v_data_row);
                }
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
          
        }

        private void Update_row_change(DataRow v_data_row)
        {
            F208_gd_lop_mon_de v_f = new F208_gd_lop_mon_de();
            //var v_data_row = m_grv.GetDataRow(m_grv.GetSelectedRows()[0]);
            var v_us = new US_GD_LOP_MON(CIPConvert.ToDecimal(v_data_row["ID"].ToString()));
            US_DM_VERSION_MON_HOC us_version = new US_DM_VERSION_MON_HOC();
            DS_DM_VERSION_MON_HOC v_ds_version = new DS_DM_VERSION_MON_HOC();
            v_ds_version.EnforceConstraints = false;
            us_version.FillDataset(v_ds_version, "where ID=" + v_data_row["ID_VERSION_MON_HOC"].ToString());
            DataRow v_d_r = v_ds_version.Tables[0].Rows[0];
            decimal v_id_version = CIPConvert.ToDecimal(v_d_r[DM_VERSION_MON_HOC.ID].ToString());
            us_version = new US_DM_VERSION_MON_HOC(v_id_version);
            decimal v_index_selected = CIPConvert.ToDecimal(us_version.dcID_MON_HOC.ToString());
            v_f.Update_form(v_us, v_index_selected);
            load_data_2_grid();
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
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
                    xoa_lop_mon(v_count);
                    MessageBox.Show(" Đã xóa thành công "+ v_count.ToString()+ " lớp môn");
                    load_data_2_grid();
                    }
                 }
         
        }

        private void xoa_lop_mon(decimal v_count)
        {
            for (int i = 0; i < v_count; i++)
            {
                var v_data_row = m_grv.GetDataRow(m_grv.GetSelectedRows()[i]);
                US_GD_LOP_MON v_us_gd_lop_mon = new US_GD_LOP_MON(CIPConvert.ToDecimal(v_data_row["ID"].ToString()));
                decimal v_dc_id_lop_mon = CIPConvert.ToDecimal(v_us_gd_lop_mon.dcID.ToString());
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                US_DUNG_CHUNG v_us_dc = new US_DUNG_CHUNG();
                v_us_dc.FillDatasetWithQuery(v_ds, "Select * from gd_diem where id_lop_mon=" + v_dc_id_lop_mon.ToString());
                if (v_ds.Tables[0].Rows.Count > 0)
                {
                    for (int j = 0; j < v_ds.Tables[0].Rows.Count; j++)
                    {
                        
                        var v_id_gdd = CIPConvert.ToDecimal(v_ds.Tables[0].Rows[j]["ID"].ToString());
                        var v_us_gdd= new US_GD_DIEM(v_id_gdd);
                         var v_ds_gdd = new DataSet();
                         v_ds_gdd.Tables.Add(new DataTable());
                         v_us_dc.FillDatasetWithQuery(v_ds_gdd, "Select * from gd_chung_chi where id_gd_diem=" + v_id_gdd.ToString());
                         if (v_ds_gdd.Tables[0].Rows.Count > 0)
                        {
                            var v_dtr_gdcc = v_ds_gdd.Tables[0].Rows[0];
                            var v_us_gdcc = new US_GD_CHUNG_CHI(CIPConvert.ToDecimal(v_dtr_gdcc["ID"].ToString()));
                            v_us_gdcc.strDA_XOA = "Y";
                            v_us_gdcc.Update();
                        }
                        v_us_gdd.strDA_XOA = "Y";
                        v_us_gdd.Update();
                    }
                }

                v_us_gd_lop_mon.strDA_XOA = "Y";
                v_us_gd_lop_mon.Update();
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
                DXMenuItem v_menu_item = new DXMenuItem("&Xem danh sách học viên của lớp môn", new EventHandler(XemNhanVienClick));
                e.Menu.Items.Add(v_menu_item);
            }
        }

        private void XemNhanVienClick(object sender, EventArgs e)
        {
            var v_dr= m_grv.GetDataRow(m_grv.FocusedRowHandle);

            F206_Nhan_vien_lop_mon v_f = new F206_Nhan_vien_lop_mon();
            v_f.display(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
