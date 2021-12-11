using System;
using System.Drawing;
using System.Windows.Forms;
using CricBlast_GUI.Home;
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

        private void Home_Load(object sender, EventArgs e)
        {
            new ChooseTeam().ShowDialog();
            homeSubPanel.Controls.Add(new MyTeam());
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
            homeSubPanel.Controls.Add(value: new PlayerStats());
            ChangeButtonColor(playerStats, 2);
        }

        private void customizeTeam_Click(object sender, EventArgs e)
        {
            if (SelectedMenu == 3) return;
            homeSubPanel.Controls.Clear();
            homeSubPanel.Controls.Add(value: new CustomizeTeam());
            ChangeButtonColor(customizeTeam, 3);
        }

        private void addPlayers_Click(object sender, EventArgs e)
        {
            if (SelectedMenu == 4) return;
            homeSubPanel.Controls.Clear();
            homeSubPanel.Controls.Add(value: new AddPlayer());
            ChangeButtonColor(addPlayers, 4);
        }

        public void playMatch_Click(object sender, EventArgs e)
        {
            if (SelectedMenu == 5) return;
            homeSubPanel.Controls.Clear();
            homeSubPanel.Controls.Add(value: new PlayMatch());
            ChangeButtonColor(playMatch, 5);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new MessageBoxYesNo(1, "Are you sure you want to log out?").ShowDialog();

            if (!Selected.MessageBox) return;
            Controls.Clear();
            Controls.Add(new Welcome { welcomeLabel = { Text = "Welcome Back!" } });
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

        private void userPhoto_Click(object sender, EventArgs e)
        {
            new Profile().ShowDialog();
        }

        private bool isAvailable = true;
        private void availability_Click(object sender, EventArgs e)
        {
            switch (isAvailable)
            {
                case true:
                    availability.Text = "Offline";
                    availabilityIcon.FillColor = Color.Gray;
                     isAvailable = false;
                    break;
                case false:
                    availability.Text = "Online";
                    availabilityIcon.FillColor = Color.LimeGreen;
                    isAvailable = true;
                    break;
            }
        }
    }
}
