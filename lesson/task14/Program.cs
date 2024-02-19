 // Напишите программу, которая принимает на вход число и проверяет, кратно ли оно
// одновременно 7 и 23

Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int number1 = 7;
int number2 = 23;
int number3 = number1 * number2;
if (number % number3 == 0)

{
    Console.WriteLine($"введенный число кратно одновременно {number1}, {number2}");

}
else
{
    Console.WriteLine($"введенный число не кратно {number1}, {number2}");

}