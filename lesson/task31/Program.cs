using System;

class UserInputToCompileForTest
{
    // Печать массива
    public static void PrintArray(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
            Console.Write($"{array[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

    // Обмен первой с последней строкой
    public static int[,] SwapFirstLastRows(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        // Создаем временный массив для хранения первой строки
        int[] tempRow = new int[colCount];
        for (int j = 0; j < colCount; j++)
        {
            tempRow[j] = array[0, j];
        }

        // Первую строку заменяем последней
        for (int j = 0; j < colCount; j++)
        {
            array[0, j] = array[rowCount - 1, j];
        }

        // Последнюю строку заменяем временной
        for (int j = 0; j < colCount; j++)
        {
            array[rowCount - 1, j] = tempRow[j];
        }

        return array;
    }

    // Обмен элементами массива (вспомогательный метод для SwapFirstLastRows)
    public static void SwapItems(int[,] array, int i)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        int temp = array[0, i];
        array[0, i] = array[rowCount - 1, i];
        array[rowCount - 1, i] = temp;
    }

    // Печать результата
    public static void PrintResult(int[,] numbers)
    {       
        numbers = SwapFirstLastRows(numbers);
        PrintArray(numbers);
    }
}

class Answer
{
    static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            numbers = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            }; 
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}
