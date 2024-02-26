// Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90].



// int[] array = new int[10];

// Random rnd = new Random();
// for (int i = 0; i < array.Length; i++)
//{
//  array[i] = rnd.Next(1, 101);
// }

// Console.WriteLine("arr: ");
// foreach (int e in array)
// {
// Console.Write(e + " ");
// }
// Console.WriteLine();

// int count = 0;
// foreach (int e in array)
//{
//  if (e >= 20 && e <= 90)
// {
// count = count + 1;
//}
//}

// Console.WriteLine($"количество число: {count}");

// Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.

// int[] arr = new int[10];
// Random rnd = new Random();
//for (int i = 0; i < arr.Length; i++)
//{
//  arr[i] = rnd.Next(10, 50);
//}
//Console.WriteLine("arr_1: ");
//foreach (int e in arr)
//{
//  Console.Write(e + " ");
// }
// Console.WriteLine();

// int count = 0;
//foreach (int e in arr)
//{
//  if (e % 2 == 0)
// {
//count = count+1;
//}
//}
//Console.WriteLine($"количество четных чисел: {count}");

// int[] array = new int[10];
// Console.Write("задайте элементы массива: ");

// for (int i = 0; i < array.Length; i++)
// {
   //  Console.Write($"Элемент {i + 1}: ");
    // array[i] = int.Parse(Console.ReadLine()!);
// }

// int count = 0;
// foreach (int e in array)
// {
   // if (e % 2 == 0)
    // {
       // count = count + 1;
    //}
//}
// Console.WriteLine($"количество четных чисел: {count}");
using System;

class Program
{
    static void Main()
    {
        int arraySize = 5;

        int[] array = new int[arraySize];
        Random rnd = new Random();
        for (int i = 0; i < arraySize; i++)
        {
            array[i] = rnd.Next(1, 101); 
        }

        Console.WriteLine("Массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");

        foreach (int num in array)
        {
            Console.WriteLine($"{num} - {(isSimple(num) ? "простое число" : "не простое число")}");
        }

        int count = 0;
        foreach (int number in array)
        {
            count = count + 1;
        }
        Console.WriteLine($"кол-во: {count}");
    }

    static bool isSimple(int number)
    {
        if (number <= 1)
            return false;
        
        if (number == 2)
            return true;

        if (number % 2 == 0)
            return false;

        int boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
