using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AOC.NewFolder
{
    public static class Day1
    {
        public static int FirstTask()
        {
            return File.ReadAllText(@"..\..\..\Day1\input1.txt")
                       .Split("\r\n\r\n")
                       .Select(x => x.Split("\r\n")
                                     .Select(z => Convert.ToInt32(z)).Sum())
                       .Max();
        }

        public static int FirstTaskNormalWay()
        {
            var input = File.ReadAllText(@"..\..\..\Day1\input1.txt");
            var inputSplitted = input.Split("\r\n\r\n");
            var max = 0;

            foreach (var values in inputSplitted)
            {
                var specificSplitted = values.Split("\r\n");
                var value = specificSplitted.Select(x => Convert.ToInt32(x)).Sum();

                if (value > max)
                    max = value;
            }

            return max;
        }

        public static int SecondTask()
        {
            return File.ReadAllText(@"..\..\..\Day1\input1.txt")
                       .Split("\r\n\r\n")
                       .Select(x => x.Split("\r\n")
                                     .Select(z => Convert.ToInt32(z))
                                     .Sum())
                       .OrderByDescending(x => x)
                       .Take(3)
                       .Sum();
        }


        public static int SecondTaskNormalWay()
        {
            var input = File.ReadAllText(@"..\..\..\Day1\input1.txt");
            var inputSplitted = input.Split("\r\n\r\n");
            var energyTotals = new List<int>();

            foreach (var values in inputSplitted)
                energyTotals.Add(values.Split("\r\n").Select(x => Convert.ToInt32(x)).Sum());

            return energyTotals.OrderByDescending(x=>x).Take(3).Sum();
        }
    }
}
