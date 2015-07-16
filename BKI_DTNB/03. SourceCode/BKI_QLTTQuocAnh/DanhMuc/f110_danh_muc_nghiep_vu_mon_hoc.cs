using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using DevExpress.XtraGrid.Views.Grid;
namespace BKI_QLTTQuocAnh.DanhMuc
{
    public partial class f110_danh_muc_nghiep_vu_mon_hoc : DevExpress.XtraEditors.XtraForm
    {
        public f110_danh_muc_nghiep_vu_mon_hoc()
        {
            InitializeComponent();
        }
        //private void f110_danh_muc_hoc_phan_mon_hoc_de_LOAD(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        WinFormControls.load_data_to_combobox("DM_HOC_PHAN", "ID", "TEN_HOC_PHAN", "", WinFormControls.eTAT_CA.NO, m_cbo_ma_hoc_phan);
        //        load_data_to_grid();
        //    }
        //    catch (Exception v_e)
        //    {

        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        //private void load_data_to_grid()
        //{
        //    US_V_HOC_PHAN_MON_HOC v_us = new US_V_HOC_PHAN_MON_HOC();
        //    DataSet v_ds = new DataSet();
        //    DataTable v_dt = new DataTable();
        //    v_ds.Tables.Add(v_dt);
        //    v_us.FillDatasetTheoHocPhan(v_ds, CIPConvert.ToDecimal(m_cbo_ma_hoc_phan.SelectedValue));
        //    m_grc.DataSource = v_ds.Tables[0];
        //}
       
        #region Public Interface
        //public void display_for_insert()
        //{
        //    m_e_form_mode = DataEntryFormMode.InsertDataState;
        //    this.ShowDialog();
        //}
        //public void display_for_update(US_DM_HOC_PHAN_MON_HOC m_us)
        //{
        //    m_e_form_mode = DataEntryFormMode.UpdateDataState;
        //    m_us_dm_hoc_phan_mon_hoc = m_us;
        //    us_obj_2_form();
        //    this.ShowDialog();

        //}
        //public void display_for_view(US_DM_HOC_PHAN_MON_HOC m_us)
        //{
        //    m_us_dm_hoc_phan_mon_hoc = m_us;
        //    us_obj_2_form();
        //    m_cmd_save.Enabled = false;//Không cho click vào button save
        //    this.ShowDialog();
        //}
        #endregion
        #region Members
        DataEntryFormMode m_e_form_mode;
        US_DM_HOC_PHAN_MON_HOC m_us_dm_hoc_phan_mon_hoc = new US_DM_HOC_PHAN_MON_HOC();
        #endregion
        #region Private Methods
        //private void form_2_us_obj()
        //{ 
        //    m_us_dm_hoc_phan_mon_hoc.strMA_MON_HOC=
        //}
        #endregion
        #region Events
        #endregion
        private void f110_danh_muc_nghiep_vu_mon_hoc_Load(object sender, System.EventArgs e)
        {
            load_data_2_grid();
        }
        private void load_data_2_grid()
        {//Hiển thị khi mới laod form

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_NGHIEP_VU_MON_HOC");
            m_grc.DataSource = v_ds.Tables[0];
        }
      

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = e.ListSourceRowIndex + 1;
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
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