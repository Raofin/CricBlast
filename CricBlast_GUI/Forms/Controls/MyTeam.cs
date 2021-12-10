using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CricBlast_GUI.Home;

namespace CricBlast_GUI.Forms.Controls
{
    public partial class MyTeam : UserControl
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

        public MyTeam()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.ContainerControl |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.SupportsTransparentBackColor
                , true);
            InitializeComponent();
        }

        private void MyTeam_Load(object sender, EventArgs e)
        {
            if (Selected.UserTeam == 1)
            {
                teamLogo.Visible = true;
            }
            else
            {
                teamLogo.Visible = false;
            }
        }

        private void changeTeam_Click(object sender, EventArgs e)
        {
            new ChooseTeam().ShowDialog();
            if (Selected.UserTeam == 0)
            {
                teamLogo.Visible = true;
            }
            else
            {
                teamLogo.Visible = false;
            }
        }
    }
}
