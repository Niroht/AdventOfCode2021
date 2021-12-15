using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.DaySolutions
{
    public class DayOneSolution
    {
        public int GetNumberOfIncreases(IEnumerable<int> depths)
        {
            int? currentDepth = null;
            int increaseCount = 0;
            foreach(var depth in depths)
            {
                if (currentDepth != null && depth > currentDepth)
                {
                    increaseCount++;
                }

                currentDepth = depth;
            }

            return increaseCount;
        }
    }
}
