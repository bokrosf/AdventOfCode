using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode.Year2018
{
    public static class PathResolver
    {
        private const string PathPrefix = @"..\..\..\..\AdventOfCode.Year2018\Inputs\";

        public static string ResolveInputFileNamePath(string fileName) => PathPrefix + fileName;
    }
}
