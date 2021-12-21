using System.Windows.Forms;

namespace CricBlast_GUI.UI.User_Controls
{
    public partial class TournamentPlay : UserControl
    {
        public TournamentPlay()
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
