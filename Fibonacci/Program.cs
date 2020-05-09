using System;

namespace Fibonacci
{
    class Program
    {
        public static int Fib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }
        public static void Main()
        {
            int parsedValue;
            bool check = true;
            while (check)
            {
                Console.WriteLine("With number of Fibonacci do you want count ?");
                string input = Console.ReadLine();
                if (int.TryParse(input, out parsedValue) && parsedValue > 0)
                {
                    Console.WriteLine($"Your Fibonacci number is  {Fib(parsedValue)}");
                    check = false;
                }
                else Console.WriteLine("Put in positive number");
            }
        }
    }
}
