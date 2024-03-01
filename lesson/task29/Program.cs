//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

void Print_arr(int[,] mas)
{
  for (int i = 0; i < mas.GetLength(0); i++)
  {
    for (int j = 0; j < mas.GetLength(1); j++)
    {
      Console.Write($"{mas[i, j]}\t");
    }
    Console.WriteLine();
  }
}

int[,] Sq(int[,] arry)
{
  for (int i = 0; i < arry.GetLength(0); i++)
  {
    for (int j = 0; j < arry.GetLength(1); j++)
    {
      if(i % 2 == 0 && j % 2 == 0) 
      {
        arry[i, j] = arry[i, j] * arry[i, j];
      }
    }
  }
  return arry;
}



Console.Write("Введите размерность m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
  for (int j = 0; j < arr.GetLength(1); j++)
  {
    arr[i, j] = new Random().Next(1, 10);
  }
}
Print_arr(arr);
Console.WriteLine();
// int[,] arr_sq = Sq(arr);
Print_arr(Sq(arr));

// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

void Print_arr(int[,] mas)
{
  for (int i = 0; i < mas.GetLength(0); i++)
  {
    for (int j = 0; j < mas.GetLength(1); j++)
    {
      Console.Write($"{mas[i, j]}\t");
    }
    Console.WriteLine();
  }
}

int[,] FillRandomArray(int[,] arr)
{
  Random rnd = new Random();
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = rnd.Next(0, 11);
    }
  }
  return arr;
}

int FindSumOfDianogal(int[,] arr)
{
  int sum = 0;

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (i == j)
      {
        sum += arr[i, j];
      }
    }
  }
  return sum;
}

Console.Write("Введите размерность m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = FillRandomArray(new int[m,n]);
Print_arr(arr);
int sum = FindSumOfDianogal(arr);
Console.WriteLine($"Сумма элементов главной диагонали: {sum}");


// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, состоящий
 // из средних арифметических значений по строкам двумерного массива.

 void Print_arr(int[,] mas)
{
  for (int i = 0; i < mas.GetLength(0); i++)
  {
    for (int j = 0; j < mas.GetLength(1); j++)
    {
      Console.Write($"{mas[i, j]}\t");
    }
    Console.WriteLine();
  }
}

int[,] FillRandomArray(int[,] arr)
{
  Random rnd = new Random();
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = rnd.Next(0, 11);
    }
  }
  return arr;
}

double[] mas_one(int[,] arr)
{
  double[] mas = new double[arr.GetLength(0)];
  double sum = 0;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      sum += arr[i,j];
    }
    mas[i] = sum / arr.GetLength(1);
  }
  return mas;
}

void Print_arr_one(double[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write($"{arr[i]}\t");
  }
  Console.WriteLine();
}


Console.Write("Введите размерность m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = FillRandomArray(new int[m,n]);
Print_arr(arr);

double[] arr_one = mas_one(arr);
Console.WriteLine();
Print_arr_one(arr_one);