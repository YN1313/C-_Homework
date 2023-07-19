// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] ourNumb = new int[sizeArray];
FillArrayRandomNumbers(ourNumb);
Console.WriteLine("Наш массив: ");
PrintArray(ourNumb);
int count = 0;

for (int i = 0; i < ourNumb.Length; i++)
  if (ourNumb[i] % 2 == 0)
    count++;

Console.WriteLine($"В массиве {count} чётных чисел");

void FillArrayRandomNumbers(int[] ourNumb)
{
  for (int j = 0; j < ourNumb.Length; j++)
  {
    ourNumb[j] = new Random().Next(100, 1000);
  }
}

void PrintArray(int[] ourNumb)
{
  Console.Write("[ ");
  for (int j = 0; j < ourNumb.Length; j++)
  {
    Console.Write(ourNumb[j] + " ");
  }
  Console.Write("]");
  Console.WriteLine();
}
