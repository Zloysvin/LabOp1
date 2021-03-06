﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace LabOp1
{
    public static class ParserCSV
    {
        public static Team[] ParseToTeams(string Path, int height)
        {
            StreamReader sr = new StreamReader(@Path);
            sr.ReadLine();
            string[,] Parsed = new string[1, 1];
            bool ArrayCreated = false;
            int Hcounter = 0;
            while(!sr.EndOfStream)
            {
                string[] lines = sr.ReadLine().Split(",");
                if (!ArrayCreated)
                {
                    string[,] CParsed = new string[height, lines.Length];
                    Parsed = CParsed;
                    ArrayCreated = true;
                }
                for (int i = 0; i < lines.Length; i++)
                {
                    Parsed[Hcounter, i] = lines[i];
                }
                Hcounter++;
            }
            sr.Close();
            return TeamConvertor.Convert(Parsed, Hcounter);
        }
    }
}
