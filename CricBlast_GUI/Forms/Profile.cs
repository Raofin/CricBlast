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
    public partial class Profile : Form
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

        public Profile()
        {
            InitializeComponent();
        }

        private bool modify = false;

        private void modify_Click(object sender, EventArgs e)
        {
            if (modify)
            {
                usernameLabel.Visible = emailLabel.Visible = passwordLabel.Visible = phoneLabel.Visible = true;
                usernameTextBox.Visible = emailTextBox.Visible = passwordTextBox.Visible = phoneTextBox.Visible = false;
                modifyButton.Text = "Confirm";
                modifyButton.FillColor = Color.FromArgb(37, 161, 92);
                modify = false;
                new MessageBoxOk(0, "Your account information has been successfully updated :)").ShowDialog();
                return;
            }

            usernameLabel.Visible = emailLabel.Visible = passwordLabel.Visible = phoneLabel.Visible = false;
            usernameTextBox.Visible = emailTextBox.Visible = passwordTextBox.Visible = phoneTextBox.Visible = true;
            modifyButton.Text = "Confirm";
            modifyButton.FillColor = Color.Tomato;
            modify = true;


            /*if (!modify)
            {
                usernameLabel.Visible = emailLabel.Visible = passwordLabel.Visible = phoneLabel.Visible = false;
                usernameTextBox.Visible = emailTextBox.Visible = passwordTextBox.Visible = phoneTextBox.Visible = true;
                modifyButton.Text = "Confirm";
                modifyButton.FillColor = Color.FromArgb(37, 161, 92);
                modify = false;
            }*/
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
