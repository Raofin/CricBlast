using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using CricBlast_GUI.UI.User_Controls;
using Guna.UI2.WinForms;

namespace CricBlast_GUI.UI.Admin_Controls
{
    public partial class AdminPanel : UserControl
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, System.EventArgs e)
        {
            adminSubPanel.Controls.Clear();
            var threadParameters = new ThreadStart(() =>
            {
                Invoke((Action)(() =>
                {
                    adminSubPanel.Controls.Add(value: new Dashboard());
                    loading.Visible = false;
                }));
            });
            var thread = new Thread(threadParameters);
            thread.Start();
        }

        public int SelectedMenu = 1;

        private void logout_Click(object sender, System.EventArgs e)
        {
            new MessageBoxYesNo(1, "Are you sure you want to log out?").ShowDialog();

            if (!Selected.MessageBoxYesOrNo) return;

            Controls.Clear();
            Controls.Add(new Welcome { welcomeLabel = { Text = "Welcome Back!" } });
        }

        private bool _isAvailable = true;

        private void availability_Click(object sender, System.EventArgs e)
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

        private void dashboard_Click(object sender, System.EventArgs e)
        {
            if (SelectedMenu == 1) return;
            ChangeButtonColor(dashboard, 1);

            var threadParameters = new ThreadStart(() =>
            {
                Invoke((Action)(() =>
                {
                    adminSubPanel.Controls.Add(value: new Dashboard());
                    loading.Visible = false;
                }));
            });
            var thread = new Thread(threadParameters);
            thread.Start();
        }

        private void tournaments_Click(object sender, System.EventArgs e)
        {
            if (SelectedMenu == 2) return;
            ChangeButtonColor(tournament, 2);

            var threadParameters = new ThreadStart(() =>
            {
                Invoke((Action)(() =>
                {
                    adminSubPanel.Controls.Add(value: new TournamentsAdmin());
                    loading.Visible = false;
                }));
            });
            var thread = new Thread(threadParameters);
            thread.Start();
        }

        private void addUser_Click(object sender, System.EventArgs e)
        {
            if (SelectedMenu == 3) return;
            ChangeButtonColor(addUser, 3);

            var threadParameters = new ThreadStart(() =>
            {
                Invoke((Action)(() =>
                {
                    adminSubPanel.Controls.Add(value: new AddUser());
                    loading.Visible = false;
                }));
            });
            var thread = new Thread(threadParameters);
            thread.Start();
        }

        private void manageUser_Click(object sender, System.EventArgs e)
        {
            if (SelectedMenu == 4) return;
            ChangeButtonColor(manageUser, 4);

            var threadParameters = new ThreadStart(() =>
            {
                Invoke((Action)(() =>
                {
                    adminSubPanel.Controls.Add(value: new ManageUser());
                    loading.Visible = false;
                }));
            });
            var thread = new Thread(threadParameters);
            thread.Start();
        }

        private void projectDetails_Click(object sender, System.EventArgs e)
        {
            if (SelectedMenu == 5) return;
            ChangeButtonColor(projectDetails, 5);

            var threadParameters = new ThreadStart(() =>
            {
                Invoke((Action)(() =>
                {
                    adminSubPanel.Controls.Add(value: new ProjectInfo());
                    loading.Visible = false;
                }));
            });
            var thread = new Thread(threadParameters);
            thread.Start();
        }

        private void ChangeButtonColor(Guna2Button button, int changeMenu)
        {
            button.FillColor = Color.FromArgb(246, 161, 47);
            adminSubPanel.Controls.Clear();
            loading.Visible = true;

            switch (SelectedMenu)
            {
                case 1:
                    dashboard.FillColor = Color.Transparent;
                    break;
                case 2:
                    tournament.FillColor = Color.Transparent;
                    break;
                case 3:
                    addUser.FillColor = Color.Transparent;
                    break;
                case 4:
                    manageUser.FillColor = Color.Transparent;
                    break;
                case 5:
                    projectDetails.FillColor = Color.Transparent;
                    break;
            }

            SelectedMenu = changeMenu;
        }

        private void logoPicture_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Raofin/CricBlast");
        }
    }
}
