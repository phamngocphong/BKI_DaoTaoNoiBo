using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            WinFormControls.load_xls_to_gridview(m_str_path, gridControl1);
        }

        internal void display(string ip_str_path)
        {
            m_str_path = ip_str_path;
            this.Show();
        }
    }
}
