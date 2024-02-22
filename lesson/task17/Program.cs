// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет

// int[] arr = { 5, 6, -12, 0, 8, -6 };

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// bool wellDone = false;

// foreach (int number1 in arr)
// {
// if (number1 == number)
//{
//  wellDone = true;
// break;
// }
// }

// int[] arr = { 5, 6, -12, 0, 8, -6 };

//Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

//bool result = false;
// int i = 0;

// while (i < arr.Length)
// {
// if (arr[i] == number)
// {
// result = true;
// break;
//}
// i++;
//}
//if (result)
//{
//  Console.WriteLine("Да");
//}

// else

// Console.WriteLine("Нет");




int[] arr = { 5, 6, -12, 0, 8, -6 };

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = false;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == number)
    {
        result = true;
        break;
    }
}

if (result)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
