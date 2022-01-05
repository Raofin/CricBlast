using System;
using System.Data;
using System.Data.SqlClient;
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
            Icon = Properties.Resources.CricBlast;
        }

        private void LoadMatchHistory()
        {
            var query = $"SELECT UserTeam, Result FROM Matches " +
                        $"WHERE UserId = {Selected.UserDetails[0]} " +
                        $"ORDER BY MatchId DESC";

            using (var sqlConnection = new SqlConnection(ConnectionString.CricBlastDB))
            {
                var sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                var dataTable = new DataTable();

                sqlConnection.Open();
                sqlDataAdapter.Fill(dataTable);
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

            using (var sqlConnection = new SqlConnection(ConnectionString.CricBlastDB))
            {
                using (var sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        userPhoto.Image = ConvertImage.ToImage((byte[])sqlDataReader["Image"]);
                        won.Text = sqlDataReader["Won"].ToString();
                        played.Text = sqlDataReader["Played"].ToString();
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
