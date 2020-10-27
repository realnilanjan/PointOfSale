using System;
using System.Windows.Forms;

namespace PointOfSaleUI.Helpers
{
    public static class Functions
    {
        public static void ProcessGridColor(DataGridView grid, int cellvalue)
        {
            foreach (DataGridViewColumn c in grid.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.Programmatic;
            }

            foreach (DataGridViewRow rw in grid.Rows)
            {
                if (Convert.ToInt32(rw.Cells[cellvalue].Value) <= 5)
                {
                    rw.DefaultCellStyle.BackColor = Properties.Settings.Default.ZeroToFiveBackColor;
                    rw.DefaultCellStyle.SelectionBackColor = Properties.Settings.Default.ZeroToFiveRowSelectionBackColor;
                    rw.DefaultCellStyle.SelectionForeColor = Properties.Settings.Default.ZeroToFiveRowRowSelectionForeColor;
                    rw.DefaultCellStyle.ForeColor = Properties.Settings.Default.ZeroToFiveRowSelectionForeColor;
                }
                else if (Convert.ToInt32(rw.Cells[cellvalue].Value) > 5 && Convert.ToInt32(rw.Cells[cellvalue].Value) <= 10)
                {
                    rw.DefaultCellStyle.BackColor = Properties.Settings.Default.FiveToTenBackColor;
                    rw.DefaultCellStyle.SelectionBackColor = Properties.Settings.Default.FiveToTenRowSelectionBackColor;
                    rw.DefaultCellStyle.SelectionForeColor = Properties.Settings.Default.FiveToTenRowRowSelectionForeColor;
                    rw.DefaultCellStyle.ForeColor = Properties.Settings.Default.FiveToTenRowSelectionForeColor;
                }

                else if (Convert.ToInt32(rw.Cells[cellvalue].Value) > 10 && Convert.ToInt32(rw.Cells[cellvalue].Value) <= 15)
                {
                    rw.DefaultCellStyle.BackColor = Properties.Settings.Default.TenToFifteenBackColor;
                    rw.DefaultCellStyle.SelectionBackColor = Properties.Settings.Default.TenToFifteenRowSelectionBackColor;
                    rw.DefaultCellStyle.SelectionForeColor = Properties.Settings.Default.TenToFifteenRowRowSelectionForeColor;
                    rw.DefaultCellStyle.ForeColor = Properties.Settings.Default.TenToFifteenRowSelectionForeColor;
                }
            }
        }
    }
}
    