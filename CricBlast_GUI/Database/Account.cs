using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

namespace CricBlast_GUI.Database
{
    public class Account
    {
        public static bool isUnique(string email)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                var query = "SELECT * FROM Users WHERE Email = @email";

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@email", email);

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                return sqlDataReader.HasRows;
            }
        }

        public static void create(string username, string email, string password, 
            string phoneNumber, int gender, Image image)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                var query = "INSERT INTO Users (Username, Email, Password, PhoneNumber, Gender, Image) " +
                            "VALUES (@username, @email, @password, @phoneNumber, @gender, @image)";

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@username", username);
                sqlCommand.Parameters.AddWithValue("@email", email);
                sqlCommand.Parameters.AddWithValue("@password", password);
                sqlCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                sqlCommand.Parameters.AddWithValue("@gender", gender);
                sqlCommand.Parameters.AddWithValue("@image", Convert.toBytes(image));

                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }

        public static void modify(string username, string email, string password, string phoneNumber, string id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                var query = "UPDATE Users SET Username = @username, Email = @email, " +
                            "Password = @password, PhoneNumber = @phoneNumber WHERE Id = @id";

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@username", username);
                sqlCommand.Parameters.AddWithValue("@email", email);
                sqlCommand.Parameters.AddWithValue("@password", password);
                sqlCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }


    }
}