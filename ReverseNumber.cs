using System;
namespace Day6Assignment
{
    public class ReverseNumber
    {
        public void Reverse()
        {

            Console.WriteLine("\nEnter any number you want to find reverse : ");
            int number = Convert.ToInt32(Console.ReadLine()); 

            int reverse = 0, actualnumber;
            actualnumber = number;
            while (number > 0) 
            {
                reverse = (reverse * 10);
                reverse = reverse + (number % 10);
                number = number / 10;
            }
            Console.WriteLine($"\nThe reverse of {actualnumber} is : {reverse}");
        }
    }
}
