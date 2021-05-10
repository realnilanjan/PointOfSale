using System.Runtime.InteropServices;

namespace PointOfSale.Lib.Helpers
{
    public static class InternetConnectionState
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public static bool CheckInternet()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }
    }
}
