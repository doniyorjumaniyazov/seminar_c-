// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

 
    
        int[] array = CreateRandomArray(10);
        PrintArray(array);
        int count = CountWorker(array);
        Console.WriteLine($"Количество четных чисел: {count}");    

     int[] CreateRandomArray(int size)
    {
        int[] array = new int[size];
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(100, 1000);
        }
        return array;
    }

     void PrintArray(int[] array)
    {
        foreach (int e in array)
        {
            Console.Write($"{e} ");
        }
        Console.WriteLine();
    }

     bool EvenNumbers(int number)
    {
        return number % 2 == 0;
    }

     int CountWorker(int[] array)
    {
        int count = 0;
        foreach (int e in array)
        {
            if (EvenNumbers(e))
            {
                count++;
            }
        }
        return count;
    }

