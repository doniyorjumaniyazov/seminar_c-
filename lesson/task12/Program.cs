// Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую
// цифру этого числа.

// Console.Write("вводите трехзначние число: ");
// string number = (Console.ReadLine())! ;

// int number1 = Convert.ToInt32(number);

   //     int num = number1 / 10;

     //   Console.WriteLine($"резултать: {num}");

// Напишите программу, которая принимает на вход трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре. 

Console.Write("вводите трехзначние число: ");
string input = Console.ReadLine()! ;

int number = Convert.ToInt32(input);

int number1 = (number/10) %10;
int number2 = number %10;

double result = Math.Pow(number1, number2);

Console.WriteLine($"Релутат:{result}");
