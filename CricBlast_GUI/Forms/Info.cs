using System;
using System.Windows.Forms;

namespace CricBlast_GUI.Forms
{
    public partial class Info : Form
    {
        public Info()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
            InitializeComponent();
        }

        private void infoPictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Raofin/CricBlast");
        }
    }
}
