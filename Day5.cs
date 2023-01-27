using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.NewFolder
{
    public static class Day5
    {
        public static void FirstTask()
        {
            var kek = new List<string> 
                {
                    string.Join(",", File.ReadAllLines(@"..\..\..\Day5\input5.txt"))
                }
                .Select(x => new Tuple<IEnumerable<string>, IEnumerable<string>>
                (
                    x.Split(",").Take(8).Select(x => x.Replace("   ", "_")).Select(x => x.Replace(" ", "")).Select(x=> x.Replace("______", "_____"))
                    .Select(x => x.Replace("[","")).Select(x=> x.Replace("]","")),
                    x.Split(",").Skip(10)
                )).ToList()[0];

            var xx = 3;
        }

        public static void SecondTask()
        {
            var kek = File.ReadAllLines(@"..\..\..\Day5\input5.txt")
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