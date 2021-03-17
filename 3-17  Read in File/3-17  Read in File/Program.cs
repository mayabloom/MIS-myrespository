using System;
using System.Collections.Generic;
using System.IO;

namespace _3_17__Read_in_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("geoMap.csv");
            List<string> states = new List<string>();
            List<double> soccerScore = new List<double>();
            List<double> footballScores = new List<double>();


            for (int i = 3; i < lines.Length; i++)
            {
                //"North Dakota,12%,88$"
                string line = lines[i];

                //        0          1       2
                //{"North Dakota", "12%", "88%"}
                string[] pieces = line.Split(',');
                string state = pieces[0];
                states.Add(state);//(pieces[0]);

                //"12%"
                string soccerScoreAsString = pieces[1];
                double soccerScore = Convert.ToDouble(soccerScoreAsString.Trim('%')) / 100;
                soccerScore.Add(soccerScore);

                footballScores.Add(Convert.ToDouble(pieces[2].Trim('%')) / 100);
                
            }
            Console.WriteLine(lines);

            for (int i = 0; i < footballScores.Count; i++)
            {
                if (soccerScore[i] >footballScores[i])
                {
                    Console.WriteLine((states[i]));
                }
            }
        }
    }
}
