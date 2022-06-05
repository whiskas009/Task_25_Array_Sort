using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_25_Array_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[] { 20, 3, 2, 4, 7, 6, 5, 11, 9, 10, 8, 12, 13, 14, 15, 16, 17, 18, 19, 1 };
            int[] secondArray = new int[firstArray.Length];
            int numberInFirstArray = firstArray[0];
            int codNumberInFirstArray = 0;

            for (int i = 0; i < firstArray.Length; i++)
                Console.Write(firstArray[i]);

            Console.WriteLine("\n");

            for (int j = firstArray.Length; j > 0; j--)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] >= numberInFirstArray)
                    {
                        numberInFirstArray = firstArray[i];
                        codNumberInFirstArray = i;
                    }
                }
                firstArray[codNumberInFirstArray] = 0;
                secondArray[j-1] = numberInFirstArray;
                numberInFirstArray = firstArray[0];
            }

            for (int i = 0; i < secondArray.Length; i++)
                Console.Write(secondArray[i]);

            Console.WriteLine("\n");
        }
    }
}
