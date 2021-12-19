using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CricBlast_GUI.Forms;
using static CricBlast_GUI.Home.Selected;

namespace CricBlast_GUI.Database
{
    public static class Login
    {
        public static bool Verify(string nameOrEmail, string password)
        {
            var query = $"SELECT * FROM Users WHERE (Username = '{nameOrEmail}' OR Email = '{nameOrEmail}') AND Password = '{password}'";

            using (var connection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    if (!sqlDataReader.HasRows) return false;
                    LoadProfile(sqlDataReader);
                    return true;
                }
            }
        }

        public static bool Recover(string email)
        {
            var query = $"SELECT * FROM Users WHERE Email = '{email}'";

            using (var connection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    if (!sqlDataReader.HasRows) return false;
                    LoadProfile(sqlDataReader);
                    return true;
                }
            }
        }

        public static void LoadProfile(SqlDataReader sqlDataReader)
        {
            while (sqlDataReader.Read())
            {
                UserDetails[0] = sqlDataReader["Id"].ToString();
                UserDetails[1] = sqlDataReader["UserName"].ToString();
                UserDetails[2] = sqlDataReader["Email"].ToString();
                UserDetails[3] = sqlDataReader["Password"].ToString();
                UserDetails[4] = sqlDataReader["PhoneNumber"].ToString();
                UserDetails[5] = sqlDataReader["Gender"].ToString();
                UserDetails[6] = Convert.ToDateTime(sqlDataReader["Joined"]).ToString("dd/MM/yyyy");
                UserDetails[7] = sqlDataReader["Played"].ToString();
                UserDetails[8] = sqlDataReader["Won"].ToString();

                try
                {
                    UserImage = ConvertImage.ToImage((byte[]) sqlDataReader["Image"]);
                }
                catch
                {
                    UserImage = null;
                }
            }
        }
    }
}
