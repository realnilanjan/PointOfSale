using System.IO;
using System.Windows.Forms;

namespace PointOfSaleUI.UI
{
    public partial class ShowQR : Form
    {
        public ShowQR()
        {
            InitializeComponent();
            ShowQRCode();
        }

        private void ShowQRCode()
        {
            if (File.Exists(Properties.Settings.Default.QRCodePath))
            {
                picUPIQR.ImageLocation = Properties.Settings.Default.QRCodePath;
            }
            else
            {
                picUPIQR.Visible = false;
            }
        }
    }
}