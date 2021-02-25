using System;
using System.Collections.Generic;
using System.Text;

namespace LabOp1
{
    public class Team : IComparable<Team>
    {
        public string Name;
        public int Score;

        public int CompareTo(Team otherTeam)
        {
            if (Score > otherTeam.Score)
            {
                return 1;
            }

            if (Score == otherTeam.Score)
            {
                return 0;
            }

            return -1;
        }
    }
}