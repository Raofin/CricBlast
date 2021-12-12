using System;
using System.Windows.Forms;
using CricBlast_GUI.Home;

namespace CricBlast_GUI.Forms
{
    public partial class ChooseTeam : Form
    {
        public ChooseTeam()
        {
            InitializeComponent();
        }
        
        private void ChooseTeam_Load(object sender, EventArgs e)
        {
            teamComboBox.SelectedIndex = Selected.UserTeam == 0 ? 0 : Selected.UserTeam;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (teamComboBox.SelectedIndex == 0)
            {
                teamSelectError.Visible = true;
                return;
            }

            Selected.UserTeam = TeamNumber(teamComboBox.SelectedItem.ToString());
            Selected.UserTeamLogo = Teams.Team.GetLogo(Selected.UserTeam);
            Selected.UserTeamPlayerStats = Players.Player.GetTeamPlayers(Selected.UserTeam);
            Close();
        }

        private void teamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamSelectError.Visible = teamComboBox.SelectedIndex == 0;
        }

        private int TeamNumber(string selectedTeam)
        {
            switch (selectedTeam.Trim())
            {
                case "Australia":
                    return 1;
                case "Bangladesh":
                    return 2;
                case "India":
                    return 3;
                case "New Zealand":
                    return 4;
                case "Pakistan":
                    return 5;
                case "South Africa":
                    return 6;
                case "Sri Lanka":
                    return 7;
                case "West Indies":
                    return 8;
                default:
                    return 0;
            }
        }
    }
}