using System;
using System.Data;
using System.Data.SqlClient;
using static CricBlast_GUI.Home.Selected;

namespace CricBlast_GUI.Database
{
    public static class Login
    {
        public static bool verify(string nameOrEmail, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                var query = "SELECT * FROM Users WHERE (Username = @nameOrEmail OR Email = @nameOrEmail) AND Password = @password";

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@nameOrEmail", nameOrEmail);
                sqlCommand.Parameters.AddWithValue("@password", password);
                
                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (!sqlDataReader.HasRows) return sqlDataReader.HasRows;

                loadProfile(sqlDataReader);
                return sqlDataReader.HasRows;
            }
        }

        public static bool recover(string email)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                var query = "SELECT * FROM Users WHERE Email = @email";

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@email", email);

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (!sqlDataReader.HasRows) return sqlDataReader.HasRows;

                loadProfile(sqlDataReader);
                return sqlDataReader.HasRows;
            }
        }

        private static void loadProfile(SqlDataReader sqlDataReader)
        {
            while (sqlDataReader.Read())
            {
                UserDetails[0] = sqlDataReader["Id"].ToString();
                UserDetails[1] = sqlDataReader["UserName"].ToString();
                UserDetails[2] = sqlDataReader["Email"].ToString();
                UserDetails[3] = sqlDataReader["Password"].ToString();
                UserDetails[4] = sqlDataReader["PhoneNumber"].ToString();
                UserDetails[5] = sqlDataReader["Gender"].ToString();
                UserImage = Convert.toImage((byte[])sqlDataReader["Image"]);
            }
        }
    }
}
