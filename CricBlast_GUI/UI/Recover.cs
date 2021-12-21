using System;
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
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
            InitializeComponent();
        }

        private void recoverButton_Click(object sender, EventArgs e)
        {
            if (Login.Recover(emailTextBox.Text))
            {
                recoveredName.Text = Selected.UserDetails[1];
                recoveredPassword.Text = Selected.UserDetails[3];
                recoveredUserPicture.Image = Selected.UserImage;
                SystemSounds.Asterisk.Play();
            }

            error.Visible = string.IsNullOrWhiteSpace(emailTextBox.Text);
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            error.Visible = false;
        }
    }
}
