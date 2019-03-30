using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSorting
{
    class Program
    {
        static int[] InsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers will we sort?");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the numbers to sort:");
            int[] mas = new int[N];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }

            InsertionSort(mas);

            Console.WriteLine("After sorting:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.ReadKey();
        }
    }
}
//https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-6.php
