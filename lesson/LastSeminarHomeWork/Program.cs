// 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
 // Использовать рекурсию, не использовать циклы.

 Console.Write("введите значение М: ");
 int M = Convert.ToInt32(Console.ReadLine()!);
 Console.Write("введите значение N: ");
 int N = Convert.ToInt32(Console.ReadLine()!);

 void ShowNaturalNumbers(int M, int N)
 {
  if (M <= N) 
  {
      
      Console.Write(M + " ");
     ShowNaturalNumbers(M + 1, N); // Рекурсивный вызов функции для следующего числа;
     
  }
          
 }
     Console.WriteLine($"Натуральные числа от {M} до {N}:");
     ShowNaturalNumbers(M, N);

     // Добавок к этой задач в семинаре попиталыс как ввыводить значение обратном порядке если 
     //менят место Console.Write и Рекурсивный вызов (стр 14 истр 15)то тогда показивает обратном порядке.



  //2. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.



     int AckermannFunction(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return AckermannFunction(m - 1, 1);
        else
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
    
        int m = 1;
        int n = 2;
        
        Console.WriteLine($"A(m,n) = {AckermannFunction(m, n)}");
    

    //3. Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы
        

    void StartArray(int[] arr, int i)
    {
       
      if (i < arr.Length)
        {
              StartArray(arr, i + 1); // Рекурсивный вызов функции для следующего элемента
              Console.Write(arr[i] + " "); //просто меняли место рекурсия и вывод резелтат обратном порядке

        }
    }  
    int[] array = { 10, 2, 8, 46, 15, 3};
    Console.WriteLine("Исходный массив: [10, 2, 8, 46, 15, 3]");        
    StartArray(array, 0);
