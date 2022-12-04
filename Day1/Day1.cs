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
            return File.ReadAllText(@"..\..\..\Day1\input1.txt").Split("\r\n\r\n").Select(x => x.Split("\r\n").Select(z => Convert.ToInt32(z)).Sum()).Max();
        }

        public static int SecondTask()
        {
            return File.ReadAllText(@"..\..\..\Day1\input1.txt").Split("\r\n\r\n").Select(x => x.Split("\r\n").Select(z => Convert.ToInt32(z)).Sum()).OrderByDescending(x => x).Take(3).Sum();
        }
    }
}
