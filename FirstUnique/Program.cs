using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUnique
{
    internal class Program
    {
        // https://app.codility.com/programmers/trainings/4/first_unique/
        static void Main(string[] args)
        {
            int[] input = new int[] { 3, 5, 6, 7, 9, 2, 3, 5, 6 };
            //int[] input = new int[] { 6, 4, 4, 6 };
            Console.WriteLine("The First Unique no is : {0}",FindFirstUniqueNo(input));
            Console.ReadLine();
        }

        private static int FindFirstUniqueNo(int[] input)
        {
            for (int i = 0;i<=input.Length-1; i++)
            {
                bool isUnique = true;
                for (int j = 0; j <= input.Length - 1; j++)
                {
                    if (i != j && input[i] == input[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                    return input[i];
            }
            return -1;
        }
    }
}
