using System;
using System.Linq;

// Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Разница между максимальным и минимальным элементами массива
    
    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {
        double min = numbers[0];
        foreach (double num in numbers)
        {
            if (num < min)
            {
                min = num;
            }
        }
        return min;
    }
    
    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
        double max = numbers[0];
        foreach (double num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }
    
    public static void PrintResult(double[] array)
    {
        double min = FindMin(array);
        double max = FindMax(array);
        double difference = max - min;
        Console.WriteLine($"{difference}");
    }
}

// Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        double[] array;

        if (args.Length >= 1)
        {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Заменяем запятые на точки, если разделителем является запятая
            joinedArgs = joinedArgs.Replace(',', '.');

            // Разделяем строку по пробелу и преобразуем в массив вещественных чисел
            array = joinedArgs.Split(' ')
                              .Select(double.Parse)
                              .ToArray();
        }
        else
        {
            // Если аргументов на входе нет
            array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
        }
        // Вызываем метод PrintResult для вывода результата
        UserInputToCompileForTest.PrintResult(array);
    }
}
