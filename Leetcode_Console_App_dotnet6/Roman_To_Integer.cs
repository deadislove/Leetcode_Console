using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App
{
    class Roman_To_Integer
    {
        // https://leetcode.com/problems/roman-to-integer/

        public int RomanToInt(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum += RomanToInt2(s, i, map) * map[s[i]];
            }
            return sum;
        }

        public static int RomanToInt2(string s, int i, Dictionary<char, int> map)
        {
            if (i == s.Length - 1) return 1;
            else if (map[s[i]] < map[s[i + 1]])
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
