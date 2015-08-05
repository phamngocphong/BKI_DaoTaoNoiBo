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

namespace BKI_QLTTQuocAnh.NghiepVu
{
    public partial class F112_nhan_su_nghiep_vu : Form
    {
        public decimal m_dc_id_nhan_vien;
        public decimal m_dc_id_nghiep_vu;
        public decimal m_dc_id_nhan_vien_nghiep_vu;
        public string m_str_ma_nhan_vien;
        public string m_str_ho_dem;
        public string m_str_ten;

        public F112_nhan_su_nghiep_vu()
        {
            InitializeComponent();
        }

        private void F112_nhan_su_nghiep_vu_Load(object sender, EventArgs e)
        {
            load_data_to_grid();
        }

        private void load_data_to_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetVNghiepVuMonHoc(v_ds);
            m_grc.DataSource = v_ds.Tables[0];
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_selected_row = m_grv.SelectedRowsCount;
                if (v_selected_row == 0)
                {
                    MessageBox.Show("Bạn phải chọn ít nhất 1 bản ghi để thực hiện tác vụ này!");
                }
                else
                {

                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thực hiện tác vụ này không?", "Cảnh báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        for (int i = 0; i < m_grv.SelectedRowsCount; i++)
                        {
                            var v_data_row = m_grv.GetDataRow(m_grv.GetSelectedRows()[i]);
                            var v_us = new US_DM_NHAN_SU_NGHIEP_VU(CIPConvert.ToDecimal(v_data_row["ID"].ToString()));
                            v_us.strDA_XOA_YN = "Y";
                            v_us.Update();
                        }
                        MessageBox.Show("Xóa nghiệp vụ thành công!");
                        load_data_to_grid();
                    }
                }
            }
            catch (Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void get_thong_tin_tu_datarow()
        {
                var v_data_row = m_grv.GetDataRow(m_grv.GetSelectedRows()[0]);
                m_dc_id_nhan_vien =CIPConvert.ToDecimal(v_data_row["ID_NHAN_VIEN"].ToString());
                 m_str_ma_nhan_vien = v_data_row["MA_NV"].ToString();
                 m_str_ho_dem = v_data_row["HO_DEM"].ToString();
                 m_str_ten = v_data_row["TEN"].ToString();
                 F112_nhan_su_nghiep_vu_de v_f112_de = new F112_nhan_su_nghiep_vu_de();
                 v_f112_de.display_for_insert(m_dc_id_nhan_vien, m_str_ma_nhan_vien, m_str_ho_dem, m_str_ten);
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                var v_count = m_grv.SelectedRowsCount;
                if (v_count == 0)
                {
                    MessageBox.Show("Bạn phải chọn nhân viên mới có thể cập nhật được nghiệp vụ cho họ!");
                }
                else if (v_count > 1)
                {
                    MessageBox.Show("Vui lòng chỉ lựa chọn 1 nhân viên để cập nhật nghiệp vụ!");
                }
                else
                {
                    var v_us = new US_DM_NHAN_SU_NGHIEP_VU();
                    get_thong_tin_tu_datarow();
                    load_data_to_grid();
                }
            }
            catch (Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
