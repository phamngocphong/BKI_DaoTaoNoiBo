using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_DTNB.US;
using BKI_DTNB.DS;
using System.Data.SqlClient;
using System.Configuration;
namespace BKI_DTNB.NghiepVu
{
    public partial class F208_gd_lop_mon_de : Form
    {
        decimal m_dc_id_mon_hoc = -1;
        decimal m_dc_ma_ten_mon_hoc = -1;
        decimal m_dc_id_version = -1;
        string m_ma_lop = "";
        DataEntryFormMode m_e_form_mode;
        US_GD_LOP_MON m_us = new US_GD_LOP_MON();
        public F208_gd_lop_mon_de()
        {
            InitializeComponent();

        }

        private void F208_gd_lop_mon_de_Load(object sender, EventArgs e)
        {
            load_data_2_cbo();

        }

        private void load_data_2_cbo()
        {
            // WinFormControls.load_data_to_combobox("DM_MON_HOC", "ID", "MA_MON_HOC", "", WinFormControls.eTAT_CA.NO, m_cbo_ma_ten_mon_hoc);
            WinFormControls.load_data_to_combobox_with_query(m_cbo_ma_ten_mon_hoc, "ID", "TEN_MON_HOC", WinFormControls.eTAT_CA.NO, "SELECT ID, MA_MON_HOC+' - '+ TEN_MON_HOC AS TEN_MON_HOC FROM DM_MON_HOC");
            m_cbo_ma_ten_mon_hoc.SelectedValue = m_dc_ma_ten_mon_hoc;

        }

        public void m_cbo_ma_ten_mon_hoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_dc_id_mon_hoc = CIPConvert.ToDecimal(m_cbo_ma_ten_mon_hoc.SelectedValue.ToString());
            load_data_2_cbo_version();
        }

        private void load_data_2_cbo_version()
        {
            WinFormControls.load_data_to_combobox("DM_VERSION_MON_HOC", "ID", "MA_VERSION", " WHERE ID_MON_HOC=" + m_dc_id_mon_hoc.ToString(), WinFormControls.eTAT_CA.NO, m_cbo_version);
            m_cbo_version.SelectedValue = m_dc_id_version;
        }
        public void form_to_us()
        {

            m_us.strMA_LOP_HOC = m_txt_ma_lop.Text;
            m_us.datTHOI_GIAN = m_dat_thoi_gian.Value;
            m_us.dcDIEM_QUA_MON = CIPConvert.ToDecimal(m_txt_diem_qua_mon.Text);
            m_us.datNGAY_LAP = DateTime.Now.Date;
            m_us.datNGAY_SUA = DateTime.Now.Date;
            m_us.strDIA_DIEM = m_txt_dia_diem.Text;
            m_us.strNGUOI_LAP = "admin";
            m_us.IsNGUOI_SUANull();
            m_us.dcSO_LUONG = CIPConvert.ToDecimal(m_txt_so_luong.Text);
            m_us.strDA_XOA = "N";
            m_us.dcID_VERSION_MON_HOC = CIPConvert.ToDecimal(m_cbo_version.SelectedValue.ToString());
        }

        public void us_to_form(US_GD_LOP_MON ip_us, decimal ip_selected)
        {
            m_ma_lop = m_us.strMA_LOP_HOC;
            m_us = ip_us;
            m_txt_ma_lop.Text = m_us.strMA_LOP_HOC;
            m_dat_thoi_gian.Value = m_us.datTHOI_GIAN;
            m_txt_diem_qua_mon.Text = m_us.dcDIEM_QUA_MON.ToString();
            m_txt_dia_diem.Text = m_us.strDIA_DIEM;
            m_txt_so_luong.Text = m_us.dcSO_LUONG.ToString();
            //m_cbo_version.SelectedValue = m_us.dcID_VERSION_MON_HOC;
            //m_cbo_ma_ten_mon_hoc.SelectedValue = ip_selected;
            m_dc_id_version = m_us.dcID_VERSION_MON_HOC;
            m_dc_ma_ten_mon_hoc = ip_selected;
        }
        private bool check_validate_ma_lop(string ip_ma_lop)
        {
            bool ma_lop_is_ok = true;
            US_DUNG_CHUNG v_us_dc = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us_dc.FillDatasetWithQuery(v_ds, "SELECT MA_LOP_HOC FROM GD_LOP_MON ");
            //DataRow m_dt_r=v_ds.Tables[0].Rows[0];
            for (int i = 0; i <= v_ds.Tables[0].Rows.Count; i++)
            {
                DataRow m_dt_r = v_ds.Tables[0].Rows[i];
                if (ip_ma_lop == m_dt_r["MA_LOP_HOC"].ToString())
                {
                    ma_lop_is_ok = false;
                    MessageBox.Show("Trùng mã lớp. Vui lòng nhập lại!");
                    break;
                }
            }
            return ma_lop_is_ok;
        }
        private bool check_validate_data_type()
        {
            string diem_qua_mon = m_txt_diem_qua_mon.Text;
            string so_luong_hoc_vien = m_txt_so_luong.Text;
            decimal value=0;
            if (!(Decimal.TryParse(diem_qua_mon, out value)) || !(Decimal.TryParse(so_luong_hoc_vien, out value)))
            {
                
                MessageBox.Show("Vui lòng nhập kiểu số cho Số Lượng và Điểm Qua Môn!");
                return false;
            }
            else return true;
        }

        private bool check_validate_data_is_OK()
        {
            
            if ((m_txt_dia_diem.Text == "") || (m_txt_diem_qua_mon.Text == "") || (m_txt_so_luong.Text == "") || (m_txt_ma_lop.Text == "") || (m_cbo_version.SelectedValue == null) || (m_cbo_ma_ten_mon_hoc.SelectedValue == null))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường dữ liệu!");
                return false;
            }
            else
                return true;
        }

        internal void Insert_form(bool ip_trang_thai)
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }



        internal void Update_form(US_GD_LOP_MON ip_us, decimal ip_selected)
        {
            us_to_form(ip_us, ip_selected);
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            this.ShowDialog();
        }

        private void savedata()
        {
            if (check_validate_data_is_OK() != true || check_validate_data_type() != true) return;
            else
            {
                form_to_us();
                try
                {
                    switch (m_e_form_mode)
                    {
                        case DataEntryFormMode.InsertDataState:
                            m_us.Insert();
                            break;
                        case DataEntryFormMode.UpdateDataState:
                            m_us.Update();
                            break;
                    }
                    MessageBox.Show("Lưu lớp môn thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Trùng mã lớp. Xin vui lòng nhập lại thông tin!");
                }
            }
        }

        private void m_cmd_luu_Click(object sender, EventArgs e)
        {

            try
            {
                savedata();
            }
            catch (Exception ex)
            {

                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void m_cmd_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
