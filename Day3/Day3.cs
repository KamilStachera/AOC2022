using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.NewFolder
{
    public static class Day3
    {
        public static int FirstTask()
        {
            return File.ReadAllLines(@"..\..\..\Day3\input3.txt")
                       .Select(x => new string[2] { x.Substring(0, x.Length / 2), 
                                                    x.Substring(x.Length / 2, x.Length / 2) })
                       .Select(x => x[0].Intersect(x[1])
                                        .First())
                       .Select(x => char.IsUpper(x) ? x - 38 : x - 96)
                       .Sum();
        }

        public static int SecondTask()
        {
            return File.ReadAllLines(@"..\..\..\Day3\input3.txt")
                       .Chunk(3)
                       .Select(x => x[0].Intersect(x[1])
                                        .Intersect(x[2])
                                        .First())
                       .Select(x => char.IsUpper(x) ? x - 38 : x - 96)
                       .Sum();
        }
    }
}
