using System;
using System.Drawing;
using System.Windows.Forms;

namespace PointOfSale.Lib.Helpers
{
    public static class Messages
    {
        public static void DisplayMessage(String message, Label label, Color color,int Interval = 3000)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = Interval;
            label.Invoke(new Action(() => label.Text = message));
            label.Invoke(new Action(() => label.Visible = true));
            label.Invoke(new Action(() => label.BackColor = color));
            // above two line sets the visibility and shows the message and interval elapses hide the visibility of the label. Elapsed will we called after Start() method.

            timer.Elapsed += (s, en) => {
                label.Invoke(new Action(() => label.Visible = false));
                timer.Stop(); // Stop the timer(otherwise keeps on calling)
            };
            timer.Start(); // Starts the timer. 
        }
    }
}
