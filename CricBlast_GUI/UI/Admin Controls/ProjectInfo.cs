using System;
using System.Windows.Forms;

namespace CricBlast_GUI.UI.Admin_Controls
{
    public partial class ProjectInfo : UserControl
    {
        public ProjectInfo()
        {
            InitializeComponent();
        }

        private void infoPicture_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Raofin/CricBlast");
        }
    }
}
