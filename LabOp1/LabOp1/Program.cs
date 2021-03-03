using System;

namespace LabOp1
{
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            Sorter<Team> sorter = new Sorter<Team>();

            Console.WriteLine("Enter Directory:");
            string path = Console.ReadLine();
            string[] files = Directory.GetFiles(@path, "*.csv");
            for (int i = 0; i < files.Length; i++)
            {
                StreamReader sr = new StreamReader(files[i]);
                int height = Convert.ToInt32(sr.ReadLine());
                sr.Close();
                Team[] teams = ParserCSV.ParseToTeams(files[i], height);
                var teamsSortedByIncreasing = sorter.SortWithHeapSorting(teams);
                ParserClasses.ExportCSV.Export(teamsSortedByIncreasing, i+1);
            }
            
        }
    }
}