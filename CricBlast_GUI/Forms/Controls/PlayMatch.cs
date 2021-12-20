using System;
using System.Drawing;
using System.Windows.Forms;
using CricBlast_GUI.Home;

namespace CricBlast_GUI.Forms.Controls
{
    public partial class PlayMatch : UserControl
    {
        public PlayMatch()
        {
            InitializeComponent();
            userTeamLabel.Text = Teams.Team.GetStats(Selected.UserTeam, Teams.Team.TeamName);
            userTeamLogo.Image = Selected.UserTeamLogo;

        }

        private void opponentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (opponentComboBox.SelectedIndex == 0)
            {
                opponentTeamLogo.Image = Properties.Resources.Question_Mark;
                opponentTeamLabel.Text = "";
                teamSelectError.Visible = true;
                return;
            }

            if (ChooseTeam.TeamNumber(opponentComboBox) == Selected.UserTeam)
            {
                teamSelectError.Visible = true;
                return;
            }

            Selected.OpponentTeam = ChooseTeam.TeamNumber(opponentComboBox);
            Selected.OpponentTeamLogo = (Bitmap)(opponentTeamLogo.Image = Teams.Team.GetLogo(Selected.OpponentTeam));
            opponentTeamLabel.Text = Teams.Team.GetStats(Selected.OpponentTeam, Teams.Team.TeamName);
            Selected.OpponentTeamPlayerStats = Players.Player.GetTeamPlayers(Selected.OpponentTeam);
            teamSelectError.Visible = false;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            gamePlayPanel.Controls.Clear();
            gamePlayPanel.Controls.Add(new GamePlayPanel());
        }
    }
}
