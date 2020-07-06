using AdventOfCode.Common;
using System;

namespace AdventOfCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DayBase day = new Year2018.Days.Day01();
            Console.WriteLine("AdventOfCode");
            Console.WriteLine();
            day.SolveFirstPart();
            day.SolveSecondPart();
        }
    }
}
