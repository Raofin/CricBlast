using System;
using System.Windows.Forms;

namespace CricBlast_GUI.UI
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void infoPictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Raofin/CricBlast");
        }
    }
}
