using System;
using System.Data.SQLite;
using System.Drawing;
using CricBlast_GUI.UI;

namespace CricBlast_GUI.Database
{
    public static class Admin
    {
        public static string[] TempUserDetails = new string[10];
        public static Image TempUserImage { get; set; }

        public static bool LoadTempProfile(string email)
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

                    while (sqLiteDataReader.Read())
                    {
                        TempUserDetails[0] = sqLiteDataReader["Id"].ToString();
                        TempUserDetails[1] = sqLiteDataReader["UserName"].ToString();
                        TempUserDetails[2] = sqLiteDataReader["Email"].ToString();
                        TempUserDetails[3] = sqLiteDataReader["Password"].ToString();
                        TempUserDetails[4] = sqLiteDataReader["PhoneNumber"].ToString();
                        TempUserDetails[5] = sqLiteDataReader["Gender"].ToString();
                        TempUserDetails[6] = Convert.ToDateTime(sqLiteDataReader["Joined"]).ToString("dd/MM/yyyy");
                        TempUserDetails[7] = sqLiteDataReader["Played"].ToString();
                        TempUserDetails[8] = sqLiteDataReader["Won"].ToString();

                        try
                        {
                            TempUserImage = ConvertImage.ToImage((byte[])sqLiteDataReader["Image"]);
                        }
                        catch
                        {
                            new MessageBoxOk(2, "error").ShowDialog();
                            TempUserImage = null;
                        }
                    }

                    return true;
                }
            }
        }

        public static void DeleteRow(string email)
        {
            var query = $"DELETE FROM Users " +
                        $"WHERE Email = '{email}'";

            using (var sqLiteConnection = new SQLiteConnection(ConnectionString.CricBlastDB))
            {
                using (var sqLiteCommand = new SQLiteCommand(query, sqLiteConnection))
                {
                    sqLiteConnection.Open();
                    sqLiteCommand.ExecuteReader();
                }
            }
        }
    }
}
