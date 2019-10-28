using System;

namespace MonthOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            PrintWeird(N);
        }

        public static void PrintWeird(int n)
        {
            if (n%2 == 0)
            {
                if (2 <= n && n <= 5)
                {
                    Console.WriteLine("Not Weird");
                } else if (6 <= n && n <= 20)
                {
                    Console.WriteLine("Weird");
                } else if (n > 20)
                {
                    Console.WriteLine("Not Weird");
                }
                
            } else
            {
                Console.WriteLine("Weird");
            }
        }
    }
}