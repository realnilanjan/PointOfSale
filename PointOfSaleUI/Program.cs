﻿using PointOfSale.Lib.DataAccess;
using PointOfSale.Lib.Models;
using System;
using System.Windows.Forms;

namespace PointOfSaleUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
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
