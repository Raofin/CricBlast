using System;
using System.Drawing;
using System.Windows.Forms;
using CricBlast_GUI.Database;
using static CricBlast_GUI.UI.Selected;

namespace CricBlast_GUI.UI
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

        private bool _modify;
        private bool _modifyPhoto;
        private Image _userNewImage = UserImage;

        public Profile()
        {
            InitializeComponent();
            Icon = Properties.Resources.CricBlast;
            LoadProfile();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            if (_modify)
            {
                ShowModify();
                usernameTextBox.Focus();
                return;
            }

            HideModify();
        }

        private void LoadProfile()
        {
            usernameLabel.Text = UserDetails[1];
            emailLabel.Text = UserDetails[2];
            passwordLabel.Text = UserDetails[3];
            phoneLabel.Text = UserDetails[4];
            accountCreated.Text = UserDetails[6];
            played.Text = UserDetails[7];
            won.Text = UserDetails[8];
            userCirclePicture.Image = UserImage;
            SetEmailFont();

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

        private void ShowModify()
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
            UserImage = userCirclePicture.Image = _userNewImage;

            usernameLabel.Visible = emailLabel.Visible =
                passwordLabel.Visible = phoneLabel.Visible = changeProfilePicture.Visible = true;
            usernameTextBox.Visible = emailTextBox.Visible =
                passwordTextBox.Visible = phoneTextBox.Visible = changeProfilePicture.Visible = false;
            modifyButton.Text = "Modify";
            modifyButton.FillColor = Color.FromArgb(37, 161, 92);
            _modify = false;

            Account.ModifyDetails(UserDetails[1], UserDetails[2], UserDetails[3], UserDetails[4], UserDetails[0]);
            if (_modifyPhoto) Account.ModifyPhoto(_userNewImage, UserDetails[0]);
            SetEmailFont();

            new MessageBoxOk(0, "Your account information has been successfully updated.").ShowDialog();
        }

        private void HideModify()
        {
            usernameLabel.Visible = emailLabel.Visible =
                passwordLabel.Visible = phoneLabel.Visible = changeProfilePicture.Visible = false;
            usernameTextBox.Visible = emailTextBox.Visible =
                passwordTextBox.Visible = phoneTextBox.Visible = changeProfilePicture.Visible = true;

            usernameTextBox.Text = UserDetails[1];
            emailTextBox.Text = UserDetails[2];
            passwordTextBox.Text = UserDetails[3];
            phoneTextBox.Text = UserDetails[4];
            userCirclePicture.Image = UserImage;

            modifyButton.Text = "Confirm";
            modifyButton.FillColor = Color.Tomato;
            _modify = true;
            SetEmailFont();
        }

        private void changeProfilePicture_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog { Filter = Properties.Resources.ImageFilter })
            {
                if (openFileDialog.ShowDialog() != DialogResult.OK) return;
                _userNewImage = userCirclePicture.Image = new Bitmap(openFileDialog.FileName);
                _modifyPhoto = true;
            }
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

        private void SetEmailFont()
        {
            if (emailLabel.Text.Length < 21)
            {
                emailLabel.Font = new Font("Segoe UI", emailLabel.Font.Size, FontStyle.Bold);
                emailLabel.Location = new Point(172, 296);
            }
            else
            {
                emailLabel.Font = new Font("Arial Narrow", emailLabel.Font.Size, FontStyle.Bold);
                emailLabel.Location = new Point(172, 298);
            }
        }

        private void phoneTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) modifyButton.PerformClick();
        }

        private void usernameTextBox_Load(object sender, EventArgs e)
        {
            usernameTextBox.Focus();
        }
    }
}
