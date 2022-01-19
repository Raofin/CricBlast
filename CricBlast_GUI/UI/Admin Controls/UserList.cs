using System.Data;
using System.Data.SQLite;
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

            using (var sqLiteConnection = new SQLiteConnection(ConnectionString.CricBlastDB))
            {
                using (var sqLiteDataAdapter = new SQLiteDataAdapter(query, sqLiteConnection))
                {
                    sqLiteConnection.Open();
                    var dataTable = new DataTable();
                    sqLiteDataAdapter.Fill(dataTable);
                    UserPreviewGrid.Columns[0].DataPropertyName = "Image";
                    UserPreviewGrid.Columns[1].DataPropertyName = "Email";
                    UserPreviewGrid.DataSource = dataTable;
                }
            }
        }
    }
}
