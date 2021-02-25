using System;
using System.IO;

namespace LabOp1
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Sorter<int> sorter = new Sorter<int>();
            List<int> integers = new List<int>();
            for (var i = 0; i < 7; i++)
            {
                integers.Add(Int32.Parse(Console.ReadLine()));
            }

            var sorted = sorter.SortWithHeapSorting(integers.ToArray());
            foreach (var i in sorted)
            {
                Console.WriteLine(i);
            }

            // Console.WriteLine("Hello World!");
            // StreamReader sr = new StreamReader(@"C:\Users\cyr\Desktop\premier_league1.csv");
            // int height = Convert.ToInt32(sr.ReadLine());
            // sr.Close();
            // Team[] teams = ParserCSV.ParseToTeams(@"C:\Users\cyr\Desktop\premier_league1.csv", height);
        }
    }
}