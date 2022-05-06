using System;
namespace Day6Assignment
{
    public class MonthlyPayment
    {
        public void Payment()
        {
            double principleAmount, year, rate, n, r, monthPayAmount;
            Console.WriteLine("\nEnter Principal Loan Amount : ");
            principleAmount = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("\nHow many years to pay off Principle Amount : ");
            year = Convert.ToDouble(Console.ReadLine());  
            Console.WriteLine("\nEnter rate of interest per year : ");
            rate = Convert.ToDouble(Console.ReadLine());      
            n = 12 * year;
            r = rate / (12 * 100);
            monthPayAmount = (principleAmount * r) / (1 - Math.Pow(1 + r, -n));
            Console.WriteLine($"\nMonthly Payment you have to pay off {principleAmount} Loan Amount over {year} years is : {monthPayAmount}");
        }
    }
}
