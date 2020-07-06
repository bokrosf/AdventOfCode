using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Common
{
    public abstract class DayBase
    {
        public abstract string GetInputFileName();
        public abstract void SolveFirstPart();
        public abstract void SolveSecondPart();
    }
}
