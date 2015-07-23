using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.US;
using DevExpress.XtraGrid;
using DevExpress.XtraPivotGrid;

namespace BKI_QLTTQuocAnh.BaoCao
{
    public partial class F303_ket_qua_dao_tao_de : Form
    {
        public GridControl v_grc;
        public F303_ket_qua_dao_tao_de()
        {
            InitializeComponent();
        }

        private void F303_ket_qua_dao_tao_de_Load(object sender, EventArgs e)
        {
            v_grc = m_grc;
        }
        public void display(PivotDrillDownDataSource ip_ds)
        {
            m_grc.DataSource = ip_ds;
            this.ShowDialog();
        }
    }
}
