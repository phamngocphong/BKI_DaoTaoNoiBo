using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using IP.Core.IPCommon;
using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;
using IP.Core.IPUserService;
using IP.Core.IPData;
using IP.Core.IPSystemAdmin;
using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.HeThong;

namespace BKI_QLTTQuocAnh.HeThong
{
    public partial class f995_ht_phan_quyen_cho_nhom : Form
    {
        #region public Interface
        public f995_ht_phan_quyen_cho_nhom()
        {
            InitializeComponent();
            format_control();
        }
        public void display() {
            this.ShowDialog();
        }
        #endregion

        #region Member
        BKI_QLTTQuocAnh.US.US_HT_USER_GROUP m_us_ht_user_group = new US_HT_USER_GROUP();
        BKI_QLTTQuocAnh.DS.DS_HT_USER_GROUP m_ds_ht_user_group = new DS_HT_USER_GROUP();
        Boolean m_bool_load_data_complete = false;
        int m_dc_index_in_left = 0;
        int m_dc_index_in_right = 0;
        decimal m_dc_id_user_group;
        #endregion

        #region Private Method
        private void load_data_2_cbo() {
            m_us_ht_user_group.FillDataset(m_ds_ht_user_group);
            m_cbo_user_group.DataSource = m_ds_ht_user_group.Tables[0];
            m_cbo_user_group.DisplayMember = HT_USER_GROUP.USER_GROUP_NAME;
            m_cbo_user_group.ValueMember = HT_USER_GROUP.ID;
            m_bool_load_data_complete = true;
        }

        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            m_cmd_exit.Visible = false;
        }

        private void load_data_2_rtxt_quyen_chua_cap(decimal ip_dc_id)
        {
            US_HT_PHAN_QUYEN_HE_THONG v_us = new US_HT_PHAN_QUYEN_HE_THONG();
            DS_HT_PHAN_QUYEN_HE_THONG v_ds = new DS_HT_PHAN_QUYEN_HE_THONG();
            v_us.FillDatasetQuyenChuaCapByIdUserGroup(v_ds, ip_dc_id);
            int v_row_count = v_ds.Tables[0].Rows.Count;
            m_lbox_quyen_chua_cap.Items.Clear();
            for (int i = 0; i < v_row_count; i++)
            {
                DataRow v_dr = v_ds.Tables[0].Rows[i];
                m_lbox_quyen_chua_cap.Items.Add(v_dr[HT_PHAN_QUYEN_HE_THONG.MA_PHAN_QUYEN]);
            }
        }

        private void load_data_2_rtxt_quyen_da_cap(decimal ip_dc_id)
        {
            US_HT_PHAN_QUYEN_HE_THONG v_us = new US_HT_PHAN_QUYEN_HE_THONG();
            DS_HT_PHAN_QUYEN_HE_THONG v_ds = new DS_HT_PHAN_QUYEN_HE_THONG();
            v_us.FillDatasetQuyenDaCapByIdUserGroup(v_ds, ip_dc_id);
            int v_row_count = v_ds.Tables[0].Rows.Count;
            m_lbox_quyen_da_cap.Items.Clear();
            for (int i = 0; i < v_row_count; i++)
            {
                DataRow v_dr = v_ds.Tables[0].Rows[i];
                m_lbox_quyen_da_cap.Items.Add(v_dr[HT_PHAN_QUYEN_HE_THONG.MA_PHAN_QUYEN]);
            }
        }
        #endregion
        
        #region Event
        private void f995_ht_phan_quyen_cho_nhom_Load(object sender, EventArgs e)
        {
            format_control();
            load_data_2_cbo();
            m_us_ht_user_group.FillDataset(m_ds_ht_user_group);
            DataRow v_dr = m_ds_ht_user_group.Tables[0].Rows[0];
            load_data_2_rtxt_quyen_da_cap(CIPConvert.ToDecimal(v_dr[HT_USER_GROUP.ID]));
            load_data_2_rtxt_quyen_chua_cap(CIPConvert.ToDecimal(v_dr[HT_USER_GROUP.ID]));
            m_dc_index_in_left = 0;
            m_dc_index_in_right = 0;
        }

        private void m_lbox_quyen_chua_cap_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_dc_index_in_left = m_lbox_quyen_chua_cap.SelectedIndex;
        }

        private void m_lbox_quyen_da_cap_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_dc_index_in_right = m_lbox_quyen_da_cap.SelectedIndex;
        }

        private void m_cmd_left_2_right_Click(object sender, EventArgs e)
        {
            try
            {
                m_lbox_quyen_chua_cap.SelectedIndex = m_dc_index_in_left;
                m_lbox_quyen_da_cap.Items.Add(m_lbox_quyen_chua_cap.SelectedItem);
                m_lbox_quyen_chua_cap.Items.RemoveAt(m_lbox_quyen_chua_cap.SelectedIndex);
                m_dc_index_in_left = 0;
            }
            catch (System.Exception v_e)
            {
                BaseMessages.MsgBox_Error("Đã cấp hết quyền!");
            }          
        }

        private void m_cmd_right_2_left_Click(object sender, EventArgs e)
        {
            try
            {
                m_lbox_quyen_da_cap.SelectedIndex = m_dc_index_in_right;
                m_lbox_quyen_chua_cap.Items.Add(m_lbox_quyen_da_cap.SelectedItem);
                m_lbox_quyen_da_cap.Items.RemoveAt(m_lbox_quyen_da_cap.SelectedIndex);
                m_dc_index_in_right = 0;
            }
            catch (System.Exception v_e)
            {
                BaseMessages.MsgBox_Error("Không còn quyền đã cấp để chuyển!");
            }      
        }

        private void m_cmd_left_2_right_all_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < m_lbox_quyen_chua_cap.Items.Count; i++)
            {
                m_lbox_quyen_chua_cap.SelectedIndex = i;
                m_lbox_quyen_da_cap.Items.Add(m_lbox_quyen_chua_cap.SelectedItem);
            }
            m_lbox_quyen_chua_cap.Items.Clear();
        }

        private void m_cmd_right_2_left_all_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < m_lbox_quyen_da_cap.Items.Count; i++)
            {
                m_lbox_quyen_da_cap.SelectedIndex = i;
                m_lbox_quyen_chua_cap.Items.Add(m_lbox_quyen_da_cap.SelectedItem);
            }
            m_lbox_quyen_da_cap.Items.Clear();
        }

        private void m_cbo_user_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_bool_load_data_complete)
            {
                m_dc_id_user_group = CIPConvert.ToDecimal(m_cbo_user_group.SelectedValue);
                decimal v_dc_id = CIPConvert.ToDecimal(m_cbo_user_group.SelectedValue);
                load_data_2_rtxt_quyen_da_cap(v_dc_id);
                load_data_2_rtxt_quyen_chua_cap(v_dc_id);
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                US_HT_PHAN_QUYEN_CHO_NHOM v_us_ht_phan_quyen_cho_nhom;
                DS_HT_PHAN_QUYEN_CHO_NHOM v_ds_ht_phan_quyen_cho_nhom = new DS_HT_PHAN_QUYEN_CHO_NHOM();

                CCollection v_coll_new = new CCollection(m_lbox_quyen_da_cap.Items.Count);
                for (int i = 0; i < m_lbox_quyen_da_cap.Items.Count; i++)
                {
                    v_coll_new.insert(m_lbox_quyen_da_cap.Items[i].ToString());
                }

                US_HT_PHAN_QUYEN_HE_THONG v_us_pqht = new US_HT_PHAN_QUYEN_HE_THONG();
                DS_HT_PHAN_QUYEN_HE_THONG v_ds_pqht = new DS_HT_PHAN_QUYEN_HE_THONG();
                v_us_pqht.FillDatasetQuyenDaCapByIdUserGroup(v_ds_pqht, m_dc_id_user_group);
                CCollection v_coll_old = new CCollection(v_ds_pqht.Tables[0].Rows.Count);
                for (int i = 0; i < v_ds_pqht.Tables[0].Rows.Count; i++)
                {
                    DataRow v_dr = v_ds_pqht.Tables[0].Rows[i];
                    v_coll_old.insert(v_dr[HT_PHAN_QUYEN_HE_THONG.MA_PHAN_QUYEN].ToString());
                }

                CCollection v_coll_quyen_insert = new CCollection(v_coll_new.countInANotInB(v_coll_old));
                v_coll_quyen_insert = v_coll_new.InANotInB(v_coll_old);
                for (int i = 0; i < v_coll_quyen_insert.getIndex(); i++)
                {
                    v_us_ht_phan_quyen_cho_nhom = new US_HT_PHAN_QUYEN_CHO_NHOM();
                    //v_us_ht_phan_quyen_cho_nhom.dcID_USER_GROUP = 1;
                    v_us_ht_phan_quyen_cho_nhom.dcID_USER_GROUP = m_dc_id_user_group;
                    v_ds_pqht.Clear();
                    v_us_pqht.FillDatasetByMaPhanQuyen(v_ds_pqht, v_coll_quyen_insert.s[i]);
                    v_us_ht_phan_quyen_cho_nhom.dcID_PHAN_QUYEN_HE_THONG = CIPConvert.ToDecimal(v_ds_pqht.Tables[0].Rows[0][HT_PHAN_QUYEN_HE_THONG.ID]);
                    v_us_ht_phan_quyen_cho_nhom.Insert();
                }

                CCollection v_coll_quyen_delete = new CCollection(v_coll_new.countNotInAInB(v_coll_old));
                v_coll_quyen_delete = v_coll_new.NotInAInB(v_coll_old);
                for (int i = 0; i < v_coll_quyen_delete.getIndex(); i++)
                {
                    v_ds_ht_phan_quyen_cho_nhom.Clear();
                    v_us_ht_phan_quyen_cho_nhom = new US_HT_PHAN_QUYEN_CHO_NHOM();
                    v_us_ht_phan_quyen_cho_nhom.FillDatasetByIdUserGroupAndMaPhanQuyen(v_ds_ht_phan_quyen_cho_nhom, m_dc_id_user_group, v_coll_quyen_delete.s[i]);
                    v_us_ht_phan_quyen_cho_nhom.dcID = CIPConvert.ToDecimal(v_ds_ht_phan_quyen_cho_nhom.Tables[0].Rows[0][HT_PHAN_QUYEN_CHO_NHOM.ID]);
                    v_us_ht_phan_quyen_cho_nhom.Delete();
                }
                BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhật");
                //this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }
        #endregion

        
    }
}
