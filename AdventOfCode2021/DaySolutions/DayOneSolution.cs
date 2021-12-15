using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.DaySolutions
{
    public class DayOneSolution
    {
        public int GetNumberOfIncreases(IEnumerable<int> depths, int windowSize)
        {
            int? currentDepth = null;
            int increaseCount = 0;

            for (var currentPositionInDepths = 0; currentPositionInDepths <= depths.Count() - windowSize; currentPositionInDepths++)
            {
                var windowDepthSum = 0;
                for (var currentPositionInWindow = 0; currentPositionInWindow < windowSize; currentPositionInWindow++)
                {
                    windowDepthSum += depths.ElementAt(currentPositionInDepths + currentPositionInWindow);
                }

                if (currentDepth != null && windowDepthSum > currentDepth)
                {
                    increaseCount++;
                }

                currentDepth = windowDepthSum;
            }

            return increaseCount;
        }
    }
}
