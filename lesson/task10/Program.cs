// Создайте программу, которая запрашивает у пользователя его имя и затем
// выводит на экран приветствие с использованием этого имени

// Console.Write("Whats your name?: ");
// string name = Console.ReadLine() ?? "";
// String greeting = "You are welcome, " + name + "!";;

// Console.WriteLine(greeting);

// Напишите программу, которая находит сумму двух чисел, введенных пользователем

// Console.Write("Первое число");
// string input1 = Console.ReadLine() ?? "";


// Console.Write("Второе число");
// string input2 = Console.ReadLine() ?? "";

// int num1 = Convert.ToInt32(input1);
// int num2 = Convert.ToInt32(input2);

// int sum = (num1 + num2);


// Console.WriteLine($"Равно {sum}");

// Калькулятор: Создайте простой калькулятор, который может
//  выполнять основные арифметические операции (+, -, *, /) с двумя числами

Console.Title = "Wcalculate";
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Blue;
Console.Clear();
Console.Title = "Wcalculate";
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Red;
Console.Clear();
string input;
do
{
    Console.Write("первое число: ");
    string num1 = Console.ReadLine() ?? "";

    Console.Write("Втрое число: ");
    string num2 = Console.ReadLine() ?? "";

    double number1 = Convert.ToDouble(num1);
    double number2 = Convert.ToDouble(num2);

    double sum = number1 + number2;
    double sum1 = number1 - number2;
    double sum2 = number1 * number2;
    double sum3 = number1 / number2;

    Console.WriteLine($"Cложение = {sum}");
    Console.WriteLine($"Вычитаные = {sum1}");
    Console.WriteLine($"Умножение = {sum2}");
    Console.WriteLine($"Деление = {sum3}");
    Console.WriteLine("");
    input = Console.ReadLine();
} while (input != "exit");
