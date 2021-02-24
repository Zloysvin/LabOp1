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
            int height = Convert.ToInt32(sr.ReadLine());
            sr.Close();
            Team[] teams = ParserCSV.ParseToTeams(@"C:\Users\cyr\Desktop\premier_league1.csv", height);
        }
    }
}
