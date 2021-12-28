using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace CricBlast_GUI.UI.User_Controls
{
    public partial class TournamentPlay : UserControl
    {
        public TournamentPlay()
        {
            InitializeComponent();
        }

        private async Task Generate()
        {
            okButton.Enabled = false;
            var teams = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            teams = teams.OrderBy(a => Guid.NewGuid()).ToList();
            var random = new Random();
            group11Logo.Image = Teams.Team.GetLogo(teams[0]);
            group12Logo.Image = Teams.Team.GetLogo(teams[1]);
            group13Logo.Image = Teams.Team.GetLogo(teams[2]);
            group14Logo.Image = Teams.Team.GetLogo(teams[3]);
            group15Logo.Image = Teams.Team.GetLogo(teams[4]);
            group16Logo.Image = Teams.Team.GetLogo(teams[5]);
            group17Logo.Image = Teams.Team.GetLogo(teams[6]);
            group18Logo.Image = Teams.Team.GetLogo(teams[7]);
            teams.RemoveAt(random.Next(0, 2));
            teams.RemoveAt(random.Next(2, 3));
            teams.RemoveAt(random.Next(3, 4));
            teams.RemoveAt(random.Next(4, 5));
            await Task.Delay(1000);
            group21Logo.Image = Teams.Team.GetLogo(teams[0]);
            await Task.Delay(1000);
            group22Logo.Image = Teams.Team.GetLogo(teams[1]);
            await Task.Delay(1000);
            group23Logo.Image = Teams.Team.GetLogo(teams[2]);
            await Task.Delay(1000);
            group24Logo.Image = Teams.Team.GetLogo(teams[3]);
            teams.RemoveAt(random.Next(0, 2));
            teams.RemoveAt(random.Next(2, 3));
            await Task.Delay(1000);
            group31Logo.Image = Teams.Team.GetLogo(teams[0]);
            await Task.Delay(1000);
            group32Logo.Image = Teams.Team.GetLogo(teams[1]);
            teams.RemoveAt(random.Next(0, 2));
            await Task.Delay(1000);
            winnerLogo.Image = Teams.Team.GetLogo(teams[0]);
            okButton.Enabled = true;
        }

        private void ResetTeamLogos()
        {
            group11Logo.Image = Properties.Resources.Question_Mark;
            group12Logo.Image = Properties.Resources.Question_Mark;
            group13Logo.Image = Properties.Resources.Question_Mark;
            group14Logo.Image = Properties.Resources.Question_Mark;
            group15Logo.Image = Properties.Resources.Question_Mark;
            group16Logo.Image = Properties.Resources.Question_Mark;
            group17Logo.Image = Properties.Resources.Question_Mark;
            group18Logo.Image = Properties.Resources.Question_Mark;
            group21Logo.Image = Properties.Resources.Question_Mark;
            group22Logo.Image = Properties.Resources.Question_Mark;
            group23Logo.Image = Properties.Resources.Question_Mark;
            group24Logo.Image = Properties.Resources.Question_Mark;
            group31Logo.Image = Properties.Resources.Question_Mark;
            group32Logo.Image = Properties.Resources.Question_Mark;
            winnerLogo.Image = Properties.Resources.Question_Mark;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            ResetTeamLogos();
            Generate();
        }
    }
}
