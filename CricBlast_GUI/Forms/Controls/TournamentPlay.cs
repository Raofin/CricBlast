using System.Windows.Forms;

namespace CricBlast_GUI.Forms.Controls
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
