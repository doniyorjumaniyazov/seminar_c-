Console.Write("введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num%10;
int num2 = num/100;

Console.WriteLine($"Сумма равно {num1+num2} ");
