using System.Collections.Generic;

namespace Leetcode_Console_App
{
    internal static class Reorder_Routes_to_Make_All_Paths_Lead_to_the_City_Zero
    {
        public static void Client() { }

        // Reference: https://leetcode.com/problems/reorder-routes-to-make-all-paths-lead-to-the-city-zero/solutions/2959221/fast-and-easy-to-understand-bfs-on-c/?orderBy=most_votes&languageTags=csharp
        public static int MinReorder(int n, int[][] connections)
        {
            var dict = new Dictionary<int, HashSet<int>>();
            var hashSet = new HashSet<string>();

            foreach (var connection in connections)
            {
                if (!dict.ContainsKey(connection[0]))
                {
                    dict.Add(connection[0], new HashSet<int>());
                }
                dict[connection[0]].Add(connection[1]);

                if (!dict.ContainsKey(connection[1]))
                {
                    dict.Add(connection[1], new HashSet<int>());
                }
                dict[connection[1]].Add(connection[0]);
                hashSet.Add($"{connection[1]}-{connection[0]}");

            }

            var queue = new Queue<int>();
            queue.Enqueue(0);

            var visited = new bool[n];
            var res = 0;

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                visited[node] = true;

                foreach (var next in dict[node])
                {
                    if (!visited[next])
                    {
                        var key = $"{next}-{node}";
                        if (hashSet.Contains(key))
                        {
                            res++;
                        }
                        queue.Enqueue(next);
                    }
                }
            }

            return res;
        }
    }
}
