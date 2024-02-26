// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная

       while (true)
             {
             Console.Write("Введите число: ");
             string anything = Console.ReadLine()!;

             if (anything == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }            
            if (int.TryParse(anything, out int number))
            {                
                if (IsEvenNum(number))
                {
                    Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для выхода.");
            }
        }
    
     bool IsEvenNum(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum = sum + number % 10;
            number /= 10;
        }
        return sum % 2 == 0;
    }
             