using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using CricBlast_GUI.Database;

namespace CricBlast_GUI.UI
{
    public partial class MatchHistory : Form
    {
        public MatchHistory()
        {
            InitializeComponent();
            LoadUserData();
            LoadMatchHistory();
            FormLocation.CenterToScreen(this);
            Icon = Properties.Resources.CricBlast;
        }

        private void LoadMatchHistory()
        {
            var query = $"SELECT UserTeam, Result FROM Matches " +
                        $"WHERE UserId = {Selected.UserDetails[0]} " +
                        $"ORDER BY MatchId DESC";

            using (var sqLiteConnection = new SQLiteConnection(ConnectionString.CricBlastDB))
            {
                var sqLiteDataAdapter = new SQLiteDataAdapter(query, sqLiteConnection);
                var dataTable = new DataTable();

                sqLiteConnection.Open();
                sqLiteDataAdapter.Fill(dataTable);
                MatchHistoryGrid.Columns[0].DataPropertyName = "UserTeam";
                MatchHistoryGrid.Columns[1].DataPropertyName = "Result";
                MatchHistoryGrid.DataSource = dataTable;
            }
        }

        public void LoadUserData()
        {
            var query = $"SELECT Image, Won, Played " +
                        $"FROM Users " +
                        $"WHERE Id = {Selected.UserDetails[0]}";

            using (var sqLiteConnection = new SQLiteConnection(ConnectionString.CricBlastDB))
            {
                using (var sqLiteCommand = new SQLiteCommand(query, sqLiteConnection))
                {
                    sqLiteConnection.Open();
                    var sqLiteDataReader = sqLiteCommand.ExecuteReader();

                    while (sqLiteDataReader.Read())
                    {
                        userPhoto.Image = ConvertImage.ToImage((byte[])sqLiteDataReader["Image"]);
                        won.Text = sqLiteDataReader["Won"].ToString();
                        played.Text = sqLiteDataReader["Played"].ToString();
                    }
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
