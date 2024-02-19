 // Напишите программу, которая принимает на вход число и проверяет, кратно ли оно
// одновременно 7 и 23

// Console.Write("введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());

// int number1 = 7;
// int number2 = 23;
// int number3 = number1 * number2;
// if (number % number3 == 0)

//{
  //  Console.WriteLine($"{number} кратно одновременно {number1}, {number2}.");

// }
// else
// {
   // Console.WriteLine($"{number} не кратно {number1}, {number2}.");

// }


       // Console.WriteLine("Введите число: ");
        // int number = Convert.ToInt32(Console.ReadLine());

        // if (number % 7 == 0 && number % 23 == 0)
        // {
           //  Console.WriteLine($"{number} кратно и 7, и 23.");
        // }
        // else
        // {
           // Console.WriteLine($"{number} не кратно одновременно 7 и 23.");
        // }

        // Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
         // и выдаёт номер координатной четверти плоскости,в которой находится эта точка.

         Console.Write("Вводите x: ");
         double x = Convert.ToDouble(Console.ReadLine());

         Console.Write("Вводите y: ");
         double y = Convert.ToDouble(Console.ReadLine());

         if (x == 0 && y == 0)
         {
            Console.WriteLine("Точка находится в начале координат.");
         }

         else 
         { 
            if (x > 0 && y > 0)
            {
            Console.WriteLine("1 четверть");
            }

            if (x < 0 && y > 0)
            {
                Console.WriteLine("2 четверть");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("3 четверть");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("4 четверть");
            }


         }