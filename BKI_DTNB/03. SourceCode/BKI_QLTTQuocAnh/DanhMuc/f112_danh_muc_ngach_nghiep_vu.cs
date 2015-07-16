using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_QLTTQuocAnh.DanhMuc
{
    public partial class f112_danh_muc_ngach_nghiep_vu : Form
    {
        public f112_danh_muc_ngach_nghiep_vu()
        {
            InitializeComponent();
        }
        private void f112_danh_muc_dai_Load(object sender, System.EventArgs e)
        {
            load_data_2_grid();
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_NGACH_CON_NGHIEP_VU");
            m_grc.DataSource = v_ds.Tables[0];

        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {

            if (e.IsGetData)
                e.Value = e.ListSourceRowIndex + 1;
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
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
