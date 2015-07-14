using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS.CDBNames;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using DevExpress.XtraGrid.Views.Grid;
using BKI_QLTTQuocAnh.NghiepVu;

namespace BKI_QLTTQuocAnh
{
    public partial class F301_BC_NV_CHUA_HOAN_THANH_CHUONG_TRINH_HOC : Form
    {
        public F301_BC_NV_CHUA_HOAN_THANH_CHUONG_TRINH_HOC()
        {
            InitializeComponent();
        }

        private void F301_BC_NV_CHUA_HOAN_THANH_CHUONG_TRINH_HOC_Load(object sender, EventArgs e)
        {
            try
            {
                WinFormControls.load_data_to_combobox("DM_NGACH", "ID", "TEN_NGACH", "", WinFormControls.eTAT_CA.NO, m_cbo_ngach);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void load_data_2_grid()
        {
            US_DM_MON_HOC v_us = new US_DM_MON_HOC();//Khai báo US
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetTheoMonHoc(v_ds, CIPConvert.ToDecimal(m_cbo_mon_hoc.SelectedValue));
            m_grc.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_tao_lop_Click(object sender, EventArgs e)
        {
            try
            {
                F301_Tao_lop v_f = new F301_Tao_lop();
                decimal v_so_luong_hoc_vien = v_f.Display(m_grv.SelectedRowsCount, CIPConvert.ToDecimal(m_cbo_mon_hoc.SelectedValue));
                if (v_f.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    List<decimal> v_lst_id_lop  = taoLopHoc(v_so_luong_hoc_vien);
                    assignHV(v_lst_id_lop);
                    MessageBox.Show("Đã assign học viên vào các lớp học");
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }            
        }

        decimal m_so_luong_hoc_vien;

        private List<decimal> taoLopHoc(decimal v_so_luong_hoc_vien)
        {
            m_so_luong_hoc_vien = v_so_luong_hoc_vien;
            decimal v_dc_so_hoc_vien = m_grv.SelectedRowsCount;
            decimal v_dc_id_mon_hoc = CIPConvert.ToDecimal(m_cbo_mon_hoc.SelectedValue);
            List<decimal> v_lst_id_lop = new List<decimal>();
            var v_mon_hoc = new US_DM_MON_HOC(v_dc_id_mon_hoc);
            while (v_dc_so_hoc_vien > 0)
            {
                US_GD_LOP_HOC v_us = new US_GD_LOP_HOC();
                v_us.dcID_MON_HOC = v_dc_id_mon_hoc;
                v_us.dcSO_LUONG = v_so_luong_hoc_vien;
                v_us.strDA_XOA = "N";
                v_us.strMA_LOP_HOC = "FAKE-" + v_mon_hoc.strMA_MON_HOC + "-" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + new Random().Next(10, 99).ToString();
                v_us.strNGUOI_LAP = "admin";
                v_us.IsNGUOI_SUANull();
                v_us.Insert();
                v_lst_id_lop.Add(v_us.dcID);
                v_dc_so_hoc_vien -= CIPConvert.ToDecimal(v_so_luong_hoc_vien);
            }
            MessageBox.Show("Tạo thành công " + v_lst_id_lop.Count() + " lớp môn cho môn " + v_mon_hoc.strTEN_MON_HOC);
            return v_lst_id_lop;
        }

        private void assignHV(List<decimal> ip_lst_id_lop)
        {
            decimal v_id_lop = ip_lst_id_lop[0];
            for (int i = 0; i < m_grv.SelectedRowsCount; i++)
            {
                if (m_grv.GetSelectedRows()[i] >= 0){
                    US_GD_DIEM v_us = new US_GD_DIEM();
                    var v_data_row = m_grv.GetDataRow(m_grv.GetSelectedRows()[i]);
                    v_us.dcID_LOP_HOC = ip_lst_id_lop[(int)(i / m_so_luong_hoc_vien)];
                    v_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(v_data_row[0].ToString());
                    v_us.strQUA_MON = "N";
                    v_us.strHOC_XONG_YN = "N";
                    v_us.strDA_XOA = "N";
                    updateNhanVienMonHoc(v_us.dcID_LOP_HOC, v_us.dcID_NHAN_VIEN);
                    v_us.Insert();
                }                
            }
        }

        private void updateNhanVienMonHoc(decimal ip_dc_id_lop_hoc, decimal ip_dc_id_nhan_vien)
        {
            US_GD_LOP_HOC v_us_gd_lop_hoc = new US_GD_LOP_HOC();
            DS_GD_LOP_HOC v_ds_gd_lop_hoc = new DS_GD_LOP_HOC();
            v_ds_gd_lop_hoc.EnforceConstraints = false;
            v_us_gd_lop_hoc.FillDataset(v_ds_gd_lop_hoc, " where id_mon_hoc = " + m_cbo_mon_hoc.SelectedValue);
            for (int i = 0; i < v_ds_gd_lop_hoc.Tables[0].Rows.Count; i++)
            {
                US_GD_DIEM v_us = new US_GD_DIEM();
                DS_GD_DIEM v_ds = new DS_GD_DIEM();
                DataRow v_dr = v_ds_gd_lop_hoc.Tables[0].Rows[i];
                v_us.FillDataset(v_ds, " where id_nhan_vien = " + ip_dc_id_nhan_vien.ToString() + " and id_lop_hoc = " + v_dr[GD_LOP_HOC.ID]);
                for (int j = 0; j < v_ds.Tables[0].Rows.Count; j++)
                {
                    DataRow v_dr_diem = v_ds.Tables[0].Rows[i];
                    v_us = new US_GD_DIEM(CIPConvert.ToDecimal(v_dr[GD_DIEM.ID].ToString()));
                    v_us.strDA_XOA = "Y";
                    v_us.Update();
                }
            }
        }

        private void m_cmd_search_Click(object sender, EventArgs e)
        {
            load_data_2_grid();
        }

        private void m_cbo_ngach_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data_2_cbo_phong();
        }

        private void load_data_2_cbo_phong()
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_phong, "ID", "TEN_DON_VI", WinFormControls.eTAT_CA.NO, "SELECT DDV.ID, DDV.TEN_DON_VI FROM DM_NGACH_PHONG AS dnp, DM_DON_VI AS ddv WHERE DDV.ID = DNP.ID_PHONG AND dnp.ID_NGACH = " + m_cbo_ngach.SelectedValue.ToString());
        }

        private void m_cbo_phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data_2_cbo_hoc_phan();
        }

        private void load_data_2_cbo_hoc_phan()
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_hoc_phan, "ID", "TEN_HOC_PHAN", WinFormControls.eTAT_CA.NO, "SELECT DHP.ID, dhp.TEN_HOC_PHAN FROM DM_PHONG_HOC_PHAN AS dphp, DM_HOC_PHAN AS dhp WHERE dphp.ID_HOC_PHAN = dhp.ID AND dphp.ID_PHONG = " + m_cbo_phong.SelectedValue.ToString());
        }

        private void m_cbo_hoc_phan_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data_2_cbo_mon_hoc();
        }

        private void load_data_2_cbo_mon_hoc()
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_mon_hoc, "ID", "TEN_MON_HOC", WinFormControls.eTAT_CA.NO, "SELECT DMH.ID, dmh.TEN_MON_HOC FROM DM_HOC_PHAN_MON_HOC AS dhpmh, DM_MON_HOC AS dmh WHERE dhpmh.ID_MON_HOC = dmh.ID AND ID_HOC_PHAN = " + m_cbo_hoc_phan.SelectedValue.ToString());
        }
    }
}
