using System.Windows.Forms;

namespace CricBlast_GUI.Forms.Admin_Controls
{
    public partial class AdminPanel : UserControl
    {
        public AdminPanel()
        {
            InitializeComponent();
            adminSubPanel.Controls.Add(new ManageUser());
        }
    }
}
