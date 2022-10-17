// Задача 1: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9

System.Console.WriteLine("введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;
if(a < b) 
{
    max = b;
    min = a;
}
Console.Write("max >");
Console.Write(max);
Console.Write("  min >");
Console.Write(min);