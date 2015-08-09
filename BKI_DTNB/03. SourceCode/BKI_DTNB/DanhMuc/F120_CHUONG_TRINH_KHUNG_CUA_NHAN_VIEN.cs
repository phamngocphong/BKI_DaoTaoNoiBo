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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Menu;
using BKI_DTNB.DS;
using BKI_DTNB.DS.CDBNames;
using DevExpress.XtraPivotGrid;
namespace BKI_DTNB.DanhMuc
{
    public partial class F120_CHUONG_TRINH_KHUNG_CUA_NHAN_VIEN : Form
    {
        
        public F120_CHUONG_TRINH_KHUNG_CUA_NHAN_VIEN()
        {
            InitializeComponent();
        }

        private void F120_CHUONG_TRINH_KHUNG_CUA_NHAN_VIEN_Load(object sender, EventArgs e)
        {
            load_data_to_combobox_ma_ten_nhan_vien();
        }

        private void load_data_to_combobox_ma_ten_nhan_vien()
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_ma_ten_nhan_vien, "ID", "TEN_NHAN_VIEN", WinFormControls.eTAT_CA.NO, "Select dmns.ID, dmns.MA_NV+ ' - '+ dmns.Ho_dem+ ' '+ dmns.Ten as TEN_NHAN_VIEN from dm_nhan_su as dmns");
            
        }

        private void m_cmd_hien_thi_Click(object sender, EventArgs e)
        {
            if (m_cbo_ma_ten_nhan_vien.SelectedItem==null)
            {
                MessageBox.Show("Vui lòng điền vào mã nhân viên");
            }
            else
            {
                load_data_to_grid();
            }
        }
        
        private void load_data_to_grid()
        {
            
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetChuongTrinhKhung(v_ds, CIPConvert.ToDecimal(m_cbo_ma_ten_nhan_vien.SelectedValue));
            m_grc.DataSource = v_ds.Tables[0];
            
            if (m_grv.DataRowCount ==0)
            {
                MessageBox.Show("Nhân viên này chưa có nghiệp vụ!");
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
                e.Menu.Items.Add(WinFormControls.CreateRowSubMenu(view, rowHandle));
            }
        }
    }

}
