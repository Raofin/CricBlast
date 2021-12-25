using System.Data.SqlClient;
using CricBlast_GUI.UI;

namespace CricBlast_GUI.Database
{
    public class MatchResults
    {
        public static void Played(bool won)
        {
            var win = won ? ", Won = Won + 1" : null;

            var query = $"UPDATE Users " +
                        $"SET Played = Played + 1 {win} " +
                        $"WHERE ID = '{Selected.UserDetails[0]}'";

            using (var sqlConnection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                using (var sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteReader();
                }
            }
        }

        public static void Result(string result)
        {
            result = $"{result.Substring(0, 1) + result.Substring(1).ToLower()} against {Selected.OpponentTeamName}.";

            var query = "INSERT INTO Matches (UserId, UserTeam, Result) " +
                        $"VALUES ('{Selected.UserDetails[0]}', '{Selected.UserTeamName}', '{result}')";

            using (var sqlConnection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                using (var sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
