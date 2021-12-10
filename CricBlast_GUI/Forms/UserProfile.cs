using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricBlast_GUI.Forms
{
    public partial class UserProfile : Form
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

        public UserProfile()
        {
            InitializeComponent();
        }

        private bool modify = false;
        private void modify_Click(object sender, EventArgs e)
        {
            if (modify)
            {
                new MessageBoxOk(0, "Your account information has been successfully updated :)").ShowDialog();
                return;
            }
            usernameLabel.Visible = emailLabel.Visible = passwordLabel.Visible = phoneLabel.Visible = false;
            usernameTextBox.Visible = emailTextBox.Visible = passwordTextBox.Visible = phoneTextBox.Visible = true;
            modifyButton.Text = "Confirm";
            modifyButton.FillColor = Color.Tomato;
            modify = true;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
