using System;
using System.Linq;

namespace Day6Assignment
{
    public class CouponNumber
    {
        public void Coupon()
        {
            Console.WriteLine("\nHow many numbers you want to add as distinct coupon numbers : ");
            int no = Convert.ToInt32(Console.ReadLine()); 
            int[] distinctCouponNumbers = new int[no];
            Console.WriteLine($"\nEnter any {no} numbers you want to add as coupon number : ");
            for (int i = 0; i < no; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine()); 
                while (true) 
                {
                    if (Array.Exists(distinctCouponNumbers, x => x == a)) 
                    {
                        Console.WriteLine($"\n{a} is already exists");
                        Console.WriteLine("\nPlease enter again");
                        a = Convert.ToInt32(Console.ReadLine()); 
                    }
                    else
                    {
                        distinctCouponNumbers[i] = a; 
                        break;
                    }
                }
            }
            Console.WriteLine("\nYour entered Distinct Numbers are : ");
            for (int i = 0; i < distinctCouponNumbers.Length; i++) 
            {
                Console.Write(distinctCouponNumbers[i] + " ");
            }
            int count = 0;
            Random random = new Random(); 
            Console.WriteLine("\n");
            while (true) 
            {
                int randomNumber = random.Next(distinctCouponNumbers.Min(), distinctCouponNumbers.Max()); 
                count++; 
                Console.WriteLine($"Generated Random number is : {randomNumber}");
                if (Array.Exists(distinctCouponNumbers, x => x == randomNumber)) 
                {
                    int item = randomNumber;
                    distinctCouponNumbers = distinctCouponNumbers.Where(e => e != item).ToArray();  
                    if (distinctCouponNumbers.Length == 0) 
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"\n\nTotal random numbers generated to get the all dictinct coupon numbers are : {count}");
        }
    }
}
