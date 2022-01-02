using System.Configuration;

namespace CricBlast_GUI.Database
{
    public static class ConnectionString
    {
        public static readonly string CricBlastDB = ConfigurationManager.ConnectionStrings["LocalDB"].ConnectionString;
    }
}
