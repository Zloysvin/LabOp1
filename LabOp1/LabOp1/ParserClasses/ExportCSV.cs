using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace LabOp1.ParserClasses
{
    public static class ExportCSV
    {
        public static void Export(Team[] SortedTeams, int nameMod)
        {
            StreamWriter sw = new StreamWriter("results"+nameMod+".csv");
            for (int i = 0; i < SortedTeams.Length; i++)
            {
                sw.WriteLine(SortedTeams[i].Name+","+SortedTeams[i].Score);
            }
            sw.Close();
        }
    }
}
