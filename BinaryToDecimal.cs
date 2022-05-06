using System;
namespace Day6Assignment
{
    public class BinaryToDecimal
    {
        public void BToDConversion()
        {
            float fractionalBinary, binaryNumber, binary, rem, decimalNumber = 0;
            long factor = 1, integerBinary;
            Console.WriteLine("\nEnter any number : ");
            binaryNumber = (float.Parse)(Console.ReadLine()); 
            integerBinary = (int)(binaryNumber); 
            fractionalBinary = binaryNumber - integerBinary; 
            Console.WriteLine($"\nInteger part of given binary number : {integerBinary}");
            Console.WriteLine($"\nFraction part of given binary number : {fractionalBinary}");
            binary = binaryNumber;
            while (integerBinary > 0) 
            {
                rem = integerBinary % 10;
                decimalNumber = decimalNumber + rem * factor;
                integerBinary = integerBinary / 10;
                factor = factor * 2;
            }
            float p = 0.5F;
            int temp;
            while (fractionalBinary > 0) 
            {
                fractionalBinary *= 10;
                temp = (int)fractionalBinary;
                decimalNumber += temp * p;
                p *= 0.5F;
                fractionalBinary -= temp;
            }
            Console.WriteLine($"\nDecimal Number of {binary} is : {decimalNumber}");
        }
    }
}
