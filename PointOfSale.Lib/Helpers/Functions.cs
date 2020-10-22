using PointOfSale.Lib.DataModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PointOfSale.Lib.Helpers
{
    public static class Functions
    {
        public static void FillCombo(List<CategoryDataModel> categoriesSource, ComboBox control)
        {
            control.DataSource = categoriesSource;
            control.ValueMember = "Id";
            control.DisplayMember = "CategoryName";
        }

        public static void FillCombo(List<SupplierDataModel> supplierSource, ComboBox control)
        {
            control.DataSource = supplierSource;
            control.ValueMember = "Id";
            control.DisplayMember = "SupplierName";
        }

        public static void FillCombo(List<QuantityDescriptionModel> quantityDescriptions, ComboBox control)
        {
            control.DataSource = quantityDescriptions;
            control.ValueMember = "Id";
            control.DisplayMember = "QtyDescription";
        }

        public static void ProcessGridColor(DataGridView grid, int cellvalue)
        {
            foreach (DataGridViewColumn c in grid.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.Programmatic;
            }

            foreach (DataGridViewRow rw in grid.Rows)
            {
                if (Convert.ToInt32(rw.Cells[cellvalue].Value) < 10)
                {
                    rw.DefaultCellStyle.BackColor = Color.Red;
                    rw.DefaultCellStyle.SelectionBackColor = Color.Red;
                    rw.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
    }
}