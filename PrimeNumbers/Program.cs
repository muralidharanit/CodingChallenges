using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the limit to generate a prime no : ");
            int.TryParse(Console.ReadLine(), out int input);

            for(int i = 2; i < input; i++)
            {
                bool prime = true;
                for(int j = 2; j < input; j++)
                {
                    if (i!= j && i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if(prime)
                {
                    Console.WriteLine(i + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
