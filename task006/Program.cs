// Напишите программу вычисления модуля числа.
System.Console.WriteLine("Введите число >");
int number = int.Parse(Console.ReadLine()); 
int mod = number;
if (number < 0)
{
    mod = -number;
}
System.Console.WriteLine($"{mod} is abs of {number}");