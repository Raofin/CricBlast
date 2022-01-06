using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace CricBlast_GUI.UI.User_Controls
{
    public partial class Home : UserControl
    {
        public int SelectedMenu = 1;
        private bool _isAvailable = true;

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = Selected.UserDetails[1];
            userPhoto.Image = Selected.UserImage;
            new ChooseTeam().ShowDialog();

            var threadParameters = new ThreadStart(() =>
            {
                Invoke((Action)(() =>
                {
                    homeSubPanel.Controls.Add(value: new MyTeam());
                    loading.Visible = false;
                }));
            });
            var thread = new Thread(threadParameters);
            thread.Start();
        }

        private void myTeam_Click(object sender, EventArgs e)
        {
            if (SelectedMenu == 1) return;
            ChangeButtonColor(myTeam, 1);

            var threadParameters = new ThreadStart(() =>
            {
                Invoke((Action)(() =>
                {
                    homeSubPanel.Controls.Add(value: new MyTeam());
                    loading.Visible = false;
                }));
            });
            var thread = new Thread(threadParameters);
            thread.Start();
        }

        private void playerStats_Click(object sender, EventArgs e)
        {
            if (SelectedMenu == 2) return;
            ChangeButtonColor(playerStats, 2);

            var threadParameters = new ThreadStart(() =>
            {
                Invoke((Action)(() =>
                {
                    homeSubPanel.Controls.Add(value: new PlayerStats());
                    loading.Visible = false;
                }));
            });
            var thread = new Thread(threadParameters);
            thread.Start();
        }

        private void customizeTeam_Click(object sender, EventArgs e)
        {
            if (SelectedMenu == 3) return;
            ChangeButtonColor(customizeTeam, 3);

            var threadParameters = new ThreadStart(() =>
            {
                Invoke((Action)(() =>
                {
                    homeSubPanel.Controls.Add(value: new CustomizeTeam());
                    loading.Visible = false;
                }));
            });
            var thread = new Thread(threadParameters);
            thread.Start();
        }

        private void addPlayers_Click(object sender, EventArgs e)
        {
            if (SelectedMenu == 4) return;
            ChangeButtonColor(addPlayers, 4);

            var threadParameters = new ThreadStart(() =>
            {
                Invoke((Action)(() =>
                {
                    homeSubPanel.Controls.Add(value: new AddPlayer());
                    loading.Visible = false;
                }));
            });
            var thread = new Thread(threadParameters);
            thread.Start();
        }

        public void playMatch_Click(object sender, EventArgs e)
        {
            if (SelectedMenu == 5) return;
            ChangeButtonColor(playMatch, 5);

            var threadParameters = new ThreadStart(() =>
            {
                Invoke((Action)(() =>
                {
                    homeSubPanel.Controls.Add(value: new PlayMatch());
                    loading.Visible = false;
                }));
            });
            var thread = new Thread(threadParameters);
            thread.Start();
        }

        private void tournament_Click(object sender, EventArgs e)
        {
            if (SelectedMenu == 6) return;
            ChangeButtonColor(tournament, 6);

            var threadParameters = new ThreadStart(() =>
            {
                Invoke((Action)(() =>
                {
                    if (Selected.Tournament)
                        homeSubPanel.Controls.Add(value: new TournamentPlay());
                    else
                        homeSubPanel.Controls.Add(value: new TournamentPlayError());
                    loading.Visible = false;
                }));
            });
            var thread = new Thread(threadParameters);
            thread.Start();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new MessageBoxYesNo(1, "Are you sure you want to log out?").ShowDialog();
            if (!Selected.MessageBoxYesOrNo) return;

            clearUserDetails();
            Controls.Clear();
            Controls.Add(new Welcome { welcomeLabel = { Text = "Welcome Back!" } });
        }

        private void clearUserDetails()
        {
            Array.Clear(Selected.UserDetails, 0, Selected.UserDetails.Length);
            Selected.UserImage = null;
            Selected.UserTeam = 0;
            Selected.OpponentTeam = 0;
            Selected.UserTeamLogo = null;
            Array.Clear(Selected.UserTeamStats, 0, Selected.UserTeamStats.Length);
            Array.Clear(Selected.UserTeamPlayerStats, 0, Selected.UserTeamPlayerStats.Length);
            Selected.Player = 0;
            Selected.Format = 0;
        }

        private void ChangeButtonColor(Guna2Button button, int changeMenu)
        {
            button.FillColor = Color.FromArgb(246, 161, 47);
            homeSubPanel.Controls.Clear();
            loading.Visible = true;

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
                case 6:
                    tournament.FillColor = Color.Transparent;
                    break;
            }

            SelectedMenu = changeMenu;
        }

        private void userPhoto_Click(object sender, EventArgs e)
        {
            new Profile().ShowDialog();
            usernameLabel.Text = Selected.UserDetails[1];
            userPhoto.Image = Selected.UserImage;
        }

        private void availability_Click(object sender, EventArgs e)
        {
            if (_isAvailable)
            {
                availability.Text = "Offline";
                availabilityIcon.FillColor = Color.Gray;
                _isAvailable = false;
            }
            else
            {
                availability.Text = "Online";
                availabilityIcon.FillColor = Color.LimeGreen;
                _isAvailable = true;
            }
        }

        private void logoPicture_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Raofin/CricBlast");
        }

        private void cricBlastLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Raofin/CricBlast");
        }
    }
}
