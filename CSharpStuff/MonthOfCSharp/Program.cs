using System;

namespace MonthOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 2;
            Looper(t);
        }

        //Day 4
        public static void Looper(int n)
        {
            for (int i = 1; i < 11; i++)
            {
                var buffer = n * i;
                Console.WriteLine(n + " x " + i + " = " + buffer);
            }
        }
        
        //Day 3
        public static void PrintWeird(int n)
        {
            //int N = int.Parse(Console.ReadLine());
            //PrintWeird(N);
            
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
        
        //Day 2 Challenge
        static int solve(double meal_cost, int tip_percent, int tax_percent)
        {
            /*double meal_cost = 12.00;
            int tip_percent = 20;
            int tax_percent = 8;
            Console.WriteLine(solve(meal_cost, tip_percent, tax_percent));*/
            
            double tip = meal_cost * tip_percent / 100;
            double tax = meal_cost*tax_percent/100;
            double total = meal_cost + tip + tax;
            return Convert.ToInt32(total);

        }
        
        //Day 1 Challenge
        static int simpleArraySum(int[] ar)
        {
            /*
                    * Write your code here.
                    */
            int sum = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }

            return sum;

            //int[] ar = {1,2,3,4,10,11};
            //int suma = simpleArraySum(ar)
            //Console.WriteLine(suma);
        }
    }
}