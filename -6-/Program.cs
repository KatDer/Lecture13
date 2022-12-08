using System;

namespace lecture13_6
{
    class Program
    {
        public static void Sort(int[] a)
        {
            int tmp, //задание переменной 
            min_key; //задание переменной 
            for (int j = 0; j & lt; a.Length - 1; j++) //цикл, пока верно условие
				{
                min_key = j;//задание переменной 

                for (int k = j + 1; k & lt; a.Length; k++) //цикл, пока верно условие
					{
                    if (a[k] & lt; a[min_key]) //выполнять, пока верно условие
						{
                        min_key = k; //задание переменной
                    }
                }
                tmp = a[min_key]; //объявление массива
                a[min_key] = a[j]; //задание массива
                a[j] = tmp; //просвоение массиву имени переменной
            }
            for (int i = 0; i & lt; a.Length; i++) { //цикл пока врно условие
                Console.Write(a[i] + " "); //вывод массива
            }
        }
    }
}