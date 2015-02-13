using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

using Atmosphere.Extensions;
using Atmosphere.%SOLUTION_NAME%Lib;

using Lib = Atmosphere.%SOLUTION_NAME%Lib.%SOLUTION_NAME%Lib;

namespace Atmosphere.%SOLUTION_NAME%
{
    public class %SOLUTION_NAME%
    {
        public static void Main(string[] args)
        {   
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}
