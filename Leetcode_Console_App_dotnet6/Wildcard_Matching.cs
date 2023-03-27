namespace Leetcode_Console_App
{
    internal static class Wildcard_Matching
    {
        public static void Client() { }

        public static bool IsMatch(string s, string p)
        {
            var i = 0;
            var j = 0;
            var star = -1;
            var m = -1;

            while (i < s.Length)
            {
                if (j < p.Length && (p[j] == '?' || p[j] == s[i]))
                {
                    i++;
                    j++;

                    continue;
                }

                if (j < p.Length && p[j] == '*')
                {
                    star = j++;
                    m = i;

                    continue;
                }

                if (star >= 0)
                {
                    j = star + 1;
                    i = ++m;

                    continue;
                }

                return false;
            }

            while (j < p.Length && p[j] == '*')
            {
                j++;
            }

            return j == p.Length;
        }

        public static bool IsMatch2(string s, string p)
        {
            int sIndex = 0;
            int pIndex = 0;
            int starIndex = -1;
            int sMatchIndex = 0;

            while (sIndex < s.Length)
            {
                // If the pattern character is a '?', or if the pattern
                // character and the string character match, move both
                // pointers to the next characters.
                if (pIndex < p.Length && (p[pIndex] == '?' || p[pIndex] == s[sIndex]))
                {
                    sIndex++;
                    pIndex++;
                }
                // If the pattern character is a '*', save the current
                // pattern index and the current string index, and move
                // the pattern pointer to the next character.
                else if (pIndex < p.Length && p[pIndex] == '*')
                {
                    starIndex = pIndex;
                    sMatchIndex = sIndex;
                    pIndex++;
                }
                // If the pattern character and the string character do not
                // match, and the last pattern character was not a '*',
                // the matching fails.
                else if (starIndex == -1)
                {
                    return false;
                }
                // If the pattern character and the string character do not
                // match, and the last pattern character was a '*', move
                // the string pointer to the next character and try to
                // match again using the same pattern index.
                else
                {
                    sIndex = sMatchIndex + 1;
                    sMatchIndex++;
                    pIndex = starIndex + 1;
                }
            }

            // Skip the remaining '*' characters in the pattern.
            while (pIndex < p.Length && p[pIndex] == '*')
            {
                pIndex++;
            }

            // If all the characters in the pattern have been processed,
            // the matching is successful.
            return pIndex == p.Length;
        }
    }    
}
