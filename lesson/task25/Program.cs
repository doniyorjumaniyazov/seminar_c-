//  Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива

// double[] arr = new double[7];//
// Console.WriteLine("Введите элементы массива:");

// for (int i = 0; i < arr.Length; i++)
//{
//  Console.Write($"{i + 1}: ");
// arr[i] = double.Parse(Console.ReadLine()!);
// }

// double max = arr[0];
// double min = arr[0];

// for (int i = 1; i < arr.Length; i++)
//{
//  if (arr[i] > max)
// {
//   max = arr[i];
// }

// if (arr[i] < min)
//{
//  min = arr[i];
// }
// }

// double difference = max - min;
// Console.WriteLine($"Разница между максимальным и минимальным: {difference}");

// Дано натуральное число
// в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.

// Random rnd = new Random();
//int number = rnd.Next(1, 100000);
//Console.Write($"{number} ");

// int digitCount = 0;
// int tempNumber = number;
// while (tempNumber != 0)
//{
  //  tempNumber /= 10;
    //digitCount++;
//}
//int[] digitsArray = new int[digitCount];

//for (int i = digitCount - 1; i >= 0; i--)
//{
  //  digitsArray[i] = number % 10;
    //number /= 10;
// }

// Console.Write("Массив цифр числа: [");
 // Console.Write(string.Join(" ", digitsArray));
 // Console.WriteLine("]");

  Задайте массив из N случайных целых чисел (N вводится с клавиатуры).

// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.

// Пример

// [1 5 11 21 81 4 0 91 2 3]

// => 2

int[] FillRandomArray(int size)
{
  int[] arr = new int[size];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next(0, 1000);
  }
  return arr;
}

void PrintArray(int[] arr)
{
  foreach (int el in arr)
  {
    Console.Write($"{el} ");
  }
  Console.WriteLine();
}

int IsInteresting(int[] arr)
{
  int count = 0;
  foreach(int el in arr)
  {
    if (HaveOne(el) && MultySeven(el))
    {
      count++;
    }
  }
  return count;
}

bool HaveOne(int num)
{
  if (num % 10 == 1)
  {
    return true;
  }
  return false;
}

bool MultySeven(int num)
{
  if (num % 7 == 0)
  { return true;}
  return false;
}

Console.Write("Введите резмерность одномерного массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = FillRandomArray(length);
PrintArray(arr);
Console.WriteLine($"Количество чисел удовлетворяющих условию: {IsInteresting(arr)}");

22:54
int[] FillRandomArray(int size)
{
  int[] arr = new int[size];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next(0, 1000);
  }
  return arr;
}

void PrintArray(int[] arr)
{
  foreach (int el in arr)
  {
    Console.Write($"{el} ");
  }
  Console.WriteLine();
}

int IsInteresting(int[] arr)
{
  int count = 0;
  foreach(int el in arr)
  {
    if (HaveOne(el) && MultySeven(el))
    {
      count++;
    }
  }
  return count;
}

bool HaveOne(int num)
{
  if (num % 10 == 1)
  {
    return true;
  }
  return false;
}

bool MultySeven(int num)
{
  if (num % 7 == 0)
  { return true;}
  return false;
}

Console.Write("Введите резмерность одномерного массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = FillRandomArray(length);
PrintArray(arr);
Console.WriteLine($"Количество чисел удовлетворяющих условию: {IsInteresting(arr)}");


// след

int[] FillRandomArray(int size)
{
  int[] arr = new int[size];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next(0, 10);
  }
  return arr;
}

void PrintArray(int[] arr)
{
  foreach (int el in arr)
  {
    Console.Write($"{el} ");
  }
  Console.WriteLine();
}

double num(int[] col) // 1 4 8 7 8 7 4 9
{
    double n = 0;
    foreach (var item in col)
    {
        n = n * 10 + item;
    }
    return n;
}
// 1
// 1 *10 + 4 = 14
// 14 * 10 + 8 = 148
// 148 *10 + 7 = 1487...

Console.Write("Введите резмерность одномерного массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = FillRandomArray(length);
PrintArray(arr);
Console.WriteLine(num(arr));

//
or (int i = 0; i < 10; i++)
{
    if(i == 6) continue;
    if (i == 8) break;
    Console.WriteLine(i);
}

//
int i = 1;
while (true)
{
    Console.WriteLine(i);
    if(i ==150) break;
    i++;
}