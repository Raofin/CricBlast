using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricBlast_GUI.Forms.Controls
{
    public partial class AddPlayer : UserControl
    {
        public Image PlayerImage { get; set; }

        public AddPlayer()
        {
            InitializeComponent();
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

            if (!playerNameError.Visible && !ageError.Visible && !roleError.Visible && !battingError.Visible &&
                !bowlingError.Visible && !photoError.Visible)
            {
                new MessageBoxOk(0, "The player has been added successfully.").ShowDialog();
            }
            else
            {
                new MessageBoxOk(2, "Please fill out all the fields properly.").ShowDialog();
            }
        }
    }
}
