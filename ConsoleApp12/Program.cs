using System;
using System.IO;
using System.Linq;


public class HelloWorld
{
    static public void Main()
    {
            int out_ = palPrime(1, 9);
            Console.WriteLine(out_);
            Console.ReadLine();
    }

    static int palPrime(int L, int R)
    {
        int validPalPrimeCount = 0;
        bool isPalindromic = false;
        bool isPrime = true;
        //Write your code here
        for (int i = L; i <= R; i++)
        {
            string numString = i.ToString();
            char[] numCharArray = numString.ToCharArray();
            Array.Reverse(numCharArray);
            string reversedNumString = new string(numCharArray);
            if (numString == reversedNumString)
            {
                isPalindromic = true;
            }

            if (i <= 1)
            {
                // not a prime number, less than or equal to 1
                // skip to next iteration
                continue;
            }

            if (i == 2)
            {
                // if i == 2, add 1 and skip. We do this to avoid not counting number 2 during the next if statement
                validPalPrimeCount += 1;
                continue;
            }

            if (i % 2 == 0)
            {
                // not a prime number, divisible by two
                // skip to next iteration
                continue;
            }

            int productCount = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    productCount += 1;
                }
            }

            if (productCount > 2) isPrime = false;

            if (isPrime && isPalindromic)
            {
                validPalPrimeCount += 1;
            }
        }

        return validPalPrimeCount;
    }

}