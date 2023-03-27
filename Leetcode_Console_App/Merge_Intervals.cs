using System;
using System.Collections.Generic;

namespace Leetcode_Console_App
{
    internal static class Merge_Intervals
    {
        public static void Client() {
            int[][] intputArr = new int[][] { 
                new int[]{ 1, 3},
                new int[]{ 2, 6},
                new int[]{ 8, 10},
                new int[]{ 15, 18},
            };
            var result = Merge(intputArr);
        }

        public static int[][] Merge(int[][] intervals)
        {
            int n = intervals.Length;
            if (intervals == null || n == 1)
                return intervals;

            Array.Sort(intervals, (a, b) => a[0] - b[0]);

            int start = intervals[0][0];
            int end = intervals[0][1];

            List<int[]> res = new List<int[]>();
            
            for (int i = 1; i < n; i++) {
                if (end >= intervals[i][0])
                    end = Math.Max(end, intervals[i][1]);
                else {
                    res.Add(new int[] { start, end });
                    start = intervals[i][0];
                    end = intervals[i][1];
                }
            }

            res.Add(new int[] { start, end });
            return res.ToArray();
        }
    }
}
