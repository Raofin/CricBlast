using System;

namespace CricBlast_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Players();
            string[,,] team1 = players.GetTeamPlayers(1);

            Console.WriteLine(team1[2, (int) Players.Format.Test, (int) Players.States.Wicket]);
        }
    }
}