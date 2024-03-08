using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isPrime = IsPrime(num);

            if (isPrime)
            {
                Console.WriteLine($"{num} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime number.");
            }
        }

        static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
