using System;
using System.Media;
using System.Windows.Forms;

namespace CricBlast_GUI.UI
{
    public partial class MessageBoxOk : Form
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

        public MessageBoxOk(byte mark, string message, string buttonText = "Ok")
        {
            InitializeComponent();
            Icon = Properties.Resources.CricBlast;
            TopMost = true;
            this.message.Text = message;
            okButton.Text = buttonText;
            switch (mark)
            {
                case 0:
                    SystemSounds.Asterisk.Play();
                    messageMark.Image = Properties.Resources.Check_Mark;
                    break;
                case 1:
                    SystemSounds.Exclamation.Play();
                    messageMark.Image = Properties.Resources.Warning_Mark;
                    break;
                default:
                    SystemSounds.Hand.Play();
                    messageMark.Image = Properties.Resources.Error_Mark;
                    break;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
