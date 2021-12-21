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
            using (var sqlConnection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                sqlConnection.Open();
                var sqlDataAdapter = new SqlDataAdapter("SELECT Email, Image FROM Users", sqlConnection);
                var dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                AllUserGrid.Columns[0].DataPropertyName = "Image";
                AllUserGrid.Columns[1].DataPropertyName = "Email";
                AllUserGrid.DataSource = dataTable;
            }
        }
    }
}
