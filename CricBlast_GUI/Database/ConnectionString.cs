using System.Configuration;

namespace CricBlast_GUI.Database
{
    public static class ConnectionString
    {
        public static readonly string CrikBlastDB = ConfigurationManager.ConnectionStrings["LocalDB"].ConnectionString;
    }
}
