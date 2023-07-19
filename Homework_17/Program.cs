// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(123);

        Console.WriteLine("Сгенерированный массив:");
        PrintArray(array);

        int count = CountElementsInRange(array, 10, 99);

        Console.WriteLine("Количество элементов массива, значения которых лежат в отрезке [10, 99]: {0}", count);
    }

    static int[] GenerateRandomArray(int length)
    {
        int[] array = new int[length];
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(1, 200); // Генерируем случайное число от 1 до 200
        }

        return array;
    }

    static int CountElementsInRange(int[] array, int min, int max)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= min && array[i] <= max)
                count++;
        }

        return count;
    }

    static void PrintArray(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}
