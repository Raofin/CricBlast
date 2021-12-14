using System.Configuration;
using System.Data.SqlClient;
using CricBlast_GUI.Home;

namespace CricBlast_GUI.Database
{
    public class Login
    {
        public static bool verify(string username, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@username", username);
                sqlCommand.Parameters.AddWithValue("@password", password);

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                    while (sqlDataReader.Read())
                        Selected.UserId = (int) sqlDataReader["Id"];

                return sqlDataReader.HasRows;
            }
        }
    }
}
