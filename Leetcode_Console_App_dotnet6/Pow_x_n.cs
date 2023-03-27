namespace Leetcode_Console_App
{
    internal static class Pow_x_n
    {
        public static void Client() { }

        public static double MyPow(double x, int n)
        {
            if (n == 0)
                return 1;
            else if (n == -1)
                return 1 / x;
            else if (n == 1)
                return x;
            else
            {
                int half = n >> 1;
                double halfPow = MyPow(x, half);
                if ((n & 1) == 0)
                    return halfPow * halfPow;
                else
                    return halfPow * halfPow * x;
            }
        }
    }
}
