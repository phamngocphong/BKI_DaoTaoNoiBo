using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using BKI_QLTTQuocAnh.DS.CDBNames;

namespace BKI_QLTTQuocAnh.NghiepVu
{
    public partial class F210_Nhap_diem_xlsx : Form
    {
        string m_str_path = "";
        public F210_Nhap_diem_xlsx()
        {
            InitializeComponent();
        }

        private void F210_Nhap_diem_xlsx_Load(object sender, EventArgs e)
        {
            WinFormControls.load_xls_to_gridview(m_str_path, m_grc);

        }

        internal void display(string ip_str_path)
        {
            m_str_path = ip_str_path;
            this.Show();
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < m_grv.SelectedRowsCount; i++)
            {
                var v_data_row = m_grv.GetDataRow(m_grv.GetSelectedRows()[i]);
                US_GD_LOP_MON v_us_gdlm= new US_GD_LOP_MON();
                DS_GD_LOP_MON v_ds_gdlm= new DS_GD_LOP_MON();

                v_us_gdlm.FillDataset(v_ds_gdlm, " where MA_LOP_HOC='" + v_data_row["MA_LOP"].ToString() + "'");
                DataRow v_dt_r = v_ds_gdlm.Tables[0].Rows[0];
                decimal v_id_gdlm = CIPConvert.ToDecimal(v_dt_r[GD_LOP_MON.ID].ToString());
                //v_us_gdlm = new US_GD_LOP_MON(v_id_gdlm);
                //decimal 
                US_DUNG_CHUNG v_us_dc = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us_dc.FillDatasetWithQuery(v_ds, "SELECT * FROM DM_NHAN_SU WHERE MA_NV='" + v_data_row["MA_NHAN_VIEN"].ToString() + "'");
                v_dt_r = v_ds.Tables[0].Rows[0];
                decimal v_id_ns = CIPConvert.ToDecimal(v_dt_r["ID"].ToString());
                v_ds.Clear();
                v_us_dc.FillDatasetWithQuery(v_ds, "SELECT * FROM GD_DIEM WHERE ID_NHAN_VIEN="+ v_id_ns.ToString()+" AND ID_LOP_MON="+ v_id_gdlm.ToString());
                if (v_ds.Tables[0].Rows.Count == 0) {
                    MessageBox.Show("Nhân viên này chưa có trong lớp môn này");
                    continue;
                }
                v_dt_r = v_ds.Tables[0].Rows[0];
                
                decimal v_id_gdd = CIPConvert.ToDecimal(v_dt_r["ID"].ToString());
                US_GD_DIEM v_us_gdd = new US_GD_DIEM(v_id_gdd);
                v_us_gdd.dcDIEM_CHUYEN_CAN = CIPConvert.ToDecimal(v_data_row["DIEM_CHUYEN_CAN"].ToString());
                v_us_gdd.dcDIEM_KIEM_TRA= CIPConvert.ToDecimal(v_data_row["DIEM_KIEM_TRA"].ToString());
                v_us_gdd.dcDIEM_THI = CIPConvert.ToDecimal(v_data_row["DIEM_THI"].ToString());
                v_us_gdd.strQUA_MON = v_data_row["KET_QUA"].ToString();
                v_us_gdd.datNGAY_SUA = DateTime.Now.Date;
                v_us_gdd.strHOC_XONG_YN = "Y";
                v_us_gdd.Update();

                //US_GD_LOP_MON v_us_gdlm= new US_GD_LOP_MON(v_data_row[]
            }

                        //US_GD_DIEM v_us = new US_GD_DIEM(CIPConvert.ToDecimal(v_data_row["ID"].ToString()));
                        //v_us.strQUA_MON = v_da_qua_mon;
                        //v_us.strHOC_XONG_YN = v_da_hoc_xong;
        }
    }
}
