namespace Leetcode_Console_App_dotnet6
{
    internal static class Permutation_Sequence
    {
        public static void Client() { }

        // Reference: https://leetcode.com/problems/permutation-sequence/solutions/2973999/js-py-java-c-spliting-in-windows-approach-backtracking/?orderBy=most_votes&languageTags=csharp
        public static string GetPermutation(int n, int k) {
            // create Set
            List<int> set = new List<int>();
            for (int i = 1; i <= n; i++) set.Add(i);
            // find Kth permutation
            return backtracking(n, k, set, "");
        }

        private static int factorial(int n) {
            if (n == 1) return 1;
            else return n * factorial(n - 1);
        }

        private static string backtracking(int N, int K, List<int> set, string permutation) {
            // Base Case
            if (N is 0) return permutation;

            int fact = factorial(N),
            combinations = fact / N, // size of window for each digit
            index = 0; // index where K at windows

            int[] windows = new int[N]; // max range of each window
            for (int i = 0, c = combinations; i < N; i++, c += combinations)
            {
                windows[i] = c;
                index += (K > c) ? 1 : 0;
            }

            permutation += set[index]; // add to permutation
            set.RemoveAt(index); // remove from set
            K -= (index > 0) ? windows[index - 1] : index; // reduce K
            return backtracking(N - 1, K, set, permutation);
        }
    }
}
