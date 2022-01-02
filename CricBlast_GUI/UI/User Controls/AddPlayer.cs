using System;
using System.Drawing;
using System.Windows.Forms;

namespace CricBlast_GUI.UI.User_Controls
{
    public partial class AddPlayer : UserControl
    {
        public Image PlayerImage { get; set; }

        public AddPlayer()
        {
            InitializeComponent();
        }

        private void AddPlayer_Load(object sender, EventArgs e)
        {
            playerName.Focus();
        }

        private void choosePhotoButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog { Filter = Properties.Resources.ImageFilter })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    PlayerImage = playerPicture.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            playerNameError.Visible = string.IsNullOrWhiteSpace(playerName.Text);
            ageError.Visible = string.IsNullOrWhiteSpace(playerAge.Text);
            roleError.Visible = roleComboBox.SelectedIndex == 0;
            battingError.Visible = battingComboBox.SelectedIndex == 0;
            bowlingError.Visible = bowlingComboBox.SelectedIndex == 0;
            photoError.Visible = PlayerImage == null;

            if (!playerNameError.Visible && !ageError.Visible && !roleError.Visible &&
                !battingError.Visible && !bowlingError.Visible && !photoError.Visible)
            {
                new MessageBoxOk(0, "The player has been added successfully.").ShowDialog();
                playerName.Text = null;
                playerAge.Text = null;
                roleComboBox.SelectedIndex = 0;
                battingComboBox.SelectedIndex = 0;
                bowlingComboBox.SelectedIndex = 0;
                playerPicture.Image = Properties.Resources.User_Male_WhiteBack;
            }
            else new MessageBoxOk(2, "Please fill out all the fields properly.").ShowDialog();
        }
    }
}
