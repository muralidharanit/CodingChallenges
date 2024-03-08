using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnsSmallestPositiveIntegerInGivenArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = new int[] { 9, 2, 4, 3, 1, 5 };

            Array.Sort(intArray);

            int leastNo = 0;

            for(int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] >= leastNo)
                {
                    leastNo++;
                }
            }

            Console.WriteLine(leastNo);
            Console.ReadLine();
        }
    }
}
