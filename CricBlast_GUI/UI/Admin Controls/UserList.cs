using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CricBlast_GUI.Database;

namespace CricBlast_GUI.UI.Admin_Controls
{
    public partial class UserList : UserControl
    {
        public UserList()
        {
            InitializeComponent();
            LoadAllUser();
        }

        private void LoadAllUser()
        {
            var query = "SELECT Email, Image " +
                        "FROM Users";

            using (var sqlConnection = new SqlConnection(ConnectionString.CricBlastDB))
            {
                using (var sqlDataAdapter = new SqlDataAdapter(query, sqlConnection))
                {
                    sqlConnection.Open();
                    var dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    UserPreviewGrid.Columns[0].DataPropertyName = "Image";
                    UserPreviewGrid.Columns[1].DataPropertyName = "Email";
                    UserPreviewGrid.DataSource = dataTable;
                }
            }
        }
    }
}
