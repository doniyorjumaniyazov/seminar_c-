// Напишите программу, которая находит среднее значение
 // всех элементов вещественного массива и выводит его на экран.

       // Random random = new Random();
        //int arrayLength = random.Next(1, 15);
        //int[] arr = new int[arrayLength];
        //for (int i = 0; i < arr.Length; i++)
        //{
          //  arr[i] = random.Next(1, 101);
        //}

        //Console.WriteLine("Array: " + string.Join(", ", arr)); // Выводим массив на экран

        //double sum = 0;
        //foreach (int num in arr)
        //{
          //  sum = arr.Sum(); // Вычисляем сумму элементов массива
        //}
        //double avg = sum / arr.Length;

        //Console.WriteLine($"Sum: {sum} Avarage: {avg}");

        // Напишите программу на C#, которая находит наиболее часто встречающийся элемент в массиве целых чисел. 
        // Если таких элементов несколько, выведите любой из них.

       
        
        int[] arr = { 2, 3, 2, 5, 6, 7, 2, 8, 2, 4 };

        // Создаем словарь для подсчета количества встреч каждого элемента
        Dictionary<int, int> counts = new Dictionary<int, int>();

        // Подсчитываем количество встреч каждого элемента в массиве
        foreach (int num in arr)
        {
            if (counts.ContainsKey(num))
                counts[num]++;
            else
                counts[num] = 1;
        }

        // Находим максимальное количество встреч элемента
        int maxCount = 0;
        foreach (var pair in counts)
        {
            if (pair.Value > maxCount)
                maxCount = pair.Value;
        }

        // Создаем список для хранения наиболее часто встречающихся элементов
        List<int> mostFrequentElements = new List<int>();

        // Добавляем элементы, количество встреч которых равно максимальному, в список
        foreach (var pair in counts)
        {
            if (pair.Value == maxCount)
                mostFrequentElements.Add(pair.Key);
        }

        // Выводим наиболее часто встречающиеся элементы
        Console.WriteLine("Наиболее часто встречающийся элемент(ы):");
        foreach (int element in mostFrequentElements)
        {
            Console.WriteLine(element);
        }
    }
}

