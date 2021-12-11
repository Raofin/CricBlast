using CricBlast_GUI.Home;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CricBlast_GUI.Forms.Controls
{
    public partial class CustomizeTeam : UserControl
    {
        public CustomizeTeam()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.ContainerControl |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }

        private void CustomizeTeam_Load(object sender, EventArgs e)
        {
            setBestEleven();
            LoadPlayers();
        }

        public void setBestEleven()
        {
            setPlayer(_1, 0);
            setPlayer(_2, 1);
            setPlayer(_3, 2);
            setPlayer(_4, 3);
            setPlayer(_5, 4);
            setPlayer(_6, 5);
            setPlayer(_7, 6);
            setPlayer(_8, 7);
            setPlayer(_9, 8);
            setPlayer(_10, 9);
            setPlayer(_11, 10);
        }

        private void setPlayer(Guna2ComboBox setPlayer, int player)
        {
            setPlayer.Items.Add(GetStats(Selected.PlayingEleven[player], 0));
            setPlayer.Items.Add(GetStats(11, 0));
            setPlayer.Items.Add(GetStats(12, 0));
            setPlayer.Items.Add(GetStats(13, 0));
            setPlayer.Items.Add(GetStats(14, 0));
            setPlayer.SelectedIndex = 0;
        }

        private string GetStats(int playerNumber, int stats)
        {
            return Selected.UserTeamPlayerStats[playerNumber, Selected.Format, stats];
        }

        private List<string> SelectedEleven = new List<string>();

        private void modify_Click(object sender, EventArgs e)
        {
            SelectedEleven.Clear();
            SelectedEleven.Add(_1.SelectedItem.ToString());
            SelectedEleven.Add(_2.SelectedItem.ToString());
            SelectedEleven.Add(_3.SelectedItem.ToString());
            SelectedEleven.Add(_4.SelectedItem.ToString());
            SelectedEleven.Add(_5.SelectedItem.ToString());
            SelectedEleven.Add(_6.SelectedItem.ToString());
            SelectedEleven.Add(_7.SelectedItem.ToString());
            SelectedEleven.Add(_8.SelectedItem.ToString());
            SelectedEleven.Add(_9.SelectedItem.ToString());
            SelectedEleven.Add(_10.SelectedItem.ToString());
            SelectedEleven.Add(_11.SelectedItem.ToString());

            if (SelectedEleven.Count != SelectedEleven.Distinct().Count())
            {
                new MessageBoxOk(1, "Duplicate Found!").ShowDialog();
                SelectedEleven.Clear();
                return;
            }

            Selected.PlayingEleven.Clear();
            foreach (var items in SelectedEleven)
            {
                for (int i = 0; i < 15; i++)
                {
                    if (!items.Equals(Selected.UserTeamPlayerStats[i, Selected.Format, 0])) continue;
                    Selected.PlayingEleven.Add(i);
                    break;
                }
            }

            LoadPlayers();
        }

        private void LoadPlayers()
        {
            captain.Items.Clear();
            wicketKeeper.Items.Clear();

            foreach (var items in Selected.PlayingEleven)
                captain.Items.Add(Selected.UserTeamPlayerStats[items, Selected.Format, 0]);

            foreach (var items in Selected.PlayingEleven)
                wicketKeeper.Items.Add(Selected.UserTeamPlayerStats[items, Selected.Format, 0]);
        }

        private void resetPlayers_Click(object sender, EventArgs e)
        {
            Selected.PlayingEleven.Clear();
            int[] defaultPlayers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Selected.PlayingEleven.AddRange(defaultPlayers);
            LoadPlayers();
            setBestEleven();
        }
    }
}