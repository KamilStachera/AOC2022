using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.NewFolder
{
    public static class Day4
    {
        public static int FirstTask()
        {
            return File.ReadAllLines(@"..\..\..\Day4\input4.txt")
                       .Select(x => x.Split(','))
                       .Select(x => new List<int[]>
                       {
                           x[0].Split('-').Select(int.Parse).ToArray(),
                           x[1].Split('-').Select(int.Parse).ToArray()
                       })
                       .Select(x => new List<int>[2]
                       {
                           Enumerable.Range(x[0][0],x[0][1] - x[0][0] + 1).ToList(),
                           Enumerable.Range(x[1][0],x[1][1] - x[1][0] + 1).ToList()
                       })
                       .Select(x => x[0].All(z => x[1].Contains(z)) ||
                                    x[1].All(z => x[0].Contains(z)) ? 1 : 0)
                       .Sum();
        }

        public static int SecondTask()
        {
            return File.ReadAllLines(@"..\..\..\Day4\input4.txt")
                       .Select(x => x.Split(','))
                       .Select(x => new List<int[]>
                       {
                           x[0].Split('-').Select(int.Parse).ToArray(),
                           x[1].Split('-').Select(int.Parse).ToArray()
                       })
                       .Select(x => new List<int>[2]
                       {
                           Enumerable.Range(x[0][0],x[0][1] - x[0][0] + 1).ToList(),
                           Enumerable.Range(x[1][0],x[1][1] - x[1][0] + 1).ToList()
                       })
                       .Select(x => x[0].Intersect(x[1]).Any() ? 1 : 0)
                       .Sum();
        }
    }
}
