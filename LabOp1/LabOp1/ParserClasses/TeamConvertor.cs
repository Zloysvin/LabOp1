using System;
using System.Collections.Generic;
using System.Text;

namespace LabOp1
{
    public static class TeamConvertor
    {
        public static Team[] Convert(string[,] ParsedCSV, int height)
        {
            int L = ParsedCSV.Length / height;
            List<Team> teams = new List<Team>();
            for (int i = 0; i < height; i++)
            {
                var team = new Team();
                team.Score = 0;
                for (int j = 0; j < L; j++)
                {
                    if (j != 0)
                    {
                        team.Score += GetScore(ParsedCSV[i, j].ToString());
                    }
                    else
                    {
                        team.Name = ParsedCSV[i, j];
                    }
                }
                teams.Add(team);
            }
            return teams.ToArray();
        }
        static int GetScore(string match)
        {
            if (!match.Contains("0x"))
                return System.Convert.ToInt32(match[0].ToString());
            else
                return System.Convert.ToInt32(match, 16);
        }
    }
}
