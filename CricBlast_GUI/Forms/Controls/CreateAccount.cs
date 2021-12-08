using System;
using System.Windows.Forms;

namespace CricBlast_GUI.Forms.Controls
{
    public partial class CreateAccount : UserControl
    {
        private string CaptchaResult { get; set; }

        public CreateAccount()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
            InitializeComponent();
            GenerateCaptcha();
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
            genderError.Visible = !genderRadioMale.Checked && !genderRadioFemale.Checked;
        }

        private void refreshPicture_Click(object sender, EventArgs e)
        {
            GenerateCaptcha();
        }

        private void GenerateCaptcha()
        {
            var r = new Random();
            int number1 = r.Next(10, 20);
            int number2 = r.Next(10, 20);
            CaptchaResult = (number1 + number2).ToString();
            CaptchLabel.Text = $"{number1} + {number2} =";
        }

        private void genderRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            userPictureBox.Image = Properties.Resources.User_Male;
            genderError.Visible = false;
        }

        private void genderRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            userPictureBox.Image = Properties.Resources.User_Female;
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
    }
}
