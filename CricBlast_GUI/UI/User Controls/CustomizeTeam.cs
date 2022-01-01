using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace CricBlast_GUI.UI.User_Controls
{
    public partial class CustomizeTeam : UserControl
    {
        public CustomizeTeam()
        {
            InitializeComponent();
        }

        private void CustomizeTeam_Load(object sender, EventArgs e)
        {
            SetBestEleven();
            LoadPlayers();
        }

        public void SetBestEleven()
        {
            SetPlayer(_1, 0);
            SetPlayer(_2, 1);
            SetPlayer(_3, 2);
            SetPlayer(_4, 3);
            SetPlayer(_5, 4);
            SetPlayer(_6, 5);
            SetPlayer(_7, 6);
            SetPlayer(_8, 7);
            SetPlayer(_9, 8);
            SetPlayer(_10, 9);
            SetPlayer(_11, 10);
        }

        private void SetPlayer(Guna2ComboBox setPlayer, int player)
        {
            setPlayer.Items.Clear();
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
                new MessageBoxOk(1, "Please check if there is a duplicate player.").ShowDialog();
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

            new MessageBoxOk(0, "Playing eleven has been successfully modified.").ShowDialog();
        }

        private void LoadPlayers()
        {
            captain.Items.Clear();
            wicketKeeper.Items.Clear();

            foreach (var items in Selected.PlayingEleven)
                captain.Items.Add(Selected.UserTeamPlayerStats[items, Selected.Format, 0]);

            foreach (var items in Selected.PlayingEleven)
                wicketKeeper.Items.Add(Selected.UserTeamPlayerStats[items, Selected.Format, 0]);

            captain.SelectedIndex = Selected.Captain == 0 ? 5 : Selected.Captain;
            wicketKeeper.SelectedIndex = Selected.WicketKeeper == 0 ? 4 : Selected.WicketKeeper;
        }

        private void resetPlayers_Click(object sender, EventArgs e)
        {
            Selected.PlayingEleven.Clear();
            int[] defaultPlayers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Selected.PlayingEleven.AddRange(defaultPlayers);
            Selected.Captain = Selected.WicketKeeper = 0;
            LoadPlayers();
            SetBestEleven();
        }

        private void captain_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected.Captain = captain.SelectedIndex;
        }

        private void wicketKeeper_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected.WicketKeeper = wicketKeeper.SelectedIndex;
        }
    }
}