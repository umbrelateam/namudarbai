using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    class Program
    {
        static int[] BubbleSorting(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
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
            BubbleSorting(mas);
            Console.WriteLine("After sorting:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.ReadLine();
        }
    }
}
