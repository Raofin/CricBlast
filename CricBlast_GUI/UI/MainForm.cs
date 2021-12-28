using System;
using System.Windows.Forms;
using CricBlast_GUI.UI.User_Controls;

namespace CricBlast_GUI.UI
{
    public partial class MainForm : Form
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

        public MainForm()
        {
            InitializeComponent();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(value: new TournamentPlay());
        }

        private void GetStarted_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(value: new Welcome());
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            new Info().ShowDialog();
        }
    }
}