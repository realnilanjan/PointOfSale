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

        public static void DoErrorShake(Form form)
        {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 10;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }
    }
}