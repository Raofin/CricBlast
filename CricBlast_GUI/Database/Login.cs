using System.Data.SqlClient;
using static CricBlast_GUI.Home.Selected;

namespace CricBlast_GUI.Database
{
    public class Login
    {
        public static bool verify(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                var query = "SELECT * FROM Users WHERE Email = @email AND Password = @password";

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@email", email);
                sqlCommand.Parameters.AddWithValue("@password", password);

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (!sqlDataReader.HasRows)
                    return sqlDataReader.HasRows;

                while (sqlDataReader.Read())
                {
                    UserDetails[0] = sqlDataReader["Id"].ToString();
                    UserDetails[1] = sqlDataReader["UserName"].ToString();
                    UserDetails[2] = sqlDataReader["Email"].ToString();
                    UserDetails[3] = sqlDataReader["Password"].ToString();
                    UserDetails[4] = sqlDataReader["PhoneNumber"].ToString();
                    UserDetails[5] = sqlDataReader["Gender"].ToString();
                    UserImage = Convert.toImage((byte[]) sqlDataReader["Image"]);
                }

                return sqlDataReader.HasRows;
            }



        }

    }
}
