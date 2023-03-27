namespace Leetcode_Console_App
{
    internal static class Divide_Two_Integers
    {
        public static void Client() { }

        public static int Divide(int dividend, int divisor)
        {
            // C# 9.0
            //nint d1 = dividend;
            //nint d2 = divisor;
            //if (d1 / d2 <= int.MinValue) return int.MinValue;
            //if (d1 / d2 >= int.MaxValue) return int.MaxValue;
            return (dividend / divisor);
        }
    }
}
