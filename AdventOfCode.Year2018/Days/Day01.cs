using AdventOfCode.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode.Year2018.Days
{
    public class Day01 : DayBase
    {
        private const string InputFileName = "input_01.txt";

        public override string GetInputFilePath() => PathResolver.ResolveInputFileNamePath(InputFileName);

        public override void SolveFirstPart()
        {
            int frequency = 0;
            
            using (StreamReader inputReader = new StreamReader(GetInputFilePath()))
            {
                while (!inputReader.EndOfStream)
                {
                    frequency += int.Parse(inputReader.ReadLine());
                }
            }

            Console.WriteLine($"First part's solution: {frequency}");
        }

        public override void SolveSecondPart()
        {
            int frequency = 0;
            HashSet<int> frequencies = new HashSet<int> { 0 };
            bool isDuplicateFrequencyFound = false;

            while (!isDuplicateFrequencyFound)
            {
                using (StreamReader inputReader = new StreamReader(File.OpenRead(GetInputFilePath())))
                {
                    while (!inputReader.EndOfStream && !isDuplicateFrequencyFound)
                    {
                        frequency += int.Parse(inputReader.ReadLine());
                        isDuplicateFrequencyFound = frequencies.Contains(frequency);
                        frequencies.Add(frequency);
                    }
                }
            }
            
            Console.WriteLine($"Second part's solution: {frequency}");
        }
    }
}
