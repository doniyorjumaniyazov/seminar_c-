//int[] arr = {2, 6, 5, 7, 5, 3, 8};


//int min = arr[0];

// for (int i = 0; i < arr.Length; i++)
//{
  //  if (arr[i] < min)
   

//int max = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
  //  if (arr[i] > max)
    //{
  //      max = arr[i];
    //}     
//}
//Console.WriteLine($"{max}");

// int difference = max - min;

// Console.WriteLine($"{difference}");

int[] arr = {2, 6, 5, 7, 5, 3, 8};


int min = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
    }     
}


int max = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }     
}


int difference = max - min;

Console.WriteLine($"максимал: {max} минимал: {min} разница: {difference}");
