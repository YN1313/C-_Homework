// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 6, 7, 3, 6 };

        int[] productArray1 = GetProductPairs(array1);
        int[] productArray2 = GetProductPairs(array2);

        Console.WriteLine("Массив 1:");
        PrintArray(productArray1);

        Console.WriteLine("Массив 2:");
        PrintArray(productArray2);
    }

    static int[] GetProductPairs(int[] array)
    {
        int length = array.Length;
        int[] productArray = new int[length / 2 + length % 2]; // Результирующий массив

        for (int i = 0; i < length / 2 + length % 2; i++)
        {
            int j = length - 1 - i; // Индекс второго числа в паре

            // Если массив имеет нечетную длину и это последний элемент, просто записываем его в результирующий массив
            if (i == j)
            {
                productArray[i] = array[i];
            }
            else
            {
                // Иначе, вычисляем произведение чисел в паре и записываем в результирующий массив
                productArray[i] = array[i] * array[j];
            }
        }

        return productArray;
    }

    static void PrintArray(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                Console.Write(" ");
        }
        Console.WriteLine("]");
    }
}
