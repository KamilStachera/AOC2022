using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.NewFolder
{
    public static class Day2
    {
        public static int FirstTask()
        {
            return File.ReadAllLines(@"..\..\..\Day2\input2.txt")
                       .Select(x => x.Split(' '))
                       .Select(x => x[0] == "A" ?
                                                 x[1] == "Y" ? 8 : x[1] == "X" ? 4 : 3
                                  : x[0] == "B" ?
                                                 x[1] == "Y" ? 5 : x[1] == "X" ? 1 : 9
                                  :
                                                 x[1] == "Y" ? 2 : x[1] == "X" ? 7 : 6
                                  ).Sum();
        }

        public static int SecondTask()
        {
            return File.ReadAllLines(@"..\..\..\Day2\input2.txt")
                       .Select(x => x.Split(' '))
                       .Select(x => x[0] == "A" ?
                                                 x[1] == "Y" ? 4 : x[1] == "X" ? 3 : 8
                                  : x[0] == "B" ?
                                                 x[1] == "Y" ? 5 : x[1] == "X" ? 1 : 9
                                  :
                                                 x[1] == "Y" ? 6 : x[1] == "X" ? 2 : 7
                                  ).Sum();
        }
    }
}
