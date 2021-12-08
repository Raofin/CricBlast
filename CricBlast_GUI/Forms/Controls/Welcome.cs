using System.Windows.Forms;

namespace CricBlast_GUI.Forms.Controls
{
    public partial class Welcome : UserControl
    {
        public Welcome()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
            InitializeComponent();
        }

        private void label6_Click(object sender, System.EventArgs e)
        {
            Controls.Clear();
            Controls.Add(value: new CreateAccount());
        }

        private bool eye;
        private void eyePicture_Click(object sender, System.EventArgs e)
        {
            switch (eye)
            {
                case true:
                    eyePicture.Image = Properties.Resources.Eye_Close;
                    eye = false;
                    passwordTextBox.UseSystemPasswordChar = true;
                    return;
                case false:
                    eyePicture.Image = Properties.Resources.Eye_Open;
                    eye = true;
                    passwordTextBox.UseSystemPasswordChar = false;
                    break;
            }
        }

        private bool user;
        private void refreshPicture_Click(object sender, System.EventArgs e)
        {
            switch (user)
            {
                case true:
                    loginAsPicture.Image = Properties.Resources.User_Male;
                    user = false;
                    usernameLabel.Text = "USERNAME OR EMAIL";
                    createAccountLabel.Visible = true;
                    label5.Visible = true;
                    return;
                case false:
                    loginAsPicture.Image = Properties.Resources.Admin_Colored;
                    user = true;
                    usernameLabel.Text = "ADMIN NAME OR EMAIL";
                    createAccountLabel.Visible = false;
                    label5.Visible = false;
                    break;
            }
        }

        private void label4_Click(object sender, System.EventArgs e)
        {
            new Recover().Show();
        }

        private void login_Click(object sender, System.EventArgs e)
        {
            usernameRequired.Visible = string.IsNullOrWhiteSpace(usernameTextBox.Text);
            passwordRequired.Visible = string.IsNullOrWhiteSpace(passwordTextBox.Text);
        }

        private void usernameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            usernameRequired.Visible = false;
        }

        private void passwordTextBox_TextChanged(object sender, System.EventArgs e)
        {
            passwordRequired.Visible = false;
        }
    }
}