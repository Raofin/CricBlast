using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using CricBlast_GUI.Database;

namespace CricBlast_GUI.UI.Admin_Controls
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            LoadServerStats();
            LoadRecentlyJoined();
        }

        private void LoadServerStats()
        {
            var random = new Random();
            activeUsers.Text = random.Next(3, 7).ToString();

            var query = "SELECT COUNT(id), SUM(Played) " +
                        "FROM Users";

            using (var sqLiteConnection = new SQLiteConnection(ConnectionString.CricBlastDB))
            {
                using (var sqLiteCommand = new SQLiteCommand(query, sqLiteConnection))
                {
                    sqLiteConnection.Open();
                    var sqLiteDataReader = sqLiteCommand.ExecuteReader();

                    while (sqLiteDataReader.Read())
                    {
                        totalUsers.Text = sqLiteDataReader[0].ToString();
                        totalMatches.Text = sqLiteDataReader[1].ToString();
                    }
                }
            }
        }

        private void LoadRecentlyJoined()
        {
            using (var sqLiteConnection = new SQLiteConnection(ConnectionString.CricBlastDB))
            {
                var query = "SELECT Username, Email, Image " +
                            "FROM Users " +
                            "ORDER BY ID DESC " +
                            "LIMIT 6";

                using (var sqLiteCommand = new SQLiteCommand(query, sqLiteConnection))
                {
                    sqLiteConnection.Open();
                    var sqLiteDataReader = sqLiteCommand.ExecuteReader();

                    var dataTable = new DataTable();
                    dataTable.Load(sqLiteDataReader);

                    user1Name.Text = dataTable.Rows[0]["UserName"].ToString();
                    user1Email.Text = dataTable.Rows[0]["Email"].ToString();
                    user1Picture.Image = ConvertImage.ToImage((byte[])dataTable.Rows[0]["Image"]);

                    user2Name.Text = dataTable.Rows[1]["UserName"].ToString();
                    user2Email.Text = dataTable.Rows[1]["Email"].ToString();
                    user2Picture.Image = ConvertImage.ToImage((byte[])dataTable.Rows[1]["Image"]);

                    user3Name.Text = dataTable.Rows[2]["UserName"].ToString();
                    user3Email.Text = dataTable.Rows[2]["Email"].ToString();
                    user3Picture.Image = ConvertImage.ToImage((byte[])dataTable.Rows[2]["Image"]);

                    user4Name.Text = dataTable.Rows[3]["UserName"].ToString();
                    user4Email.Text = dataTable.Rows[3]["Email"].ToString();
                    user4Picture.Image = ConvertImage.ToImage((byte[])dataTable.Rows[3]["Image"]);

                    user5Name.Text = dataTable.Rows[4]["UserName"].ToString();
                    user5Email.Text = dataTable.Rows[4]["Email"].ToString();
                    user5Picture.Image = ConvertImage.ToImage((byte[])dataTable.Rows[4]["Image"]);

                    user6Name.Text = dataTable.Rows[5]["UserName"].ToString();
                    user6Email.Text = dataTable.Rows[5]["Email"].ToString();
                    user6Picture.Image = ConvertImage.ToImage((byte[])dataTable.Rows[5]["Image"]);
                }
            }
        }
    }
}
