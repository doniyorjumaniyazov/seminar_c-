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

Console.Write("первое число: ");
string num1 = Console.ReadLine() ?? "";

Console.Write("Втрое число: ");
string num2 = Console.ReadLine() ?? "";

int number1 = Convert.ToInt32(num1);
int number2 = Convert.ToInt32(num2);

int sum = number1 + number2;
int sum1 = number1 - number2;
int sum2 = number1 * number2;
float sum3 = (float)number1 / number2;

Console.WriteLine($"{sum}");
Console.WriteLine($"{sum1}");
Console.WriteLine($"{sum2}");
Console.WriteLine($"{sum3}");
