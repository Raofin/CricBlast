using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CricBlast_GUI.Forms;

namespace CricBlast_GUI.Database
{
    public class Register
    {

        public static bool checkExistingAccount(string email)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM Users WHERE Email = @email";

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@email", email);

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                return sqlDataReader.HasRows;
            }
        }

        public static void createAccount(string username, string email, string password, string phoneNumber, int gender)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var query = "INSERT INTO Users (Username, Email, Password, PhoneNumber, Gender) VALUES (@username, @email, @password, @phoneNumber, @gender)";

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@username", username);
                sqlCommand.Parameters.AddWithValue("@email", email);
                sqlCommand.Parameters.AddWithValue("@password", password);
                sqlCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                sqlCommand.Parameters.AddWithValue("@gender", gender);

                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }

        }
    }
}