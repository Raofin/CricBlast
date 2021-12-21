using System;
using System.Drawing;
using System.Windows.Forms;

namespace CricBlast_GUI.UI.User_Controls
{
    public partial class PlayMatch : UserControl
    {
        public PlayMatch()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
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
                opponentSelectError.Visible = true;
                return;
            }

            if (ChooseTeam.TeamNumber(opponentComboBox) == Selected.UserTeam)
            {
                opponentSelectError.Visible = true;
                return;
            }

            Selected.OpponentTeam = ChooseTeam.TeamNumber(opponentComboBox);
            Selected.OpponentTeamLogo = (Bitmap) (opponentTeamLogo.Image = Teams.Team.GetLogo(Selected.OpponentTeam));
            opponentTeamLabel.Text = Teams.Team.GetStats(Selected.OpponentTeam, Teams.Team.TeamName);
            Selected.OpponentTeamPlayerStats = Players.Player.GetTeamPlayers(Selected.OpponentTeam);
            opponentSelectError.Visible = false;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            formatSelectError.Visible = formatComboBox.SelectedIndex == 0;
            pitchSelectError.Visible = pitchComboBox.SelectedIndex == 0;
            stadiumSelectError.Visible = stadiumComboBox.SelectedIndex == 0;
            
            if (opponentSelectError.Visible || formatSelectError.Visible || pitchSelectError.Visible ||
                stadiumSelectError.Visible)
            {
                new MessageBoxOk(Selected.WarningMark, "Please select the fields properly.").ShowDialog();
                return;
            }

            playButton.Visible = false;
            playAgainButton.Visible = true;
            backButton.Visible = true;
            gamePanel.Controls.Add(new GamePlayPanel());
            gamePanel.Controls["GamePlayPanel"].BringToFront();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            gamePanel.Controls.RemoveByKey("GamePlayPanel");
            gamePanel.Controls.Add(new GamePlayPanel());
            gamePanel.Controls["GamePlayPanel"].BringToFront();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            playButton.Visible = true;
            playAgainButton.Visible = false;
            backButton.Visible = false;
            gamePanel.Controls.RemoveByKey("GamePlayPanel");
        }

        private void formatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            formatSelectError.Visible = formatComboBox.SelectedIndex == 0 || formatComboBox.SelectedIndex == 3;
            switch (formatComboBox.SelectedIndex)
            {
                case 1:
                    GamePlayPanel.MatchFormat = 1;
                    matchTitle.Text = "TWENTY-20 INTERNATIONAL";
                    break;
                case 2:
                    GamePlayPanel.MatchFormat = 2;
                    matchTitle.Text = "ONE DAY INTERNATIONAL";
                    break;
                case 3:
                    new MessageBoxOk(Selected.WarningMark, "This feature is not currently available.").ShowDialog();
                    matchTitle.Text = "Play Match";
                    formatComboBox.SelectedIndex = 0;
                    //formatSelectError.Visible = true;
                    break;
                default:
                    formatSelectError.Visible = true;
                    break;
            }
        }

        private void pitchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pitchSelectError.Visible = pitchComboBox.SelectedIndex == 0;
        }

        private void stadiumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stadiumSelectError.Visible = stadiumComboBox.SelectedIndex == 0;
        }
    }
}
