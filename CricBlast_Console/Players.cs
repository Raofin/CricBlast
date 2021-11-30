using System;
using System.IO;
using System.Linq;

namespace CricBlast_Console
{
    class Players
    {
        public enum Format
        {
            T20I, ODI, Test
        }

        public enum States
        {
            Name, Match, Run, Average, StrikeRate, Hundred, Fifty, Wicket
        }

        public string GetLine(int lineNumber)
        {
            using (var sr = new StreamReader(Locations.PlayerData))
            {
                for (int i = 1; i < lineNumber; i++)
                    sr.ReadLine();
                return sr.ReadLine();
            }
        }

        public string[,,] GetTeamPlayers(int selectedTeam)
        {
            int totalLineCount = File.ReadLines(Locations.PlayerData).Count();
            int selectedTeamLineStart = 0;
            int selectedTeamLineEnd = 0;

            for (var i = 1; i < totalLineCount; i++)
            {
                if (GetLine(i).Length > 1 && GetLine(i).Substring(0, 1).Equals(selectedTeam.ToString()))
                {
                    selectedTeamLineStart = i + 1;
                    for (int j = i; j < totalLineCount; j++)
                    {
                        if (String.IsNullOrEmpty(GetLine(j)))
                        {
                            selectedTeamLineEnd = j;
                            break;
                        }
                    }
                }
            }

            string[,,] allPlayerStates = new string[selectedTeamLineEnd - selectedTeamLineStart, 3, 8];
            string[][] states = new string[3][];

            int m = 0;
            for (int i = selectedTeamLineStart; i < selectedTeamLineEnd; i++)
            {
                string line = GetLine(i);
                string[] format = line.Split(';');
                for (int j = 0; j < 3; j++)
                {
                    for (int l = 0; l < 3; l++)
                        states[l] = format[l].Split(',').Select(element => element.Trim()).ToArray();
                    for (int k = 0; k < 8; k++)
                        allPlayerStates[m, j, k] = states[j][k];
                }

                m++;
            }

            return allPlayerStates;
        }
    }
}