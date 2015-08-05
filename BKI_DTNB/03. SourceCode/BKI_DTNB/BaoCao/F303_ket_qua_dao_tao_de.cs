using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_DTNB.DS;
using BKI_DTNB.US;
using DevExpress.XtraGrid;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace BKI_DTNB.BaoCao
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

        private void m_grv_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
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
