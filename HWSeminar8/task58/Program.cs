/*Задача 58*: Задайте две матрицы. Напишите программу, которая будет
*находить произведение двух матриц.*/
Console.WriteLine("Введите число строк 1-й матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов 2-й матрицы:  ");
int p = int.Parse(Console.ReadLine());

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < p; j++)
    {
      int sum = 0;
      for (int k = 0; k < n; k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(10,99);
    }
  }
}

void WriteArray (int[,] array)
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
