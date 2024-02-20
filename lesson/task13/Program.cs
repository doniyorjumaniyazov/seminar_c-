// Напишите программу, которая будет принимать навход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.
   //  {
      //  Console.Write("Введите первое число: ");
        //int number1 = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Введите второе число: ");
        //int number2 = Convert.ToInt32(Console.ReadLine());

        //if (number2 == 0)
        // {
           // Console.WriteLine("Деление на ноль невозможно!");
            //return;
       // }

        // if (number1 % number2 == 0)
        // {
           // Console.WriteLine($"{number1} кратно {number2}");
        //}
        // else
        // {
           // Console.WriteLine($"{number1} не кратно {number2}. Остаток: {number1 % number2}");
        //}
    //}
// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
//третьей цифры нет.



    


Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// // num < 100 -> третей цифры нет
// // num = 5789 / 10
// // num = 57
// int num2 = 0;
// if (num < 0) num = -num;

// if (num < 100)
// {
//     Console.WriteLine("третей цифры нет");
// }
// else
// {
//     while (num > 999)
//     {
//         num /= 10; // num = num / 10
//     }
//     Console.WriteLine(num);
//     num2 = num % 10;
//     Console.WriteLine(num2);
// }

string num = Console.ReadLine()!;
if (num.Length < 3)
{
    Console.WriteLine("третей цифры нет");
}
else
{
    Console.WriteLine(num[2]);
}

22