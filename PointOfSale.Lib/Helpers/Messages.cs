using System;
using System.Drawing;
using System.Windows.Forms;

namespace PointOfSale.Lib.Helpers
{
    public static class Messages
    {
        public static void DisplayMessage(String message, Label label, Color color,int Interval = 3000)
        {
            try
            {
                System.Timers.Timer timer = new System.Timers.Timer();
                timer.Interval = Interval;
                label.Invoke(new Action(() => label.Text = message));
                label.Invoke(new Action(() => label.Visible = true));
                label.Invoke(new Action(() => label.BackColor = color));
                timer.Elapsed += (s, en) =>
                {
                    try
                    {
                        label.Invoke(new Action(() => label.Visible = false));
                        timer.Stop();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                };
                timer.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
