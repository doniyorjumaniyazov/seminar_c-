// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет

// int[] arr = { 5, 6, -12, 0, 8, -6 };

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// bool wellDone = false;

// foreach (int number1 in arr)
// {
// if (number1 == number)
//{
//  wellDone = true;
// break;
// }
// }

// int[] arr = { 5, 6, -12, 0, 8, -6 };

//Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

//bool result = false;
// int i = 0;

// while (i < arr.Length)
// {
// if (arr[i] == number)
// {
// result = true;
// break;
//}
// i++;
//}
//if (result)
//{
//  Console.WriteLine("Да");
//}

// else

// Console.WriteLine("Нет");




// int[] arr = { 5, 6, -12, 0, 8, -6 };

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// bool result = false;

// for (int i = 0; i < arr.Length; i++)
// {
   // if (arr[i] == number)
    //{
      //  result = true;
        //break;
    //}
//}
// if (result)
//{
  //  Console.WriteLine("Да");
//}
// else
//{
   //  Console.WriteLine("Нет");
//}

// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные


// int[] arr = new int[10];
// Random rand = new Random();

// for (int i = 0; i < arr.Length; i++)
// {
   //  arr[i] = rand.Next(-10, 10); 
// }

// Console.WriteLine("Начальной:");
// Console.WriteLine("[" + string.Join(", ", arr) + "]");

// for (int i = 0; i < arr.Length; i++)
// {
   //  arr[i] = -arr[i]; 
// }

// Console.WriteLine("Последный:");
// Console.WriteLine("[" + string.Join(", ", arr) + "]");

// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.


        // int[] arr = new int[9];
        // Random rand = new Random();

        
        // for (int i = 0; i < arr.Length; i++)
        // {
           // arr[i] = rand.Next(-10, 15); 
        // }       

        //Console.WriteLine("Исходный массив:");
        
        // foreach (int number in arr)
        // {
           // Console.Write(number + ", ");
        // }
        // Console.WriteLine(); 

        // Console.WriteLine("Произведения пар чисел в массиве:");
        // for (int i = 0; i < arr.Length / 2; i++)
        // {
           // int Product = arr[i] * arr[arr.Length - 1 - i];
            //Console.WriteLine(Product);
        //}
 
 //       if (arr.Length % 2 != 0)
   //     {
     //       int nonProduct = arr.Length / 2;
       //     Console.WriteLine($"Элемент {arr[nonProduct]} не имеет пары.");
        // }

       // Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.

            Console.Write("Введите трехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 100 && number <= 999) // Проверяем, что введено трехзначное число
        {
            int[] digits = new int[3]; // Создаем массив для цифр числа

            // Разбиваем число на цифры и заполняем массив
            digits[0] = number % 10; // Младший разряд числа
            digits[1] = (number / 10) % 10; // Средний разряд числа
            digits[2] = number / 100; // Старший разряд числа

            // Выводим массив на экран
            Console.Write("[");
            for (int i = 0; i < digits.Length; i++)
            {
                Console.Write(digits[i]);
                if (i != digits.Length - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("]");
        }
        else
        {
            Console.WriteLine("Ошибка: введено неправильное число. Пожалуйста, введите трехзначное число.");
        }
    

