using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Common
{
    public abstract class DayBase
    {
        public abstract string GetInputFilePath();
        public abstract void SolveFirstPart();
        public abstract void SolveSecondPart();
    }
}
