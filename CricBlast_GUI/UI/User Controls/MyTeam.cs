using System;
using System.Windows.Forms;
using static CricBlast_GUI.UI.Selected;
using static Teams.Team;

namespace CricBlast_GUI.UI.User_Controls
{
    public partial class MyTeam : UserControl
    {
        public MyTeam()
        {
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
