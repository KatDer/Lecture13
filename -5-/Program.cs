using System;

namespace lecture13_5
{
    class Program
    {
        private static void CountingSort(int[] arr)
        {
            int max = arr.Max(); //задание переменной
            int min = arr.Min(); //задание переменной

            int[] count = new int[max - min + 1]; //задание массива
            int z = 0; // объявление целочисленной переменной

            for (int i = 0; i < count.Length; i++) // цикл, пока верно условие
            {
                count[i] = 0;
            }
            for (int i = 0; i < arr.Length; i++) //цикл, пока верно условие
            {
                count[arr[i] - min]++;
            }

            for (int i = min; i <= max; i++) // цикл, пока верно условие
            {
                while (count[i - min]-- > 0)
                {
                    arr[z] = i;
                    z++;
                }
            }

            foreach (var x in arr) //выполнять для каждого указанного элемента
            {
                Console.Write(x + " "); //вывод результат на экран
            }
        }
    }
}