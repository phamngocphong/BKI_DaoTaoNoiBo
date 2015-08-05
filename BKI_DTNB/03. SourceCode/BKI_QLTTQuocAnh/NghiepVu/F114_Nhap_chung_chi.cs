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

            decimal v_count = 0;
            int v_int_khong_nhap_duoc = 0;
            decimal v_selectedRowCount = m_grv.SelectedRowsCount;
            if (v_selectedRowCount > 0)
            {
                kiem_tra_va_thuc_hien_nhap_chung_chi(ref v_count, ref v_int_khong_nhap_duoc, v_selectedRowCount);
            }
            else
            {
                MessageBox.Show("Bạn phải chọn nhân viên để cấp chứng chỉ cho họ!");
            }

        }

        private void kiem_tra_va_thuc_hien_nhap_chung_chi(ref decimal v_count, ref int v_int_khong_nhap_duoc, decimal v_selectedRowCount)
        {
            for (int i = 0; i < v_selectedRowCount; i++)
            {
                decimal v_id_gdlm = 0;
                decimal v_id_ns =0;
                DataRow v_dt_r;
                 US_DUNG_CHUNG v_us_dc = new US_DUNG_CHUNG();
              
                var v_data_row = m_grv.GetDataRow(m_grv.GetSelectedRows()[v_int_khong_nhap_duoc]);
                try
                {
                   v_dt_r= get_id_lop_mon_tu_data_row(ref v_id_gdlm, v_data_row, v_us_dc);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không tồn tại mã lớp" + v_data_row["MA_LOP"].ToString() + ".Xin vui lòng kiểm tra lại thông tin!");
                    v_int_khong_nhap_duoc++;
                    continue;
                }
               
                get_id_nhan_vien_tu_data_row( v_us_dc,v_data_row,ref v_id_ns, v_dt_r);
                get_id_gd_diem(v_us_dc, v_id_ns, v_id_gdlm, v_dt_r, ref v_int_khong_nhap_duoc, v_data_row,ref v_count);
               
            }
            if (v_count == v_selectedRowCount)
            {
                MessageBox.Show("Nhập thành công chứng chỉ cho " + v_count + " nhân viên");
            }
            else
            {
                MessageBox.Show("Nhập thành công chứng chỉ cho " + v_count + " nhân viên. Vui lòng kiểm tra lại thông tin của " + (v_selectedRowCount - v_count).ToString() + " nhân viên được chọn còn lại trong bảng!");
            }
           
        }
//chưa có điểm, cho vào try catch
        private void get_id_gd_diem(US_DUNG_CHUNG v_us_dc, decimal v_id_ns, decimal v_id_gdlm, DataRow v_dt_r, ref int v_int_khong_nhap_duoc, DataRow v_data_row,ref decimal v_count)
        {
            DataSet v_ds_gdd = new DataSet();
            v_ds_gdd.Tables.Add(new DataTable());
            //  v_ds.Clear();
            v_us_dc.FillDatasetWithQuery(v_ds_gdd, "SELECT * FROM GD_DIEM WHERE ID_NHAN_VIEN=" + v_id_ns.ToString() + " AND ID_LOP_MON=" + v_id_gdlm.ToString() + "AND DA_XOA='N'");
            if (v_ds_gdd.Tables[0].Rows.Count == 0)
            {

                MessageBox.Show("Nhân viên" + v_data_row["HO_DEM"].ToString() + " " + v_data_row["TEN"].ToString() + " chưa có điểm. Xin vui lòng kiểm tra lại dữ liệu!");
                v_int_khong_nhap_duoc++;
                //  continue;
            }
            else
            {
                get_gd_cc(v_ds_gdd, ref v_count, v_data_row, ref v_int_khong_nhap_duoc, v_dt_r);
              
            }
        }

        private void get_gd_cc(DataSet v_ds_gdd, ref decimal v_count, DataRow v_data_row, ref int v_int_khong_nhap_duoc, DataRow v_dt_r)
        {
            DataRow v_dt_gdd = v_ds_gdd.Tables[0].Rows[0];
            decimal v_id_gdd = CIPConvert.ToDecimal(v_dt_gdd["ID"].ToString());

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
            try
            {
                v_us_gdcc.Insert();
                v_data_row.Delete();

                v_count++;
            }
            catch (Exception)
            {

                MessageBox.Show("Chứng chỉ "+ v_us_gdcc.strSO_CHUNG_CHI+  " đã tồn tại. Vui lòng kiểm tra lại thông tin!");
                v_int_khong_nhap_duoc++;
            }
        }

        private void get_id_nhan_vien_tu_data_row(US_DUNG_CHUNG v_us_dc,DataRow v_data_row,ref decimal v_id_ns,DataRow v_dt_r)
        {
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us_dc.FillDatasetWithQuery(v_ds, "SELECT * FROM DM_NHAN_SU WHERE MA_NV='" + v_data_row["MA_NHAN_VIEN"].ToString() + "'");
                v_dt_r = v_ds.Tables[0].Rows[0];
                v_id_ns = CIPConvert.ToDecimal(v_dt_r["ID"].ToString());
         }

        private DataRow get_id_lop_mon_tu_data_row(ref decimal v_id_gdlm, DataRow v_data_row, US_DUNG_CHUNG v_us_dc)
        {
           
            US_GD_LOP_MON v_us_gdlm = new US_GD_LOP_MON();
            DS_GD_LOP_MON v_ds_gdlm = new DS_GD_LOP_MON();
            v_us_dc.FillDatasetWithQuery(v_ds_gdlm, "Select * from gd_lop_mon where MA_LOP_HOC='" + v_data_row["MA_LOP"].ToString() + "'");
            //if (v_ds_gdlm.Tables[0].Rows.Count == 0)
            //{
            //    MessageBox.Show("Không tồn tại mã lớp" + v_data_row["MA_LOP"].ToString() + ".Xin vui lòng kiểm tra lại thông tin!");
            //}
            //else
            //{
                
                var v_dt_r = v_ds_gdlm.Tables[0].Rows[0];
                v_id_gdlm = CIPConvert.ToDecimal(v_dt_r["ID"].ToString());
                return v_dt_r;
            //}
        }

        
    }
}
