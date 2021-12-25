using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CricBlast_GUI.Database;

namespace CricBlast_GUI.UI.User_Controls
{
    public partial class MatchHistory : Form
    {
        public MatchHistory()
        {
            InitializeComponent();
            LoadMatchHistory();
        }

        private void LoadMatchHistory()
        {
            var query = $"SELECT UserTeam, Result FROM Matches WHERE UserId = {Selected.UserDetails[0]} ORDER BY MatchId DESC";

            using (var sqlConnection = new SqlConnection(ConnectionString.CrikBlastDB))
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

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
