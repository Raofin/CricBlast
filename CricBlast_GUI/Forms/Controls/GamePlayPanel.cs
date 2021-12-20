using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricBlast_GUI.Forms.Controls
{
    public partial class GamePlayPanel : UserControl
    {
        public GamePlayPanel()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new PlayMatch().gamePlayPanel);
        }
    }
}
