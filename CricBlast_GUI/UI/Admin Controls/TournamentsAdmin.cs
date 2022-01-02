using System;
using System.Drawing;
using System.Windows.Forms;

namespace CricBlast_GUI.UI.Admin_Controls
{
    public partial class TournamentsAdmin : UserControl
    {
        public TournamentsAdmin()
        {
            InitializeComponent();
        }

        private void selectTeams_Click(object sender, EventArgs e)
        {
            new SelectTeams().ShowDialog();
        }

        private void selectStadiums_Click(object sender, EventArgs e)
        {
            new SelectStadium().ShowDialog();
        }

        private void choosePhoto_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog { Filter = Properties.Resources.ImageFilter })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    trophyPictureBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void startTournament_Click(object sender, EventArgs e)
        {
            titleError.Visible = string.IsNullOrWhiteSpace(titleTextBox.Text);
            countryError.Visible = hostingCountryComboBox.SelectedIndex == 0;
            teamsError.Visible = teamsComboBox.SelectedIndex == 0;

            if (titleError.Visible || countryError.Visible || teamsError.Visible)
                new MessageBoxOk(Selected.WarningMark, "Please fill out all the fields properly.").ShowDialog();
            else
            {
                Selected.TournamentTitle = titleTextBox.Text.ToUpper();
                Selected.TrophyImage = trophyPictureBox.Image;
                Selected.Tournament = true;
                new MessageBoxOk(0, "The tournament has begun.").ShowDialog();
            }
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            titleError.Visible = string.IsNullOrWhiteSpace(titleTextBox.Text);
        }

        private void hostingCountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            countryError.Visible = hostingCountryComboBox.SelectedIndex == 0;
        }

        private void teamsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamsError.Visible = teamsComboBox.SelectedIndex == 0;
        }

        private void titleTextBox_Load(object sender, EventArgs e)
        {
            titleTextBox.Focus();
        }
    }
}
