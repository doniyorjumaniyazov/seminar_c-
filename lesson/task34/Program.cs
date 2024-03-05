// Задайте массив символов (тип char []). Создайте строку из символов этого массива.

string CharsOfString(char[] arr)
{
    string st = "";
    foreach (var item in arr)
    {
        st += item;
    }
    return st;
}


char[] chars = new char[] {'a', 'b', 'c', 'd', 'e'};
Console.WriteLine(CharsOfString(chars));

// На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран.

using System.Text;
char[] StringToCharArray(string inputString)
{
  char[] charArray = new char[inputString.Length];
  for (int i = 0; i < inputString.Length; i++)
  {
    charArray[i] = inputString[i];
  }
  return charArray;
}

void PrintCharArray(char[] arr)
{
  foreach (char item in arr)
  {
    Console.Write($"'{item}' ");
  }
}

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
Console.Write("Введите строку: ");
string inputString = Console.ReadLine()!;
PrintCharArray(StringToCharArray(inputString));

