using PointOfSale.Lib.DataAccess;
using PointOfSale.Lib.Models;
using System;
using System.Threading;
using System.Windows.Forms;

namespace PointOfSaleUI
{
    static class Program
    {
        //TODO: Make single instance after checking if a session is already running, show login else show dashboard.

        ///// <summary>
        ///// The main entry point for the application.
        ///// </summary>
        //static Mutex mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");
        //[STAThread]
        //static void Main()
        //{
        //    if (mutex.WaitOne(TimeSpan.Zero, true))
        //    {
        //        Application.EnableVisualStyles();
        //        Application.SetCompatibleTextRenderingDefault(false);
        //        Application.Run(new UI.Login());
        //        mutex.ReleaseMutex();
        //    }
        //    else
        //    {
        //        // send our Win32 message to make the currently running instance
        //        // jump on top of all the other windows
        //        NativeMethods.PostMessage(
        //            (IntPtr)NativeMethods.HWND_BROADCAST,
        //            NativeMethods.WM_SHOWME,
        //            IntPtr.Zero,
        //            IntPtr.Zero);
        //    }
        //}


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SQLDataAccess dataAccess = new SQLDataAccess();

            if (Properties.Settings.Default.WizardStep == 3)
            {
                BusinessInformation.BusinessInfo = dataAccess.GetBusinessInformation();
                Application.Run(new UI.Login());
            }
            else
            {
                Application.Run(new UI.Wizard());
            }
        }
    }
}
