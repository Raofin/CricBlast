using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricBlast_GUI.UI
{
    public partial class TournamentResult : Form
    {
        public TournamentResult(Image championTeamLogo, string championTeamName)
        {
            InitializeComponent();
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
