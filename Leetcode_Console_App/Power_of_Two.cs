namespace Leetcode_Console_App
{
    class Power_of_Two
    {
        /* Problem link: https://leetcode.com/problems/power-of-two/
         */

        public bool IsPowerOfTwo(int n)
        {
            return (n > 0 && (n & (n - 1)) == 0);
        }
    }
}
