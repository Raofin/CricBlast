using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace CricBlast_GUI.Forms.Controls
{
    public partial class Home : UserControl
    {

        public Home()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
            InitializeComponent();
        }

        public int SelectedMenu = 1;
        private void myTeam_Click(object sender, EventArgs e)
        {
            if (SelectedMenu == 1) return;
            homeSubPanel.Controls.Clear();
            homeSubPanel.Controls.Add(value: new MyTeam());
            ChangeButtonColor(myTeam, 1);
        }

        private void playerStats_Click(object sender, EventArgs e)
        {
            if (SelectedMenu == 2) return;
            homeSubPanel.Controls.Clear();
            homeSubPanel.Controls.Add(new PlayerStats());
            ChangeButtonColor(playerStats, 2);
        }

        private void customizeTeam_Click(object sender, EventArgs e)
        {
            if (SelectedMenu == 3) return;
            ChangeButtonColor(customizeTeam, 3);
        }

        private void addPlayers_Click(object sender, EventArgs e)
        {
            if (SelectedMenu == 4) return;
            ChangeButtonColor(addPlayers, 4);
        }

        private void playMatch_Click(object sender, EventArgs e)
        {
            if (SelectedMenu == 5) return;
            ChangeButtonColor(playMatch, 5);
        }

        private void changeTeam_Click(object sender, EventArgs e)
        {
            new ChooseTeam().ShowDialog();
        }

        private void ChangeButtonColor(Guna2Button button, int changeMenu)
        {
            button.FillColor = Color.FromArgb(246, 161, 47);

            switch (SelectedMenu)
            {
                case 1:
                    myTeam.FillColor = Color.Transparent;
                    break;
                case 2:
                    playerStats.FillColor = Color.Transparent;
                    break;
                case 3:
                    customizeTeam.FillColor = Color.Transparent;
                    break;
                case 4:
                    addPlayers.FillColor = Color.Transparent;
                    break;
                case 5:
                    playMatch.FillColor = Color.Transparent;
                    break;
            }

            SelectedMenu = changeMenu;
        }
    }
}
