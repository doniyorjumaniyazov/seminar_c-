// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без строки и столбца

 
        // Пример двумерного массива
        int[,] matrix = {
            {8, 2, 3},
            {4, 5, 1},
            {7, 8, 9}
        };

        // Находим наименьший элемент и его индексы
        int minElement = matrix[0, 0];
        int minRow = 0, minCol = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < minElement)
                {
                    minElement = matrix[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }

        // Создаем новый массив без строки и столбца с минимальным элементом
        int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
        int newRow = 0, newCol = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i != minRow)
            {
                newCol = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j != minCol)
                    {
                        newMatrix[newRow, newCol] = matrix[i, j];
                        newCol++;
                    }
                }
                newRow++;
            }
        }

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Выводим новый массив
        Console.WriteLine("Новый массив после удаления строки и столбца с минимальным элементом:");
        for (int i = 0; i < newMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < newMatrix.GetLength(1); j++)
            {
                Console.Write(newMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    

