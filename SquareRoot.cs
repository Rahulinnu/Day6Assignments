using System;
namespace Day6Assignment
{
    public class SquareRoot
    {
        public void FindSqrt()
        {
            Console.WriteLine("\nEnter number you want to find Square Root of this : ");
            double c = Convert.ToDouble(Console.ReadLine()); 
            double t = c;        
            double EPSILON = 1e-15;
            while (Math.Abs(t * t - c) > EPSILON) 
            {
                t = (c / t + t) / 2.0; 
            }
            Console.WriteLine($"\nSquare Root of {c} : {t}");
        }
    }
}
