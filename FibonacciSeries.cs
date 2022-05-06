using System;
namespace Day6Assignment
{
    public class FibonacciSeries
    {
        public void Fibonacci()
        {
            int firstNumber = 0, secondNumber = 1, sum = 0;
            Console.WriteLine("\nEnter the number for fibonacci series : ");
            int check = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nFibonacci Series is : ");
            Console.Write($" {firstNumber} {secondNumber} ");
            for (int i = 2; i < check; i++)
            {
                sum = firstNumber + secondNumber;
                Console.Write($"{sum} ");
                firstNumber = secondNumber;
                secondNumber = sum;
            }
        }
    }
}
