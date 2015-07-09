using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;

using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS.CDBNames;


namespace BKI_QLTTQuocAnh
{
    public class WinFormControls
    {
        public WinFormControls()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public enum eTAT_CA
        {
            YES,
            NO
        }
        public enum eLOAI_TU_DIEN
        {
            TRANG_THAI_CHUC_VU,
            LOAI_HOP_DONG,
            LOAI_DON_VI,
            CAP_DON_VI,
            CO_CHE,
            LOAI_DU_AN,
            TRANG_THAI_DU_AN,
            LOAI_QUYET_DINH,
            TRANG_THAI_LAO_DONG,
            DM_CA_HOC
        }
        public static void load_data_to_cbo_tu_dien(
             eLOAI_TU_DIEN ip_e
            , eTAT_CA ip_e_tat_ca
            , ComboBox ip_obj_cbo_trang_thai)
        {

            IP.Core.IPUserService.US_CM_DM_TU_DIEN v_us_dm_tu_dien = new IP.Core.IPUserService.US_CM_DM_TU_DIEN();
            IP.Core.IPData.DS_CM_DM_TU_DIEN v_ds_dm_tu_dien = new IP.Core.IPData.DS_CM_DM_TU_DIEN();
            string v_str_loai_tu_dien = "";
            switch (ip_e)
            {
                case eLOAI_TU_DIEN.TRANG_THAI_CHUC_VU:
                    v_str_loai_tu_dien = MA_LOAI_TU_DIEN.TRANG_THAI_CHUC_VU;
                    break;
                case eLOAI_TU_DIEN.LOAI_HOP_DONG:
                    v_str_loai_tu_dien = MA_LOAI_TU_DIEN.LOAI_HOP_DONG;
                    break;
                case eLOAI_TU_DIEN.LOAI_DON_VI:
                    v_str_loai_tu_dien = MA_LOAI_TU_DIEN.LOAI_DON_VI;
                    break;
                case eLOAI_TU_DIEN.CAP_DON_VI:
                    v_str_loai_tu_dien = MA_LOAI_TU_DIEN.CAP_DON_VI;
                    break;
                case eLOAI_TU_DIEN.LOAI_QUYET_DINH:
                    v_str_loai_tu_dien = MA_LOAI_TU_DIEN.LOAI_QUYET_DINH;
                    break;
                case eLOAI_TU_DIEN.TRANG_THAI_LAO_DONG:
                    v_str_loai_tu_dien = MA_LOAI_TU_DIEN.TRANG_THAI_LAO_DONG;
                    break;
                case eLOAI_TU_DIEN.DM_CA_HOC:
                    v_str_loai_tu_dien = MA_LOAI_TU_DIEN.DM_CA_HOC;
                    break;
            }
            v_us_dm_tu_dien.fill_tu_dien_cung_loai_ds(
                v_str_loai_tu_dien
                , CM_DM_TU_DIEN.GHI_CHU
                , v_ds_dm_tu_dien);

            ip_obj_cbo_trang_thai.DataSource = v_ds_dm_tu_dien.CM_DM_TU_DIEN;
            ip_obj_cbo_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN;
            ip_obj_cbo_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;

            if (ip_e_tat_ca == eTAT_CA.YES)
            {
                DataRow v_dr = v_ds_dm_tu_dien.CM_DM_TU_DIEN.NewRow();
                v_dr[CM_DM_TU_DIEN.ID] = -1;
                v_dr[CM_DM_TU_DIEN.TEN] = "------ Tất cả ------";
                v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "";
                v_dr[CM_DM_TU_DIEN.TEN_NGAN] = "";
                v_dr[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = 1;
                v_dr[CM_DM_TU_DIEN.GHI_CHU] = "";
                v_ds_dm_tu_dien.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);
                ip_obj_cbo_trang_thai.SelectedIndex = 0;
            }
        }
    }
}
