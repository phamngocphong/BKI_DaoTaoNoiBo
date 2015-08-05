using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_DTNB.NghiepVu
{
    public partial class F210_Nhap_diem_xlsx_de : Form
    {
        public F210_Nhap_diem_xlsx_de()
        {
            InitializeComponent();
        }

        private void m_cmd_chon_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "xlsx Files (.xlsx)|*.xlsx|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            var userClickedOK = openFileDialog1.ShowDialog();
            if (userClickedOK == System.Windows.Forms.DialogResult.OK)
            {
                m_txt_path.Text = openFileDialog1.FileName;
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        public void display(ref string v_str_path)
        {
            this.ShowDialog();
            v_str_path = m_txt_path.Text;
        }
    }
}
