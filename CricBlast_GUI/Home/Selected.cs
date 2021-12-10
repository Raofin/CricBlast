using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricBlast_GUI.Home
{
    class Selected
    {
        public static int UserTeam { get; set; }
        public static int OpponentTeam { get; set; }
        public static bool MessageBox { get; set; }


        public static readonly byte CheckMark = 0;
        public static readonly byte WarningMark = 1;
        public static readonly byte ErrorMark = 2;

        public enum MyEnum
        {
            Afghanistan,
            Australia,
            Bangladesh,
            England,
            India,
            NewZealand,
            Pakistan,
            SouthAfrica,
            SriLanka,
            WestIndies

        }

        public static int TeamNumber(string selectedTeam)
        {
            switch (selectedTeam.Trim())
            {
                case "Afghanistan":
                    return 0;
                case "Australia":
                    return 1;
                case "Bangladesh":
                    return 2;
                case "England":
                    return 3;
                case "India":
                    return 4;
                case "New Zealand":
                    return 5;
                case "Pakistan":
                    return 6;
                case "South Africa":
                    return 7;
                case "Sri Lanka":
                    return 8;
                case "West Indies":
                    return 9;
                default:
                    return 2;
            }
        }
    }
}
