﻿using System;
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
                        team.Score += GetScore(ParsedCSV[i, j]);
                        team.GoalSaldo += GetGoalSaldo(ParsedCSV[i, j]);
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

        private static int GetInt(string score)
        {
            if (score.Contains("0x"))
            {
                return System.Convert.ToInt32(score, 16);
            }

            return System.Convert.ToInt32(score);
        }

        static int GetScore(string match)
        {
            string[] goals = match.Split(":");
            var score1 = GetInt(goals[0]);
            var score2 = GetInt(goals[1]);
            if (score1 == score2)
            {
                return 1;
            }
            else if (score1 > score2)
            {
                return 3;
            }

            return 0;
        }

        private static int GetGoalSaldo(string match)
        {
            string[] goals = match.Split(":");
            var score1 = GetInt(goals[0]);
            var score2 = GetInt(goals[1]);

            return score1 - score2;
        }
    }
}