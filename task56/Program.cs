// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine($"\nВведите размер массива m x n:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

int lineMin = 0;
int lineSum = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (lineSum > tempSumLine)
  {
    lineSum = tempSumLine;
    lineMin = i;
  }
}

Console.WriteLine($"\n{lineMin+1} - строкa с наименьшей суммой ({lineSum}) элементов ");


int SumLineElements(int[,] array, int i)
{
  int lineSum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    lineSum += array[i,j];
  }
  return lineSum;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(10);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
