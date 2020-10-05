using System;

namespace MathUtils
{
    public class Math
    {
        public static int factorial(int n)
        {
            if (n < 0 || n > 20)
            {
                throw new ArgumentException();
            }

            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("ashdhas dahsdh ");
        }
    }
}