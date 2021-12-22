using System;
using System.Drawing;
using System.Windows.Forms;

namespace CricBlast_GUI.UI.User_Controls
{
    public partial class GamePlayPanel : UserControl
    {
        public static int MatchFormat { get; set; }
        private string MatchResult { get; set; }
        private int Team1Runs { get; set; }
        private int Team1Wickets { get; set; }
        private int Team1Over { get; set; }
        private int Team2Runs { get; set; }
        private int Team2Wickets { get; set; }
        private int Team2Over { get; set; }

        private bool Won { get; set; }

        public GamePlayPanel()
        {
            InitializeComponent();
            GenerateGame(MatchFormat);
            SetGame();
        }

        public void SetGame()
        {
            userTeamLogo.Image = Selected.UserTeamLogo;
            opponentTeamLogo.Image = Selected.OpponentTeamLogo;
            userTeamScore.Text = $"{Team1Runs}/{Team1Wickets} ({Team1Over})";
            opponentTeamScore.Text = $"{Team2Runs}/{Team2Wickets} ({Team2Over})";
            matchResult.Text = $"{Selected.UserTeamName} {MatchResult}";
            matchResult.ForeColor = Won ? Color.FromArgb(59, 226, 55) : Color.Tomato;
        }

        public void GenerateGame(int format)
        {
            // format 1 = T10
            // format 2 = T20
            // format 3 = ODI

            var runsMin = 250;
            var runsMax = 350;
            var overMin = 40;
            var overMax = 50;

            /*runsMin = 120;
            runsMax = 200;
            overMin = 18;
            overMax = 20;*/

            switch (format)
            {
                case 1:
                    runsMin = 120;
                    runsMax = 200;
                    overMin = 18;
                    overMax = 20;
                    break;
                case 2:
                    runsMin = 250;
                    runsMax = 350;
                    overMin = 40;
                    overMax = 50;
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
                        Won = true;
                        break;
                    case false:
                        Team1Wickets = random.Next(5, 11);
                        Team2Wickets = random.Next(0, 9);
                        Team1Over = Team1Wickets == 10 ? random.Next(overMin, overMax) : overMax;
                        Team2Over = Team2Wickets == 10 ? random.Next(overMin, overMax - 1) : overMax;
                        MatchResult = $"Lost by {Team2Runs - Team1Runs} Runs.";
                        Won = false;
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
                        Won = true;
                        break;
                    case false:
                        Team2Runs = Team1Runs;
                        Team2Wickets = random.Next(5, 9);
                        Team2Over = random.Next(overMin, overMax - 1);
                        Team1Wickets = random.Next(2, 11);
                        Team1Over = Team1Wickets == 10 ? random.Next(overMin, overMax) : overMax;
                        MatchResult = $"Lost by {10 - Team2Wickets} Wickets.";
                        Won = false;
                        break;
                }
            }
        }
    }
}