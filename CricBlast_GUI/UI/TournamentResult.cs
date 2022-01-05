using System;
using System.Drawing;
using System.Windows.Forms;

namespace CricBlast_GUI.UI
{
    public partial class TournamentResult : Form
    {
        public TournamentResult(Image championTeamLogo, string championTeamName)
        {
            InitializeComponent();
            Icon = Properties.Resources.CricBlast;
            tournamentTitle.Text = Selected.TournamentTitle;
            trophyPicture.Image = Selected.TrophyImage;
            this.championTeamLogo.Image = championTeamLogo;
            this.championTeamName.Text = championTeamName;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
