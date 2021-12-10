using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricBlast_GUI.Forms
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
            DoubleBuffered = true;
            InitializeComponent();

            this.message.Text = message;
            this.okButton.Text = buttonText;
            switch (mark)
            {
                case 0:
                    messageMark.Image = Properties.Resources.Check_Mark;
                    break;
                case 1:
                    messageMark.Image = Properties.Resources.Warning_Mark;
                    break;
                default:
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
