using System;
using System.Windows.Forms;

namespace CricBlast_GUI.UI
{
    public partial class SelectStadium : Form
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

        public SelectStadium()
        {
            InitializeComponent();
            Icon = Properties.Resources.CricBlast;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
