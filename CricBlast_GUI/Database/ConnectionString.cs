using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricBlast_GUI.Database
{
    public static class ConnectionString
    {
        public static string CrikBlastDB = ConfigurationManager.ConnectionStrings["LocalDB"].ConnectionString;
    }
}
