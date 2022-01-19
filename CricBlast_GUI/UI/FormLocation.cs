using System;
using System.Drawing;
using System.Windows.Forms;

namespace CricBlast_GUI.UI
{
    public static class FormLocation
    {
        public static void CenterToScreen(Form form)
        {
            var screen = Screen.FromControl(form);

            var workingArea = screen.WorkingArea;
            form.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - form.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - form.Height) / 2)
            };
        }
    }
}
