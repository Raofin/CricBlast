using System;
using System.Windows.Forms;
using Players;
using Teams;

namespace CricBlast_GUI.UI.User_Controls
{
    public partial class PlayerStats : UserControl
    {
        public PlayerStats()
        {
            InitializeComponent();
        }

        private void PlayerStats_Load(object sender, EventArgs e)
        {
            changeFormatComboBox.Items.Add("T20I");
            changeFormatComboBox.Items.Add("ODI");
            changeFormatComboBox.Items.Add("Test");

            for (int i = 0; i < 15; i++) changePlayerComboBox.Items.Add(Selected.UserTeamPlayerStats[i, 0, 0]);

            changePlayerComboBox.SelectedIndex = Selected.Player;
            changeFormatComboBox.SelectedIndex = Selected.Format;
            SetStats();
        }

        private void changePlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected.Player = changePlayerComboBox.SelectedIndex;
            SetStats();
        }

        private void changeFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected.Format = changeFormatComboBox.SelectedIndex;
            SetStats();
        }

        private void SetStats()
        {
            playerPhoto.Image = Player.GetPlayerImage(Selected.UserTeam, changePlayerComboBox.SelectedIndex);
            userTeamName.Text = Team.GetStats(Selected.UserTeam, Team.TeamName);
            playerName.Text = GetStats(0);
            matches.Text = GetStats(1);
            runs.Text = GetStats(2);
            average.Text = GetStats(3);
            strikeRate.Text = GetStats(4);
            hundreds.Text = GetStats(5);
            fifties.Text = GetStats(6);
            wickets.Text = GetStats(7);
        }

        private string GetStats(int stats)
        {
            return Selected.UserTeamPlayerStats[Selected.Player, Selected.Format, stats];
        }
    }
}
