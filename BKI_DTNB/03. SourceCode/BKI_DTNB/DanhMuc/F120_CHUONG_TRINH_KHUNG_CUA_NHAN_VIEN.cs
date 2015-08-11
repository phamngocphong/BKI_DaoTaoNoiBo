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
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

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
            try
            {
                get_nhan_vien();
                
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

      

        private void m_cmd_hien_thi_Click(object sender, EventArgs e)
        {
            if (m_search_lookup_edit.Text==null)
            {
                MessageBox.Show("Vui lòng điền vào mã nhân viên");
            }
            else
            {
               
                load_data_to_grid();
            }
        }

        private void get_nhan_vien()
        {
              US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithQuery(v_ds, "Select ID, MA_NV, ho_dem +' '+ Ten as HO_TEN from dm_nhan_su");
            m_search_lookup_edit.Properties.DataSource = v_ds.Tables[0];
            m_search_lookup_edit.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
          
        }
        
        private void load_data_to_grid()
        {
            
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
           v_us.FillDatasetChuongTrinhKhung(v_ds, CIPConvert.ToDecimal(m_search_lookup_edit.EditValue.ToString()));
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
