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
    public partial class MessageBox : Form
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

        public MessageBox(byte mark, string message)
        {
            DoubleBuffered = true;
            InitializeComponent();
            messageMark.Image = mark == 0 ? Properties.Resources.Check_Mark : Properties.Resources.Error_Mark;
            this.message.Text = message;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
