// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.Clear();

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n}.");
double[,] arr = new double[m, n];
CreateArrayDouble(arr);
WriteArray(arr);
Console.WriteLine();

void CreateArrayDouble(double[,] arr)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      arr[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] arr){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(arr[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}