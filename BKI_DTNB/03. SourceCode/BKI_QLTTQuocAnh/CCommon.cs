using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;
using BKI_QLTTQuocAnh.US;

namespace BKI_QLTTQuocAnh
{
    class CCommon
    {
        /// <summary>
        /// Trả về danh sách các nhân viên được quyền chọn theo user người sử dụng
        /// </summary>
        /// <param name="ip_id_user"></param>
       


        public static void load_data_2_cbo_trang_thai_lop_mon(
            decimal ip_dc_id_trang_thai_lop_mon
            , System.Windows.Forms.ComboBox op_cbo_trang_thai_lop_mon
            )
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "where id_loai_tu_dien = " + ip_dc_id_trang_thai_lop_mon);


            //DS_V_RPT_210_DM_LOP_MON v_ds_v_rpt_210_dm_lop_mon = new DS_V_RPT_210_DM_LOP_MON();
            //US_V_RPT_210_DM_LOP_MON v_us_v_rpt_210_dm_lop_mon = new US_V_RPT_210_DM_LOP_MON();

            //v_us_v_rpt_210_dm_lop_mon.FillDataset(v_ds_v_rpt_210_dm_lop_mon, "Where TRANG_THAI_LOP_MON = " + ip_dc_id_trang_thai_lop_mon.ToString());
            op_cbo_trang_thai_lop_mon.DataSource = v_ds.CM_DM_TU_DIEN;
            op_cbo_trang_thai_lop_mon.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
            op_cbo_trang_thai_lop_mon.ValueMember = CM_DM_TU_DIEN.ID;
            op_cbo_trang_thai_lop_mon.SelectedIndex = 0;
           
        }

        public static void load_data_2_cbo_trang_thai_hoc_sinh(
            decimal ip_dc_id_trang_thai_hoc_sinh
            , System.Windows.Forms.ComboBox op_cbo_trang_thai_hoc_sinh
            )
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "where id_loai_tu_dien = " + ip_dc_id_trang_thai_hoc_sinh);

            //DataRow v_dr = v_ds.CM_DM_TU_DIEN.NewRow();
            //v_dr[CM_DM_TU_DIEN.ID] = -1;
            //v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "All";
            //v_dr[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = 10;
            //v_dr[CM_DM_TU_DIEN.TEN_NGAN] = "--Tất cả---";
            //v_dr[CM_DM_TU_DIEN.TEN] = "--Tất cả---";
            //v_ds.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);

            //DS_V_RPT_210_DM_LOP_MON v_ds_v_rpt_210_dm_lop_mon = new DS_V_RPT_210_DM_LOP_MON();
            //US_V_RPT_210_DM_LOP_MON v_us_v_rpt_210_dm_lop_mon = new US_V_RPT_210_DM_LOP_MON();

            //v_us_v_rpt_210_dm_lop_mon.FillDataset(v_ds_v_rpt_210_dm_lop_mon, "Where TRANG_THAI_LOP_MON = " + ip_dc_id_trang_thai_lop_mon.ToString());
            op_cbo_trang_thai_hoc_sinh.DataSource = v_ds.CM_DM_TU_DIEN;
            op_cbo_trang_thai_hoc_sinh.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
            op_cbo_trang_thai_hoc_sinh.ValueMember = CM_DM_TU_DIEN.ID;
            op_cbo_trang_thai_hoc_sinh.SelectedIndex = 0;

        }

        public static void load_data_2_cbo_loai_phieu_thu(
            decimal ip_dc_id_loai_tu_dien
            , System.Windows.Forms.ComboBox op_cbo_tu_dien)
        {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "where id_loai_tu_dien = " + ip_dc_id_loai_tu_dien);

            DataRow v_dr = v_ds.CM_DM_TU_DIEN.NewRow();
            v_dr[CM_DM_TU_DIEN.ID] = -1;
            v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "TAT_CA";
            v_dr[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = -1;
            v_dr[CM_DM_TU_DIEN.TEN_NGAN] = "--Tất cả--";
            v_dr[CM_DM_TU_DIEN.TEN] = "--Tất cả--";
            v_dr[CM_DM_TU_DIEN.GHI_CHU] = "";

            v_ds.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);

            op_cbo_tu_dien.DataSource = v_ds.CM_DM_TU_DIEN;
            op_cbo_tu_dien.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
            op_cbo_tu_dien.ValueMember = CM_DM_TU_DIEN.ID;

            op_cbo_tu_dien.SelectedIndex = 0;
        }

        public static void load_data_2_cbo_trang_thai_hoc_sinh(
            System.Windows.Forms.ComboBox op_cbo_trang_thai_hoc_sinh
            ) {
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            v_us.FillDataset(v_ds, "where id_loai_tu_dien = " + CONST_LOAI_TU_DIEN.TRANG_THAI_HOC_SINH);

            op_cbo_trang_thai_hoc_sinh.DataSource = v_ds.CM_DM_TU_DIEN;
            op_cbo_trang_thai_hoc_sinh.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
            op_cbo_trang_thai_hoc_sinh.ValueMember = CM_DM_TU_DIEN.ID;
            op_cbo_trang_thai_hoc_sinh.SelectedIndex = 0;

        }
    }
}
