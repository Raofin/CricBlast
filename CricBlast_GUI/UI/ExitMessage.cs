using System;
using System.Media;
using System.Windows.Forms;

namespace CricBlast_GUI.UI
{
    public partial class ExitMessage : Form
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

        public ExitMessage()
        {
            InitializeComponent();
            SystemSounds.Asterisk.Play();
            FormLocation.CenterToScreen(this);
            Icon = Properties.Resources.CricBlast;
        }

        private void contributionsButton_Click(object sender, EventArgs e)
        {
            new Info().ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Raofin/CricBlast");
            Application.Exit();
        }
    }
}
