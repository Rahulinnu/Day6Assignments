using System;
namespace Day6Assignment
{
    public class PerfectNumber
    {
        public void Perfect()
        {
            int sum = 0, actualnum;
            Console.WriteLine("Enter any number you want to find whether is Perfect or not : ");
            int no = Convert.ToInt32(Console.ReadLine()); 
            actualnum = no;
            for (int i = 1; i < no; i++)
            {
                if (no % i == 0) 
                {
                    sum = sum + i;
                }
            }
            if (sum == actualnum) 
            {
                Console.WriteLine($"\n{actualnum} number is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"\n{actualnum} number is not a perfect number");
                Console.ReadLine();
            }
        }
    }
}
