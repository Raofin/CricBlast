using System;
using System.Windows.Forms;
using CricBlast_GUI.Home;
using Players;

namespace CricBlast_GUI.Forms.Controls
{
    public partial class PlayerStats : UserControl
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public PlayerStats()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
            InitializeComponent();
        }

        private void PlayerStats_Load(object sender, EventArgs e)
        {
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
            playerPhoto.Image = Images.GetPlayerImage(Selected.UserTeam, changePlayerComboBox.SelectedIndex);
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
