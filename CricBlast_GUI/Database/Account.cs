using System;
using System.Data.SqlClient;
using System.Drawing;

namespace CricBlast_GUI.Database
{
    public static class Account
    {
        public static bool IsUnique(string email)
        {
            var query = $"SELECT * " +
                        $"FROM Users " +
                        $"WHERE Email = '{email}'";

            using (var sqlConnection = new SqlConnection(ConnectionString.CricBlastDB))
            {
                using (var sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();
                    return sqlDataReader.HasRows;
                }
            }
        }

        public static void Create(string username, string email, string password, string phoneNumber, int gender, Image image)
        {
            var query = "INSERT INTO Users (Username, Email, Password, PhoneNumber, Gender, Image, Joined, Played, Won) " +
                        $"VALUES ('{username}', '{email}', '{password}', '{phoneNumber}', '{gender}', @image, '{DateTime.Now}', '0', '0')";

            using (var sqlConnection = new SqlConnection(ConnectionString.CricBlastDB))
            {
                using (var sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@image", ConvertImage.ToBytes(image));
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public static void ModifyDetails(string username, string email, string password, string phoneNumber, string id)
        {
            var query = $"UPDATE Users " +
                        $"SET Username = '{username}', Email = '{email}', Password = '{password}', " +
                            $"PhoneNumber = '{phoneNumber}' WHERE Id = '{id}'";

            using (var sqlConnection = new SqlConnection(ConnectionString.CricBlastDB))
            {
                using (var sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();

                    var sqlDataReader = sqlCommand.ExecuteReader();
                    Login.LoadProfile(sqlDataReader);
                }
            }
        }

        public static void ModifyPhoto(Image image, string id)
        {
            var query = $"UPDATE Users " +
                        $"SET Image = @image " +
                        $"WHERE Id = '{id}'";

            using (var sqlConnection = new SqlConnection(ConnectionString.CricBlastDB))
            {
                using (var sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@image", ConvertImage.ToBytes(image));
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();

                    var sqlDataReader = sqlCommand.ExecuteReader();
                    Login.LoadProfile(sqlDataReader);
                }
            }
        }
    }
}