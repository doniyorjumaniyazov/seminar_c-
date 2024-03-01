// Напишите программу, которая перевернёт одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.) 
int[] SomeRandomArray(int size)
    {
        int[] array = new int[size];
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(1, 100);
        }
        return array;
    }
    void PrintArray(int[] array)
    {
        foreach (int e in array)
        {
            Console.Write($"{e} ");
        }
        Console.WriteLine();
       }
       void ReverseArray(int[] array)
       {
        int leftnumber = 0;
        int rightnumber = array.Length - 1;

        
        while (leftnumber < rightnumber)
        {
            int temp = array[leftnumber];
            array[leftnumber] = array[rightnumber];
            array[rightnumber] = temp;            
            leftnumber++;
            rightnumber--;
        }
       }
       int[] array = SomeRandomArray(5);
        Console.WriteLine("Исходный массив:");
                PrintArray(array);
        ReverseArray(array);
        Console.WriteLine("Перевернутый массив:");
                PrintArray(array);
      