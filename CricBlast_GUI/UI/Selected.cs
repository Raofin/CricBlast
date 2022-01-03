using System.Collections.Generic;
using System.Drawing;

namespace CricBlast_GUI.UI
{
    public static class Selected
    {
        public static string[] UserDetails = new string[10];
        public static Image UserImage { get; set; }

        public static int UserTeam { get; set; }
        public static string UserTeamName { get; set; }
        public static Bitmap UserTeamLogo { get; set; }
        public static string[] UserTeamStats { get; set; }
        public static string[,,] UserTeamPlayerStats { get; set; }
        public static int Captain { get; set; }
        public static int WicketKeeper { get; set; }

        public static int OpponentTeam { get; set; }
        public static string OpponentTeamName { get; set; }
        public static Bitmap OpponentTeamLogo { get; set; }
        public static string[,,] OpponentTeamPlayerStats { get; set; }

        public static bool Tournament { get; set; }

        public static string TournamentTitle { get; set; }
        public static Image TrophyImage { get; set; }

        public static int Player { get; set; }
        public static int Format { get; set; }
        public static List<int> PlayingEleven = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public static bool MessageBoxYesOrNo { get; set; }

        public static readonly byte CheckMark = 0;
        public static readonly byte WarningMark = 1;
        public static readonly byte ErrorMark = 2;
    }
}
