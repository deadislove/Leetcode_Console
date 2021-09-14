using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App.Microsoft
{
    public class RemoveDeuplicatesString
    {
        public static void Client()
        {
            char[] str = "geeksforgeeks".ToCharArray();
            int n = str.Length;
            Console.WriteLine("RemoveDuplicater1");
            Console.WriteLine(RemoveDuplicater.RemoveDuplicater1(str, n));

            Console.WriteLine("RemoveDuplicater2");
            Console.WriteLine(RemoveDuplicater.RemoveDuplicater2(str, n));
        }
    }

    public class RemoveDuplicater
    {
        public static string RemoveDuplicater1(char[] str, int n)
        {
            // Used as index in the modified string
            int index = 0;

            // Traverse through all characters
            for (int i = 0; i < n; i++)
            {
                // Check if str[i] is present before it
                int j;
                for (j = 0; j < i; j++)
                {
                    if (str[i] == str[j])
                        break;
                }

                //If not present, then add it to result.
                if (j == i)
                    str[index++] = str[i];
            }

            char[] ans = new char[index];
            Array.Copy(str, ans, index);
            return String.Join("", ans);
        }

        public static string RemoveDuplicater2(char[] str, int n)
        {
            // Create a set using String characters
            // excluding '\0'
            int m = n - 1;
            HashSet<char> s = new HashSet<char>();
            foreach (char x in str)
                s.Add(x);

            char[] st = new char[s.Count];

            // Print content of the set
            int i = 0;
            foreach (char x in s)
                st[i++] = x;

            return new string(st);
        }
    }
}
