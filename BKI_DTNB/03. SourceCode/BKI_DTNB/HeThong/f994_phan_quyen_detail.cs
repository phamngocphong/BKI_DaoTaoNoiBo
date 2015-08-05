using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BKI_DTNB.DS;
using BKI_DTNB.DS.CDBNames;
using BKI_DTNB.US;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
//using BKI_HRM.US;
//using IP.Core.IPUserService;

namespace BKI_DTNB.HeThong
{
    public partial class f994_phan_quyen_detail : Form
    {
        public void display() {
            this.ShowDialog();
        }
        public void load_data_2_txt_form(US_HT_FORM ip_us){
            m_txt_form.Text = ip_us.strFORM_NAME;
        }

        public f994_phan_quyen_detail()
        {
            InitializeComponent();
            format_control();
        }

        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void f994_phan_quyen_detail_Load(object sender, EventArgs e)
        {
            load_data_2_cbo_nhom_quyen();
            load_data_2_cbo_chuc_nang();
        }

        private void load_data_2_cbo_chuc_nang()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 14);
            m_cbo_chuc_nang.DataSource = v_ds.Tables[0];
            m_cbo_chuc_nang.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_chuc_nang.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
        }

        private void load_data_2_cbo_nhom_quyen()
        {
            US_HT_PHAN_QUYEN_HE_THONG v_us = new US_HT_PHAN_QUYEN_HE_THONG();
            DS_HT_PHAN_QUYEN_HE_THONG v_ds = new DS_HT_PHAN_QUYEN_HE_THONG();
            v_us.FillDataset(v_ds);
            m_cbo_nhom_quyen.DataSource = v_ds.Tables[0];
            m_cbo_nhom_quyen.ValueMember = HT_PHAN_QUYEN_HE_THONG.ID;
            m_cbo_nhom_quyen.DisplayMember = HT_PHAN_QUYEN_HE_THONG.MA_PHAN_QUYEN;
        }

        private void m_cmd_chon_form_Click(object sender, EventArgs e)
        {
            f990_ht_form v_frm = new f990_ht_form();
            v_frm.show_2_choose(this);
        }

        
    }
}
