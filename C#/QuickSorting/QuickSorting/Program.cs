using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 23, 72, 2, 69, 15, 21 };

            SortArray(numbers);

            foreach (int number in numbers)
                Console.WriteLine(number);

            Console.ReadKey();
        }

        private static void SortArray(int[] numbers)
        {
            QuickSort(numbers, 0, numbers.Length - 1);
        }

        private static void QuickSort(int[] numbers, int start, int end)
        {
            int left = start;
            int right = end;

            int pivot = numbers[(start + end) / 2];//находим pivot.(как бы делит массив на две части)

            while (left <= right)
            {
                while (numbers[left] < pivot)//проверяет, есть ли в левой части число больше pivot.
                    left++;

                while (numbers[right] > pivot)//проверяет, есть ли в правой части число меньше pivot.
                    right--;

                if (left <= right)//swap
                {
                    int tmp = numbers[left];//tmp - временная
                    numbers[left] = numbers[right];
                    numbers[right] = tmp;
                    left++;//продвижение дальше
                    right--;
                }
            }

            if (start < right)//задействие метода для подсекции массива.(куда идти дальше)
                QuickSort(numbers, start, right);
            //рекурсия
            if (left < end)
                QuickSort(numbers, left, end);
        }
    }
}

