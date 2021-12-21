using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CricBlast_GUI.Forms.Admin_Controls;
using CricBlast_GUI.Forms.Controls;

namespace CricBlast_GUI.Forms
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
            //new SelectTeams().ShowDialog();
            InitializeComponent();

            //mainPanel.Controls.Clear();
            //mainPanel.Controls.Add(value: new Controls.Home());
            //mainPanel.Controls.Add(value: new AdminPanel());
        }

        private void GetStarted_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(value: new Welcome());
        }

        // Drag form
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
    }
}