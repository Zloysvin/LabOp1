using System;
using System.Collections.Generic;
using System.Text;

namespace LabOp1
{
    public class Team : IComparable<Team>
    {
        public string Name;
        public int Score;
        public int GoalSaldo;

        public int CompareTo(Team otherTeam)
        {
            if (Score > otherTeam.Score)
            {
                return 1;
            }

            if (Score == otherTeam.Score)
            {
                if (GoalSaldo > otherTeam.GoalSaldo)
                {
                    return 1;
                }
            }

            return -1;
        }
    }
}