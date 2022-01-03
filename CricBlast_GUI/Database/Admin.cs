using System;
using System.Data.SqlClient;
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

            using (var sqlConnection = new SqlConnection(ConnectionString.CricBlastDB))
            {
                using (var sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    if (!sqlDataReader.HasRows) return false;

                    while (sqlDataReader.Read())
                    {
                        TempUserDetails[0] = sqlDataReader["Id"].ToString();
                        TempUserDetails[1] = sqlDataReader["UserName"].ToString();
                        TempUserDetails[2] = sqlDataReader["Email"].ToString();
                        TempUserDetails[3] = sqlDataReader["Password"].ToString();
                        TempUserDetails[4] = sqlDataReader["PhoneNumber"].ToString();
                        TempUserDetails[5] = sqlDataReader["Gender"].ToString();
                        TempUserDetails[6] = Convert.ToDateTime(sqlDataReader["Joined"]).ToString("dd/MM/yyyy");
                        TempUserDetails[7] = sqlDataReader["Played"].ToString();
                        TempUserDetails[8] = sqlDataReader["Won"].ToString();

                        try
                        {
                            TempUserImage = ConvertImage.ToImage((byte[])sqlDataReader["Image"]);
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

            using (var sqlConnection = new SqlConnection(ConnectionString.CricBlastDB))
            {
                using (var sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteReader();
                }
            }
        }
    }
}
