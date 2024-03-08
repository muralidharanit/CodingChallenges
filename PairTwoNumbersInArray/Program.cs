using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairTwoNumbersInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 5, 7, 9, 6 };

            for (int i = 0; i < a.Length-1; i++)
            {
                for (int j = a.Length - 1; j >= i+1; j--)
                {
                    string t = a[i] + " - " +a[j];
                    Console.WriteLine(t);
                }
            }

            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }

                Console.ReadLine();
        }
    
    }
}
