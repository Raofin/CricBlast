using System.Collections.Generic;
using System.Drawing;

namespace CricBlast_GUI.Home
{
    class Selected
    {
        public static string[] UserDetails = new string[10];
        public static Image UserImage { get; set; }

        public static int UserTeam { get; set; }
        public static int OpponentTeam { get; set; }
        public static bool MessageBox { get; set; }

        public static Bitmap UserTeamLogo { get; set; }

        public static string[] UserTeamStats { get; set; }
        public static string[,,] UserTeamPlayerStats { get; set; }
        public static string[,,] OpponentTeamPlayerStats { get; set; }

        public static List<int> PlayingEleven = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public static int Player { get; set; }
        public static int Format { get; set; }

        public static readonly byte CheckMark = 0;
        public static readonly byte WarningMark = 1;
        public static readonly byte ErrorMark = 2;
    }
}
