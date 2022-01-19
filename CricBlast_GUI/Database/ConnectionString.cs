namespace CricBlast_GUI.Database
{
    public static class ConnectionString
    {
        public static readonly string CricBlastDB =
            $@"Data Source = { System.IO.Path.GetTempPath() }\CricBlast.db; Version = 3";
    }
}
