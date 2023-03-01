using Leetcode_Console_App.Microsoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Valid_Palindrome valid_Palindrome = new Valid_Palindrome();
            //valid_Palindrome.IsPalindrome("A man, a plan, a canal: Panama");

            //Excel_Sheet_Column_Title excel_Sheet_Column_Title = new Excel_Sheet_Column_Title();
            //excel_Sheet_Column_Title.ConvertToTitle(27);

            //Majority_Element majority_Element = new Majority_Element();
            //majority_Element.MajorityElement2(new int[] {3,2,3 });

            //RemoveDeuplicatesString.Client();
            //SearchElementSortedAndRotatedArray.Client();
            //AddTwoNumbers.Client();
            //ConnectNodeAtSameLevel.Client();
            //LCA_BinaryTree.Client();
            Program program = new Program();

            program.solution(3, new int[] { 1, 2, 3, 3, 1, 3, 1 });

            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }


        //Reference link :http://vfrdtyky.blogspot.com/2018/11/codility-c-debug-test.html
        // Problem fixs on when the index is -1.
        public int solution(int M, int[] A)
        {
            int N = A.Length;
            int[] count = new int[M + 1];
            for (int i = 0; i <= M; i++)
                count[i] = 0;
            int maxOccurence = 1;
            //int index = -1; default;
            int index = 0;
            for (int i = 0; i < N; i++)
            {
                //if (count[A[i]] > 0)
                if(A[i] <= M && count[A[i]] > 0)
                {
                    int tmp = count[A[i]];
                    if (tmp > maxOccurence)
                    {
                        maxOccurence = tmp;
                        index = i;
                    }
                    count[A[i]] = tmp + 1;
                }
                //else
                else if(A[i] <= M)
                {
                    count[A[i]] = 1;
                }
            }

            //return 1 or 3;

            var ChangeResult = N > 0 ? A[index] : 0;
            //return A[index];
            return N > 0 ? A[index] : 0;
        }

        //1304. Find N Unique Integers Sum up to Zero
        //https://leetcode.com/problems/find-n-unique-integers-sum-up-to-zero/
        //https://www.geeksforgeeks.org/find-n-distinct-integers-with-zero-sum/
        public int[] solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var range = Enumerable.Range(0, N).Select(x => x - N / 2);

            var T = range.Select(x => x >= 0 ? x + 1 : x).ToArray();

            return N % 2 == 0
                ? range.Select(x => x >= 0 ? x + 1 : x).ToArray()
            : range.ToArray();

        }

        //1525. Number of Good Ways to Split a String - LEETcode
        //https://leetcode.com/problems/number-of-good-ways-to-split-a-string/
        public int solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            string s = S;
            int[] count = new int[s.Length];
            HashSet<char> uniqueChars = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                uniqueChars.Add(s[i]);
                count[i] = uniqueChars.Count;
            }

            uniqueChars.Clear();

            int result = 1;
            for (int i = s.Length - 1; i > 0; i--)
            {
                uniqueChars.Add(s[i]);
                if (count[i - 1] == uniqueChars.Count) { result++; }
            }

            return result;

        }
    }
}
