using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;
using DevExpress.XtraPrinting;
using System.Drawing.Printing;
using DevExpress.XtraGrid.Views.Grid;

namespace BKI_DTNB.BaoCao
{
    public partial class RPT_XtraReport : DevExpress.XtraReports.UI.XtraReport
    {
        int m_count_group_col = 0;

        public RPT_XtraReport()
        {
            InitializeComponent();
        }
        public RPT_XtraReport(DataSet ip_ds, DevExpress.XtraGrid.Views.Grid.GridView ip_grv, ArrayList ip_arr_parameter, PaperKind ip_paper_kind, bool ip_land_scape)
        {
            InitializeComponent();
            ReportFormat(true, PaperKind.A4);
            ReportFillParameter(ip_arr_parameter);
            ReportData(ip_ds);
            ReportGroupBand(ip_grv);
            InitTables(ip_grv);
        }

        private void ReportFillParameter(ArrayList ip_arr_parameter)
        {
            for (int i = 0; i < ip_arr_parameter.Count; i++)
            {
                iParameter v_parameter = (iParameter)ip_arr_parameter[i];
                for (int j = 0; j < this.fXRControls.Count; j++)
                {
                    ((XRLabel)this.FindControl(v_parameter.ParameterName, true)).Text = v_parameter.ParameterValue;
                }
            }
            int pagewidth = (PageWidth - (Margins.Left + Margins.Right) - (m_count_group_col + 1) * 20);
            iP_tieu_de_bao_cao.Width = pagewidth - (m_count_group_col + 1) * 20;
            iP_tieu_de_bao_cao.Location = new Point(0 + (m_count_group_col + 1) * 20, 50);
            iP_tieu_de_bao_cao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        }
        private void ReportGroupBand(GridView ip_grv)
        {
            for (int i = ip_grv.GroupCount - 1; i >= 0; i--)
                InsertGroupBand(ip_grv.GroupedColumns[i], i);
        }
        private void ReportData(DataSet ip_ds)
        {
            this.DataSource = ip_ds;
            this.DataMember = ip_ds.Tables[0].TableName;
        }
        private void ReportFormat(bool ip_land_scape, PaperKind ip_paper_kind)
        {
            this.Landscape = ip_land_scape;
            this.PaperKind = ip_paper_kind;
        }
        private void InsertGroupBand(GridColumn gridColumn, int i)
        {
            GroupHeaderBand gb = new GroupHeaderBand();
            gb.Height = 25;
            gb.RepeatEveryPage = true;
            XRLabel l = new XRLabel();
            l.DataBindings.Add("Text", this.DataSource, gridColumn.FieldName);
            l.Size = new Size(300, 25);
            l.Location = new Point(0 + i * 20, 0);
            l.BackColor = Color.Beige;
            gb.Controls.Add(l);
            GroupField gf;
            if (gridColumn.SortOrder == ColumnSortOrder.Ascending)
            {
                gf = new GroupField(gridColumn.FieldName, XRColumnSortOrder.Ascending);
                m_count_group_col += 1;
            }
            else
            {
                gf = new GroupField(gridColumn.FieldName, XRColumnSortOrder.Descending);
                m_count_group_col += 1;
            }
            l.BackColor = Color.White;
            l.Font = new Font(l.Font.FontFamily, 12, FontStyle.Bold);
            gb.GroupFields.Add(gf);
            gb.StylePriority.UseBackColor = true;
            gb.BackColor = Color.Maroon;
            this.Bands.Add(gb);
        }
        public void InitTables(GridView ip_grv)
        {
            ArrayList columnALCaption = new ArrayList();
            ArrayList columnAL = new ArrayList();
            for (int i = 0; i < ip_grv.Columns.Count; i++)
                if (ip_grv.Columns[i].Visible && ip_grv.Columns[i].GroupIndex < 0)
                {
                    columnAL.Add(ip_grv.Columns[i].FieldName);
                    columnALCaption.Add(ip_grv.Columns[i].Caption);
                }
            int colCount = columnAL.Count;
            int pagewidth = (PageWidth - (Margins.Left + Margins.Right) - (m_count_group_col + 1) * 20);
            int colWidth = pagewidth / colCount;

            XRTable table = new XRTable();
            XRTableRow row = new XRTableRow();
            XRTable table2 = new XRTable();
            XRTableRow row2 = new XRTableRow();

            for (int i = 0; i < colCount; i++)
            {
                XRTableCell cell = new XRTableCell();
                cell.Width = (int)colWidth;
                cell.Text = columnALCaption[i].ToString();
                row.Cells.Add(cell);

                XRTableCell cell2 = new XRTableCell();
                cell2.Width = (int)colWidth;
                cell2.DataBindings.Add("Text", null, columnAL[i].ToString());
                row2.Cells.Add(cell2);
            }
            table.Rows.Add(row);
            table.Width = pagewidth - (m_count_group_col + 1) * 20;
            table.Borders = BorderSide.Bottom;
            table.BackColor = Color.Maroon;
            table.ForeColor = Color.White;
            table.StylePriority.UseFont = true;
            table.Font = new Font(table.Font.FontFamily, 12, FontStyle.Bold);
            table.Location = new Point(0 + (m_count_group_col + 1) * 20, 0);

            row2.CanShrink = true;
            table2.Rows.Add(row2);
            table2.Width = pagewidth - (m_count_group_col + 1) * 20;
            table2.Location = new Point(0 + (m_count_group_col + 1) * 20, 0);

            Bands["PageHeader"].Controls.Add(table);
            Bands["Detail"].Controls.Add(table2);
        }
    }
}
