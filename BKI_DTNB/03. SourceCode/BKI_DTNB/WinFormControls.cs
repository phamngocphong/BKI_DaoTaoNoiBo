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

using BKI_DTNB.DS;
using BKI_DTNB.US;
using BKI_DTNB.DS.CDBNames;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;
using System.Configuration;
using System.Data.OleDb;
using DevExpress.XtraReports.UI;
using System.IO;


namespace BKI_DTNB
{
    public class WinFormControls
    {
        public WinFormControls()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static void DTNB_ControlFormat(Form ip_form) {
            format_control(ip_form, "m_lbl");
            format_control(ip_form, "m_tieu_de");
            format_control(ip_form, "m_cbo");
            format_control(ip_form, "m_cmd");
           
        
        }
        private static void format_control(Control ip_c, string ip_st)
        {
            if (ip_c.Name.StartsWith(ip_st) && ip_st == "m_lbl")
            {
                ip_c.ForeColor = Color.Maroon;
                ip_c.Font = new Font("Arial", 10,FontStyle.Bold);  
               
            }
            if (ip_c.Name.StartsWith(ip_st) && ip_st == "m_tieu_de")
            {
                ip_c.ForeColor = Color.Maroon;
                ip_c.Font = new Font("Arial", 12, FontStyle.Bold);
            }
            if (ip_c.Name.StartsWith(ip_st) && ip_st == "m_cbo")
            {
                ip_c.Font = new Font("Arial", 10, FontStyle.Bold);
            }
            if (ip_c.Name.StartsWith(ip_st)&& ip_st=="m_cmd")
            {
                ip_c.ForeColor = Color.White;
                ip_c.BackColor = Color.Maroon;
            }
            else 
            {
                foreach (Control child in ip_c.Controls)
                {
                    format_control(child, ip_st);
                }
            }
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

        public static void load_data_to_auto_complete_source(string ip_str_table_name, string ip_str_column_name, TextBox ip_txt) {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithProc(v_ds, ip_str_table_name, ip_str_column_name);
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                DataRow v_dr = v_ds.Tables[0].Rows[i];
                ip_txt.AutoCompleteCustomSource.Add(v_dr[ip_str_column_name].ToString());
            }
        }

        public static void load_data_to_combobox(string ip_str_table_name, string ip_str_value_field, string ip_str_display_field, string ip_str_condition, eTAT_CA ip_e_tat_ca,ComboBox ip_cbo) {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetCBO(v_ds, ip_str_table_name, ip_str_value_field, ip_str_display_field, ip_str_condition);
            
            ip_cbo.DisplayMember = ip_str_display_field;
            ip_cbo.ValueMember = ip_str_value_field;
            ip_cbo.DataSource = v_ds.Tables[0];

            if (ip_e_tat_ca == eTAT_CA.YES)
            {
                DataRow v_dr = v_ds.Tables[0].NewRow();
                v_dr[0] = -1;
                v_dr[1] = "------ Tất cả ------";
                v_ds.Tables[0].Rows.InsertAt(v_dr, 0);
                ip_cbo.SelectedIndex = 0;
            }
            else
            {
                ip_cbo.SelectedIndex = 0;
            }
        }

        public static void load_data_to_combobox_with_query(ComboBox ip_cbo, string ip_str_value_field, string ip_str_display_field, eTAT_CA ip_e_tat_ca, string ip_query)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithQuery(v_ds, ip_query);
            
            ip_cbo.DisplayMember = ip_str_display_field;
            ip_cbo.ValueMember = ip_str_value_field;
            ip_cbo.DataSource = v_ds.Tables[0];

            if (ip_e_tat_ca == eTAT_CA.YES)
            {
                DataRow v_dr = v_ds.Tables[0].NewRow();
                v_dr[0] = -1;
                v_dr[1] = "------ Tất cả ------";
                v_ds.Tables[0].Rows.InsertAt(v_dr, 0);
                ip_cbo.SelectedIndex = 0;
            }
            else
            {
                ip_cbo.SelectedIndex = 0;
            }
        }

        public static void load_xls_to_gridview(string ip_str_path, DevExpress.XtraGrid.GridControl ip_grc) {
            string conStr = "";
            string v_file_type = Path.GetExtension(ip_str_path);
            if (v_file_type == ".xls")
            {
                conStr = ConfigurationManager.ConnectionStrings["Excel03ConString"].ConnectionString;   
            }
            else
            {
                conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
            }
            conStr = String.Format(conStr, ip_str_path, "Yes");
            OleDbConnection con = new OleDbConnection(conStr);
            OleDbCommand ExcelCommand = new OleDbCommand();
            ExcelCommand.Connection = con;
            con.Open();
            DataTable ExcelDataSet = new DataTable();
            ExcelDataSet = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            DataTable dt = new DataTable();
            if (ExcelDataSet != null && ExcelDataSet.Rows.Count > 0)
            {
                string SheetName = ExcelDataSet.Rows[0]["TABLE_NAME"].ToString(); // get sheetname
                ExcelCommand.CommandText = "SELECT * From [" + SheetName + "]";
                OleDbDataAdapter ExcelAdapter = new OleDbDataAdapter(ExcelCommand);
                ExcelAdapter.SelectCommand = ExcelCommand;
                ExcelAdapter.Fill(dt);
            }
            con.Close();
            ip_grc.DataSource = dt;
        }

        #region Report
        static GridView m_grv;
        public static DXMenuItem CreateRowSubMenu(GridView view, int rowHandle)
        {
            m_grv = view;
            DXSubMenuItem subMenu = new DXSubMenuItem("Báo cáo");
            DXMenuItem menuItemReportXLS = new DXMenuItem("&Báo cáo XLS", new EventHandler(ExportXLSClick));
            DXMenuItem menuItemReportPDF = new DXMenuItem("&Báo cáo PDF", new EventHandler(ExportPDFClick));
            DXMenuItem menuItemReportHTML = new DXMenuItem("&Báo cáo HTML", new EventHandler(ExportHTMLClick));
            DXMenuItem menuItemReportDOC = new DXMenuItem("&Báo cáo TXT", new EventHandler(ExportDOCClick));
            subMenu.Items.Add(menuItemReportXLS);
            subMenu.Items.Add(menuItemReportPDF);
            subMenu.Items.Add(menuItemReportHTML);
            subMenu.Items.Add(menuItemReportDOC);
            return subMenu;
        }

        private static void ExportPDFClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv.ExportToPdf(saveFileDialog1.FileName);
                MessageBox.Show("Lưu báo cáo thành công");
            }
        }

        private static void ExportHTMLClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "html files (*.html)|*.html|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv.ExportToHtml(saveFileDialog1.FileName);
                MessageBox.Show("Lưu báo cáo thành công");
            }
        }

        private static void ExportDOCClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_grv.ExportToText(saveFileDialog1.FileName);
                MessageBox.Show("Lưu báo cáo thành công");
            }
        }

        private static void ExportXLSClick(object sender, EventArgs e)
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
        #endregion
    }

    public class US_DUNG_CHUNG : US_Object {
        public void FillDatasetWithProc(DataSet op_ds, string ip_str_table_name, string ip_str_column_name)
        {
            CStoredProc v_cstore = new CStoredProc("get_data_to_dataset_with_table_name_and_column_name");
            v_cstore.addNVarcharInputParam("@TABLE_NAME", ip_str_table_name);
            v_cstore.addNVarcharInputParam("@COLUMN_NAME", ip_str_column_name);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        public void FillDatasetTinhHinhDaoTao(DataSet op_ds, DateTime ip_dat)
        {
            CStoredProc v_cstore = new CStoredProc("rpt_tinh_hinh_dao_tao");
            v_cstore.addDatetimeInputParam("@ip_dat_ngay_bao_cao",ip_dat );
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        public void FillDatasetVNghiepVuMonHoc(DataSet op_ds)
        {
            CStoredProc v_cstore = new CStoredProc("get_danh_sach_nhan_vien_nghiep_vu");
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        internal void FillDatasetCBO(DataSet op_ds, string ip_str_table_name, string ip_str_value_field, string ip_str_display_field, string ip_str_condition)
        {
            CStoredProc v_cstore = new CStoredProc("get_data_for_cbo");
            v_cstore.addNVarcharInputParam("@TABLE_NAME", ip_str_table_name);
            v_cstore.addNVarcharInputParam("@COLUMN_VALUE", ip_str_value_field);
            v_cstore.addNVarcharInputParam("@COLUMN_DISPLAY", ip_str_display_field);
            v_cstore.addNVarcharInputParam("@CONDITION", ip_str_condition);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        internal void FillDatasetWithTableName(DataSet op_ds, string ip_str_table_name)
        {
            CStoredProc v_cstore = new CStoredProc("get_data_from_table");
            v_cstore.addNVarcharInputParam("@TABLE_NAME", ip_str_table_name);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }


        internal void FillDatasetWithQuery(DataSet op_ds, string ip_query)
        {
            CStoredProc v_cstore = new CStoredProc("pr_fill_ds_with_query");
            v_cstore.addNVarcharInputParam("@SQL_QUERY", ip_query);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        internal void FillDatasetChungChiHetHan(DataSet v_ds, DateTime dateTime)
        {
            CStoredProc v_cstore = new CStoredProc("get_chung_chi_het_han_theo_ngach");
            v_cstore.addDatetimeInputParam("@ngay",dateTime );
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void FillDatasetSQLInjection(DataSet v_ds, string p)
        {
            CStoredProc v_cstore = new CStoredProc("sqlInjection");
            v_cstore.addNVarcharInputParam("@str_query", p);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }



        internal void FillDatasetChuongTrinhKhung(DataSet v_ds, decimal p)
        {
            CStoredProc v_cstore = new CStoredProc("pr_get_chuong_trinh_hoc_cua_1_nhan_vien");
            v_cstore.addDecimalInputParam("@id_nhan_vien", p);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }
    }

    public class iParameter
    {
        public string ParameterName { get; set; }
        public string ParameterValue { get; set; }

        public iParameter(string ip_name, string ip_value) {
            ParameterName = ip_name;
            ParameterValue = ip_value;
        }
    }
}
