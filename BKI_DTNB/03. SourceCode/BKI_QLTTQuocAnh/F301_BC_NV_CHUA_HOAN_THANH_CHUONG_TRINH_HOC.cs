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
                US_GD_LOP_MON v_us = new US_GD_LOP_MON();
                v_us.dcID_MON_HOC = v_dc_id_mon_hoc;
                v_us.dcSO_LUONG = v_so_luong_hoc_vien;
                v_us.strDA_XOA = "N";
                v_us.strMA_LOP_HOC = "FAKE-" + new US_DM_MON_HOC(v_us.dcID_MON_HOC).strMA_MON_HOC + DateTime.Now.Date.ToShortDateString() + new Random().Next(10,99);
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
                    updateNhanVienMonHoc(v_us.dcID_NHAN_VIEN);
                    v_us.Insert();
                }                
            }
        }

        private void updateNhanVienMonHoc(decimal ip_dc_id_nhan_vien)
        {
            US_GD_LOP_MON v_us_gd_LOP_MON = new US_GD_LOP_MON();
            DS_GD_LOP_MON v_ds_gd_LOP_MON = new DS_GD_LOP_MON();
            v_ds_gd_LOP_MON.EnforceConstraints = false;
            v_us_gd_LOP_MON.FillDataset(v_ds_gd_LOP_MON, " where id_mon_hoc = " + m_cbo_mon_hoc.SelectedValue);
            for (int i = 0; i < v_ds_gd_LOP_MON.Tables[0].Rows.Count; i++)
            {
                US_GD_DIEM v_us = new US_GD_DIEM();
                DS_GD_DIEM v_ds = new DS_GD_DIEM();
                DataRow v_dr = v_ds_gd_LOP_MON.Tables[0].Rows[i];
                v_us.FillDataset(v_ds, " where id_nhan_vien = " + ip_dc_id_nhan_vien.ToString() + " and id_lop_hoc = " + v_dr[GD_LOP_MON.ID]);
                for (int j = 0; j < v_ds.Tables[0].Rows.Count; j++)
                {
                    DataRow v_dr_diem = v_ds.Tables[0].Rows[i];
                    v_us = new US_GD_DIEM(CIPConvert.ToDecimal(v_dr[GD_DIEM.ID].ToString()));
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
            WinFormControls.load_data_to_combobox_with_query(m_cbo_nghiep_vu, "ID", "TEN_NGHIEP_VU", WinFormControls.eTAT_CA.YES, "SELECT DNV.ID, dnv.TEN_NGHIEP_VU FROM DM_NGHIEP_VU AS dnv, DM_NGACH_CON_NGHIEP_VU AS dncnv WHERE dncnv.ID_NGHIEP_VU = dnv.ID AND dncnv.ID_NGACH = "+ m_cbo_ngach.SelectedValue +" OR "+ m_cbo_ngach.SelectedValue +" = -1");
        }

        private void load_data_2_cbo_mon_hoc()
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_mon_hoc, "ID", "MON_HOC", WinFormControls.eTAT_CA.NO, "SELECT DISTINCT dmh.ID, dmh.MA_MON_HOC + ' - '+ dmh.TEN_MON_HOC AS MON_HOC FROM DM_MON_HOC AS dmh, DM_NGHIEP_VU_MON_HOC AS dnvmh WHERE dmh.ID =dnvmh.ID_MON_HOC AND (dnvmh.ID_NGHIEP_VU = "+ m_cbo_nghiep_vu.SelectedValue +" OR "+ m_cbo_nghiep_vu.SelectedValue +" = -1)");
        }

        private void m_cbo_dia_phuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data_2_cbo_ngach();
        }

        private void load_data_2_cbo_ngach()
        {
            WinFormControls.load_data_to_combobox("DM_NGACH", "ID", "MA_NGACH", " WHERE ID_CAP_TREN IS NOT NULL and (ID_DIA_PHUONG = " + m_cbo_dia_phuong.SelectedValue + " OR " + m_cbo_dia_phuong.SelectedValue + "=-1)", WinFormControls.eTAT_CA.YES, m_cbo_ngach);
        }

        private void m_cbo_nghiep_vu_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data_2_cbo_mon_hoc();
        }

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv.ExportToXls(saveFileDialog1.FileName);
                MessageBox.Show("Lưu báo cáo thành công");
            }
        }

        private void m_cmd_xuat_pdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //m_grv.ExportToPdf(saveFileDialog1.FileName);
                m_grv.ExportToHtml(saveFileDialog1.FileName);
                MessageBox.Show("Lưu báo cáo thành công");
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
    }
}
