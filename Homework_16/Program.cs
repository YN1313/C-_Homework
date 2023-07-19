// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] ourNumb = new int[sizeArray];
FillArrayRandomNumbers(ourNumb);
Console.WriteLine("Наш массив: ");
PrintArray(ourNumb);
int sumOfNumbers = 0;

for (int i = 0; i < ourNumb.Length; i += 2)
  sumOfNumbers += ourNumb[i];

Console.WriteLine($"Cумма элементов на нечётных позициях = {sumOfNumbers}");

void FillArrayRandomNumbers(int[] ourNumb)
{
  for (int j = 0; j < ourNumb.Length; j++)
  {
    ourNumb[j] = new Random().Next(1, 20);
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
