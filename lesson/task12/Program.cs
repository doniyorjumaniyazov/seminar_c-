// Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую
// цифру этого числа.

// Console.Write("вводите трехзначние число: ");
// string number = (Console.ReadLine())! ;

// int number1 = Convert.ToInt32(number);

//     int num = number1 / 10;

//   Console.WriteLine($"резултать: {num}");

// Напишите программу, которая принимает на вход трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.

//Console.Write("вводите трехзначние число: ");
// string input = Console.ReadLine()! ;

// int number = Convert.ToInt32(input);

// int number1 = (number/10) %10;
// int number2 = number %10;

// double result = Math.Pow(number1, number2);

// Console.WriteLine($"Релутат:{result}");

// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.

Console.Write("первое число: ");
int input1 = int.Parse(Console.ReadLine());

Console.Write("второе число: ");
int input2 = int.Parse(Console.ReadLine());

if (input1 % input2 == 0)
{
    Console.WriteLine("резултат: {да}");
}
else
{
    Console.WriteLine("резултат: {нет}");
}
