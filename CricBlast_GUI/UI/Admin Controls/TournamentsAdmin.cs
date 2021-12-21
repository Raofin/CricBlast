using System;
using System.Drawing;
using System.Windows.Forms;

namespace CricBlast_GUI.UI.Admin_Controls
{
    public partial class TournamentsAdmin : UserControl
    {
        public TournamentsAdmin()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
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
            new MessageBoxOk(0, "The tournament has begun.").ShowDialog();
        }
    }
}
