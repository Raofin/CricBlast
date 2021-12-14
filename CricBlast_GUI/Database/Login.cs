using System.Configuration;
using System.Data.SqlClient;
using CricBlast_GUI.Home;

namespace CricBlast_GUI.Database
{
    public class Login
    {
        public static bool verify(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                var query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@username", username);
                sqlCommand.Parameters.AddWithValue("@password", password);

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (!sqlDataReader.HasRows) 
                    return sqlDataReader.HasRows;

                while (sqlDataReader.Read())
                {

                    Selected.UserDetails[0] = sqlDataReader["Id"].ToString();
                    Selected.UserDetails[1] = sqlDataReader["UserName"].ToString();
                    Selected.UserDetails[2] = sqlDataReader["Email"].ToString();
                    Selected.UserDetails[3] = sqlDataReader["Password"].ToString();
                    Selected.UserDetails[4] = sqlDataReader["PhoneNumber"].ToString();
                    Selected.UserDetails[5] = sqlDataReader["Gender"].ToString();
                }

                return sqlDataReader.HasRows;
            }
        }
    }
}
