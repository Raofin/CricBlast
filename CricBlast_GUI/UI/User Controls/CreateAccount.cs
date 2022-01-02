using System;
using System.Drawing;
using System.Windows.Forms;
using CricBlast_GUI.Database;

namespace CricBlast_GUI.UI.User_Controls
{
    public partial class CreateAccount : UserControl
    {
        private string CaptchaResult { get; set; }
        private int Gender { get; set; }
        private Image UserPicture { get; set; }
        private bool _eye;

        public CreateAccount()
        {
            InitializeComponent();
            GenerateCaptcha();
            usernameTextBox.Select();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(value: new Welcome());
        }

        private void register_Click(object sender, EventArgs e)
        {
            usernameError.Visible = string.IsNullOrWhiteSpace(usernameTextBox.Text);
            emailError.Visible = string.IsNullOrWhiteSpace(emailTextBox.Text);
            passwordError.Visible = string.IsNullOrWhiteSpace(passwordTextBox.Text);
            mobileError.Visible = string.IsNullOrWhiteSpace(mobileTextBox.Text);
            photoError.Visible = UserPicture == null;
            genderError.Visible = !genderRadioMale.Checked && !genderRadioFemale.Checked;
            captchaError.Visible = !captchaTextBox.Text.Trim().Equals(CaptchaResult);


            if (usernameError.Visible || emailError.Visible || passwordError.Visible || mobileError.Visible ||
                photoError.Visible || genderError.Visible || captchaError.Visible)
                new MessageBoxOk(Selected.WarningMark, "Please fill out all the fields properly.").ShowDialog();
            else
            {
                if (Account.IsUnique(emailTextBox.Text))
                    new MessageBoxOk(Selected.ErrorMark, "You already have an account with that email.")
                        .ShowDialog();
                else
                {
                    Account.Create(usernameTextBox.Text, emailTextBox.Text, passwordTextBox.Text,
                        mobileTextBox.Text, Gender, UserPicture);
                    new MessageBoxOk(Selected.CheckMark, "Your registration has been successfully completed.")
                        .ShowDialog();
                    Controls.Clear();
                    Controls.Add(new Welcome());
                }
            }
        }

        private void refreshCaptchaPicture_Click(object sender, EventArgs e)
        {
            captchaTextBox.Text = null;
            captchaError.Visible = false;
            GenerateCaptcha();
            captchaTextBox.Focus();
        }

        private void GenerateCaptcha()
        {
            var random = new Random();
            int number1 = random.Next(10, 20);
            int number2 = random.Next(10, 20);
            CaptchaResult = (number1 + number2).ToString();
            CaptchLabel.Text = $"{number1} + {number2} =";
        }

        private void eyePicture_Click(object sender, System.EventArgs e)
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

        private void genderRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (UserPicture != null) return;
            userPictureBox.Image = Properties.Resources.User_Male;
            Gender = 1;
            genderError.Visible = false;
        }

        private void genderRadioButton2_CheckedChanged(object sender, EventArgs e)
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

        private void captchaTextBox_TextChanged(object sender, EventArgs e)
        {
            captchaError.Visible = !captchaTextBox.Text.Trim().Equals(CaptchaResult);
        }

        private void captchaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) register.PerformClick();
        }

        private void usernameTextBox_Load(object sender, EventArgs e)
        {
            usernameTextBox.Focus();
        }
    }
}

