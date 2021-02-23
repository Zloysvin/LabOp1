using System;
using System.IO;

namespace LabOp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StreamReader sr = new StreamReader(@"C:\Users\cyr\Desktop\premier_league1.csv");
            sr.Close();
            int height = Convert.ToInt32(sr.ReadLine());
            string[,] CSVtable = ParserCSV.Parse(@"C:\Users\cyr\Desktop\premier_league1.csv", height);
            Team[] teams = new Team[height];
        }
    }
}
