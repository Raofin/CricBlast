using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CricBlast_GUI.Forms
{
    class Game
    {
        private int userTeam = 1;
        private int oppoTeam = 2;

        public int runs { get; set; }
        public int wickets { get; set; }
        public int over { get; set; }

        public void OdiGenerateGame(int run, int wicket, int over)
        {
            var random = new Random();
            run = random.Next(250, 350);
            wicket = random.Next(2, 10);
            over = 50;

            if (wicket == 10) over = random.Next(40, 50);
        }
    }
}
