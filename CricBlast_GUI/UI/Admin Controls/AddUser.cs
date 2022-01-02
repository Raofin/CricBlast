using System;
using System.Drawing;
using System.Windows.Forms;
using CricBlast_GUI.Database;

namespace CricBlast_GUI.UI.Admin_Controls
{
    public partial class AddUser : UserControl
    {
        private int Gender { get; set; }
        private Image UserPicture { get; set; }
        private bool _eye;

        public AddUser()
        {
            InitializeComponent();
            allUserGridPanel.Controls.Add(new UserList());
            allUserGridPanel.Controls["UserList"].Dock = DockStyle.Fill;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            usernameError.Visible = string.IsNullOrWhiteSpace(usernameTextBox.Text);
            emailError.Visible = string.IsNullOrWhiteSpace(emailTextBox.Text);
            passwordError.Visible = string.IsNullOrWhiteSpace(passwordTextBox.Text);
            mobileError.Visible = string.IsNullOrWhiteSpace(mobileTextBox.Text);
            photoError.Visible = UserPicture == null;
            genderError.Visible = !genderRadioMale.Checked && !genderRadioFemale.Checked;

            if (usernameError.Visible || emailError.Visible || passwordError.Visible || mobileError.Visible ||
                photoError.Visible || genderError.Visible)
                new MessageBoxOk(Selected.WarningMark, "Please fill out all the fields properly.").ShowDialog();
            else
            {
                if (Account.IsUnique(emailTextBox.Text))
                    new MessageBoxOk(Selected.ErrorMark, "That email address is already in use by another account.")
                        .ShowDialog();
                else
                {
                    Account.Create(usernameTextBox.Text, emailTextBox.Text, passwordTextBox.Text,
                        mobileTextBox.Text, Gender, UserPicture);
                    new MessageBoxOk(Selected.CheckMark, "The user has been added successfully.")
                        .ShowDialog();

                    usernameTextBox.Text = "";
                    emailTextBox.Text = "";
                    passwordTextBox.Text = "";
                    mobileTextBox.Text = "";
                    genderRadioMale.Checked = genderRadioFemale.Checked = false;
                    userPictureBox.Image = Properties.Resources.Unknown_User;
                    UserPicture = null;

                    allUserGridPanel.Controls.Clear();
                    allUserGridPanel.Controls.Add(new UserList());
                    allUserGridPanel.Controls["UserList"].Dock = DockStyle.Fill;

                }
            }
        }

        private void eyePicture_Click(object sender, EventArgs e)
        {
            switch (_eye)
            {
                case true:
                    eyePicture.Image = Properties.Resources.Eye_Close;
                    _eye = false;
                    passwordTextBox.UseSystemPasswordChar = true;
                    return;
                case false:
                    eyePicture.Image = Properties.Resources.Eye_Open;
                    _eye = true;
                    passwordTextBox.UseSystemPasswordChar = false;
                    break;
            }
        }

        private void choosePhoto_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog { Filter = Properties.Resources.ImageFilter })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    UserPicture = userPictureBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void genderRadioMale_CheckedChanged(object sender, EventArgs e)
        {
            if (UserPicture != null) return;
            userPictureBox.Image = Properties.Resources.User_Male;
            Gender = 1;
            genderError.Visible = false;
        }

        private void genderRadioFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (UserPicture != null) return;
            userPictureBox.Image = Properties.Resources.User_Female;
            Gender = 0;
            genderError.Visible = false;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            usernameError.Visible = false;
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            emailError.Visible = false;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordError.Visible = false;
        }

        private void mobileTextBox_TextChanged(object sender, EventArgs e)
        {
            mobileError.Visible = false;
        }

        private void usernameTextBox_Load(object sender, EventArgs e)
        {
            usernameTextBox.Focus();
        }
    }
}
