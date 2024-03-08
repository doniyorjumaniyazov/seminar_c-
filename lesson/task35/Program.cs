//Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

{
        char[,] chars = new char[,] {
            {'d', 'o', 'n', 'i', 'e', 'r'},
            {'d', 'o', 'n', 'i', 'e', 'r'}
        };
        Console.WriteLine(createCharArray(chars));
    }

     string createCharArray(char[,] arr)
    {
        string str = "";
        foreach (char e in arr)
        {
            str += e;
        }
        return str;
    }

   // Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные

string accoridingString =  "adCQTdhhhhRRtgFLllKKoPPB.";
string anotherString = accoridingString.ToLower();

Console.WriteLine(anotherString);

// Задайте произвольную строку. Выясните, является ли она палиндромом.
    
  
        
        Console.WriteLine("Введите строку для проверки на палиндром:");
        string str = Console.ReadLine()!;

        bool isPalindrome = IsPalindrome(str);

        if (isPalindrome)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    

      bool IsPalindrome(string str)
    {
        int length = str.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (str[i] != str[length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }

   // Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.
        
        
       Console.WriteLine("Начальной строка: ");
       string str1 = Console.ReadLine()!;
      
       string ReverseWords(string str1)
       {
        
        string[] words = str1.Split(' ');
        Array.Reverse(words);

        
        return string.Join(" ", words);
    }
       
         string reversedString = ReverseWords(str1);
         Console.WriteLine($"Результат: {reversedString}");
            

     

  

    
           