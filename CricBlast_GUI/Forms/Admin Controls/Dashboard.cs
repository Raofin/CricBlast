using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CricBlast_GUI.Database;

namespace CricBlast_GUI.Forms.Admin_Controls
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, System.EventArgs e)
        {
            var random = new Random();
            activeUsers.Text = random.Next(3, 7).ToString();

            using (var connection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                using (var sqlCommand = new SqlCommand("SELECT COUNT(id) FROM Users", connection))
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        totalUsers.Text = sqlDataReader[0].ToString();
                    }
                }
            }

            using (var connection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                using (var sqlCommand = new SqlCommand("SELECT SUM(Played) FROM Users", connection))
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        totalMatches.Text = sqlDataReader[0].ToString();
                    }
                }
            }

            using (var connection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                using (var sqlCommand = new SqlCommand("SELECT TOP 1 * FROM Users ORDER BY ID DESC", connection))
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        user1Name.Text = sqlDataReader["UserName"].ToString();
                        user1Email.Text = sqlDataReader["Email"].ToString();
                        user1Picture.Image = ConvertImage.ToImage((byte[])sqlDataReader["Image"]);
                    }
                }
            }

            using (var connection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                using (var sqlCommand = new SqlCommand("SELECT TOP 2 * FROM Users ORDER BY ID DESC", connection))
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        user2Name.Text = sqlDataReader["UserName"].ToString();
                        user2Email.Text = sqlDataReader["Email"].ToString();
                        user2Picture.Image = ConvertImage.ToImage((byte[])sqlDataReader["Image"]);
                    }
                }
            }

            using (var connection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                using (var sqlCommand = new SqlCommand("SELECT TOP 3 * FROM Users ORDER BY ID DESC", connection))
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        user3Name.Text = sqlDataReader["UserName"].ToString();
                        user3Email.Text = sqlDataReader["Email"].ToString();
                        user3Picture.Image = ConvertImage.ToImage((byte[])sqlDataReader["Image"]);
                    }
                }
            }

            using (var connection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                using (var sqlCommand = new SqlCommand("SELECT TOP 4 * FROM Users ORDER BY ID DESC", connection))
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        user4Name.Text = sqlDataReader["UserName"].ToString();
                        user4Email.Text = sqlDataReader["Email"].ToString();
                        user4Picture.Image = ConvertImage.ToImage((byte[])sqlDataReader["Image"]);
                    }
                }
            }

            using (var connection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                using (var sqlCommand = new SqlCommand("SELECT TOP 5 * FROM Users ORDER BY ID DESC", connection))
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        user5Name.Text = sqlDataReader["UserName"].ToString();
                        user5Email.Text = sqlDataReader["Email"].ToString();
                        user5Picture.Image = ConvertImage.ToImage((byte[])sqlDataReader["Image"]);
                    }
                }
            }

            using (var connection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                using (var sqlCommand = new SqlCommand("SELECT TOP 6 * FROM Users ORDER BY ID DESC", connection))
                {
                    connection.Open();
                    var sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        user6Name.Text = sqlDataReader["UserName"].ToString();
                        user6Email.Text = sqlDataReader["Email"].ToString();
                        user6Picture.Image = ConvertImage.ToImage((byte[])sqlDataReader["Image"]);
                    }
                }
            }
        }
    }
}
