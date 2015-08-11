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
using BKI_DTNB.DS.CDBNames;
using DevExpress.XtraEditors.Repository;

namespace BKI_DTNB.NghiepVu
{
    public partial class F207_Nhap_diem : Form
    {
        public List<int> m_lst_index = new List<int>();
        public F207_Nhap_diem()
        {
            InitializeComponent();
        }

        private void F207_Nhap_diem_Load(object sender, EventArgs e)
        {
            load_data_2_grid();
            RepositoryItemComboBox riCombo = new RepositoryItemComboBox();
            riCombo.Items.AddRange(new string[] { "Đã qua môn", "Không qua môn" });
            //Add a repository item to the repository items of grid control
            m_grc.RepositoryItems.Add(riCombo);
            //Now you can define the repository item as an inplace editor of columns
            c_qua_mon.ColumnEdit = riCombo;
           

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
            //try
            //{
            //    string v_da_hoc_xong = "";
            //    string v_da_qua_mon = "";
            //    decimal v_diem_chuyen_can = -1;
            //    decimal v_diem_giua_ky = -1;
            //    decimal v_diem_cuoi_ky = -1;
            //    F207_Nhap_diem_DE v_f = new F207_Nhap_diem_DE();
            //    v_f.display(ref v_da_hoc_xong, ref v_da_qua_mon, ref v_diem_chuyen_can, ref v_diem_giua_ky, ref v_diem_cuoi_ky);
            //    if (v_f.DialogResult == System.Windows.Forms.DialogResult.OK)
            //    {
            //        for (int i = 0; i < m_grv.SelectedRowsCount; i++)
            //        {
            //            var v_data_row = m_grv.GetDataRow(m_grv.GetSelectedRows()[i]);
            //            US_GD_DIEM v_us = new US_GD_DIEM(CIPConvert.ToDecimal(v_data_row["ID"].ToString()));
            //            v_us.strQUA_MON = v_da_qua_mon;
            //            v_us.strHOC_XONG_YN = v_da_hoc_xong;
            //            v_us.dcDIEM_CHUYEN_CAN = v_diem_chuyen_can;
            //            v_us.dcDIEM_KIEM_TRA = v_diem_giua_ky;
            //            v_us.dcDIEM_THI = v_diem_cuoi_ky;
            //            v_us.datNGAY_SUA = DateTime.Now.Date;
            //            v_us.Update();
            //        }
            //        MessageBox.Show("Đã cập nhật thành công kết quả học cho " + m_grv.SelectedRowsCount.ToString() + " nhân viên");
            //        load_data_2_grid();
            //    }
            //}
            //catch (Exception v_e)
            //{
            //    CSystemLog_301.ExceptionHandle(v_e);
            //}


            try
            {
                string v_str_path = "";
                F210_Nhap_diem_xlsx_de v_f_de = new F210_Nhap_diem_xlsx_de();

                v_f_de.display(ref v_str_path);
                if (v_f_de.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    F210_Nhap_diem_xlsx v_f = new F210_Nhap_diem_xlsx();
                 //   v_f.MdiParent = this;
                    v_f.display(v_str_path);
                }
                //f111_danh_muc_nghiep_vu v_f = new f111_danh_muc_nghiep_vu();
                //v_f.MdiParent = this;
                //v_f.Show();
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
                DXMenuItem v_menu_item = new DXMenuItem("&Cấp chứng chỉ cho học viên này", new EventHandler(CapChungChiClick));
                e.Menu.Items.Add(v_menu_item);
            }
        }

        private void CapChungChiClick(object sender, EventArgs e)
        {
            var v_dt_row = m_grv.GetDataRow(m_grv.FocusedRowHandle);
            US_V_GD_DIEM v_us = new US_V_GD_DIEM(CIPConvert.ToDecimal(v_dt_row["ID"].ToString()));
            F209_gd_chung_chi_de v_f = new F209_gd_chung_chi_de();
            v_f.dislay_for_insert(v_us);
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_grv_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!m_lst_index.Exists(x => x == e.RowHandle))
            {
                m_lst_index.Add(e.RowHandle);
            }
        }

        private void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                luu_du_lieu();
                //load_data_2_grid();
                MessageBox.Show("Đã lưu xong");
                load_data_2_grid();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void update_lop_mon(DataRow v_dr) //Lưu dữ liệu từ gridview vào DB
        {
            US_GD_DIEM v_us = new US_GD_DIEM(CIPConvert.ToDecimal(v_dr[GD_DIEM.ID].ToString()));//Kiếm tra khác rỗng
            if (v_dr[GD_DIEM.DIEM_CHUYEN_CAN].ToString().Trim() != "")
            {
                v_us.dcDIEM_CHUYEN_CAN = CIPConvert.ToDecimal(v_dr[GD_DIEM.DIEM_CHUYEN_CAN].ToString());
            }
            if (v_dr[GD_DIEM.DIEM_KIEM_TRA].ToString().Trim() != "")
            {
                v_us.dcDIEM_KIEM_TRA = CIPConvert.ToDecimal(v_dr[GD_DIEM.DIEM_KIEM_TRA].ToString());
            }
            if (v_dr[GD_DIEM.DIEM_THI].ToString().Trim() != "")
            {
                v_us.dcDIEM_THI = CIPConvert.ToDecimal(v_dr[GD_DIEM.DIEM_THI].ToString());
                v_us.strHOC_XONG_YN = "Y";
            }
            
            if (v_dr["QUA_MON"].ToString() == "Đã qua môn")
            {
                v_us.strQUA_MON = "Y";
            }
            else if (v_dr["QUA_MON"].ToString() == "Không qua môn")
            {
                v_us.strQUA_MON = "N";
            }
            try
            {
                v_us.Update();
            }
            catch (Exception)
            {

                MessageBox.Show("Cột Kết quả bạn chỉ được lựa chọn 1 trong 2 trạng thái!");
            }
           
        }
        private void luu_du_lieu()
        {
            foreach (var item in m_lst_index)
            {
                DataRow v_dr = m_grv.GetDataRow(item);
                update_lop_mon(v_dr);
            }
        }
    }
}