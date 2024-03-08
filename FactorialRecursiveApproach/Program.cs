using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialRecursiveApproach
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            for(int i = 1; i <= num & num >1; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"Factorial of {num} is: {fact} using for loop");

            long result = CalculateFactorial(num);
            Console.WriteLine($"Factorial of {num} is: {result} using recursive");

            Console.ReadLine();
        }

        static long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                long fact = CalculateFactorial(n - 1);
                return n * fact;
            }
        }
    }
}
