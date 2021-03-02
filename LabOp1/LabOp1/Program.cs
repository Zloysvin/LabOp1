using System;

namespace LabOp1
{
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            Sorter<Team> sorter = new Sorter<Team>();

            Console.WriteLine("Hello World!");
            StreamReader sr = new StreamReader(@"C:\Users\cyr\Desktop\premier_league1.csv");
            int height = Convert.ToInt32(sr.ReadLine());
            sr.Close();
            Team[] teams = ParserCSV.ParseToTeams(@"C:\Users\cyr\Desktop\premier_league1.csv", height);
            var teamsSortedByIncreasing = sorter.SortWithHeapSorting(teams);
            ParserClasses.ExportCSV.Export(teamsSortedByIncreasing);
        }
    }
}