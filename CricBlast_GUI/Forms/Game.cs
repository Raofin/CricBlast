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
        public int Team1Runs { get; set; }
        public int Team1Wickets { get; set; }
        public int Team1Over { get; set; }

        public int Team2Runs { get; set; }
        public int Team2Wickets { get; set; }
        public int Team2Over { get; set; }

        public string MatchResult { get; set; }

        public void Generate(int format = 3)
        {
            // 1 = T10
            // 2 = T20
            // 3 = ODI

            var runsMin = 250;
            var runsMax = 350;
            var overMin = 40;
            var overMax = 50;


            switch (format)
            {
                case 1:
                    runsMin = 80;
                    runsMax = 130;
                    overMin = 9;
                    overMax = 10;
                    break;
                case 2:
                    runsMin = 120;
                    runsMax = 200;
                    overMin = 18;
                    overMax = 20;
                    break;
            }

            var random = new Random();

            Team1Runs = random.Next(runsMin, runsMax);
            Team2Runs = random.Next(runsMin, runsMax);

            var temp = random.Next(2);
            if (temp == 1) ByRuns();
            else ByWickets();

            void ByRuns()
            {
                switch (Team1Runs > Team2Runs)
                {
                    case true:
                        Team1Wickets = random.Next(0, 9);
                        Team2Wickets = random.Next(5, 11);
                        Team1Over = Team1Wickets == 10 ? random.Next(overMin, overMax) : overMax;
                        Team2Over = Team2Wickets == 10 ? random.Next(overMin, overMax - 1) : overMax;
                        MatchResult = $"Won by {Team1Runs - Team2Runs} Runs.";
                        break;
                    case false:
                        Team1Wickets = random.Next(5, 11);
                        Team2Wickets = random.Next(0, 9);
                        Team1Over = Team1Wickets == 10 ? random.Next(overMin, overMax) : overMax;
                        Team2Over = Team2Wickets == 10 ? random.Next(overMin, overMax - 1) : overMax;
                        MatchResult = $"Lost by {Team2Runs - Team1Runs} Runs.";
                        break;
                }
            }

            void ByWickets()
            {
                switch (Team1Runs > Team2Runs)
                {
                    case true:
                        Team1Runs = Team2Runs;
                        Team1Wickets = random.Next(5, 9);
                        Team1Over = random.Next(overMin, overMax - 1);
                        Team2Wickets = random.Next(2, 11);
                        Team2Over = Team2Wickets == 10 ? random.Next(overMin, overMax) : overMax;
                        MatchResult = $"Won by {10 - Team1Wickets} Wickets.";
                        break;
                    case false:
                        Team2Runs = Team1Runs;
                        Team2Wickets = random.Next(5, 9);
                        Team2Over = random.Next(overMin, overMax - 1);
                        Team1Wickets = random.Next(2, 11);
                        Team1Over = Team1Wickets == 10 ? random.Next(overMin, overMax) : overMax;
                        MatchResult = $"Lost by {10 - Team2Wickets} Wickets.";
                        break;
                }
            }
        }
    }
}
