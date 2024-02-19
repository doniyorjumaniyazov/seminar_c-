// Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую
// цифру этого числа.

Console.Write("вводите трехзначние число: ");
string number = (Console.ReadLine())! ;

int number1 = Convert.ToInt32(number);

        int num = number1 / 10;

        Console.WriteLine($"резултать: {num}");
        
