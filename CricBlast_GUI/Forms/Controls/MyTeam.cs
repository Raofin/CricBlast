using System;
using System.Windows.Forms;
using static CricBlast_GUI.Home.Selected;
using static Teams.Team;

namespace CricBlast_GUI.Forms.Controls
{
    public partial class MyTeam : UserControl
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public MyTeam()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.ContainerControl |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.SupportsTransparentBackColor
                , true);
            InitializeComponent();
            SetStats();
        }

        private void changeTeam_Click(object sender, EventArgs e)
        {
            new ChooseTeam().ShowDialog();
            SetStats();
        }

        private void SetStats()
        {
            teamLogo.Image = UserTeamLogo;
            teamName.Text = UserTeamName;
            UserTeamStats = GetAllStats(UserTeam);
            teamName.Visible = true;
            teamLogo.Visible = true;

            testMatch.Text = UserTeamStats[TestMatch];
            testWon.Text = UserTeamStats[TestWon];
            testLost.Text = UserTeamStats[TestLost];

            odiMatch.Text = UserTeamStats[OdiMatch];
            odiWon.Text = UserTeamStats[OdiWon];
            odiLost.Text = UserTeamStats[OdiLost];

            t20iMatch.Text = UserTeamStats[T20IMatch];
            t20iWon.Text = UserTeamStats[T20IWon];
            t20iLost.Text = UserTeamStats[T20ILost];
        }
    }
}
