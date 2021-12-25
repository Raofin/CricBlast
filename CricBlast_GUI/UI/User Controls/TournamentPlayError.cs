using System.Windows.Forms;

namespace CricBlast_GUI.UI.User_Controls
{
    public partial class TournamentPlayError : UserControl
    {
        public TournamentPlayError()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
            InitializeComponent();
        }
    }
}
