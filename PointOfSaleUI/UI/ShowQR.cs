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
            picUPIQR.ImageLocation = Properties.Settings.Default.QRCodePath;
        }
    }
}