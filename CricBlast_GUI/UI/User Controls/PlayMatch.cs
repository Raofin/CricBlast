using System;
using System.Drawing;
using System.Windows.Forms;

namespace CricBlast_GUI.UI.User_Controls
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
                opponentSelectError.Visible = true;
                return;
            }

            if (ChooseTeam.TeamNumber(opponentComboBox) == Selected.UserTeam)
            {
                opponentSelectError.Visible = true;
                return;
            }

            Selected.OpponentTeam = ChooseTeam.TeamNumber(opponentComboBox);
            Selected.OpponentTeamName = opponentComboBox.SelectedItem.ToString();
            Selected.OpponentTeamLogo = (Bitmap) (opponentTeamLogo.Image = Teams.Team.GetLogo(Selected.OpponentTeam));
            opponentTeamLabel.Text = Teams.Team.GetStats(Selected.OpponentTeam, Teams.Team.TeamName);
            Selected.OpponentTeamPlayerStats = Players.Player.GetTeamPlayers(Selected.OpponentTeam);
            opponentSelectError.Visible = false;
        }

        private bool _playMode;

        private void playButton_Click(object sender, EventArgs e)
        {
            switch (_playMode)
            {
                case true:
                    gamePanel.Controls.RemoveByKey("GamePlayPanel");
                    gamePanel.Controls.Add(new GamePlayPanel());
                    gamePanel.Controls["GamePlayPanel"].BringToFront();
                    break;
                case false:
                    formatSelectError.Visible = formatComboBox.SelectedIndex == 0;
                    pitchSelectError.Visible = pitchComboBox.SelectedIndex == 0;
                    stadiumSelectError.Visible = stadiumComboBox.SelectedIndex == 0;

                    if (opponentSelectError.Visible || formatSelectError.Visible || pitchSelectError.Visible ||
                        stadiumSelectError.Visible)
                    {
                        new MessageBoxOk(Selected.WarningMark, "Please select the fields properly.").ShowDialog();
                        return;
                    }
                    gamePanel.Controls.Add(new GamePlayPanel());
                    gamePanel.Controls["GamePlayPanel"].BringToFront();

                    playButton.Text = "Play Again";
                    matchHistoryButton.Text = "Back";
                    _playMode = true;
                    break;
            }
        }

        private void matchHistoryButton_Click(object sender, EventArgs e)
        {
            switch (_playMode)
            {
                case true:
                    gamePanel.Controls.RemoveByKey("GamePlayPanel");
                    playButton.Text = "Play";
                    matchHistoryButton.Text = "View History";
                    _playMode = false;
                    break;
                case false:
                    new MatchHistory().ShowDialog();
                    break;
            }
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
                    matchTitle.Text = "Play A Match";
                    formatComboBox.SelectedIndex = 0;
                    break;
                default:
                    formatSelectError.Visible = true;
                    break;
            }
        }

        private void pitchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pitchSelectError.Visible = pitchComboBox.SelectedIndex == 0;

            switch (pitchComboBox.SelectedIndex)
            {
                case 1:
                    GamePlayPanel.Pitch = 1;
                    break;
                case 2: 
                    GamePlayPanel.Pitch = 2;
                    break;
                case 3:
                    GamePlayPanel.Pitch = 3;
                    break;
                default:
                    pitchSelectError.Visible = true;
                    break;
            }
        }

        private void stadiumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stadiumSelectError.Visible = stadiumComboBox.SelectedIndex == 0;
        }
    }
}
