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
namespace BKI_QLTTQuocAnh.DanhMuc
{
    public partial class f110_danh_muc_hoc_phan_mon_hoc_de : DevExpress.XtraEditors.XtraForm
    {
        public f110_danh_muc_hoc_phan_mon_hoc_de()
        {
            InitializeComponent();
        }
        private void f110_danh_muc_hoc_phan_mon_hoc_de_LOAD(object sender, EventArgs e)
        {
            try
            {
                WinFormControls.load_data_to_combobox("DM_HOC_PHAN", "ID", "TEN_HOC_PHAN", "", WinFormControls.eTAT_CA.NO, m_cbo_ma_hoc_phan);
                load_data_to_grid();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void load_data_to_grid()
        {
            US_V_HOC_PHAN_MON_HOC v_us = new US_V_HOC_PHAN_MON_HOC();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetTheoHocPhan(v_ds, CIPConvert.ToDecimal(m_cbo_ma_hoc_phan.SelectedValue));
            m_grc.DataSource = v_ds.Tables[0];
        }
       
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
        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cbo_ma_hoc_phan_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data_2_cbo_ten_hoc_phan();
        }

        private void load_data_2_cbo_ten_hoc_phan()
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_ten_hoc_phan, "ID", "TEN_HOC_PHAN", WinFormControls.eTAT_CA.NO, "SELECT DDV.ID, DDV.TEN_HOC_PHAN FROM DM_HOC_PHAN_MON_HOC AS dnp, DM_HOC_PHAN AS ddv WHERE DDV.ID = DNP.ID_TEN_HOC_PHAN AND dnp.ID_MA_HOC_PHAN = " + m_cbo_ma_hoc_phan.SelectedValue.ToString());
        }

        private void m_cbo_ten_hoc_phan_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data_2_cbo_ma_mon_hoc();
        }

        private void load_data_2_cbo_ma_mon_hoc()
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_ma_mon_hoc, "ID", "TEN_MON_HOC", WinFormControls.eTAT_CA.NO, "SELECT DHP.ID, dhp.TEN_MON_HOC FROM DM_HOC_PHAN_MON_HOC AS dphp, DM_MON_HOC AS dhp WHERE dphp.ID_MA_MON_HOC = dhp.ID AND dphp.ID_TEN_HOC_PHAN = " + m_cbo_ten_hoc_phan.SelectedValue.ToString());
        }

        private void m_cbo_hoc_phan_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data_2_cbo_mon_hoc();
        }

        private void load_data_2_cbo_mon_hoc()
        {
     //       WinFormControls.load_data_to_combobox_with_query(m_cbo_ten_mon_hoc, "ID", "TEN_MON_HOC", WinFormControls.eTAT_CA.NO, "SELECT DMH.ID, dmh.TEN_MON_HOC FROM DM_HOC_PHAN_MON_HOC AS dhpmh, DM_MON_HOC AS dmh WHERE dhpmh.ID_MON_HOC = dmh.ID AND ID_HOC_PHAN = " + m_cbo_hoc_phan.SelectedValue.ToString());
        }   
    }
}