using PointOfSale.Lib.DataModel;
using PointOfSale.Lib.TerminalModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace PointOfSale.Lib.Helpers
{
    public static class Utils
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
            const int shake_amplitude = 10;         //TODO: Add a setting for changing value
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }

        public static List<CartItemModel> ReadDrafts(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<CartItemModel>),
                    new XmlRootAttribute("CartItemModel"));
                var shoppingCart = (List<CartItemModel>)deserializer.Deserialize(reader);
                return shoppingCart;
            }
        }

        public static void SaveDrafts(List<CartItemModel> cartItems, string fileName)
        {
            string DraftsDirPath = Environment.CurrentDirectory + @"\Saved Transactions\";      //TODO: Add a setting for renaming
            if (!(Directory.Exists(DraftsDirPath)))
            {
                Directory.CreateDirectory(DraftsDirPath);
                XmlSerializer serializer = new XmlSerializer(typeof(List<CartItemModel>), new XmlRootAttribute("CartItemModel"));
                using (var writer = XmlWriter.Create(DraftsDirPath + fileName))
                {
                    serializer.Serialize(writer, cartItems);
                }
            }
            else
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<CartItemModel>), new XmlRootAttribute("CartItemModel"));
                using (var writer = XmlWriter.Create(DraftsDirPath + fileName))
                {
                    serializer.Serialize(writer, cartItems);
                }
            }
        }
    }
}
