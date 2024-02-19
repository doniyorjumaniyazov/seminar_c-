
    {
        Console.Write("Введите первое число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number2 == 0)
        {
            Console.WriteLine("Деление на ноль невозможно!");
            return;
        }

        if (number1 % number2 == 0)
        {
            Console.WriteLine($"{number1} кратно {number2}");
        }
        else
        {
            Console.WriteLine($"{number1} не кратно {number2}. Остаток: {number1 % number2}");
        }
    }



       
     
