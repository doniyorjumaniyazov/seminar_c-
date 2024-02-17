// Создайте программу, которая запрашивает у пользователя его имя и затем
// выводит на экран приветствие с использованием этого имени

// Console.Write("Whats your name?: ");
// string name = Console.ReadLine() ?? "";
// String greeting = "You are welcome, " + name + "!";;

// Console.WriteLine(greeting);

// Напишите программу, которая находит сумму двух чисел, введенных пользователем

Console.Write("Первое число");
string input1 = Console.ReadLine() ?? "";


Console.Write("Второе число");
string input2 = Console.ReadLine() ?? "";

int num1 = Convert.ToInt32(input1);
int num2 = Convert.ToInt32(input2);

int sum = (num1 + num2);


Console.WriteLine($"Сумма число {num1} и {num2} равно {sum}");

