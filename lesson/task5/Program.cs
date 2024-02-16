// Console.Write("введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = num%10;
// int num2 = num/100;

// Console.WriteLine($"Сумма равно {num1+num2} ");

// Console.Write("введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// while (true)
// {
   //  if ((num <= 999) && (num >= 100)) break;
        
  
    // Console.Write("Введите трехзначное число: ");
    // num = Convert.ToInt32(Console.ReadLine());
// }

// int num1 = num % 10;
// int num2 = num / 100;

// Console.WriteLine($"Сумма равно {num1 + num2} ");

 // Console.Write("введите трехзначное число: ");
 // int num = Convert.ToInt32(Console.ReadLine());

int num = new Random().Next(100, 1000);

int num1 = num % 10;
int num2 = num / 100;

Console.WriteLine($"Число {num}. Сумма {num1} и {num2} равно {num1 + num2}");
