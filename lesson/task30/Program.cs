using System;

class UserInputToCompileForTest
{ 
    public static int FindElementByPosition(int[,] array, int x, int y)
    {
       if (x < 1 || x > array.GetLength(0))
        {
            Console.WriteLine("Позиция по рядам выходит за пределы массива");
            return -1;
        }
        if (y < 1 || y > array.GetLength(1))
        {
            Console.WriteLine("Позиция по колонкам выходит за пределы массива");
            return -1;
        }
        return array[x - 1, y - 1];
    }

    public static bool ValidatePosition(int[,] array, int x, int y)
    {
         return x >= 1 && x <= array.GetLength(0) && y >= 1 && y <= 
         array.GetLength(1);
    }

    public static void PrintResult(int[,] array, int x, int y)
    {
         if (ValidatePosition(array, x, y))
        {
            Console.WriteLine($"{array[x - 1, y - 1]}");
        }
        else
        {
            if (x < 1 || x > array.GetLength(0))
                Console.WriteLine("Позиция по рядам выходит за пределы массива");
            if (y < 1 || y > array.GetLength(1))
                Console.WriteLine("Позиция по колонкам выходит за пределы массива");
        }
    }
}

class Answer
{
    public static void Main(string[] args)
    {   
        int[,] array;

        int x, y;

        if (args.Length >= 3)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            array = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        array[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }

            // Парсинг x и y из аргументов
            if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
            {
                // Теперь у вас есть двумерный массив "array" и координаты x и y
                UserInputToCompileForTest.PrintResult(array, x, y);
            }
            else
            {
                Console.WriteLine("Error parsing x or y to an integer.");
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            array = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
            x = 2;
            y = 2;
            
            UserInputToCompileForTest.PrintResult(array, x, y);
        }                
    }
}
