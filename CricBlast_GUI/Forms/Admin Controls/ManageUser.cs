using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CricBlast_GUI.Database;

namespace CricBlast_GUI.Forms.Admin_Controls
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
            using (var sqlConnection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                sqlConnection.Open();
                var sqlDataAdapter =
                    new SqlDataAdapter(
                        "SELECT Username, Email, Password, PhoneNumber, Image, " +
                        "FORMAT (getdate(), 'dd/MM/yyyy') as Joined, Played, Won FROM Users",
                        sqlConnection);
                var dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                UserDataGridView.Columns[0].DataPropertyName = "Image";
                UserDataGridView.Columns[1].DataPropertyName = "Username";
                UserDataGridView.Columns[2].DataPropertyName = "Email";
                UserDataGridView.Columns[3].DataPropertyName = "Password";
                UserDataGridView.Columns[4].DataPropertyName = "Joined";
                UserDataGridView.Columns[5].DataPropertyName = "Played";
                UserDataGridView.Columns[6].DataPropertyName = "Won";
                UserDataGridView.DataSource = dataTable;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                Admin.DeleteRow(UserDataGridView.SelectedCells[1].Value.ToString());
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
                Admin.LoadTempProfile(UserDataGridView.SelectedCells[1].Value.ToString());
                new AdminView(2).ShowDialog();
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
                Admin.LoadTempProfile(UserDataGridView.SelectedCells[1].Value.ToString());
                new AdminView(1).ShowDialog();
            }
            catch
            {
                // ignored
            }
        }
    }
}
