using PointOfSaleUI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleUI.UI
{
    public partial class SavedTransactionDrafts : Form
    {
        string DraftsDirPath = Environment.CurrentDirectory + @"\Saved Transactions\";
        public string TransactionFile;

        public SavedTransactionDrafts()
        {
            InitializeComponent();
            LoadSavedTransactionList();
        }

        private void LoadSavedTransactionList()
        {
            try
            {
                var fileList = new DirectoryInfo(DraftsDirPath).GetFiles();
                if (fileList.Count() <= 0)
                {
                    savedDraftsGrid.Visible = false;
                }
                else
                {
                    var file = from s in fileList
                               select new
                               {
                                   FileName = s.Name,
                                   Directory = s.DirectoryName,
                                   Date = s.CreationTime
                               };
                    savedDraftsGrid.DataSource = file.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No saved transactions found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void savedDraftsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string fileName = savedDraftsGrid.CurrentRow.Cells[0].Value.ToString();
            string filePath = savedDraftsGrid.CurrentRow.Cells[1].Value.ToString();

            TransactionFile = filePath + @"\" + fileName;
            RuntimeValues.DraftFileName = TransactionFile;
            this.DialogResult = DialogResult.OK;
        }
    }
}
