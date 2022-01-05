using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using CricBlast_GUI.Database;

namespace CricBlast_GUI.UI
{
    public partial class Recover : Form
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

        public Recover()
        {
            InitializeComponent();
            Icon = Properties.Resources.CricBlast;
        }

        private bool _recovered;

        private void recoverButton_Click(object sender, EventArgs e)
        {
            error.Visible = string.IsNullOrWhiteSpace(emailTextBox.Text);

            if (_recovered)
            {
                Close();
                return;
            }

            if (Login.Recover(emailTextBox.Text))
            {
                recoveredName.Text = Selected.UserDetails[1];
                recoveredPassword.Text = Selected.UserDetails[3];
                recoveredUserPicture.Image = Selected.UserImage;
                recoverButton.FillColor = Color.FromArgb(37, 161, 92);
                recoverButton.Text = "OK";
                SystemSounds.Asterisk.Play();
                _recovered = true;
            }
            else new MessageBoxOk(2, "There are no accounts linked to that email address.").ShowDialog();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            error.Visible = string.IsNullOrWhiteSpace(emailTextBox.Text);
        }

        private void emailTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) recoverButton.PerformClick();
        }

        private void emailTextBox_Load(object sender, EventArgs e)
        {
            emailTextBox.Focus();
        }
    }
}
