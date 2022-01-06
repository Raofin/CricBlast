using System;
using System.Windows.Forms;

namespace CricBlast_GUI.UI
{
    public partial class SelectTeams : Form
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

        public SelectTeams()
        {
            InitializeComponent();
            Icon = Properties.Resources.CricBlast;
            australiaPictureBox.Image = Teams.Team.GetLogo(1);
            bangladeshPictureBox.Image = Teams.Team.GetLogo(2);
            indiaPictureBox.Image = Teams.Team.GetLogo(3);
            newzealandPictureBox.Image = Teams.Team.GetLogo(4);
            pakistanPictureBox.Image = Teams.Team.GetLogo(5);
            southafricaPictureBox.Image = Teams.Team.GetLogo(6);
            srilankaPictureBox.Image = Teams.Team.GetLogo(7);
            westindiesPictureBox.Image = Teams.Team.GetLogo(8);
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (!australiaCheckBox.Checked || !bangladeshCheckBox.Checked || !indiaCheckBox.Checked ||
                !newzealandCheckBox.Checked || !pakistanCheckBox.Checked || !southafricaCheckBox.Checked ||
                !srilankaCheckBox.Checked || !westindiesCheckBox.Checked)
            {
                new MessageBoxOk(1, "Please choose at least eight teams.").ShowDialog();
                return;
            }

            Close();
        }

        private void australiaPictureBox_Click(object sender, EventArgs e)
        {
            australiaCheckBox.Checked = !australiaCheckBox.Checked;
        }

        private void bangladeshPictureBox_Click(object sender, EventArgs e)
        {
            bangladeshCheckBox.Checked = !bangladeshCheckBox.Checked;
        }

        private void indiaPictureBox_Click(object sender, EventArgs e)
        {
            indiaCheckBox.Checked = !indiaCheckBox.Checked;
        }

        private void newzealandPictureBox_Click(object sender, EventArgs e)
        {
            newzealandCheckBox.Checked = !newzealandCheckBox.Checked;
        }

        private void pakistanPictureBox_Click(object sender, EventArgs e)
        {
            pakistanCheckBox.Checked = !pakistanCheckBox.Checked;
        }

        private void southafricaPictureBox_Click(object sender, EventArgs e)
        {
            southafricaCheckBox.Checked = !southafricaCheckBox.Checked;
        }

        private void srilankaPictureBox_Click(object sender, EventArgs e)
        {
            srilankaCheckBox.Checked = !srilankaCheckBox.Checked;
        }

        private void westindiesPictureBox_Click(object sender, EventArgs e)
        {
            westindiesCheckBox.Checked = !westindiesCheckBox.Checked;
        }
    }
}
