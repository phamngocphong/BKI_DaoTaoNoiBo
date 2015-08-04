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

namespace BKI_QLTTQuocAnh.NghiepVu
{
    public partial class F114_Nhap_chung_chi : Form
    {
        string m_str_path = "";
        public F114_Nhap_chung_chi()
        {
            InitializeComponent();
        }

        private void F114_Nhap_chung_chi_Load(object sender, EventArgs e)
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
                //lấy id lớp môn từ datarow
                var v_data_row = m_grv.GetDataRow(m_grv.GetSelectedRows()[i]);
                US_GD_LOP_MON v_us_gdlm = new US_GD_LOP_MON();
                DS_GD_LOP_MON v_ds_gdlm = new DS_GD_LOP_MON();

                v_us_gdlm.FillDataset(v_ds_gdlm, " where MA_LOP_HOC='" + v_data_row["MA_LOP"].ToString() + "'");
                DataRow v_dt_r = v_ds_gdlm.Tables[0].Rows[0];
                decimal v_id_gdlm = CIPConvert.ToDecimal(v_dt_r["ID"].ToString());
               
                // lấy id nhân viên từ datarow
                US_DUNG_CHUNG v_us_dc = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us_dc.FillDatasetWithQuery(v_ds, "SELECT * FROM DM_NHAN_SU WHERE MA_NV='" + v_data_row["MA_NHAN_VIEN"].ToString() + "'");
                v_dt_r = v_ds.Tables[0].Rows[0];
                decimal v_id_ns = CIPConvert.ToDecimal(v_dt_r["ID"].ToString());
                v_ds.Clear();
                v_us_dc.FillDatasetWithQuery(v_ds, "SELECT * FROM GD_DIEM WHERE ID_NHAN_VIEN=" + v_id_ns.ToString() + " AND ID_LOP_MON=" + v_id_gdlm.ToString()+"AND DA_XOA='N'");
                if (v_ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Nhân viên này chưa có điểm. Xin vui lòng kiểm tra lại dữ liệu!");
                    continue;
                }
                v_dt_r = v_ds.Tables[0].Rows[0];

                decimal v_id_gdd = CIPConvert.ToDecimal(v_dt_r["ID"].ToString());
                //v_ds = new DS_GD_CHUNG_CHI();
                //v_us_dc.FillDatasetWithQuery(v_ds, "SELECT * FROM GD_CHUNG_CHI WHERE GD_CHUNG_CHI.ID_GD_DIEM=" + v_id_gdd.ToString());
                //v_dt_r = v_ds.Tables[0].Rows[0];
                //decimal v_id_gdcc= CIPConvert.ToDecimal(v_dt_r["ID"].ToString());
                US_GD_CHUNG_CHI v_us_gdcc = new US_GD_CHUNG_CHI();
                v_us_gdcc.dcID_GD_DIEM = v_id_gdd;
                v_us_gdcc.strSO_CHUNG_CHI = v_data_row["SO_CHUNG_CHI"].ToString();
                v_us_gdcc.datNGAY_CAP = (DateTime)v_data_row["NGAY_CAP"];
                v_us_gdcc.datNGAY_BAT_DAU = (DateTime)v_data_row["NGAY_BAT_DAU"];
                if (v_data_row["NGAY_KET_THUC"].ToString() == "")
                {
                    v_us_gdcc.IsNGAY_KET_THUCNull();
                }
                else
                {
                    v_us_gdcc.datNGAY_KET_THUC = (DateTime)v_data_row["NGAY_KET_THUC"];
                }
                v_us_gdcc.datNGAY_LAP = DateTime.Now.Date;
                v_us_gdcc.datNGAY_SUA = DateTime.Now.Date;
                v_us_gdcc.strDA_XOA = "N";
                v_us_gdcc.Insert(); 
            }
            MessageBox.Show("Nhập thành công chứng chỉ cho "+ m_grv.SelectedRowsCount.ToString()+ " nhân viên!");

        }
    }
}
