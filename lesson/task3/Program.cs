Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе первое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == Math.Pow(num2,3))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}