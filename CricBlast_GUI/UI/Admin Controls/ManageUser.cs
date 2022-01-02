using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CricBlast_GUI.Database;

namespace CricBlast_GUI.UI.Admin_Controls
{
    public partial class ManageUser : UserControl
    {
        public ManageUser()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var query = "SELECT Username, Email, Password, PhoneNumber, Image, " +
                        "FORMAT (Joined, 'dd/MM/yyyy') as Joined, Played, Won " +
                        "FROM Users";

            using (var sqlConnection = new SqlConnection(ConnectionString.CricBlastDB))
            {
                using (var sqlDataAdapter = new SqlDataAdapter(query, sqlConnection))
                {
                    sqlConnection.Open();
                    var dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    UserGrid.Columns[0].DataPropertyName = "Image";
                    UserGrid.Columns[1].DataPropertyName = "Username";
                    UserGrid.Columns[2].DataPropertyName = "Email";
                    UserGrid.Columns[3].DataPropertyName = "Password";
                    UserGrid.Columns[4].DataPropertyName = "Joined";
                    UserGrid.Columns[5].DataPropertyName = "Played";
                    UserGrid.Columns[6].DataPropertyName = "Won";
                    UserGrid.DataSource = dataTable;
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            new MessageBoxYesNo(1, "Are you sure you want to remove this user?").ShowDialog();
            if (!Selected.MessageBoxYesOrNo) return;

            try
            {
                Admin.DeleteRow(UserGrid.SelectedCells[1].Value.ToString());
                Controls.Clear();
                Controls.Add(new ManageUser());
            }
            catch
            {
                // ignored
            }
        }

        private void modify_Click(object sender, EventArgs e)
        {
            try
            {
                Admin.LoadTempProfile(UserGrid.SelectedCells[1].Value.ToString());
                new AdminProfileView(2).ShowDialog();
                Controls.Clear();
                Controls.Add(new ManageUser());
            }
            catch
            {
                // ignored
            }
        }

        private void viewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Admin.LoadTempProfile(UserGrid.SelectedCells[1].Value.ToString());
                new AdminProfileView(1).ShowDialog();
            }
            catch
            {
                // ignored
            }
        }
    }
}
