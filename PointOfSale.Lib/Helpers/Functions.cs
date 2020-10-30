using PointOfSale.Lib.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

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

        public static void ReadDrafts(DataGridView dataGridView, string fileName)
        {
            string path = fileName;
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            dataGridView.DataSource = ds;
            dataGridView.DataMember = "student";
        }

        public static void SaveDrafts(DataGridView dataGridView, string fileName)
        {
            string DirPath = Environment.CurrentDirectory + @"\Saved Transactions\";
            DataTable dt = new DataTable();

            dt.TableName = "CartItem";
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dt.Columns.Add(dataGridView.Columns[i].HeaderText);
            }

            foreach (DataGridViewRow currentRow in dataGridView.Rows)
            {
                dt.Rows.Add();
                int runningCount = 0;
                foreach (DataGridViewCell item in currentRow.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][runningCount] = item.FormattedValue;
                    runningCount++;
                }
            }

            if (dt != null)
            {
                if (Directory.Exists(DirPath))
                {
                    dt.WriteXml(DirPath + fileName + ".xml");
                }
                else
                {
                    Directory.CreateDirectory(DirPath);
                    dt.WriteXml(DirPath + fileName + ".xml");
                }
            }
        }
    }
}
