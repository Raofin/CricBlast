using System.Data.SQLite;
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

            using (var sqLiteConnection = new SQLiteConnection(ConnectionString.CricBlastDB))
            {
                using (var sqLiteCommand = new SQLiteCommand(query, sqLiteConnection))
                {
                    sqLiteConnection.Open();
                    var sqLiteDataReader = sqLiteCommand.ExecuteReader();
                    return sqLiteDataReader.HasRows;
                }
            }
        }

        public static void Create(string username, string email, string password, string phoneNumber, int gender, Image image)
        {
            var query = "INSERT INTO Users (Username, Email, Password, PhoneNumber, Gender, Image, Joined, Played, Won) " +
                        $"VALUES ('{username}', '{email}', '{password}', '{phoneNumber}', '{gender}', @image, DateTime('now'), '0', '0')";

            using (var sqLiteConnection = new SQLiteConnection(ConnectionString.CricBlastDB))
            {
                using (var sqLiteCommand = new SQLiteCommand(query, sqLiteConnection))
                {
                    sqLiteCommand.Parameters.AddWithValue("@image", ConvertImage.ToBytes(image));
                    sqLiteConnection.Open();
                    sqLiteCommand.ExecuteNonQuery();
                }
            }
        }

        public static void ModifyDetails(string username, string email, string password, string phoneNumber, string id)
        {
            var query = $"UPDATE Users " +
                        $"SET Username = '{username}', Email = '{email}', Password = '{password}', " +
                            $"PhoneNumber = '{phoneNumber}' WHERE Id = '{id}'";

            using (var sqLiteConnection = new SQLiteConnection(ConnectionString.CricBlastDB))
            {
                using (var sqLiteCommand = new SQLiteCommand(query, sqLiteConnection))
                {
                    sqLiteConnection.Open();
                    sqLiteCommand.ExecuteNonQuery();

                    var sqLiteDataReader = sqLiteCommand.ExecuteReader();
                    Login.LoadProfile(sqLiteDataReader);
                }
            }
        }

        public static void ModifyPhoto(Image image, string id)
        {
            var query = $"UPDATE Users " +
                        $"SET Image = @image " +
                        $"WHERE Id = '{id}'";

            using (var sqLiteConnection = new SQLiteConnection(ConnectionString.CricBlastDB))
            {
                using (var sqLiteCommand = new SQLiteCommand(query, sqLiteConnection))
                {
                    sqLiteCommand.Parameters.AddWithValue("@image", ConvertImage.ToBytes(image));
                    sqLiteConnection.Open();
                    sqLiteCommand.ExecuteNonQuery();

                    var sqLiteDataReader = sqLiteCommand.ExecuteReader();
                    Login.LoadProfile(sqLiteDataReader);
                }
            }
        }
    }
}