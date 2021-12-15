using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CricBlast_GUI.Database;
using CricBlast_GUI.Home;

namespace CricBlast_GUI.Forms
{
    public partial class Recover : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
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
            if (Login.recover(emailTextBox.Text))
            {
                recoveredName.Text = Selected.UserDetails[1];
                recoveredPassword.Text = Selected.UserDetails[3];
                recoveredUserPicture.Image = Selected.UserImage;

            }
            error.Visible = string.IsNullOrWhiteSpace(emailTextBox.Text);
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            error.Visible = false;
        }
    }
}
