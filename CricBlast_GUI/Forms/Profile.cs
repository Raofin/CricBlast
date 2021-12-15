using System;
using System.Drawing;
using System.Windows.Forms;
using CricBlast_GUI.Database;
using static CricBlast_GUI.Home.Selected;

namespace CricBlast_GUI.Forms
{
    public partial class Profile : Form
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

        public Profile()
        {
            InitializeComponent();
            loadProfile();
        }

        private void loadProfile()
        {
            usernameLabel.Text = UserDetails[1];
            emailLabel.Text = UserDetails[2];
            passwordLabel.Text = UserDetails[3];
            phoneLabel.Text = UserDetails[4];
            userCirclePicture.Image = UserImage;

            if (UserDetails[5].Equals("0"))
            {
                genderLabel.Text = "Female";
                genderPicture.Image = Properties.Resources.User_Female;
            }
            else
            {
                genderLabel.Text = "Male";
                genderPicture.Image = Properties.Resources.User_Male;
            }
        }

        private bool modify;

        private void modify_Click(object sender, EventArgs e)
        {
            if (modify)
            {
                usernameError.Visible = string.IsNullOrWhiteSpace(usernameTextBox.Text);
                emailError.Visible = string.IsNullOrWhiteSpace(emailTextBox.Text);
                passwordError.Visible = string.IsNullOrWhiteSpace(passwordTextBox.Text);
                mobileError.Visible = string.IsNullOrWhiteSpace(phoneTextBox.Text);

                if (usernameError.Visible || emailError.Visible || passwordError.Visible || mobileError.Visible)
                {
                    new MessageBoxOk(WarningMark, "Please fill out all the fields properly.").ShowDialog();
                    return;
                }

                UserDetails[1] = usernameLabel.Text = usernameTextBox.Text;
                UserDetails[2] = emailLabel.Text = emailTextBox.Text;
                UserDetails[3] = passwordLabel.Text = passwordTextBox.Text;
                UserDetails[4] = phoneLabel.Text = phoneTextBox.Text;

                usernameLabel.Visible = emailLabel.Visible = passwordLabel.Visible = phoneLabel.Visible = true;
                usernameTextBox.Visible = emailTextBox.Visible = passwordTextBox.Visible = phoneTextBox.Visible = false;
                modifyButton.Text = "Modify";
                modifyButton.FillColor = Color.FromArgb(37, 161, 92);
                modify = false;

                Account.modify(UserDetails[1], UserDetails[2], UserDetails[3], UserDetails[4], UserDetails[0]);
                new MessageBoxOk(0, "Your account information has been successfully updated :)").ShowDialog();
                return;
            }

            usernameLabel.Visible = emailLabel.Visible = passwordLabel.Visible = phoneLabel.Visible = false;
            usernameTextBox.Visible = emailTextBox.Visible = passwordTextBox.Visible = phoneTextBox.Visible = true;

            usernameTextBox.Text = UserDetails[1];
            emailTextBox.Text = UserDetails[2];
            passwordTextBox.Text = UserDetails[3];
            phoneTextBox.Text = UserDetails[4];

            modifyButton.Text = "Confirm";
            modifyButton.FillColor = Color.Tomato;
            modify = true;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            usernameError.Visible = false;
        }

        private void emailError_TextChanged(object sender, EventArgs e)
        {
            emailError.Visible = false;
        }

        private void passwordError_TextChanged(object sender, EventArgs e)
        {
            passwordError.Visible = false;
        }

        private void mobileError_TextChanged(object sender, EventArgs e)
        {
            mobileError.Visible = false;
        }
    }
}
