// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно
// одновременно 7 и 23

//Console.Write("Введите число: ");

  //      int number = Convert.ToInt32(Console.ReadLine());

    //     if (number % 7 == 0 && number % 23 == 0)
      //   {
        //     Console.WriteLine($"{number} (кратно одновременно) и 7, и 23.");
         // }
         // else
         // {
            // Console.WriteLine($"{number} (не кратно одновременно) 7 и 23.");
         //}

         // Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
         // и выдаёт номер координатной четверти плоскости,в которой находится эта точка.

         //Console.Write("введите x: ");
         //double x = Convert.ToDouble(Console.ReadLine());
         //Console.Write("введите y: ");
         //double y = Convert.ToDouble(Console.ReadLine());
         
       //if (x > 0 && y > 0)
        //{
          //  Console.WriteLine("Точка находится в первой координатной четверти");
        //}
        //else if (x < 0 && y > 0)
        //{
          //  Console.WriteLine("Точка находится во второй координатной четверти");
        //}
       // else if (x < 0 && y < 0)
        //{
          //  Console.WriteLine("Точка находится в третьей координатной четверти");
        //}
        //else if (x > 0 && y < 0)
        //{
          //  Console.WriteLine("Точка находится в четвёртой координатной четверти");
        //}

        
        // 3) //Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру.


         // Console.Write("Введите число: ");
          //int number = Convert.ToInt32(Console.ReadLine());
         
          //if (number >= 10 && number <= 99 )
         //{
          //int first = number / 10;
          //int second = number % 10;
         
          //int max = Math.Max(first, second);
          //Console.WriteLine($"Наибольшая цифра число: {number} --- {max}");
         //}

 // Напишите программу, которая на вход принимает натуральное число N, а на
 // выходе показывает его цифры через запятую.

       Console.Write("Введите натуральное число N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N < 1)
        {
            Console.WriteLine("Введено некорректное число.");
            return;
        }

        int i = 1;

        while (i <= N)
        {
            if (i == N)
            {
                Console.Write($"{i}" );
            }
            else
            {
                Console.Write($"{i}, ");
            }
            
            i++;
        }
 



         