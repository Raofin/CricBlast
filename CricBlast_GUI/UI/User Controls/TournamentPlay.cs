using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Teams.Team;

namespace CricBlast_GUI.UI.User_Controls
{
    public partial class TournamentPlay : UserControl
    {
        private List<int> Teams { get; set; }
        private bool PlayAgain { get; set; }

        public TournamentPlay()
        {
            InitializeComponent();
            tournamentTitle.Text = Selected.TournamentTitle;
            GenerateTeams();
        }

        private void play_Click(object sender, EventArgs e)
        {
            if (PlayAgain) GenerateTeams();
            GenerateTournament();
        }

        private void GenerateTeams()
        {
            group11Logo.Image = group12Logo.Image = group13Logo.Image = group14Logo.Image = group15Logo.Image
                = group16Logo.Image = group17Logo.Image = group18Logo.Image = group21Logo.Image
                    = group22Logo.Image = group23Logo.Image = group24Logo.Image = group31Logo.Image
                        = group32Logo.Image = winnerLogo.Image = Properties.Resources.Question_Mark;
            Teams = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            Teams = Teams.OrderBy(x => Guid.NewGuid()).ToList();
            group11Logo.Image = GetLogo(Teams[0]);
            group12Logo.Image = GetLogo(Teams[1]);
            group13Logo.Image = GetLogo(Teams[2]);
            group14Logo.Image = GetLogo(Teams[3]);
            group15Logo.Image = GetLogo(Teams[4]);
            group16Logo.Image = GetLogo(Teams[5]);
            group17Logo.Image = GetLogo(Teams[6]);
            group18Logo.Image = GetLogo(Teams[7]);
        }

        private async void GenerateTournament()
        {
            play.Enabled = false;
            var random = new Random();
            Teams.RemoveAt(random.Next(0, 2));
            Teams.RemoveAt(random.Next(2, 3));
            Teams.RemoveAt(random.Next(3, 4));
            Teams.RemoveAt(random.Next(4, 5));
            await Task.Delay(500);
            group21Logo.Image = GetLogo(Teams[0]);
            await Task.Delay(500);
            group22Logo.Image = GetLogo(Teams[1]);
            await Task.Delay(500);
            group23Logo.Image = GetLogo(Teams[2]);
            await Task.Delay(500);
            group24Logo.Image = GetLogo(Teams[3]);
            Teams.RemoveAt(random.Next(0, 2));
            Teams.RemoveAt(random.Next(2, 3));
            await Task.Delay(500);
            group31Logo.Image = GetLogo(Teams[0]);
            await Task.Delay(500);
            group32Logo.Image = GetLogo(Teams[1]);
            Teams.RemoveAt(random.Next(0, 2));
            await Task.Delay(500);
            winnerLogo.Image = GetLogo(Teams[0]);
            await Task.Delay(1000);

            new TournamentResult(GetLogo(Teams[0]), GetStats(Teams[0], TeamName)).ShowDialog();
            if (!PlayAgain)
            {
                play.Text = "Play Again";
                PlayAgain = true;
            }
            play.Enabled = true;
        }
    }
}
