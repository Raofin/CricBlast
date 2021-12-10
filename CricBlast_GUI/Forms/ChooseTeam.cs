using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CricBlast_GUI.Forms.Controls;
using CricBlast_GUI.Home;

namespace CricBlast_GUI.Forms
{
    public partial class ChooseTeam : Form
    {
        public ChooseTeam()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Selected.UserTeam = Selected.TeamNumber(teamComboBox.SelectedText);
            Close();
        }
    }
}
