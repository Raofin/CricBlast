using System;
using System.Data.SQLite;
using static CricBlast_GUI.UI.Selected;

namespace CricBlast_GUI.Database
{
    public static class Login
    {
        public static bool IsDatabaseConnected()
        {
            using (var sqLiteConnection = new SQLiteConnection(ConnectionString.CricBlastDB))
            {
                using (var sqLiteCommand = new SQLiteCommand("SELECT * FROM Users", sqLiteConnection))
                {
                    try
                    {
                        sqLiteConnection.Open();
                        sqLiteCommand.ExecuteReader();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
        }

        public static bool Verify(string nameOrEmail, string password)
        {
            var query = $"SELECT * FROM Users " +
                        $"WHERE (Username = '{nameOrEmail}' OR Email = '{nameOrEmail}') " +
                        $"AND Password = '{password}'";

            using (var sqLiteConnection = new SQLiteConnection(ConnectionString.CricBlastDB))
            {
                using (var sqLiteCommand = new SQLiteCommand(query, sqLiteConnection))
                {
                    sqLiteConnection.Open();
                    var sqLiteDataReader = sqLiteCommand.ExecuteReader();

                    if (!sqLiteDataReader.HasRows) return false;
                    LoadProfile(sqLiteDataReader);
                    return true;
                }
            }
        }

        public static bool Recover(string email)
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

                    if (!sqLiteDataReader.HasRows) return false;
                    LoadProfile(sqLiteDataReader);
                    return true;
                }
            }
        }

        public static void LoadProfile(SQLiteDataReader sqLiteDataReader)
        {
            while (sqLiteDataReader.Read())
            {
                UserDetails[0] = sqLiteDataReader["Id"].ToString();
                UserDetails[1] = sqLiteDataReader["UserName"].ToString();
                UserDetails[2] = sqLiteDataReader["Email"].ToString();
                UserDetails[3] = sqLiteDataReader["Password"].ToString();
                UserDetails[4] = sqLiteDataReader["PhoneNumber"].ToString();
                UserDetails[5] = sqLiteDataReader["Gender"].ToString();
                UserDetails[6] = Convert.ToDateTime(sqLiteDataReader["Joined"]).ToString("dd/MM/yyyy");
                UserDetails[7] = sqLiteDataReader["Played"].ToString();
                UserDetails[8] = sqLiteDataReader["Won"].ToString();

                try
                {
                    UserImage = ConvertImage.ToImage((byte[])sqLiteDataReader["Image"]);
                }
                catch
                {
                    UserImage = null;
                }
            }
        }
    }
}
