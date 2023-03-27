using System;
using System.Collections.Generic;

namespace Leetcode_Console_App
{
    internal static class Insert_Interval
    {
        public static void Client() {
            int[][] intpurArr = new int[][] { 
                new int[] { 1, 3 },
                new int[] { 6, 9 },
            };
            int[] inputNewArr = new int[] { 2, 5 };
            var result = Insert(intpurArr, inputNewArr);
        }

        public static int[][] Insert(int[][] intervals, int[] newInterval)
        {
            var res = new List<int[]>();

            foreach (var interval in intervals)
            {
                if (interval[0] > newInterval[1])
                {
                    res.Add(newInterval);
                    newInterval = interval;
                }
                else if (interval[1] < newInterval[0])
                {
                    res.Add(interval);
                }
                else
                {
                    newInterval[0] = Math.Min(newInterval[0], interval[0]);
                    newInterval[1] = Math.Max(newInterval[1], interval[1]);
                }
            }

            res.Add(newInterval);

            return res.ToArray();
        }
    }
}
