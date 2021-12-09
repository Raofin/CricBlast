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
    public partial class ChooseTeamDelete : UserControl
    {
        public ChooseTeamDelete()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new MyTeam());
        }
    }
}
