using System;

namespace Day6Assignment
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Day 6 Assignments Problems");
            Console.WriteLine("\nProblem 1 : Fiboacci");
            Console.WriteLine("Enter your choice : ");
            int a = Convert.ToInt32(Console.ReadLine());
            //Use switch case to run any particular program which user wants
            switch (a)
            {
                case 1:
                    FibonacciSeries series = new FibonacciSeries();
                    series.Fibonacci();
                    break;
            }
        }
    }
}
