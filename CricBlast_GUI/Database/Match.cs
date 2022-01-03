using System.Data.SqlClient;
using CricBlast_GUI.UI;

namespace CricBlast_GUI.Database
{
    public static class Match
    {
        public static void Play(bool won, string result)
        {
            Played(won);
            Result(result);
        }

        private static void Played(bool won)
        {
            string win;
            if (won)
            {
                win = ", Won = Won + 1";
                Selected.UserDetails[7] = (int.Parse(Selected.UserDetails[7]) + 1).ToString();
            }
            else win = null;

            Selected.UserDetails[8] = (int.Parse(Selected.UserDetails[8]) + 1).ToString();

            var query = $"UPDATE Users " +
                        $"SET Played = Played + 1 {win} " +
                        $"WHERE ID = '{Selected.UserDetails[0]}'";

            using (var sqlConnection = new SqlConnection(ConnectionString.CricBlastDB))
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

            using (var sqlConnection = new SqlConnection(ConnectionString.CricBlastDB))
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
