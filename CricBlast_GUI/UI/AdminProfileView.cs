using System;
using System.Drawing;
using System.Windows.Forms;
using CricBlast_GUI.Database;
using static CricBlast_GUI.Database.Admin;

namespace CricBlast_GUI.UI
{
    public partial class AdminProfileView : Form
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
        private Image _userNewImage = TempUserImage;

        public AdminProfileView()
        {
            InitializeComponent();
            Icon = Properties.Resources.CricBlast;
            LoadProfile();
        }

        public AdminProfileView(int viewOrModify)
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
            InitializeComponent();
            LoadProfile();

            if (viewOrModify == 1)
            {
                closeButton.Visible = false;
                modifyButton.Visible = false;
                closeMiddle.Visible = true;
            }
            else
            {
                _modify = true;
                HideModify();
            }
        }

        private void LoadProfile()
        {
            usernameLabel.Text = TempUserDetails[1];
            emailLabel.Text = TempUserDetails[2];
            passwordLabel.Text = TempUserDetails[3];
            phoneLabel.Text = TempUserDetails[4];
            accountCreated.Text = TempUserDetails[6];
            played.Text = TempUserDetails[7];
            won.Text = TempUserDetails[8];
            userCirclePicture.Image = TempUserImage;
            SetEmailFont();

            if (TempUserDetails[5].Equals("0"))
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
                new MessageBoxOk(Selected.WarningMark, "Please fill out all the fields properly.").ShowDialog();
                return;
            }

            TempUserDetails[1] = usernameLabel.Text = usernameTextBox.Text;
            TempUserDetails[2] = emailLabel.Text = emailTextBox.Text;
            TempUserDetails[3] = passwordLabel.Text = passwordTextBox.Text;
            TempUserDetails[4] = phoneLabel.Text = phoneTextBox.Text;

            TempUserImage = userCirclePicture.Image = _userNewImage;

            usernameLabel.Visible = emailLabel.Visible =
                passwordLabel.Visible = phoneLabel.Visible = changeProfilePicture.Visible = true;
            usernameTextBox.Visible = emailTextBox.Visible =
                passwordTextBox.Visible = phoneTextBox.Visible = changeProfilePicture.Visible = false;
            modifyButton.Text = "Modify";
            modifyButton.FillColor = Color.FromArgb(37, 161, 92);
            _modify = false;

            Account.ModifyDetails(TempUserDetails[1], TempUserDetails[2], TempUserDetails[3], TempUserDetails[4], TempUserDetails[0]);
            if (_modifyPhoto) Account.ModifyPhoto(_userNewImage, TempUserDetails[0]);
            SetEmailFont();

            new MessageBoxOk(0, "Account information has been successfully updated.").ShowDialog();
        }

        private void HideModify()
        {
            usernameLabel.Visible = emailLabel.Visible =
                passwordLabel.Visible = phoneLabel.Visible = changeProfilePicture.Visible = false;
            usernameTextBox.Visible = emailTextBox.Visible =
                passwordTextBox.Visible = phoneTextBox.Visible = changeProfilePicture.Visible = true;

            usernameTextBox.Text = TempUserDetails[1];
            emailTextBox.Text = TempUserDetails[2];
            passwordTextBox.Text = TempUserDetails[3];
            phoneTextBox.Text = TempUserDetails[4];
            userCirclePicture.Image = TempUserImage;

            modifyButton.Text = "Confirm";
            modifyButton.FillColor = Color.Tomato;
            _modify = true;
            SetEmailFont();
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

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (_modify)
            {
                ShowModify();
                return;
            }

            HideModify();
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

        private void closeMiddle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
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

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            mobileError.Visible = false;
        }

        private void usernameTextBox_Load(object sender, EventArgs e)
        {
            usernameTextBox.Focus();
        }
    }
}
