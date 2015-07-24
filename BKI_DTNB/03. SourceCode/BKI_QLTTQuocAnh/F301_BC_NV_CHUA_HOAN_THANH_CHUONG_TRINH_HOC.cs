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
using DevExpress.Utils.Menu;
using BKI_QLTTQuocAnh.DanhMuc;
using BKI_QLTTQuocAnh.BaoCao;
using DevExpress.XtraReports.UI;
using System.Collections;

namespace BKI_QLTTQuocAnh
{
    public partial class F301_BC_NV_CHUA_HOAN_THANH_CHUONG_TRINH_HOC : Form
    {
        decimal m_dc_id_lop_mon = -1;
        decimal m_dc_id_mon_hoc = -1;
        DataSet m_ds = new DataSet();
        public F301_BC_NV_CHUA_HOAN_THANH_CHUONG_TRINH_HOC()
        {
            InitializeComponent();
        }

        private void F301_BC_NV_CHUA_HOAN_THANH_CHUONG_TRINH_HOC_Load(object sender, EventArgs e)
        {
            try
            {
                WinFormControls.load_data_to_combobox("CM_DM_TU_DIEN", "ID", "TEN", " WHERE ID_LOAI_TU_DIEN = 21", WinFormControls.eTAT_CA.YES, m_cbo_dia_phuong);
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
            //DataSet v_ds = new DataSet();
            m_ds.Clear();
            DataTable v_dt = new DataTable();
            m_ds.Tables.Add(v_dt);
            v_us.FillDatasetTheoMonHoc(m_ds, CIPConvert.ToDecimal(m_cbo_mon_hoc.SelectedValue));
            m_grc.DataSource = m_ds.Tables[0];
        }

        private void m_cmd_tao_lop_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_dc_id_version_mon = -1;
                decimal v_dc_diem_qua_mon = -1;
                F301_Tao_lop v_f = new F301_Tao_lop();
                decimal v_so_luong_hoc_vien = v_f.Display(GetSelectedRows(m_grv).Count, CIPConvert.ToDecimal(m_cbo_mon_hoc.SelectedValue), ref v_dc_id_version_mon, ref v_dc_diem_qua_mon);
                if (v_f.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    List<decimal> v_lst_id_lop = taoLopHoc(v_so_luong_hoc_vien, v_dc_id_version_mon, v_dc_diem_qua_mon);
                    assignHV(v_lst_id_lop, v_so_luong_hoc_vien);
                    MessageBox.Show("Đã assign học viên vào các lớp học");
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private List<int> GetSelectedRows(GridView view)
        {
            List<int> v_lst = new List<int>();
            int[] rows = m_grv.GetSelectedRows();
            for (int i = 0; i < rows.Length; i++)
                if (!m_grv.IsGroupRow(rows[i]))
                {
                    v_lst.Add(rows[i]);
                }
            return v_lst;
        }

        decimal m_so_luong_hoc_vien;

        private List<decimal> taoLopHoc(decimal v_so_luong_hoc_vien, decimal ip_dc_id_version_mon, decimal ip_dc_diem_qua_mon)
        {
            m_so_luong_hoc_vien = v_so_luong_hoc_vien;
            decimal v_dc_so_hoc_vien = GetSelectedRows(m_grv).Count;
            decimal v_dc_id_mon_hoc = CIPConvert.ToDecimal(m_cbo_mon_hoc.SelectedValue);
            List<decimal> v_lst_id_lop = new List<decimal>();
            var v_mon_hoc = new US_DM_MON_HOC(v_dc_id_mon_hoc);
            while (v_dc_so_hoc_vien > 0)
            {
                US_GD_LOP_MON v_us = new US_GD_LOP_MON();
                v_us.dcID_VERSION_MON_HOC = ip_dc_id_version_mon;
                v_us.dcDIEM_QUA_MON = ip_dc_diem_qua_mon;
                v_us.dcSO_LUONG = v_so_luong_hoc_vien;
                v_us.strDA_XOA = "N";
                v_us.strMA_LOP_HOC = "FAKE-" + v_mon_hoc.strMA_MON_HOC + DateTime.Now.Date.ToShortDateString() + new Random().Next(10, 99);
                v_us.strNGUOI_LAP = "admin";
                v_us.IsNGUOI_SUANull();
                v_us.Insert();
                v_lst_id_lop.Add(v_us.dcID);
                v_dc_so_hoc_vien -= CIPConvert.ToDecimal(v_so_luong_hoc_vien);
            }
            MessageBox.Show("Tạo thành công " + v_lst_id_lop.Count() + " lớp môn cho môn " + v_mon_hoc.strTEN_MON_HOC);
            return v_lst_id_lop;
        }

        private void assignHV(List<decimal> ip_lst_id_lop, decimal ip_so_luong_hv)
        {
            decimal v_id_lop = ip_lst_id_lop[0];
            var v_lst = GetSelectedRows(m_grv);
            for (int i = 0; i < v_lst.Count; i++)
            {
                US_GD_DIEM v_us = new US_GD_DIEM();
                var v_data_row = m_grv.GetDataRow(v_lst[i]);

                v_us.dcID_LOP_MON = ip_lst_id_lop[(int)(i / ip_so_luong_hv)];
                v_us.dcID_NHAN_VIEN = CIPConvert.ToDecimal(v_data_row[0].ToString());
                v_us.strQUA_MON = "N";
                v_us.strHOC_XONG_YN = "N";
                v_us.strDA_XOA = "N";
                v_us.datNGAY_LAP = DateTime.Now.Date;
                v_us.datNGAY_SUA = DateTime.Now.Date;
                updateNhanVienMonHoc(v_us.dcID_NHAN_VIEN);
                v_us.Insert();
            }
        }

        private void updateNhanVienMonHoc(decimal ip_dc_id_nhan_vien)
        {
            US_GD_LOP_MON v_us_gd_LOP_MON = new US_GD_LOP_MON();
            DS_GD_LOP_MON v_ds_gd_LOP_MON = new DS_GD_LOP_MON();
            v_ds_gd_LOP_MON.EnforceConstraints = false;
            v_us_gd_LOP_MON.FillDataset(v_ds_gd_LOP_MON, " WHERE ID_VERSION_MON_HOC IN (SELECT ID FROM DM_VERSION_MON_HOC WHERE ID_MON_HOC = " + m_cbo_mon_hoc.SelectedValue + ")");
            for (int i = 0; i < v_ds_gd_LOP_MON.Tables[0].Rows.Count; i++)
            {
                US_GD_DIEM v_us = new US_GD_DIEM();
                DS_GD_DIEM v_ds = new DS_GD_DIEM();
                DataRow v_dr = v_ds_gd_LOP_MON.Tables[0].Rows[i];
                v_us.FillDataset(v_ds, " where id_nhan_vien = " + ip_dc_id_nhan_vien.ToString() + " and id_lop_mon = " + v_dr[GD_LOP_MON.ID]);
                for (int j = 0; j < v_ds.Tables[0].Rows.Count; j++)
                {
                    DataRow v_dr_diem = v_ds.Tables[0].Rows[j];
                    decimal v_id_gd_diem = CIPConvert.ToDecimal(v_dr_diem[GD_DIEM.ID].ToString());
                    v_us = new US_GD_DIEM(v_id_gd_diem);
                    v_us.strDA_XOA = "Y";
                    v_us.Update();
                }
            }
        }

        private void m_cmd_search_Click(object sender, EventArgs e)//Click vào nút tìm kiếm
        {
            load_data_2_grid();
        }

        private void m_cbo_ngach_SelectedIndexChanged(object sender, EventArgs e)//Combobox ngạch thay đổi giá trị
        {
            load_data_2_cbo_nghiep_vu();
        }

        private void load_data_2_cbo_nghiep_vu()
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_nghiep_vu, "ID", "TEN_NGHIEP_VU", WinFormControls.eTAT_CA.YES, "SELECT DNV.ID, dnv.TEN_NGHIEP_VU FROM DM_NGHIEP_VU AS dnv, DM_NGACH_NGHIEP_VU AS dncnv WHERE dncnv.ID_NGHIEP_VU = dnv.ID AND dncnv.ID_NGACH = " + m_cbo_ngach.SelectedValue + " OR " + m_cbo_ngach.SelectedValue + " = -1");
        }

        private void load_data_2_cbo_mon_hoc()
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_mon_hoc, "ID", "MON_HOC", WinFormControls.eTAT_CA.NO, "SELECT DISTINCT dmh.ID, dmh.MA_MON_HOC + ' - '+ dmh.TEN_MON_HOC AS MON_HOC FROM DM_MON_HOC AS dmh, DM_NGHIEP_VU_MON_HOC AS dnvmh WHERE dmh.ID =dnvmh.ID_MON_HOC AND (dnvmh.ID_NGHIEP_VU = " + m_cbo_nghiep_vu.SelectedValue + " OR " + m_cbo_nghiep_vu.SelectedValue + " = -1)");
        }

        private void m_cbo_dia_phuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data_2_cbo_ngach();
        }

        private void load_data_2_cbo_ngach()
        {
            WinFormControls.load_data_to_combobox("DM_NGACH", "ID", "MA_NGACH", " WHERE (ID_DIA_PHUONG = " + m_cbo_dia_phuong.SelectedValue + " OR " + m_cbo_dia_phuong.SelectedValue + "=-1)", WinFormControls.eTAT_CA.YES, m_cbo_ngach);
        }

        private void m_cbo_nghiep_vu_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data_2_cbo_mon_hoc();
        }

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                //saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                //saveFileDialog1.RestoreDirectory = true;
                //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                //{
                //    m_grv.ExportToXls(saveFileDialog1.FileName);
                //    MessageBox.Show("Lưu báo cáo thành công");
                //}
                ArrayList v_arr_list = new ArrayList();
                v_arr_list.Add(new iParameter("iP_tieu_de_bao_cao","Báo cáo nhân viên chưa học môn " + m_cbo_mon_hoc.Text));
                v_arr_list.Add(new iParameter("iP_trung_tam","TỔ HỢP GIÁO DỤC TOPICA"));
                v_arr_list.Add(new iParameter("iP_date_time", "Hà Nội, ngày " + DateTime.Now.Date.ToShortDateString()));
                BKI_QLTTQuocAnh.BaoCao.RPT_XtraReport v_xr = new BKI_QLTTQuocAnh.BaoCao.RPT_XtraReport(m_ds, m_grv,v_arr_list, System.Drawing.Printing.PaperKind.A4, true);
                ReportPrintTool v_xrpt = new ReportPrintTool(v_xr);
                v_xrpt.ShowPreview();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);           
            }
        }

        private void m_grv_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = e.ListSourceRowIndex + 1;
        }

        private void m_grv_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
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

        public void display(decimal ip_dc_lop_mon, decimal ip_dc_mon_hoc)
        {
            m_dc_id_lop_mon = ip_dc_lop_mon;
            m_dc_id_mon_hoc = ip_dc_mon_hoc;
            this.Show();
            this.m_cbo_mon_hoc.SelectedValue = ip_dc_mon_hoc;
            m_cbo_mon_hoc.Enabled = false;
            load_data_2_grid();
        }

        private void m_cmd_assign_Click(object sender, EventArgs e)
        {
            try
            {
                F301_Assign v_f = new F301_Assign();
                if (m_dc_id_lop_mon == -1)
                {
                    m_dc_id_mon_hoc = CIPConvert.ToDecimal(m_cbo_mon_hoc.SelectedValue.ToString());
                    v_f.Display(m_dc_id_mon_hoc, ref m_dc_id_lop_mon);
                }
                else
                {
                    v_f.Display(m_dc_id_lop_mon, m_dc_id_mon_hoc);
                }
                if (v_f.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    List<decimal> v_lst_id_lop = new List<decimal>();
                    v_lst_id_lop.Add(m_dc_id_lop_mon);
                    assignHV(v_lst_id_lop, GetSelectedRows(m_grv).Count);
                    MessageBox.Show("Assign thành công học viên vào lớp môn.");
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_grv_GroupRowCollapsing(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            //e.Allow = false;
        }

        private void m_grv_EndGrouping(object sender, EventArgs e)
        {
            //m_grv.ExpandAllGroups();
        }
    }
}
