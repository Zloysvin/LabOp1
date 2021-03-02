using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace LabOp1.ParserClasses
{
    public static class ExportCSV
    {
        public static void Export(Team[] SortedTeams)
        {
            StreamWriter sw = new StreamWriter("results.csv");
            for (int i = 0; i < SortedTeams.Length; i++)
            {
                sw.WriteLine(SortedTeams[i].Name+","+SortedTeams[i].Score);
            }
            sw.Close();
        }
    }
}
